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
    public partial class AddCardForm : Form
    {
        UserController userController;
        DataController dataController = new DataController();
        WalletController walletController = new WalletController();
        public AddCardForm(UserController user)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            userController = user;
            cardTypeComboBox.Items.AddRange(walletController.GetCardTypes());
        }

        private void AddCardForm_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                walletController.AddCard(userController,cardTypeComboBox.SelectedIndex, cardNumberTextBox.Text, pinCodeTextBox.Text);
                dataController.Save();
                MessageBox.Show($"Карта {cardNumberTextBox.Text} успешно добавлена!");
                Hide();
                MainMenuForm mainMenuForm = new MainMenuForm(userController);
                mainMenuForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Данные карты введены неверно!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenuForm mainMenuForm = new MainMenuForm(userController);
            mainMenuForm.Show();
        }
    }
}
