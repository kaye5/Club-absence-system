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
        String month = DateTime.Now.AddMonths(0).ToString("MMMM");
        String year = DateTime.Now.Year.ToString();
        private ListViewItem selectedItem;
        public profileDashboard()
        {
            
            InitializeComponent();
            coordinatorTable();
            updateData();
        }

        private void updateData()
        {
            try
            {
                db.disposeCmd();
                db.sql = $"select * from profile where year='{DateTime.Now.Year.ToString()}'";
                db.addCMD();
                MySqlDataReader profileReader = db.cmd.ExecuteReader();
                if (profileReader.Read())
                {
                    profileCashTextBox.Text = profileReader.GetInt32(2).ToString();
                    profileFeeTbox.Text = profileReader.GetInt32(1).ToString();
                }
                db.cmd.Dispose();
                profileReader.Dispose();
                //income data
                db.sql = $"select * from income where id='{month + year}'";
                db.addCMD();
                MySqlDataReader incomeReader = db.cmd.ExecuteReader();
                if (incomeReader.Read())                
                    profileIncomeTbox.Text = incomeReader.GetInt32(2).ToString();                
                incomeReader.Dispose();
                db.disposeCmd();
                //expense data
                db.sql = $"select * from income where id='{month + year}'";
                db.addCMD();
                MySqlDataReader expenseReader = db.cmd.ExecuteReader();
                if (expenseReader.Read())
                    profileExpenseTbox.Text = expenseReader.GetInt32(2).ToString();
                expenseReader.Dispose();
                db.disposeCmd();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(),MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void coordinatorTable()
        {
            if (profileListView.Items.Count > 0)
                profileListView.Items.Clear();
            db.cmd.Dispose();
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
            profileFeeTbox.ReadOnly = false;
            profileUpdateFeeBtn.Show();
        }
        private void profileUpdateFeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                db.sql = $"update mydb.profile set memberfee='{Convert.ToInt32(profileFeeTbox.Text)}' where year='{DateTime.Now.Year.ToString()}'";
                db.addCMD();
                db.cmd.ExecuteNonQuery();
                db.disposeCmd();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(),MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            profileUpdateFeeBtn.Hide();
            profileFeeTbox.ReadOnly = true;
            updateData();
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
                clearTbox();
                profileAddCoorBtn.Enabled = false;
                profileActionPanel.Hide();
                coordinatorTable();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(),MessageBoxButtons.OK,MessageBoxIcon.Error);
            }          
        }

        private void profileChangeTabBtn_Click(object sender, EventArgs e)
        {
            Button viewBtn = (Button)sender;
            Home homeForm = new Home(Convert.ToInt16(viewBtn.AccessibleDescription));
            ActiveForm.Hide();
            homeForm.Show();
        }

        private void clearTbox()
        {
            foreach (Control control in profileActionPanel.Controls)
            {
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;
                    txtBox.Text = "";
                }
            }
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

            db.sql = "update mydb.coordinator set " + 
                     $"pass = '{profilePassTbox.Text}', name = '{profileNameTbox.Text}' , position = '{profilePositionTbox.Text}' , nim = '{profileNimTBox.Text}' " +
                     $" where email = '{profileEmailTbox.Text}'";  
            try
            {
                db.cmd = new MySqlCommand(db.sql, db.connection);
                db.cmd.ExecuteNonQuery();
                db.disposeCmd();
            } catch(MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(),MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            clearTbox();
            profileActionPanel.Visible = false;
            profileUpdateCoorBtn.Visible = false;
            coordinatorTable();
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
                profileActionPanel.Visible = true;
                profileUpdateCoorBtn.Visible = true;
                profileAddCoorBtn.Enabled = false;
                profileUpdateCoorBtn.Enabled = false;
            } else
            {
                MessageBox.Show("No item selected", "Warning");
            }  
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (profileListView.SelectedItems.Count > 0)
            {
                selectedItem = profileListView.SelectedItems[0];
                db.sql = $"DELETE FROM mydb.coordinator WHERE id='{selectedItem.Text}' ";
                db.addCMD();
                db.cmd.ExecuteNonQuery();
                db.disposeCmd();
                coordinatorTable();
            }
            else
            {
                MessageBox.Show("No item selected", "Warning");
            }
        }
    }
}
