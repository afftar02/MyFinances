
namespace Presentation_Layer
{
    partial class CategoriesBudgetForm
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
            this.budgetLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.isLabel = new System.Windows.Forms.Label();
            this.budgetAmountLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.chooseCategoryLabel = new System.Windows.Forms.Label();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(163, 212);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Location = new System.Drawing.Point(55, 166);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(62, 13);
            this.budgetLabel.TabIndex = 1;
            this.budgetLabel.Text = "Бюджет на";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(123, 166);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(74, 13);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "someCategory";
            // 
            // isLabel
            // 
            this.isLabel.AutoSize = true;
            this.isLabel.Location = new System.Drawing.Point(204, 165);
            this.isLabel.Name = "isLabel";
            this.isLabel.Size = new System.Drawing.Size(65, 13);
            this.isLabel.TabIndex = 3;
            this.isLabel.Text = "составляет";
            // 
            // budgetAmountLabel
            // 
            this.budgetAmountLabel.AutoSize = true;
            this.budgetAmountLabel.Location = new System.Drawing.Point(276, 165);
            this.budgetAmountLabel.Name = "budgetAmountLabel";
            this.budgetAmountLabel.Size = new System.Drawing.Size(66, 13);
            this.budgetAmountLabel.TabIndex = 4;
            this.budgetAmountLabel.Text = "someBudget";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(163, 115);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // chooseCategoryLabel
            // 
            this.chooseCategoryLabel.AutoSize = true;
            this.chooseCategoryLabel.Location = new System.Drawing.Point(143, 26);
            this.chooseCategoryLabel.Name = "chooseCategoryLabel";
            this.chooseCategoryLabel.Size = new System.Drawing.Size(117, 13);
            this.chooseCategoryLabel.TabIndex = 6;
            this.chooseCategoryLabel.Text = "Выберите категорию:";
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(139, 67);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoriesComboBox.TabIndex = 7;
            // 
            // CategoriesBudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 263);
            this.Controls.Add(this.categoriesComboBox);
            this.Controls.Add(this.chooseCategoryLabel);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.budgetAmountLabel);
            this.Controls.Add(this.isLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.exitButton);
            this.Name = "CategoriesBudgetForm";
            this.Text = "CategoriesBudgetForm";
            this.Load += new System.EventHandler(this.CategoriesBudgetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label isLabel;
        private System.Windows.Forms.Label budgetAmountLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label chooseCategoryLabel;
        private System.Windows.Forms.ComboBox categoriesComboBox;
    }
}