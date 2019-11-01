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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
            db.connectDB();           
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String user = loginUserTextBox.Text;
            String pass = loginPassTextBox.Text;
            bool log = false;
            db.sql = "Select * from coordinator";
            db.cmd = new MySqlCommand(db.sql, db.connection);
            using (MySqlDataReader readerCoordinator = db.cmd.ExecuteReader())
            {
                while (readerCoordinator.Read())
                {
                    Console.WriteLine(readerCoordinator.GetString(0));
                    if (readerCoordinator.GetString(0) == user && readerCoordinator.GetString(1) == pass)
                    {
                        log = true;
                        break;
                    }
                }
                readerCoordinator.Close();
            }
            db.cmd.Dispose();
            if (log)
            {
                Home home = new Home();
                this.Hide();
                home.Show();
            }

        }
    }
}
