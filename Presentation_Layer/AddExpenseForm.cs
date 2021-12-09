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
    public partial class AddExpenseForm : Form
    {
        UserController userController;
        DataController dataController = new DataController();
        ExpensesController expensesController = new ExpensesController();
        int categoryIndex;
        public AddExpenseForm(UserController user,int categoryIndex)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            userController = user;
            this.categoryIndex = categoryIndex;
        }

        private void AddExpenseForm_Load(object sender, EventArgs e)
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
            double.TryParse(expenseValueTextBox.Text,out double value);
            try
            {
                expensesController.AddExpense(userController, categoryIndex, value);
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
