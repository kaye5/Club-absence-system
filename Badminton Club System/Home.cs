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
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
            newMonth();
            showProfileContainer(new profileDashboard());
        }

        public Home(int tabIndex)
        {
            InitializeComponent();
            homeTabControl.SelectTab(tabIndex);
        }

        private void newMonth()
        {
            String previousMonth = DateTime.Now.AddMonths(-1).ToString("MMMM");            
            String todayMonth = DateTime.Now.AddMonths(0).ToString("MMMM");
            String todayYear = DateTime.Today.Year.ToString();
            String today = $"{todayMonth}{todayYear}";
            Console.WriteLine(today);
            db.sql = $"select id from mydb.income where id='{today}' ";
            db.cmd = new MySqlCommand(db.sql, db.connection);
            try
            {
                MySqlDataReader todayReader = db.cmd.ExecuteReader();
                
                if (!todayReader.Read())
                {
                    db.disposeCmd();
                    db.sql = $"insert into mydb.income values('{today}','{todayMonth + " " + todayYear}',0,'{todayMonth}')";
                    db.cmd = new MySqlCommand(db.sql, db.connection);
                    db.cmd.ExecuteNonQuery();                    
                }
                db.disposeCmd();
                todayReader.Close();
                db.sql = $"select id from mydb.expense where id='{today}'";
                db.addCMD();
                todayReader = db.cmd.ExecuteReader();
                if (!todayReader.Read())
                {
                    db.disposeCmd();
                    db.sql = $"insert into mydb.expense values('{today}','{todayMonth + " " + todayYear}',0,'{todayMonth}')";
                    db.cmd = new MySqlCommand(db.sql, db.connection);
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

        private void ExpenseHistoryButton_Click(object sender, EventArgs e)
        {
            expenseDetail historyForm = new expenseDetail();
            showExpenseContainer(historyForm);
        }
        private void expenseThisMonthButton_Click(object sender, EventArgs e)
        {
            expenseDetail historyForm = new expenseDetail();
            showExpenseContainer(historyForm);
        }

        private void expenseLastMonthButton_Click(object sender, EventArgs e)
        {
            expenseDetail historyForm = new expenseDetail();
            showExpenseContainer(historyForm);
        }

        private void expenseDatePicker_ValueChanged(object sender, EventArgs e)
        {
            expenseDetail historyForm = new expenseDetail();
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
            cashDetail detailForm = new cashDetail();
            showIncomeContainer(detailForm);
        }

        private void incomeThisMonthBtn_Click(object sender, EventArgs e)
        {
            cashDetail detailForm = new cashDetail();
            showIncomeContainer(detailForm);
        }
        private void incomeLastMonthBtn_Click(object sender, EventArgs e)
        {
            cashDetail detailForm = new cashDetail();
            showIncomeContainer(detailForm);
        }
        private void incomePickDate_Click(object sender, EventArgs e)
        {
            cashDetail detailForm = new cashDetail();
            showIncomeContainer(detailForm);
        }
        private void IncomeAddBtn_Click(object sender, EventArgs e)
        {
            newCash newForm = new newCash();
            showIncomeContainer(newForm);
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

        
    }
}
