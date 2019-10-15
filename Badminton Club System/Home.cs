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

        void showContainer(Form container)
        {
            container.TopLevel = false;
            memberContainerPanel.Controls.Clear();
            memberContainerPanel.Controls.Add(container);
            container.Show();
        }

        private void containerPaymentButton_Click(object sender, EventArgs e)
        {
            memberPayment container = new memberPayment();
            showContainer(container);
        }

        private void containerMemberButton_Click(object sender, EventArgs e)
        {
            viewMember container = new viewMember();
            showContainer(container);
        }

        private void memberAddButton_Click(object sender, EventArgs e)
        {
            addMember container = new addMember();
            showContainer(container);
        }
    }
}
