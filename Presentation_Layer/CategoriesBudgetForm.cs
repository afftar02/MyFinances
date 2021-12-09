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
    public partial class CategoriesBudgetForm : Form
    {
        UserController userController;
        BudgetController budgetController = new BudgetController();

        public CategoriesBudgetForm(UserController user)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            userController = user;
            categoriesComboBox.Items.AddRange(budgetController.GetAllCategories());
            categoryLabel.Text = "...";
            budgetAmountLabel.Text = "...";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void CategoriesBudgetForm_Load(object sender, EventArgs e)
        {

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = categoriesComboBox.SelectedIndex;
                var (category, budget) = budgetController.GetCategoryBudget(userController, index);
                categoryLabel.Text = category;
                budgetAmountLabel.Text = Convert.ToString(budget);
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены некорректно!");
            }
        }
    }
}
