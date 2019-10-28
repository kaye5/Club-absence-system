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
    public partial class memberPayment : Form
    {
        String thisMonth = DateTime.Now.AddMonths(0).ToString("MMMM");
        String thisYear = DateTime.Now.Year.ToString();
        String today = DateTime.Now.ToString();
        public memberPayment()
        {
            InitializeComponent();
            updateData();
        }
        private void updateData()
        {
            try
            {
                listView1.Items.Clear();
                db.sql = "select `nim`,`name` from `member`";
                db.addCMD();
                MySqlDataReader r = db.cmd.ExecuteReader();
                while (r.Read())
                {
                    if (r.GetString(0) == "001") continue;
                    ListViewItem item = new ListViewItem(r.GetString(0));
                    item.SubItems.Add(r.GetString(1));
                    db.sql = $"select id from `income_transaction` where  `id`='{thisMonth + thisYear + r.GetString(0)}'";
                    MySqlConnection cnn = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=vroxine;");
                    cnn.Open();
                    MySqlCommand cmd = new MySqlCommand(db.sql, cnn);
                    MySqlDataReader t = cmd.ExecuteReader();
                    if (!t.Read())
                        item.SubItems.Add("NONE");
                    else
                        item.SubItems.Add("DONE");
                    cnn.Close();
                    cmd.Dispose();
                    t.Dispose();
                    listView1.Items.Add(item);
                }
                r.Dispose();
                db.disposeCmd();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkPayment(String stat)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                if (item.SubItems[2].Text ==  stat)
                    return false;
            }
            return true;
        }

        private void memberPayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("NO SELECTION", "WARNING");
                }
                else if (checkPayment("DONE"))
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        db.sql = "insert into `income_transaction` values" +
                        $"('{thisMonth + thisYear + item.SubItems[0].Text}','{thisMonth + thisYear}','{item.SubItems[0].Text}','{today}','member payment',(select `memberFee` from `profile` where `id`='001'),'MEMBER PAYMENT','payment')";
                        Console.WriteLine(db.sql);
                        db.addCMD();
                        db.cmd.ExecuteNonQuery();
                        db.disposeCmd();
                        db.sql = "update `profile` set `cash` = `memberFee` + `cash` where id='001'";
                        db.addCMD();
                        db.cmd.ExecuteNonQuery();
                        db.disposeCmd();
                        db.sql = $"update `income` set `cash` = (select `memberfee` from `profile`) + `cash` where `id`='{thisMonth+thisYear}'";
                        db.addCMD();
                        db.cmd.ExecuteNonQuery();
                        db.disposeCmd();
                    }
                    MessageBox.Show("DONE");
                    updateData();
                }
                else
                {
                    MessageBox.Show("Check your selection there's paid member in your selection", "warning");
                }
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void paymentCancleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("NO SELECTION", "WARNING");
                }
                else if (checkPayment("NONE"))
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        db.sql = $"DELETE FROM `mydb`.`income_transaction` WHERE `id` = '{thisMonth + thisYear + item.SubItems[0].Text}'";
                        db.addCMD();
                        db.cmd.ExecuteNonQuery();
                        db.disposeCmd();
                        db.sql = "update `profile` set `cash` = `cash`-`memberFee` where id='001'";
                        db.addCMD();
                        db.cmd.ExecuteNonQuery();
                        db.disposeCmd();
                        db.sql = $"update `income` set `cash` = `cash` - (select `memberfee` from `profile`)  where `id`='{thisMonth + thisYear}'";
                        db.addCMD();
                        db.cmd.ExecuteNonQuery();
                        db.disposeCmd();
                    }
                    MessageBox.Show("DONE");
                    updateData();
                }
                else
                {
                    MessageBox.Show("Check your selection there's non-paid member in your selection", "warning");
                }
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
    
}
