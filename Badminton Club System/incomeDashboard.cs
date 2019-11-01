using System;
using System.Windows.Forms;
namespace Badminton_Club_System
{
    public partial class incomeDashboard : Form
    {
        private int totalTransaction = 0;
        public incomeDashboard()
        {
            InitializeComponent();
            updateData();
        }

        private void updateData()
        {
            db.sql = "select month,cash from income";
            db.addCMD();
            MySql.Data.MySqlClient.MySqlDataReader r = db.cmd.ExecuteReader();
            while (r.Read())
            {
                ListViewItem item = new ListViewItem(r.GetString(0));
                item.SubItems.Add(r.GetInt32(1).ToString("N"));
                totalTransaction += r.GetInt32(1);
                incomeTable.Items.Add(item);
            }
            db.disposeCmd();
            incomeDashboardTotalTbox.Text = totalTransaction.ToString("N");
            incomeDashboardMonthIncome.Text = incomeTable.Items[0].SubItems[1].Text;
        }

        private void viewDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
