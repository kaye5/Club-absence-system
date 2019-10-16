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
    public partial class absenceDetail : Form
    {
        public absenceDetail()
        {
            InitializeComponent();
        }

        private void absenceDetailListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                absenceDetailCMS.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
    }
}
