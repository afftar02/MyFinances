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
    public partial class ExpensesForm : Form
    {
        UserController userController;
        DataController dataController = new DataController();
        ExpensesController expensesController = new ExpensesController();
        public ExpensesForm(UserController user)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            userController = user;
            allExpensesValueLabel.Text = Convert.ToString(expensesController.GetAllExpenses(userController));
            categoryBudgetOverLabel.Text = string.Empty;
            myProgressBar.ShowProgressText = false;
            myProgressBar.MaxValue = 50;
            myProgressBar.BackColor = Color.Black;
            mainProgressBar.ShowProgressText = false;
            mainProgressBar.MaxValue = 50;
            mainProgressBar.BackColor = Color.Black;
        }

        private void ExpensesForm_Load(object sender, EventArgs e)
        {
            expensesTreeView.Nodes.Clear();
            foreach (var categoryIndex in expensesController.GetExpensesCategories())
            {
                TreeNode node = new TreeNode(expensesController.GetCategory(categoryIndex));
                node.Nodes.Add(new TreeNode(Convert.ToString(expensesController.GetExpenseAmount(userController, categoryIndex))));
                expensesTreeView.Nodes.Add(node);
            }

            if (expensesController.IsOverAllBudget(userController))
            {
                mainProgressBar.Value = 50;
                mainProgressBar.ProgressColor = Color.Red;
            }
            else if (expensesController.IsOrangeProgressBar(userController))
            {
                mainProgressBar.Value = 50;
                mainProgressBar.ProgressColor = Color.Orange;
            }
            else if (expensesController.IsYellowProgressBar(userController))
            {
                mainProgressBar.Value = 40;
                mainProgressBar.ProgressColor = Color.Yellow;
            }
            else
            {
                mainProgressBar.Value = 20;
                mainProgressBar.ProgressColor = Color.Green;
            }
        }

        private void addExpenseButton_Click(object sender, EventArgs e)
        {
            AddExpenseForm addExpenseForm = new AddExpenseForm(userController, expensesTreeView.SelectedNode.Index);
            addExpenseForm.Show();
            Hide();
        }

        private void changeExpenseButton_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeExpenseForm changeExpenseForm = new ChangeExpenseForm(userController, expensesTreeView.SelectedNode.Index);
                changeExpenseForm.Show();
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Элемент не выбран!");
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            dataController.Save();
            Hide();
            MainMenuForm mainMenuForm = new MainMenuForm(userController);
            mainMenuForm.Show();
        }

        private void expensesTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                categoryBudgetOverLabel.Text = string.Empty;
                if (expensesController.IsOverCategoryBudget(userController, expensesTreeView.SelectedNode.Index))
                {
                    categoryBudgetOverLabel.Text = "Вы превысили бюджет на данную категорию расходов!";
                    myProgressBar.Value = 50;
                    myProgressBar.ProgressColor = Color.Red;
                }
                else if (expensesController.IsOrangeProgressBar(userController, expensesTreeView.SelectedNode.Index))
                {
                    categoryBudgetOverLabel.Text = "Вы достигли предела бюджета в данной категории!";
                    myProgressBar.Value = 50;
                    myProgressBar.ProgressColor = Color.Orange;
                }
                else if (expensesController.IsYellowProgressBar(userController, expensesTreeView.SelectedNode.Index))
                {
                    myProgressBar.Value = 40;
                    myProgressBar.ProgressColor = Color.Yellow;
                }
                else
                {
                    myProgressBar.Value = 20;
                    myProgressBar.ProgressColor = Color.Green;
                }
            }
            catch (Exception) { }
        }
    }
}
