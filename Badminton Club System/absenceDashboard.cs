using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Badminton_Club_System
{
    public partial class absenceDashboard : Form
    {
        public absenceDashboard()
        {
            InitializeComponent();
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
            absenceDetail detailForm = new absenceDetail();
            this.Hide();
            detailForm.Show();
        }
    }
}
