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
    public partial class ChangeExpenseForm : Form
    {
        UserController userController;
        DataController dataController = new DataController();
        ExpensesController expensesController = new ExpensesController();
        int indexOfCategory;

        public ChangeExpenseForm(UserController user,int categoryIndex)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            userController = user;
            categoryValueLabel.Text = expensesController.GetCategory(categoryIndex);
            indexOfCategory = categoryIndex;
        }

        private void ChangeExpenseForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ExpensesForm expensesForm = new ExpensesForm(userController);
            expensesForm.Show();
            Hide();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                expensesController.ChangeExpenseOfCategory(userController, expenseValueTextBox.Text, indexOfCategory);
                dataController.Save();
                ExpensesForm expensesForm = new ExpensesForm(userController);
                expensesForm.Show();
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены некорректно!");
            }
        }
    }
}
