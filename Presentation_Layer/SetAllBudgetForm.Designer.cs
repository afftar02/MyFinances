
namespace Presentation_Layer
{
    partial class SetAllBudgetForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.newAllBudgetTextBox = new System.Windows.Forms.TextBox();
            this.inputBudgetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 107);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(111, 107);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // newAllBudgetTextBox
            // 
            this.newAllBudgetTextBox.Location = new System.Drawing.Point(49, 61);
            this.newAllBudgetTextBox.Name = "newAllBudgetTextBox";
            this.newAllBudgetTextBox.Size = new System.Drawing.Size(100, 20);
            this.newAllBudgetTextBox.TabIndex = 2;
            // 
            // inputBudgetLabel
            // 
            this.inputBudgetLabel.AutoSize = true;
            this.inputBudgetLabel.Location = new System.Drawing.Point(35, 28);
            this.inputBudgetLabel.Name = "inputBudgetLabel";
            this.inputBudgetLabel.Size = new System.Drawing.Size(135, 13);
            this.inputBudgetLabel.TabIndex = 3;
            this.inputBudgetLabel.Text = "Введите сумму бюджета:";
            // 
            // SetAllBudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 149);
            this.Controls.Add(this.inputBudgetLabel);
            this.Controls.Add(this.newAllBudgetTextBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.exitButton);
            this.Name = "SetAllBudgetForm";
            this.Text = "SetAllBudgetForm";
            this.Load += new System.EventHandler(this.SetAllBudgetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox newAllBudgetTextBox;
        private System.Windows.Forms.Label inputBudgetLabel;
    }
}