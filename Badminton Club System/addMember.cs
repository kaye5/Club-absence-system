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
    public partial class addMember : Form
    {
        public addMember()
        {
            InitializeComponent();
        }

        private void memberAddUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> data = new List<String>();
                foreach (Control control in panel1.Controls)
                {
                    string controlType = control.GetType().ToString();
                    if (controlType == "System.Windows.Forms.TextBox")
                    {
                        TextBox txtBox = (TextBox)control;
                        data.Add(txtBox.Text);
                    }
                }
                db.sql = "insert into `member`(`intake`,`class`,`email`,`name`,`nim`) " +
                    $"values('{data[0]}','{data[1]}','{data[2]}','{data[3]}','{data[4]}')";
                Console.WriteLine(db.sql);
                db.addCMD();
                db.cmd.ExecuteNonQuery();
                db.disposeCmd();
                MessageBox.Show("DONE");
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void validation(object sender, EventArgs e)
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
                memberAddUserBtn.Enabled = true;
            else
                memberAddUserBtn.Enabled = false;
        }
    }
}
