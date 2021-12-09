
namespace Presentation_Layer
{
    partial class SetCategoryBudgetForm
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
            this.inputBudgetLabel = new System.Windows.Forms.Label();
            this.newCategoryBudgetTextBox = new System.Windows.Forms.TextBox();
            this.chooseCategoryLabel = new System.Windows.Forms.Label();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 144);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(111, 144);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // inputBudgetLabel
            // 
            this.inputBudgetLabel.AutoSize = true;
            this.inputBudgetLabel.Location = new System.Drawing.Point(29, 80);
            this.inputBudgetLabel.Name = "inputBudgetLabel";
            this.inputBudgetLabel.Size = new System.Drawing.Size(135, 13);
            this.inputBudgetLabel.TabIndex = 2;
            this.inputBudgetLabel.Text = "Введите сумму бюджета:";
            // 
            // newCategoryBudgetTextBox
            // 
            this.newCategoryBudgetTextBox.Location = new System.Drawing.Point(48, 109);
            this.newCategoryBudgetTextBox.Name = "newCategoryBudgetTextBox";
            this.newCategoryBudgetTextBox.Size = new System.Drawing.Size(100, 20);
            this.newCategoryBudgetTextBox.TabIndex = 3;
            // 
            // chooseCategoryLabel
            // 
            this.chooseCategoryLabel.AutoSize = true;
            this.chooseCategoryLabel.Location = new System.Drawing.Point(31, 9);
            this.chooseCategoryLabel.Name = "chooseCategoryLabel";
            this.chooseCategoryLabel.Size = new System.Drawing.Size(117, 13);
            this.chooseCategoryLabel.TabIndex = 4;
            this.chooseCategoryLabel.Text = "Выберите категорию:";
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(34, 37);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoriesComboBox.TabIndex = 5;
            // 
            // SetCategoryBudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 179);
            this.Controls.Add(this.categoriesComboBox);
            this.Controls.Add(this.chooseCategoryLabel);
            this.Controls.Add(this.newCategoryBudgetTextBox);
            this.Controls.Add(this.inputBudgetLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.exitButton);
            this.Name = "SetCategoryBudgetForm";
            this.Text = "SetCategoryBudgetForm";
            this.Load += new System.EventHandler(this.SetCategoryBudgetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label inputBudgetLabel;
        private System.Windows.Forms.TextBox newCategoryBudgetTextBox;
        private System.Windows.Forms.Label chooseCategoryLabel;
        private System.Windows.Forms.ComboBox categoriesComboBox;
    }
}