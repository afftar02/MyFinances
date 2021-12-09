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
    public partial class DeleteCardForm : Form
    {
        UserController userController;
        DataController dataController = new DataController();
        WalletController walletController = new WalletController();
        public DeleteCardForm(UserController user)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            userController = user;
            cardTypeComboBox.Items.AddRange(walletController.GetCardTypes());
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                walletController.DeleteCard(userController, cardTypeComboBox.SelectedIndex, cardNumberComboBox.Text);
                dataController.Save();
                MessageBox.Show($"Карта {cardNumberComboBox.Text} успешно удалена!");
                Hide();
                MainMenuForm mainMenuForm = new MainMenuForm(userController);
                mainMenuForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Данные выбраны некорректно!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenuForm mainMenuForm = new MainMenuForm(userController);
            mainMenuForm.Show();
        }

        private void cardTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cardNumberComboBox.Items.Clear();
            cardNumberComboBox.Text = string.Empty;
            cardNumberComboBox.Items.AddRange(walletController.GetCardNumbers(userController, cardTypeComboBox.SelectedIndex));
        }
    }
}
