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
    public partial class SetCategoryBudgetForm : Form
    {
        DataController dataController = new DataController();
        UserController userController;
        BudgetController budgetController = new BudgetController();

        public SetCategoryBudgetForm(UserController user)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            userController = user;
            categoriesComboBox.Items.AddRange(budgetController.GetAllCategories());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            double newCategoryBudget;
            int index = categoriesComboBox.SelectedIndex;
            if (double.TryParse(newCategoryBudgetTextBox.Text, out newCategoryBudget) && index>=0)
            {
                if(budgetController.SetNewCategoryBudget(userController, newCategoryBudget, index))
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

        private void SetCategoryBudgetForm_Load(object sender, EventArgs e)
        {

        }
    }
}
