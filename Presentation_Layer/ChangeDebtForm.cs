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
    public partial class ChangeDebtForm : Form
    {
        UserController userController;
        DataController dataController = new DataController();
        DebtController debtController = new DebtController();

        static string[] MONTH = new string[12] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        static string[] YEAR = new string[50];

        public ChangeDebtForm(UserController user,string creditorName)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            userController = user;
            int k = DateTime.Now.Year;
            for (int i = 0; i < YEAR.Length; i++)
            {
                YEAR[i] = Convert.ToString(k);
                k++;
            }
            monthComboBox.Items.AddRange(MONTH);
            yearComboBox.Items.AddRange(YEAR);
            debtAmountTextBox.Text = Convert.ToString(debtController.GetDebtAmount(userController, creditorName));
            creditorNameValueLabel.Text = creditorName;
            monthComboBox.Text = Convert.ToString(debtController.GetDebtMonth(userController, creditorName));
            yearComboBox.Text = Convert.ToString(debtController.GetDebtYear(userController, creditorName));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DebtsForm debtsForm = new DebtsForm(userController);
            debtsForm.Show();
            Hide();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            double.TryParse(debtAmountTextBox.Text, out double amount);
            string creditorName = creditorNameValueLabel.Text;
            Int32.TryParse((string)monthComboBox.SelectedItem, out int month);
            Int32.TryParse((string)yearComboBox.SelectedItem, out int year);
            if (debtController.ChangeDebt(userController, amount, creditorName, month, year))
            {
                dataController.Save();
                DebtsForm debtsForm = new DebtsForm(userController);
                debtsForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Данные введены некорректно!");
            }
        }

        private void ChangeDebtForm_Load(object sender, EventArgs e)
        {

        }
    }
}
