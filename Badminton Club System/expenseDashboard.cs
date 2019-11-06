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
    public partial class expenseDashboard : Form
    {
        private int totalExpense = 0;
        private int totalTransaction = 0;
        public expenseDashboard()
        {
            InitializeComponent();
            updateData();
        }

        private void updateData()
        {
            try
            {
                db.sql = "select month,cash from expense";
                db.addCMD();
                MySqlDataReader r = db.cmd.ExecuteReader();

                while (r.Read())
                {
                    ListViewItem item = new ListViewItem(r.GetString(0));
                    item.SubItems.Add(r.GetInt32(1).ToString("N"));
                    totalExpense = r.GetInt32(1);
                    totalTransaction += r.GetInt32(1);
                    expenseListView.Items.Add(item);
                }
                expenseTbox.Text = totalExpense.ToString("N");
                transTbox.Text = totalTransaction.ToString("N");
                db.disposeCmd();
                r.Dispose();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
