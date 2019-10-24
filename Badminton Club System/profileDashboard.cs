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
    public partial class profileDashboard : Form
    {
        private ListViewItem selectedItem;
        public profileDashboard()
        {
            InitializeComponent();
            coordinatorTable();
        }
        private void coordinatorTable()
        {
            db.sql = "select * from coordinator";
            db.cmd = new MySqlCommand(db.sql, db.connection);
            MySqlDataReader reader = db.cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                for (int i = 1; i < reader.FieldCount; i++)
                    item.SubItems.Add(reader.GetString(i));
                profileListView.Items.Add(item);
            }
            db.cmd.Dispose();
            reader.Close();
        }

        private void profileChangeFeeBtn_Click(object sender, EventArgs e)
        {
            profileUpdateFeeBtn.Show();
        }

        private void profileUpdateFeeBtn_Click(object sender, EventArgs e)
        {
            profileUpdateFeeBtn.Hide();
        }

        private void profileNewCoorBtn_Click(object sender, EventArgs e)
        {
            profileActionPanel.Show();
        }

        private void profileAddCoorBtn_Click(object sender, EventArgs e)
        {
            db.sql = "INSERT INTO mydb.coordinator " + 
                     "(email,pass,name,position,nim)" + 
                     $"values('{profileEmailTbox.Text}','{profilePassTbox.Text}','{profileNameTbox.Text}','{profilePositionTbox.Text}','{profileNimTBox.Text}')";
            try
            {
                db.cmd = new MySqlCommand(db.sql,db.connection);
                db.cmd.Prepare();
                db.cmd.ExecuteNonQuery();
                db.disposeCmd();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            profileAddCoorBtn.Enabled = false;
            profileActionPanel.Hide();
            coordinatorTable();
        }

        private void profileChangeTabBtn_Click(object sender, EventArgs e)
        {
            Button viewBtn = (Button)sender;
            Home homeForm = new Home(Convert.ToInt16(viewBtn.AccessibleDescription));
            ActiveForm.Hide();
            homeForm.Show();
        }

        private void validation(object sender,EventArgs e)
        {
            bool flag = true;
            foreach (Control control in profileActionPanel.Controls)
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
            {
                profileAddCoorBtn.Enabled = true;
                profileUpdateCoorBtn.Enabled = true;
            }
                
            else{
                profileAddCoorBtn.Enabled = false;
                profileUpdateCoorBtn.Enabled = false;
            }
                
        }

        private void dashboardListViewCLick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                coorCTMS.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void profileUpdateCoorBtn_Click(object sender, EventArgs e)
        {
            
            db.sql = "INSERT INTO mydb.coordinator " +
                     "(email,pass,name,position,nim)" +
                     $"values('{profileEmailTbox.Text}','{profilePassTbox.Text}','{profileNameTbox.Text}','{profilePositionTbox.Text}','{profileNimTBox.Text}')";
            profileUpdateCoorBtn.Visible = false;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(profileListView.SelectedItems.Count > 0)
            {
                selectedItem = profileListView.SelectedItems[0];
                profileEmailTbox.Text = selectedItem.Text;
                profilePassTbox.Text = selectedItem.SubItems[1].Text;
                profileNameTbox.Text = selectedItem.SubItems[2].Text;
                profilePositionTbox.Text = selectedItem.SubItems[3].Text;
                profileNimTBox.Text = selectedItem.SubItems[4].Text;
                profileUpdateCoorBtn.Visible = true;
            } else
            {
                MessageBox.Show("No item selected", "Warning");
            }  
        }
    }
}
