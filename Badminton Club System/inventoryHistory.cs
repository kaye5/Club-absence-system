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
    public partial class inventoryHistory : Form
    {
        private int tt = 0;
        public inventoryHistory()
        {
            InitializeComponent();
            updateTable();
        }

        private void updateTable()
        {
            try
            {
                db.sql = "select t1.id ,t1.create_time ,t2.`name`, t1.stock  , t1.action , t1.comment from inventory_transaction t1 inner join inventory t2 on t1.inventory_id = t2.ID";
                db.addCMD();
                MySqlDataReader reader = db.cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());
                    for (int i = 1; i < reader.FieldCount; i++)
                        item.SubItems.Add(reader.GetValue(i).ToString());
                    tt++;
                    listView1.Items.Add(item);
                }
                inventoryHistoryTotTrasnTbox.Text = tt.ToString();
                reader.Dispose();
                db.disposeCmd();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
