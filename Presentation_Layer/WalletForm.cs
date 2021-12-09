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
    public partial class WalletForm : Form
    {
        UserController userController = new UserController();
        WalletController walletController = new WalletController();
        public WalletForm(UserController user)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            userController = user;
            cardTypeComboBox.Items.AddRange(walletController.GetCardTypes());
        }

        private void WalletForm_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenuForm mainMenuForm = new MainMenuForm(userController);
            mainMenuForm.Show();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                balanceValueLabel.Text = Convert.ToString(walletController.GetCardBalance(userController, cardTypeComboBox.SelectedIndex, cardNumberComboBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены некорректно!");
            }
        }

        private void cardTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cardNumberComboBox.Items.Clear();
            cardNumberComboBox.Text = string.Empty;
            cardNumberComboBox.Items.AddRange(walletController.GetCardNumbers(userController, cardTypeComboBox.SelectedIndex));
        }
    }
}
