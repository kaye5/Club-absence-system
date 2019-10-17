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
    public partial class profileDashboard : Form
    {
        public profileDashboard()
        {
            InitializeComponent();
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
            profileActionPanel.Hide();
        }

        private void profileChangeTabBtn_Click(object sender, EventArgs e)
        {
            Button viewBtn = (Button)sender;
            Home homeForm = new Home(Convert.ToInt16(viewBtn.AccessibleDescription));
            ActiveForm.Hide();
            homeForm.Show();
        }
    }
}
