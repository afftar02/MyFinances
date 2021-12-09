
namespace Presentation_Layer
{
    partial class AddIncomeForm
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
            this.chooseLabel = new System.Windows.Forms.Label();
            this.cardTypeComboBox = new System.Windows.Forms.ComboBox();
            this.cardNumberComboBox = new System.Windows.Forms.ComboBox();
            this.incomeValueTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Location = new System.Drawing.Point(137, 24);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(60, 13);
            this.chooseLabel.TabIndex = 0;
            this.chooseLabel.Text = "Выберите:";
            // 
            // cardTypeComboBox
            // 
            this.cardTypeComboBox.FormattingEnabled = true;
            this.cardTypeComboBox.Location = new System.Drawing.Point(105, 58);
            this.cardTypeComboBox.Name = "cardTypeComboBox";
            this.cardTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.cardTypeComboBox.TabIndex = 1;
            this.cardTypeComboBox.Text = "тип карты";
            this.cardTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.cardTypeComboBox_SelectedIndexChanged);
            // 
            // cardNumberComboBox
            // 
            this.cardNumberComboBox.FormattingEnabled = true;
            this.cardNumberComboBox.Location = new System.Drawing.Point(105, 104);
            this.cardNumberComboBox.Name = "cardNumberComboBox";
            this.cardNumberComboBox.Size = new System.Drawing.Size(121, 21);
            this.cardNumberComboBox.TabIndex = 2;
            this.cardNumberComboBox.Text = "номер карты";
            // 
            // incomeValueTextBox
            // 
            this.incomeValueTextBox.Location = new System.Drawing.Point(116, 156);
            this.incomeValueTextBox.Name = "incomeValueTextBox";
            this.incomeValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.incomeValueTextBox.TabIndex = 3;
            this.incomeValueTextBox.Text = "сумма";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(182, 215);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(77, 215);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Отмена";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AddIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.incomeValueTextBox);
            this.Controls.Add(this.cardNumberComboBox);
            this.Controls.Add(this.cardTypeComboBox);
            this.Controls.Add(this.chooseLabel);
            this.Name = "AddIncomeForm";
            this.Text = "AddIncomeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exitButton_Click);
            this.Load += new System.EventHandler(this.AddIncomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.ComboBox cardTypeComboBox;
        private System.Windows.Forms.ComboBox cardNumberComboBox;
        private System.Windows.Forms.TextBox incomeValueTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button exitButton;
    }
}