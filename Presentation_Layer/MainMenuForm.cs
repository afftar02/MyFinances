using Kursach_3_Sem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class MainMenuForm : Form
    {
        DataController dataController = new DataController();
        UserController userController;
        WalletController walletController = new WalletController();

        public MainMenuForm(UserController user)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            userController = user;
            string userName = userController.GetUserName();
            userNameLabel.Text = userName;
            walletBalanceLabel.Text = Convert.ToString(walletController.getUserBalance(userName));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            dataController.Save();
            Application.Exit();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void SetAllBudgetMenuItem_Click(object sender, EventArgs e)
        {
            SetAllBudgetForm setAllBudgetForm = new SetAllBudgetForm(userController);
            setAllBudgetForm.Show();
        }

        private void SetCategoryBudgetMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryBudgetForm setCategoryBudgetForm = new SetCategoryBudgetForm(userController);
            setCategoryBudgetForm.Show();
        }

        private void LookAllBudgetMenuItem_Click(object sender, EventArgs e)
        {
            AllBudgetForm allBudgetForm = new AllBudgetForm(userController);
            allBudgetForm.Show();
        }

        private void LookCategoryBudgetMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesBudgetForm categoriesBudgetForm = new CategoriesBudgetForm(userController);
            categoriesBudgetForm.Show();
        }

        private void DebtsMenuItem_Click(object sender, EventArgs e)
        {
            DebtsForm debtsForm = new DebtsForm(userController);
            debtsForm.Show();
            Hide();
        }

        private void ExpensesMenuItem_Click(object sender, EventArgs e)
        {
            ExpensesForm expensesForm = new ExpensesForm(userController);
            expensesForm.Show();
            Hide();
        }

        private void LookIncomeMenuItem_Click(object sender, EventArgs e)
        {
            IncomeForm incomeForm = new IncomeForm(userController);
            incomeForm.Show();
            Hide();
        }

        private void AddIncomeMenuItem_Click(object sender, EventArgs e)
        {
            AddIncomeForm addIncomeForm = new AddIncomeForm(userController);
            addIncomeForm.Show();
            Hide();
        }

        private void DeleteIncomeMenuItem_Click(object sender, EventArgs e)
        {
            DecreaseIncomeForm decreaseIncomeForm = new DecreaseIncomeForm(userController);
            decreaseIncomeForm.Show();
            Hide();
        }

        private void AddCardMenuItem_Click(object sender, EventArgs e)
        {
            AddCardForm addCardForm = new AddCardForm(userController);
            addCardForm.Show();
            Hide();
        }

        private void DeleteCardMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCardForm deleteCardForm = new DeleteCardForm(userController);
            deleteCardForm.Show();
            Hide();
        }

        private void LookWalletMenuItem_Click(object sender, EventArgs e)
        {
            WalletForm walletForm = new WalletForm(userController);
            walletForm.Show();
            Hide();
        }
    }
}
