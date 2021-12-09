
namespace Presentation_Layer
{
    partial class ChangeExpenseForm
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
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryValueLabel = new System.Windows.Forms.Label();
            this.inputNewAmountLabel = new System.Windows.Forms.Label();
            this.expenseValueTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(114, 37);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(63, 13);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Категория:";
            // 
            // categoryValueLabel
            // 
            this.categoryValueLabel.AutoSize = true;
            this.categoryValueLabel.Location = new System.Drawing.Point(184, 37);
            this.categoryValueLabel.Name = "categoryValueLabel";
            this.categoryValueLabel.Size = new System.Drawing.Size(74, 13);
            this.categoryValueLabel.TabIndex = 1;
            this.categoryValueLabel.Text = "someCategory";
            // 
            // inputNewAmountLabel
            // 
            this.inputNewAmountLabel.AutoSize = true;
            this.inputNewAmountLabel.Location = new System.Drawing.Point(127, 78);
            this.inputNewAmountLabel.Name = "inputNewAmountLabel";
            this.inputNewAmountLabel.Size = new System.Drawing.Size(121, 13);
            this.inputNewAmountLabel.TabIndex = 2;
            this.inputNewAmountLabel.Text = "Введите новую сумму:";
            // 
            // expenseValueTextBox
            // 
            this.expenseValueTextBox.Location = new System.Drawing.Point(139, 117);
            this.expenseValueTextBox.Name = "expenseValueTextBox";
            this.expenseValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.expenseValueTextBox.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(91, 161);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Отмена";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(207, 161);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ChangeExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 218);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.expenseValueTextBox);
            this.Controls.Add(this.inputNewAmountLabel);
            this.Controls.Add(this.categoryValueLabel);
            this.Controls.Add(this.categoryLabel);
            this.Name = "ChangeExpenseForm";
            this.Text = "ChangeExpenseForm";
            this.Load += new System.EventHandler(this.ChangeExpenseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label categoryValueLabel;
        private System.Windows.Forms.Label inputNewAmountLabel;
        private System.Windows.Forms.TextBox expenseValueTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button okButton;
    }
}