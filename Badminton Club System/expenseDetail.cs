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
    public partial class expenseDetail : Form
    {
        private String month, year;
        private int allExpense = 0, tt = 0;
        public expenseDetail(String month, String year)
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
                db.sql = $"select `date_create`, `transaction_name`,`cash`,`comment` from `expense_transaction` where `expense_id` = '{month + year}'";
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
                    expenseDetailListView.Items.Add(item);
                    allExpense += cash;
                    tt++;
                }
                if (!flag)
                    MessageBox.Show("NO ITEM HERE");
                r.Dispose();
                db.disposeCmd();
                totalExpenseTbox.Text = allExpense.ToString("N");
                ttTbox.Text = tt.ToString();
                monthTbox.Text = $"{month} {year}";
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
