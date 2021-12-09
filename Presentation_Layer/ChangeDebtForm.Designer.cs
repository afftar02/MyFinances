
namespace Presentation_Layer
{
    partial class ChangeDebtForm
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
            this.changeDebtAmountLabel = new System.Windows.Forms.Label();
            this.debtAmountTextBox = new System.Windows.Forms.TextBox();
            this.creditorNameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.creditorNameValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeDebtAmountLabel
            // 
            this.changeDebtAmountLabel.AutoSize = true;
            this.changeDebtAmountLabel.Location = new System.Drawing.Point(84, 80);
            this.changeDebtAmountLabel.Name = "changeDebtAmountLabel";
            this.changeDebtAmountLabel.Size = new System.Drawing.Size(81, 13);
            this.changeDebtAmountLabel.TabIndex = 0;
            this.changeDebtAmountLabel.Text = "Размер долга:";
            // 
            // debtAmountTextBox
            // 
            this.debtAmountTextBox.Location = new System.Drawing.Point(171, 77);
            this.debtAmountTextBox.Name = "debtAmountTextBox";
            this.debtAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.debtAmountTextBox.TabIndex = 1;
            // 
            // creditorNameLabel
            // 
            this.creditorNameLabel.AutoSize = true;
            this.creditorNameLabel.Location = new System.Drawing.Point(77, 36);
            this.creditorNameLabel.Name = "creditorNameLabel";
            this.creditorNameLabel.Size = new System.Drawing.Size(88, 13);
            this.creditorNameLabel.TabIndex = 2;
            this.creditorNameLabel.Text = "Имя кредитора:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(130, 125);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(35, 13);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Срок:";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(171, 122);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 21);
            this.monthComboBox.TabIndex = 5;
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(171, 165);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 21);
            this.yearComboBox.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(90, 241);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Отмена";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(217, 241);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // creditorNameValueLabel
            // 
            this.creditorNameValueLabel.AutoSize = true;
            this.creditorNameValueLabel.Location = new System.Drawing.Point(171, 36);
            this.creditorNameValueLabel.Name = "creditorNameValueLabel";
            this.creditorNameValueLabel.Size = new System.Drawing.Size(96, 13);
            this.creditorNameValueLabel.TabIndex = 9;
            this.creditorNameValueLabel.Text = "someCreditorName";
            // 
            // ChangeDebtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 307);
            this.Controls.Add(this.creditorNameValueLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.creditorNameLabel);
            this.Controls.Add(this.debtAmountTextBox);
            this.Controls.Add(this.changeDebtAmountLabel);
            this.Name = "ChangeDebtForm";
            this.Text = "ChangeDebtForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exitButton_Click);
            this.Load += new System.EventHandler(this.ChangeDebtForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label changeDebtAmountLabel;
        private System.Windows.Forms.TextBox debtAmountTextBox;
        private System.Windows.Forms.Label creditorNameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label creditorNameValueLabel;
    }
}