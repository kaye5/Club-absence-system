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
    public partial class viewMember : Form
    {
        public viewMember()
        {
            InitializeComponent();
            memberIntakeComboBox.SelectedIndex = 0;
            memberListView.Columns[memberListView.Columns.Count - 1].Width = -2;
            
        }
    }
}
