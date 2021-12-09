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
    public partial class DebtsForm : Form
    {
        UserController userController;
        DebtController debtController = new DebtController();
        DataController dataController = new DataController();

        public DebtsForm(UserController user)
        {
            InitializeComponent();
            AutoSize = true;
            StartPosition = FormStartPosition.CenterScreen;
            userController = user;
            myProgressBar.ShowProgressText = false;
            myProgressBar.MaxValue = 50;
            myProgressBar.BackColor = Color.Black;
        }

        private void DebtsForm_Load(object sender, EventArgs e)
        {
            debtsTreeView.Nodes.Clear();
            foreach (var item in debtController.GetDebts(userController))
            {
                TreeNode node = new TreeNode(debtController.GetCreditorName(userController, item));
                node.Nodes.Add(new TreeNode(Convert.ToString(debtController.GetDebtAmount(userController, item))));
                node.Nodes.Add(new TreeNode("до " + debtController.GetDebtDate(userController, item)));
                debtsTreeView.Nodes.Add(node);
            }
        }

        private void addDebtButton_Click(object sender, EventArgs e)
        {
            AddDebtForm addDebtForm = new AddDebtForm(userController);
            addDebtForm.Show();
            Hide();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            dataController.Save();
            Hide();
            MainMenuForm mainMenuForm = new MainMenuForm(userController);
            mainMenuForm.Show();
        }

        private void deleteDebtButton_Click(object sender, EventArgs e)
        {
            if (debtController.RemoveDebt(userController, debtsTreeView.SelectedNode?.Text))
            {
                dataController.Save();
                DebtsForm debtsForm = new DebtsForm(userController);
                DebtsForm_Load(debtsForm, null);
            }
            else
            {
                MessageBox.Show("Элемент не выбран!");
            }
        }

        private void changeDebtButton_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeDebtForm changeDebtForm = new ChangeDebtForm(userController, debtsTreeView.SelectedNode?.Text);
                changeDebtForm.Show();
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Элемент не выбран!");
            }
        }

        private void debtsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            debtDateOverLabel.Text = string.Empty;
            try
            {
                if (debtController.IsOverDebrDate(userController, debtsTreeView.SelectedNode.Text))
                {
                    debtDateOverLabel.Text = "Срок истек!";
                    myProgressBar.Value = 50;
                    myProgressBar.ProgressColor = Color.Red;
                }
                else if (debtController.IsYellowProgressBar(userController, debtsTreeView.SelectedNode.Text))
                {
                    myProgressBar.Value = 40;
                    myProgressBar.ProgressColor = Color.Yellow;
                }
                else
                {
                    myProgressBar.Value = 20;
                    myProgressBar.ProgressColor = Color.Green;
                }
            }
            catch (Exception) { };
        }
    }
}
