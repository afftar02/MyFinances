
namespace Presentation_Layer
{
    partial class IncomeForm
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
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cardIncomeValueLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.cardTypeComboBox = new System.Windows.Forms.ComboBox();
            this.cardNumberComboBox = new System.Windows.Forms.ComboBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(27, 48);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(169, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Общая сумма доходов на карте";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "составляет";
            // 
            // cardIncomeValueLabel
            // 
            this.cardIncomeValueLabel.AutoSize = true;
            this.cardIncomeValueLabel.Location = new System.Drawing.Point(527, 48);
            this.cardIncomeValueLabel.Name = "cardIncomeValueLabel";
            this.cardIncomeValueLabel.Size = new System.Drawing.Size(13, 13);
            this.cardIncomeValueLabel.TabIndex = 4;
            this.cardIncomeValueLabel.Text = "0";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(259, 163);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Ок";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cardTypeComboBox
            // 
            this.cardTypeComboBox.FormattingEnabled = true;
            this.cardTypeComboBox.Location = new System.Drawing.Point(202, 45);
            this.cardTypeComboBox.Name = "cardTypeComboBox";
            this.cardTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.cardTypeComboBox.TabIndex = 6;
            this.cardTypeComboBox.Text = "тип карты";
            this.cardTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.cardTypeComboBox_SelectedIndexChanged);
            // 
            // cardNumberComboBox
            // 
            this.cardNumberComboBox.FormattingEnabled = true;
            this.cardNumberComboBox.Location = new System.Drawing.Point(329, 45);
            this.cardNumberComboBox.Name = "cardNumberComboBox";
            this.cardNumberComboBox.Size = new System.Drawing.Size(121, 21);
            this.cardNumberComboBox.TabIndex = 7;
            this.cardNumberComboBox.Text = "номер карты";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(259, 113);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 8;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 207);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cardNumberComboBox);
            this.Controls.Add(this.cardTypeComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cardIncomeValueLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Name = "IncomeForm";
            this.Text = "IncomeForm";
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exitButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cardIncomeValueLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox cardTypeComboBox;
        private System.Windows.Forms.ComboBox cardNumberComboBox;
        private System.Windows.Forms.Button applyButton;
    }
}