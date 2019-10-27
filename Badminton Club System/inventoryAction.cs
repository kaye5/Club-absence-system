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
    public partial class inventoryAction : Form
    {
        List<String> itemName = new List<String>();
        public inventoryAction()
        {
            InitializeComponent();
            updateCB();
            inventoryActionIDCB.SelectedIndex = 0;
        }

        private void updateCB()
        {
            try
            {
                itemName.Clear();
                db.sql = "select id,name from inventory";
                db.addCMD();
                MySqlDataReader r = db.cmd.ExecuteReader();
                while (r.Read())
                {
                    inventoryActionIDCB.Items.Add(r.GetString(0));
                    itemName.Add(r.GetString(1));
                }
                r.Dispose();
                db.disposeCmd();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inventoryActionIDCB_SelectedValueChanged(object sender, EventArgs e)
        {
            int CBIndex = inventoryActionIDCB.SelectedIndex;
            inventoryActionNameTbox.Text = itemName[CBIndex];
        }

        private void inventoryActionAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String itemId = inventoryActionIDCB.SelectedItem.ToString();
                int itemCount = (int)inventoryActionCountTbox.Value;
                String tid = DateTime.Now+ "I" + itemCount.ToString();
                String c = "Increase " + itemId;
                db.sql = "insert into inventory_transaction " +
                    $"values('{tid}','{DateTime.Now}',{itemCount},'INC','{c}','{itemId}')";
                Console.WriteLine(db.sql);
                db.addCMD();
                db.cmd.ExecuteNonQuery();
                db.disposeCmd();
                db.sql = $"update inventory set stock = stock + {itemCount} where id ='{itemId}'";
                db.addCMD();
                db.cmd.ExecuteReader();
                db.disposeCmd ();
                MessageBox.Show("DONE");
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inventoryItemRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String itemId = inventoryActionIDCB.SelectedItem.ToString();
                int itemCount = (int)inventoryActionCountTbox.Value;
                String tid = DateTime.Now + "I" + itemCount.ToString();
                String c = "Decrease " + itemId;
                db.sql = "insert into inventory_transaction " +
                    $"values('{tid}','{DateTime.Now}',{itemCount},'DEC','{c}','{itemId}')";
                Console.WriteLine(db.sql);
                db.addCMD();
                db.cmd.ExecuteNonQuery();
                db.disposeCmd();
                db.sql = $"update inventory set stock = if(stock-{itemCount}>=0,stock-{itemCount},stock) where id ='{itemId}'";
                db.addCMD();
                db.cmd.ExecuteReader();
                db.disposeCmd();
                MessageBox.Show("DONE");
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
