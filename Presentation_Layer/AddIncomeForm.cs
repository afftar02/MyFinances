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
    public partial class AddIncomeForm : Form
    {
        DataController dataController = new DataController();
        UserController userController = new UserController();
        IncomeController incomeController = new IncomeController();
        WalletController walletController = new WalletController();
        public AddIncomeForm(UserController user)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            userController = user;
            cardTypeComboBox.Items.AddRange(walletController.GetCardTypes());
            incomeValueTextBox.Text = string.Empty;
        }

        private void AddIncomeForm_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                double.TryParse(incomeValueTextBox.Text, out double amount);
                incomeController.AddIncome(userController, amount, cardTypeComboBox.SelectedIndex, cardNumberComboBox.Text);
                dataController.Save();
                Hide();
                MainMenuForm mainMenuForm = new MainMenuForm(userController);
                mainMenuForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }

        private void cardTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardNumberComboBox.Items.Clear();
            cardNumberComboBox.Text = string.Empty;
            cardNumberComboBox.Items.AddRange(walletController.GetCardNumbers(userController, cardTypeComboBox.SelectedIndex));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenuForm mainMenuForm = new MainMenuForm(userController);
            mainMenuForm.Show();
        }
    }
}
