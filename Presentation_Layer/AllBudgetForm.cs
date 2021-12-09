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
    public partial class AllBudgetForm : Form
    {
        BudgetController budgetController = new BudgetController();
        public AllBudgetForm(UserController userController)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            budgetAmountLabel.Text = Convert.ToString(budgetController.GetAllBudget(userController));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AllBudgetForm_Load(object sender, EventArgs e)
        {

        }
    }
}
