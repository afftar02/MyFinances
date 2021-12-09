
namespace Presentation_Layer
{
    partial class MainMenuForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.budgetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetBudgetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetAllBudgetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetCategoryBudgetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BudgetLookMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LookAllBudgetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LookCategoryBudgetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DebtsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpensesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IncomeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddIncomeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteIncomeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LookIncomeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WalletMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LookWalletMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myWalletLabel = new System.Windows.Forms.Label();
            this.walletBalanceLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(122, 173);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.budgetMenuItem,
            this.DebtsMenuItem,
            this.ExpensesMenuItem,
            this.IncomeMenuItem,
            this.WalletMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(322, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "Главное меню";
            // 
            // budgetMenuItem
            // 
            this.budgetMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetBudgetMenuItem,
            this.BudgetLookMenuItem});
            this.budgetMenuItem.Name = "budgetMenuItem";
            this.budgetMenuItem.Size = new System.Drawing.Size(62, 20);
            this.budgetMenuItem.Text = "Бюджет";
            // 
            // SetBudgetMenuItem
            // 
            this.SetBudgetMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetAllBudgetMenuItem,
            this.SetCategoryBudgetMenuItem});
            this.SetBudgetMenuItem.Name = "SetBudgetMenuItem";
            this.SetBudgetMenuItem.Size = new System.Drawing.Size(148, 22);
            this.SetBudgetMenuItem.Text = "Установить";
            // 
            // SetAllBudgetMenuItem
            // 
            this.SetAllBudgetMenuItem.Name = "SetAllBudgetMenuItem";
            this.SetAllBudgetMenuItem.Size = new System.Drawing.Size(195, 22);
            this.SetAllBudgetMenuItem.Text = "Общий бюджет";
            this.SetAllBudgetMenuItem.Click += new System.EventHandler(this.SetAllBudgetMenuItem_Click);
            // 
            // SetCategoryBudgetMenuItem
            // 
            this.SetCategoryBudgetMenuItem.Name = "SetCategoryBudgetMenuItem";
            this.SetCategoryBudgetMenuItem.Size = new System.Drawing.Size(195, 22);
            this.SetCategoryBudgetMenuItem.Text = "Бюджет на категорию";
            this.SetCategoryBudgetMenuItem.Click += new System.EventHandler(this.SetCategoryBudgetMenuItem_Click);
            // 
            // BudgetLookMenuItem
            // 
            this.BudgetLookMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LookAllBudgetMenuItem,
            this.LookCategoryBudgetMenuItem});
            this.BudgetLookMenuItem.Name = "BudgetLookMenuItem";
            this.BudgetLookMenuItem.Size = new System.Drawing.Size(148, 22);
            this.BudgetLookMenuItem.Text = "Просмотреть";
            // 
            // LookAllBudgetMenuItem
            // 
            this.LookAllBudgetMenuItem.Name = "LookAllBudgetMenuItem";
            this.LookAllBudgetMenuItem.Size = new System.Drawing.Size(195, 22);
            this.LookAllBudgetMenuItem.Text = "Общий бюджет";
            this.LookAllBudgetMenuItem.Click += new System.EventHandler(this.LookAllBudgetMenuItem_Click);
            // 
            // LookCategoryBudgetMenuItem
            // 
            this.LookCategoryBudgetMenuItem.Name = "LookCategoryBudgetMenuItem";
            this.LookCategoryBudgetMenuItem.Size = new System.Drawing.Size(195, 22);
            this.LookCategoryBudgetMenuItem.Text = "Бюджет на категорию";
            this.LookCategoryBudgetMenuItem.Click += new System.EventHandler(this.LookCategoryBudgetMenuItem_Click);
            // 
            // DebtsMenuItem
            // 
            this.DebtsMenuItem.Name = "DebtsMenuItem";
            this.DebtsMenuItem.Size = new System.Drawing.Size(53, 20);
            this.DebtsMenuItem.Text = "Долги";
            this.DebtsMenuItem.Click += new System.EventHandler(this.DebtsMenuItem_Click);
            // 
            // ExpensesMenuItem
            // 
            this.ExpensesMenuItem.Name = "ExpensesMenuItem";
            this.ExpensesMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ExpensesMenuItem.Text = "Расходы";
            this.ExpensesMenuItem.Click += new System.EventHandler(this.ExpensesMenuItem_Click);
            // 
            // IncomeMenuItem
            // 
            this.IncomeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddIncomeMenuItem,
            this.DeleteIncomeMenuItem,
            this.LookIncomeMenuItem});
            this.IncomeMenuItem.Name = "IncomeMenuItem";
            this.IncomeMenuItem.Size = new System.Drawing.Size(62, 20);
            this.IncomeMenuItem.Text = "Доходы";
            // 
            // AddIncomeMenuItem
            // 
            this.AddIncomeMenuItem.Name = "AddIncomeMenuItem";
            this.AddIncomeMenuItem.Size = new System.Drawing.Size(148, 22);
            this.AddIncomeMenuItem.Text = "Добавить";
            this.AddIncomeMenuItem.Click += new System.EventHandler(this.AddIncomeMenuItem_Click);
            // 
            // DeleteIncomeMenuItem
            // 
            this.DeleteIncomeMenuItem.Name = "DeleteIncomeMenuItem";
            this.DeleteIncomeMenuItem.Size = new System.Drawing.Size(148, 22);
            this.DeleteIncomeMenuItem.Text = "Удалить";
            this.DeleteIncomeMenuItem.Click += new System.EventHandler(this.DeleteIncomeMenuItem_Click);
            // 
            // LookIncomeMenuItem
            // 
            this.LookIncomeMenuItem.Name = "LookIncomeMenuItem";
            this.LookIncomeMenuItem.Size = new System.Drawing.Size(148, 22);
            this.LookIncomeMenuItem.Text = "Просмотреть";
            this.LookIncomeMenuItem.Click += new System.EventHandler(this.LookIncomeMenuItem_Click);
            // 
            // WalletMenuItem
            // 
            this.WalletMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCardMenuItem,
            this.DeleteCardMenuItem,
            this.LookWalletMenuItem});
            this.WalletMenuItem.Name = "WalletMenuItem";
            this.WalletMenuItem.Size = new System.Drawing.Size(69, 20);
            this.WalletMenuItem.Text = "Кошелёк";
            // 
            // AddCardMenuItem
            // 
            this.AddCardMenuItem.Name = "AddCardMenuItem";
            this.AddCardMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddCardMenuItem.Text = "Добавить карту";
            this.AddCardMenuItem.Click += new System.EventHandler(this.AddCardMenuItem_Click);
            // 
            // DeleteCardMenuItem
            // 
            this.DeleteCardMenuItem.Name = "DeleteCardMenuItem";
            this.DeleteCardMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteCardMenuItem.Text = "Удалить карту";
            this.DeleteCardMenuItem.Click += new System.EventHandler(this.DeleteCardMenuItem_Click);
            // 
            // LookWalletMenuItem
            // 
            this.LookWalletMenuItem.Name = "LookWalletMenuItem";
            this.LookWalletMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LookWalletMenuItem.Text = "Просмотреть";
            this.LookWalletMenuItem.Click += new System.EventHandler(this.LookWalletMenuItem_Click);
            // 
            // myWalletLabel
            // 
            this.myWalletLabel.AutoSize = true;
            this.myWalletLabel.Location = new System.Drawing.Point(80, 114);
            this.myWalletLabel.Name = "myWalletLabel";
            this.myWalletLabel.Size = new System.Drawing.Size(78, 13);
            this.myWalletLabel.TabIndex = 2;
            this.myWalletLabel.Text = "Мой кошелёк:";
            // 
            // walletBalanceLabel
            // 
            this.walletBalanceLabel.AutoSize = true;
            this.walletBalanceLabel.Location = new System.Drawing.Point(164, 114);
            this.walletBalanceLabel.Name = "walletBalanceLabel";
            this.walletBalanceLabel.Size = new System.Drawing.Size(71, 13);
            this.walletBalanceLabel.TabIndex = 3;
            this.walletBalanceLabel.Text = "someBalance";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(75, 71);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(83, 13);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Пользователь:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(164, 71);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(82, 13);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "someUserName";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 220);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.walletBalanceLabel);
            this.Controls.Add(this.myWalletLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exitButton_Click);
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem budgetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetBudgetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetAllBudgetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetCategoryBudgetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DebtsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExpensesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IncomeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BudgetLookMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LookAllBudgetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LookCategoryBudgetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddIncomeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteIncomeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LookIncomeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WalletMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteCardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LookWalletMenuItem;
        private System.Windows.Forms.Label myWalletLabel;
        private System.Windows.Forms.Label walletBalanceLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label userNameLabel;
    }
}