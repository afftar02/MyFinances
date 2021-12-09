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
    public partial class SetAllBudgetForm : Form
    {
        DataController dataController = new DataController();
        UserController userController;
        BudgetController budgetController = new BudgetController();

        public SetAllBudgetForm(UserController user)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            userController = user;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            double newAllBudget;
            if(double.TryParse(newAllBudgetTextBox.Text, out newAllBudget))
            {
                if(budgetController.SetNewAllBudget(userController, newAllBudget))
                {
                    dataController.Save();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Данные введены некорректно!");
                }
            }
            else
            {
                MessageBox.Show("Данные введены некорректно!");
            }
        }

        private void SetAllBudgetForm_Load(object sender, EventArgs e)
        {

        }
    }
}
