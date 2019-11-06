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
    public partial class newExpense : Form
    {
        public newExpense()
        {
            InitializeComponent();
        }

        private bool validate()
        {
            foreach (Control control in panel1.Controls)
            {
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;
                    if (string.IsNullOrEmpty(txtBox.Text))
                        return false;
                }
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(priceTbox.Text, @"^\d+$"))
                return true;
            else
                return false;
        }

        private void newExpenseAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {
                    String month = dateTimePicker1.Value.ToString("MMMM");
                    String year = dateTimePicker1.Value.ToString("yyyy");
                    String time = dateTimePicker1.Value.Date.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
                    String tName = nameTbox.Text;
                    int tPrice = Convert.ToInt32(priceTbox.Text);
                    String tComment = commentTbox.Text;
                    db.sql = $"update `profile` set `cash` = `cash` - {tPrice} where  `id` = '001'";
                    db.addCMD();
                    db.cmd.ExecuteNonQuery();
                    db.disposeCmd();
                    db.sql = $"insert into `expense_transaction` values('{time + tName + tPrice.ToString()}', '{month + year}', '{time}', '{tName}', {tPrice}, '{tComment}', 'expense')";
                    Console.WriteLine(db.sql);
                    db.addCMD();
                    db.cmd.ExecuteNonQuery();
                    db.disposeCmd();                    
                    db.sql = $"update `expense` set `cash` = `cash` + {tPrice} where  `id` = '{month + year}'";
                    db.addCMD();
                    db.cmd.ExecuteNonQuery();
                    db.disposeCmd();
                    MessageBox.Show("Done", "Done");
                }
                else MessageBox.Show("CHECK YOUR ITEM", "WARNING");
            }
            catch (MySqlException err)
            {
                if (err.Number.ToString() == "1690")
                    MessageBox.Show("Expense overcome current cash");
                else 
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
