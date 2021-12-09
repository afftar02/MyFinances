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
    public partial class IncomeForm : Form
    {
        UserController userController;
        IncomeController incomeController = new IncomeController();
        WalletController walletController = new WalletController();
        public IncomeForm(UserController user)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            userController = user;
            cardTypeComboBox.Items.AddRange(walletController.GetCardTypes());
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenuForm mainMenuForm = new MainMenuForm(userController);
            mainMenuForm.Show();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int cardTypeIndex = cardTypeComboBox.SelectedIndex;
                string cardNumber = cardNumberComboBox.Text;
                double value = incomeController.GetIncome(userController, cardTypeIndex, cardNumber);
                cardIncomeValueLabel.Text = Convert.ToString(value);
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены некорректно!");
            }
        }

        private void cardTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardNumberComboBox.Items.Clear();
            cardNumberComboBox.Text = string.Empty;
            cardNumberComboBox.Items.AddRange(walletController.GetCardNumbers(userController,cardTypeComboBox.SelectedIndex));
        }
    }
}
