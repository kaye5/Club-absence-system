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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void AbsenceSummaryButton_Click(object sender, EventArgs e)
        {
            Absence_summary absenceSumm = new Absence_summary();
            absenceSumm.TopLevel = false;
            absenceContentPanel.Controls.Clear();
            absenceContentPanel.Controls.Add(absenceSumm);
            absenceSumm.Show();
        }

        private void AbsenceNewButton_Click(object sender, EventArgs e)
        {
            Absence_new newAbsence = new Absence_new();
            newAbsence.TopLevel = false;
            absenceContentPanel.Controls.Clear();
            absenceContentPanel.Controls.Add(newAbsence);
            newAbsence.Show();
        }
    }
}
