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
            absenceDashboard dashboard = new absenceDashboard();
            showAbsenceContainer(dashboard);
            viewMember container = new viewMember();
            showMemberContainer(container);
        }     

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

        private void ExpenseAddButton_Click(object sender, EventArgs e)
        {
            newExpense addExpenseForm = new newExpense();
            showExpenseContainer(addExpenseForm);
        }

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

        private void IncomeAddBtn_Click(object sender, EventArgs e)
        {
            newCash newForm = new newCash();
            showIncomeContainer(newForm);
        }
    }
}
