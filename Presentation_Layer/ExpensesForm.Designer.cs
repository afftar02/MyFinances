
namespace Presentation_Layer
{
    partial class ExpensesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.allExpensesLabel = new System.Windows.Forms.Label();
            this.allExpensesValueLabel = new System.Windows.Forms.Label();
            this.expensesTreeView = new System.Windows.Forms.TreeView();
            this.addExpenseButton = new System.Windows.Forms.Button();
            this.changeExpenseButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.categoryBudgetOverLabel = new System.Windows.Forms.Label();
            this.myProgressBar = new Presentation_Layer.FsProgressBar();
            this.mainProgressBar = new Presentation_Layer.FsProgressBar();
            this.SuspendLayout();
            // 
            // allExpensesLabel
            // 
            this.allExpensesLabel.AutoSize = true;
            this.allExpensesLabel.Location = new System.Drawing.Point(179, 25);
            this.allExpensesLabel.Name = "allExpensesLabel";
            this.allExpensesLabel.Size = new System.Drawing.Size(131, 13);
            this.allExpensesLabel.TabIndex = 0;
            this.allExpensesLabel.Text = "Общая сумма расходов:";
            // 
            // allExpensesValueLabel
            // 
            this.allExpensesValueLabel.AutoSize = true;
            this.allExpensesValueLabel.Location = new System.Drawing.Point(316, 25);
            this.allExpensesValueLabel.Name = "allExpensesValueLabel";
            this.allExpensesValueLabel.Size = new System.Drawing.Size(13, 13);
            this.allExpensesValueLabel.TabIndex = 1;
            this.allExpensesValueLabel.Text = "0";
            // 
            // expensesTreeView
            // 
            this.expensesTreeView.Location = new System.Drawing.Point(12, 52);
            this.expensesTreeView.Name = "expensesTreeView";
            this.expensesTreeView.Size = new System.Drawing.Size(317, 305);
            this.expensesTreeView.TabIndex = 2;
            this.expensesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.expensesTreeView_AfterSelect);
            // 
            // addExpenseButton
            // 
            this.addExpenseButton.Location = new System.Drawing.Point(423, 52);
            this.addExpenseButton.Name = "addExpenseButton";
            this.addExpenseButton.Size = new System.Drawing.Size(146, 63);
            this.addExpenseButton.TabIndex = 3;
            this.addExpenseButton.Text = "Добавить";
            this.addExpenseButton.UseVisualStyleBackColor = true;
            this.addExpenseButton.Click += new System.EventHandler(this.addExpenseButton_Click);
            // 
            // changeExpenseButton
            // 
            this.changeExpenseButton.Location = new System.Drawing.Point(423, 143);
            this.changeExpenseButton.Name = "changeExpenseButton";
            this.changeExpenseButton.Size = new System.Drawing.Size(146, 63);
            this.changeExpenseButton.TabIndex = 3;
            this.changeExpenseButton.Text = "Изменить";
            this.changeExpenseButton.UseVisualStyleBackColor = true;
            this.changeExpenseButton.Click += new System.EventHandler(this.changeExpenseButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(462, 334);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // categoryBudgetOverLabel
            // 
            this.categoryBudgetOverLabel.AutoSize = true;
            this.categoryBudgetOverLabel.Location = new System.Drawing.Point(353, 248);
            this.categoryBudgetOverLabel.Name = "categoryBudgetOverLabel";
            this.categoryBudgetOverLabel.Size = new System.Drawing.Size(288, 13);
            this.categoryBudgetOverLabel.TabIndex = 5;
            this.categoryBudgetOverLabel.Text = "Вы превысили бюджет на данную категорию расходов!";
            // 
            // myProgressBar
            // 
            this.myProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.myProgressBar.BorderColor = System.Drawing.Color.Black;
            this.myProgressBar.BorderWidth = 0;
            this.myProgressBar.ForeColor = System.Drawing.Color.Black;
            this.myProgressBar.Location = new System.Drawing.Point(394, 284);
            this.myProgressBar.MaxValue = 100;
            this.myProgressBar.MinValue = 0;
            this.myProgressBar.Name = "myProgressBar";
            this.myProgressBar.ProgressColor = System.Drawing.Color.Yellow;
            this.myProgressBar.ProgressTextType = Presentation_Layer.FsProgressBar.FsProgressTextType.AsIs;
            this.myProgressBar.ShowProgressText = true;
            this.myProgressBar.Size = new System.Drawing.Size(200, 30);
            this.myProgressBar.TabIndex = 6;
            this.myProgressBar.Value = 0;
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.mainProgressBar.BorderColor = System.Drawing.Color.Black;
            this.mainProgressBar.BorderWidth = 0;
            this.mainProgressBar.ForeColor = System.Drawing.Color.Black;
            this.mainProgressBar.Location = new System.Drawing.Point(369, 12);
            this.mainProgressBar.MaxValue = 100;
            this.mainProgressBar.MinValue = 0;
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.ProgressColor = System.Drawing.Color.Yellow;
            this.mainProgressBar.ProgressTextType = Presentation_Layer.FsProgressBar.FsProgressTextType.AsIs;
            this.mainProgressBar.ShowProgressText = true;
            this.mainProgressBar.Size = new System.Drawing.Size(200, 30);
            this.mainProgressBar.TabIndex = 7;
            this.mainProgressBar.Value = 0;
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 379);
            this.Controls.Add(this.mainProgressBar);
            this.Controls.Add(this.myProgressBar);
            this.Controls.Add(this.categoryBudgetOverLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.changeExpenseButton);
            this.Controls.Add(this.addExpenseButton);
            this.Controls.Add(this.expensesTreeView);
            this.Controls.Add(this.allExpensesValueLabel);
            this.Controls.Add(this.allExpensesLabel);
            this.Name = "ExpensesForm";
            this.Text = "ExpensesForm";
            this.Load += new System.EventHandler(this.ExpensesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label allExpensesLabel;
        private System.Windows.Forms.Label allExpensesValueLabel;
        private System.Windows.Forms.TreeView expensesTreeView;
        private System.Windows.Forms.Button addExpenseButton;
        private System.Windows.Forms.Button changeExpenseButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label categoryBudgetOverLabel;
        private FsProgressBar myProgressBar;
        private FsProgressBar mainProgressBar;
    }
}