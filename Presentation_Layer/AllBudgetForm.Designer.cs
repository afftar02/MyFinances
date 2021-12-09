
namespace Presentation_Layer
{
    partial class AllBudgetForm
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
            this.budgetInfoLabel = new System.Windows.Forms.Label();
            this.budgetAmountLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // budgetInfoLabel
            // 
            this.budgetInfoLabel.AutoSize = true;
            this.budgetInfoLabel.Location = new System.Drawing.Point(58, 33);
            this.budgetInfoLabel.Name = "budgetInfoLabel";
            this.budgetInfoLabel.Size = new System.Drawing.Size(145, 13);
            this.budgetInfoLabel.TabIndex = 0;
            this.budgetInfoLabel.Text = "Общий бюджет составляет";
            // 
            // budgetAmountLabel
            // 
            this.budgetAmountLabel.AutoSize = true;
            this.budgetAmountLabel.Location = new System.Drawing.Point(209, 33);
            this.budgetAmountLabel.Name = "budgetAmountLabel";
            this.budgetAmountLabel.Size = new System.Drawing.Size(66, 13);
            this.budgetAmountLabel.TabIndex = 1;
            this.budgetAmountLabel.Text = "someBudget";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(128, 75);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AllBudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 110);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.budgetAmountLabel);
            this.Controls.Add(this.budgetInfoLabel);
            this.Name = "AllBudgetForm";
            this.Text = "AllBudgetForm";
            this.Load += new System.EventHandler(this.AllBudgetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label budgetInfoLabel;
        private System.Windows.Forms.Label budgetAmountLabel;
        private System.Windows.Forms.Button exitButton;
    }
}