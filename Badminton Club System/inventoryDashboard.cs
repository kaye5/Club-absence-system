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
    public partial class inventoryDashboard : Form
    {
        
        public inventoryDashboard()
        {
            InitializeComponent();
            updateInventory();
        }

        private void updateInventory()
        {
            int count = 0;
            try {  
                if(listView1.Items.Count > 0 )
                    listView1.Items.Clear();
                db.sql = "select * from mydb.inventory";
                db.addCMD();
                MySqlDataReader reader = db.cmd.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                    Console.WriteLine(reader.GetString(0));
                    ListViewItem item = new ListViewItem(reader.GetString(0));
                    item.SubItems.Add(reader.GetString(1));
                    item.SubItems.Add(reader.GetInt16(2).ToString());
                    item.SubItems.Add(reader.GetString(3));
                    listView1.Items.Add(item);
                }
                reader.Dispose();
                db.disposeCmd();
                textBox1.Text = count.ToString();
           }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem;
            if(listView1.SelectedItems.Count > 0)
            {
                inventoryDashboardUpdatePanel.Visible = true;
                selectedItem = listView1.SelectedItems[0];
                invetoryDashboardIDTbox.Text = selectedItem.Text;
                invetoryDashboardNameTbox.Text = selectedItem.SubItems[1].Text;
            }
        }

        private void inventoryDashboardUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String ID = invetoryDashboardIDTbox.Text;
                String name = invetoryDashboardNameTbox.Text;
                db.sql = $"update mydb.inventory set name='{name}' where id='{ID}' ";
                db.addCMD();
                db.cmd.ExecuteNonQuery();
                db.disposeCmd();
                invetoryDashboardNameTbox.Text = "";
                invetoryDashboardIDTbox.Text = "";
                inventoryDashboardUpdatePanel.Visible = false;
                updateInventory();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ARE YOU SURE\nThis will delete all the history", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                ListViewItem selectedItem;
                if (listView1.SelectedItems.Count > 0)
                {
                    selectedItem = listView1.SelectedItems[0];
                    try
                    {
                        db.sql = $"delete from mydb.inventory_transaction where inventory_id='{selectedItem.Text}'";
                        db.addCMD();
                        db.cmd.ExecuteNonQuery();
                        db.disposeCmd();
                        db.sql = $"delete from mydb.inventory where id='{selectedItem.Text}'";
                        db.addCMD();
                        db.cmd.ExecuteNonQuery();
                        db.disposeCmd();
                        updateInventory();
                    }
                    catch (MySqlException err)
                    {
                        MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                inventoryDashboardCMS.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
    }
}
