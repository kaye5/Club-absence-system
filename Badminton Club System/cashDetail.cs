using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Badminton_Club_System
{
    public partial class cashDetail : Form
    {
        private string month, year;
        private int allIncome=0, tt=0, otherIncome=0, memberIncome=0;
        public cashDetail(String month,String year)
        {
            InitializeComponent();
            this.month = month;
            this.year = year;
            updateData();
        }

        private void updateData()
        {
            try
            {
                db.sql = $"select `date_create`, `transaction_name`,`cash`,`comment` from `income_transaction` where `income_id` = '{month + year}'";
                db.addCMD();
                MySql.Data.MySqlClient.MySqlDataReader r = db.cmd.ExecuteReader();
                bool flag = false;
                while (r.Read())
                {
                    flag = true;
                    int cash = r.GetInt32(2);
                    ListViewItem item = new ListViewItem(r.GetString(0));
                    for (int i = 1; i < r.FieldCount; i++)
                        item.SubItems.Add(r.GetValue(i).ToString());
                    cashDetailListView.Items.Add(item);
                    if (r.GetString(1) == "member payment")
                        memberIncome += cash;
                    else
                        otherIncome += cash;
                    allIncome += cash;
                    tt++;
                }
                if (!flag)
                    MessageBox.Show("NO ITEM HERE");
                r.Dispose();
                db.disposeCmd();
                cashDetailTotalTbox.Text = allIncome.ToString("N");
                cashDetailMemberIncomeTbox.Text = memberIncome.ToString("N");
                cashDetailTransTbox.Text = tt.ToString();
                cashDetailOtherTbox.Text = otherIncome.ToString("N");
                monthTbox.Text = $"{month} {year}";
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
