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
    public partial class inventoryNewItem : Form
    {
        public inventoryNewItem()
        {
            InitializeComponent();
        }
        List<String> data = new List<String>();

        private void getTbox()
        {
            data.Clear();
            foreach (Control control in panel1.Controls)
            {
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;
                    data.Add(txtBox.Text);
                }
            }
            data.Insert(2,numericUpDown1.Value.ToString());
            data.Add(inventoryNewItemCommentTbox.Text);
        }

        private void clearTbox()
        {
            foreach (Control control in panel1.Controls)
            {
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;
                    txtBox.Text = "";
                }
            }
            numericUpDown1.ResetText();
            inventoryNewItemCommentTbox.Text = "";
        }

        private void validate(object sender, EventArgs e)
        {
            bool flag = true;
            foreach (Control control in panel1.Controls)
            {
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;
                    if (string.IsNullOrEmpty(txtBox.Text))
                        flag = false;
                }
            }
            if (flag)
                inventoryNewItemAddBtn.Enabled = true;
            else
                inventoryNewItemAddBtn.Enabled = false;
        }

        private void inventoryNewItemAddBtn_Click(object sender, EventArgs e)
        {
            getTbox();
            db.sql = $"insert into mydb.inventory values('{data[0]}','{data[1]}',{Convert.ToInt32(data[2])},'{data[3]}')";            
            try
            {
                db.addCMD();
                db.cmd.ExecuteNonQuery();
                db.disposeCmd();
                Console.WriteLine(DateTime.Now);
                String currTime = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
                int stock = Convert.ToInt32(data[2]);
                String tId = DateTime.Now+"A"+data[2];
                db.sql = $"insert into mydb.inventory_transaction values('{tId}','{DateTime.Now}',{stock},'Add','Add new item','{data[0]}')";
                db.addCMD();
                db.cmd.ExecuteNonQuery();
                db.disposeCmd();
                MessageBox.Show("Add Done", "Done");
                inventoryNewItemAddBtn.Enabled = false;
                clearTbox();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

