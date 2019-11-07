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
    public partial class viewMember : Form
    {
        public viewMember()
        {
            InitializeComponent();
            
            memberListView.Columns[memberListView.Columns.Count - 1].Width = -2;
            updateData();
            
        }

        private void updateData()
        {
            try
            {
                memberListView.Items.Clear();
                db.sql = $"select * from `member`";
                db.addCMD();
                MySqlDataReader r = db.cmd.ExecuteReader();
                while (r.Read())
                {
                    
                    if (r.GetString(0) == "001")
                        continue;
                    ListViewItem item = new ListViewItem(r.GetValue(0).ToString());
                    for (int i = 1; i < r.FieldCount; i++)
                        item.SubItems.Add(r.GetValue(i).ToString());
                    memberListView.Items.Add(item);
                }
                r.Dispose();
                db.disposeCmd();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewMemberDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (memberListView.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in memberListView.SelectedItems)
                    {
                        db.sql = $"DELETE FROM `mydb`.`member` WHERE `nim`='{item.SubItems[0].Text}'";
                        db.addCMD();
                        db.cmd.ExecuteNonQuery();
                        db.disposeCmd();
                    }
                    updateData();
                }
                else
                {
                    MessageBox.Show("NO ITEM SELECTED", "WARNING");
                }
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeStatA_Click(object sender, EventArgs e)
        {
            try
            {
                if (memberListView.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in memberListView.SelectedItems)
                    {
                        db.sql = $"update `mydb`.`member` set `status`='Active' WHERE `nim`='{item.SubItems[0].Text}'";
                        db.addCMD();
                        db.cmd.ExecuteNonQuery();
                        db.disposeCmd();
                    }
                    updateData();
                }
                else
                {
                    MessageBox.Show("NO ITEM SELECTED", "WARNING");
                }
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeStatB_Click(object sender, EventArgs e)
        {
            try
            {
                if (memberListView.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in memberListView.SelectedItems)
                    {
                        db.sql = $"update `mydb`.`member` set `status`='Non-Active' WHERE `nim`='{item.SubItems[0].Text}'";
                        db.addCMD();
                        db.cmd.ExecuteNonQuery();
                        db.disposeCmd();
                    }
                    updateData();
                }
                else
                {
                    MessageBox.Show("NO ITEM SELECTED", "WARNING");
                }
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                memberListView.Items.Clear();
                db.sql = $"select * from `member` where intake='{filterTbox.Text}'";
                db.addCMD();
                MySqlDataReader r = db.cmd.ExecuteReader();
                while (r.Read())
                {

                    if (r.GetString(0) == "001")
                        continue;
                    ListViewItem item = new ListViewItem(r.GetValue(0).ToString());
                    for (int i = 1; i < r.FieldCount; i++)
                        item.SubItems.Add(r.GetValue(i).ToString());
                    memberListView.Items.Add(item);
                }
                r.Dispose();
                db.disposeCmd();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            updateData();
        }
    }
}
