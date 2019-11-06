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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
namespace Badminton_Club_System
{
    public partial class Home : Form
    {        
        public Home()
        {
            InitializeComponent();
            newMonth();
            showProfileContainer(new profileDashboard());
            this.Width = 1848;
            this.Height = 1050;
        }

        public Home(int tabIndex)
        {
            InitializeComponent();
            homeTabControl.SelectedIndex = 0 ;
            homeTabControl.SelectedIndex = tabIndex;
            
        }

        private string getMonth(int n)
        {
            // 0 current month 
            // -1 prev month
            return DateTime.Now.AddMonths(n).ToString("MMMM");
        }
        private string getYear()
        {
            return DateTime.Now.Year.ToString();
        }

        private void newMonth()
        {
            String previousMonth = DateTime.Now.AddMonths(-1).ToString("MMMM");            
            String todayMonth = DateTime.Now.AddMonths(0).ToString("MMMM");
            String todayYear = DateTime.Today.Year.ToString();
            String today = $"{todayMonth}{todayYear}";
            Console.WriteLine(today);
            db.sql = $"select id from `income` where id='{today}' ";
            db.cmd = new MySqlCommand(db.sql, db.connection);
            try
            {
                MySqlDataReader todayReader = db.cmd.ExecuteReader();
                
                if (!todayReader.Read())
                {
                    db.disposeCmd();
                    db.sql = $"insert into `income` values('{today}','{todayMonth + " " + todayYear}',0,'{todayMonth}')";
                    db.cmd = new MySqlCommand(db.sql, db.connection);
                    db.cmd.ExecuteNonQuery();                    
                }
                db.disposeCmd();
                todayReader.Close();
                db.sql = $"select id from `expense` where id='{today}'";
                db.addCMD();
                todayReader = db.cmd.ExecuteReader();
                if (!todayReader.Read())
                {
                    db.disposeCmd();
                    db.sql = $"insert into `expense` values('{today}','{todayMonth + " " + todayYear}',0,'{todayMonth}')";
                    db.cmd = new MySqlCommand(db.sql, db.connection);
                    db.cmd.ExecuteNonQuery();                    
                }
                db.disposeCmd();
                todayReader.Close();
                db.sql = $"select id from `meeting` where id='{today+"1"}'";
                db.addCMD();
                todayReader = db.cmd.ExecuteReader();
                if (!todayReader.Read())
                {
                    db.disposeCmd();
                    db.sql = $"insert into `meeting` values('{today+"1"}','{todayMonth + " " + todayYear}',1)";
                    db.cmd = new MySqlCommand(db.sql, db.connection);
                    db.addCMD();
                    db.cmd.ExecuteNonQuery();
                    db.sql = $"insert into `absence`(`id`,`member_id`,`meeting_id`) select concat('{today + "1"}',m.nim) , m.nim , '{today + "1"}' from `member` m";
                    db.addCMD();
                    db.cmd.ExecuteNonQuery();
                }
                db.disposeCmd();
                todayReader.Close();
            } catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Code.ToString());
            }            
        }

        //TAB CONTROL
        private void homeTabControl_TabIndexChanged(object sender, EventArgs e)
        {
            String tabName = homeTabControl.SelectedTab.Text;
            if (tabName == "Profile") 
                showProfileContainer(new profileDashboard());
            else if (tabName == "Absence")
                showAbsenceContainer(new absenceDashboard());
            else if (tabName == "Member")
                memberMemberButton.PerformClick();
            else if (tabName == "Expense")
                expenseDashboardButton.PerformClick();
            else if (tabName == "Income")
                incomeDashboardBtn.PerformClick();
            else if (tabName == "Inventory")
                inventoryDashboardButton.PerformClick();
        }

        //SHOW ITEM PART
        void showMemberContainer(Form container)
        {
            container.TopLevel = false;
            memberContainerPanel.Controls.Clear();
            memberContainerPanel.Controls.Add(container);
            container.Show();
        }

        void showAbsenceContainer(Form container)
        {
            container.TopLevel = false;
            absenceContainerPanel.Controls.Clear();
            absenceContainerPanel.Controls.Add(container);
            container.Show();
        }

        void showExpenseContainer(Form container)
        {
            container.TopLevel = false;
            expenseContainerPanel.Controls.Clear();
            expenseContainerPanel.Controls.Add(container);
            container.Show();
        }
        void showIncomeContainer(Form container)
        {
            container.TopLevel = false;
            incomeContainerPanel.Controls.Clear();
            incomeContainerPanel.Controls.Add(container);
            container.Show();
        }


        void showInventoryContainer(Form container)
        {
            container.TopLevel = false;
            inventoryContainerPanel.Controls.Clear();
            inventoryContainerPanel.Controls.Add(container);
            container.Show();
        }

        void showProfileContainer(Form container)
        {
            container.TopLevel = false;
            profileContainerPanel.Controls.Clear();
            profileContainerPanel.Controls.Add(container);
            container.Show();
        }

        //MEMBER TAB
        private void containerMemberButton_Click(object sender, EventArgs e)
        {
            viewMember container = new viewMember();
            showMemberContainer(container);
            
        }
        private void containerPaymentButton_Click(object sender, EventArgs e)
        {
            memberPayment container = new memberPayment();
            showMemberContainer(container);
        }

        private void memberAddButton_Click(object sender, EventArgs e)
        {
            addMember container = new addMember();
            showMemberContainer(container);
        }

        //EXPENSE TAB
        private void ExpenseDashboardButton_Click(object sender, EventArgs e)
        {
            expenseDashboard dashboard = new expenseDashboard();
            showExpenseContainer(dashboard);
        }

        private void expenseThisMonthButton_Click(object sender, EventArgs e)
        {
            expenseDetail historyForm = new expenseDetail(getMonth(0),getYear());
            showExpenseContainer(historyForm);
        }

        private void expenseLastMonthButton_Click(object sender, EventArgs e)
        {
            expenseDetail historyForm = new expenseDetail(getMonth(-1), getYear());
            showExpenseContainer(historyForm);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            expenseDetail historyForm = new expenseDetail(dateTimePicker2.Value.ToString("MMMM"), dateTimePicker2.Value.ToString("yyyy"));
            showExpenseContainer(historyForm);
        }
        private void ExpenseAddButton_Click(object sender, EventArgs e)
        {
            newExpense addExpenseForm = new newExpense();
            showExpenseContainer(addExpenseForm);
        }
        

        //INCOME TAB
        private void IncomeDashboardButton_Click(object sender, EventArgs e)
        {
            incomeDashboard dashboardForm = new incomeDashboard();
            showIncomeContainer(dashboardForm);
        }

        private void IncomeHistoryBtn_Click(object sender, EventArgs e)
        {
            cashDetail detailForm = new cashDetail(getMonth(0), getYear());
            showIncomeContainer(detailForm);
        }

        private void incomeLastMonthBtn_Click(object sender, EventArgs e)
        {
            cashDetail detailForm = new cashDetail(getMonth(-1), getYear());
            showIncomeContainer(detailForm);
        }
        
        private void IncomeAddBtn_Click(object sender, EventArgs e)
        {
            newCash newForm = new newCash();
            showIncomeContainer(newForm);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            String month = dateTimePicker1.Value.ToString("MMMM");
            String year = dateTimePicker1.Value.ToString("yyyy");
            cashDetail detailForm = new cashDetail(month,year);
            showIncomeContainer(detailForm);
        }

        //INVENTORY TAB
        private void inventoryDashboardButton_Click(object sender, EventArgs e)
        {
            inventoryDashboard dashboardForm = new inventoryDashboard();
            showInventoryContainer(dashboardForm);
        }

        private void inventoryHistoryButton_Click(object sender, EventArgs e)
        {
            inventoryHistory historyForm = new inventoryHistory();
            showInventoryContainer(historyForm);
        }

        private void inventoryNewItemButton_Click(object sender, EventArgs e)
        {
            
            showInventoryContainer(new inventoryNewItem());
        }

        private void inventoryAddButton_Click(object sender, EventArgs e)
        {
            showInventoryContainer(new inventoryAction());
        }
        
        private void ExportBtn_Click(object sender, EventArgs e)
        {
            ReportDocument inv = new ReportDocument();
            inv.Load(@"\\Mac\Home\Desktop\badminton-club-system-master\badminton-club-system-master\Badminton Club System\\inventory.rpt");
            inv.Refresh();
            inv.PrintToPrinter(1, false, 0, 0);
        }
    }
}
