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
    public partial class absenceDashboard : Form
    {
        public absenceDashboard()
        {
            InitializeComponent();
            updateData();
        }
        private void dashboardListViewCLick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dashboardListViewCMS.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (absenceDashboardListView.SelectedItems.Count > 0)
            {
                String today = absenceDashboardListView.SelectedItems[0].SubItems[0].Text;
                absenceDetail detailForm = new absenceDetail(today);
                detailForm.Show();
            }
        }

        private void updateData()
        {
            try
            {
                db.sql = "select `month`,max(`meeting_count`) from meeting group by `month`";
                db.addCMD();
                MySqlDataReader r = db.cmd.ExecuteReader();
                while (r.Read())
                {
                    ListViewItem item = new ListViewItem(r.GetString(0));
                    item.SubItems.Add(r.GetInt16(1).ToString());
                    absenceDashboardListView.Items.Add(item);
                }
                r.Dispose();
                db.disposeCmd();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
