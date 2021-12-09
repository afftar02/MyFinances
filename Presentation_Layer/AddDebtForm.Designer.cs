
namespace Presentation_Layer
{
    partial class AddDebtForm
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
            this.inputDebtAmountLabel = new System.Windows.Forms.Label();
            this.debtAmountTextBox = new System.Windows.Forms.TextBox();
            this.creditorNameLabel = new System.Windows.Forms.Label();
            this.creditorNameTextBox = new System.Windows.Forms.TextBox();
            this.dateInputLabel = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputDebtAmountLabel
            // 
            this.inputDebtAmountLabel.AutoSize = true;
            this.inputDebtAmountLabel.Location = new System.Drawing.Point(46, 40);
            this.inputDebtAmountLabel.Name = "inputDebtAmountLabel";
            this.inputDebtAmountLabel.Size = new System.Drawing.Size(125, 13);
            this.inputDebtAmountLabel.TabIndex = 0;
            this.inputDebtAmountLabel.Text = "Введите размер долга:";
            // 
            // debtAmountTextBox
            // 
            this.debtAmountTextBox.Location = new System.Drawing.Point(177, 37);
            this.debtAmountTextBox.Name = "debtAmountTextBox";
            this.debtAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.debtAmountTextBox.TabIndex = 1;
            // 
            // creditorNameLabel
            // 
            this.creditorNameLabel.AutoSize = true;
            this.creditorNameLabel.Location = new System.Drawing.Point(40, 85);
            this.creditorNameLabel.Name = "creditorNameLabel";
            this.creditorNameLabel.Size = new System.Drawing.Size(131, 13);
            this.creditorNameLabel.TabIndex = 2;
            this.creditorNameLabel.Text = "Введите имя кредитора:";
            // 
            // creditorNameTextBox
            // 
            this.creditorNameTextBox.Location = new System.Drawing.Point(177, 82);
            this.creditorNameTextBox.Name = "creditorNameTextBox";
            this.creditorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditorNameTextBox.TabIndex = 3;
            // 
            // dateInputLabel
            // 
            this.dateInputLabel.AutoSize = true;
            this.dateInputLabel.Location = new System.Drawing.Point(92, 130);
            this.dateInputLabel.Name = "dateInputLabel";
            this.dateInputLabel.Size = new System.Drawing.Size(79, 13);
            this.dateInputLabel.TabIndex = 4;
            this.dateInputLabel.Text = "Введите срок:";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(177, 127);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 21);
            this.monthComboBox.TabIndex = 5;
            this.monthComboBox.Text = "Месяц";
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(177, 171);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 21);
            this.yearComboBox.TabIndex = 6;
            this.yearComboBox.Text = "Год";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(223, 245);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(95, 245);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Отмена";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AddDebtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 309);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.dateInputLabel);
            this.Controls.Add(this.creditorNameTextBox);
            this.Controls.Add(this.creditorNameLabel);
            this.Controls.Add(this.debtAmountTextBox);
            this.Controls.Add(this.inputDebtAmountLabel);
            this.Name = "AddDebtForm";
            this.Text = "AddDebtForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exitButton_Click);
            this.Load += new System.EventHandler(this.AddDebtForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputDebtAmountLabel;
        private System.Windows.Forms.TextBox debtAmountTextBox;
        private System.Windows.Forms.Label creditorNameLabel;
        private System.Windows.Forms.TextBox creditorNameTextBox;
        private System.Windows.Forms.Label dateInputLabel;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button exitButton;
    }
}