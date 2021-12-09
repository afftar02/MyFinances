
namespace Presentation_Layer
{
    partial class WalletForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cardTypeComboBox = new System.Windows.Forms.ComboBox();
            this.cardNumberComboBox = new System.Windows.Forms.ComboBox();
            this.balanceIsLabel = new System.Windows.Forms.Label();
            this.balanceValueLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(104, 230);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cardTypeComboBox
            // 
            this.cardTypeComboBox.FormattingEnabled = true;
            this.cardTypeComboBox.Location = new System.Drawing.Point(83, 36);
            this.cardTypeComboBox.Name = "cardTypeComboBox";
            this.cardTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.cardTypeComboBox.TabIndex = 1;
            this.cardTypeComboBox.Text = "тип карты";
            this.cardTypeComboBox.SelectionChangeCommitted += new System.EventHandler(this.cardTypeComboBox_SelectionChangeCommitted);
            // 
            // cardNumberComboBox
            // 
            this.cardNumberComboBox.FormattingEnabled = true;
            this.cardNumberComboBox.Location = new System.Drawing.Point(83, 90);
            this.cardNumberComboBox.Name = "cardNumberComboBox";
            this.cardNumberComboBox.Size = new System.Drawing.Size(121, 21);
            this.cardNumberComboBox.TabIndex = 2;
            this.cardNumberComboBox.Text = "номер карты";
            // 
            // balanceIsLabel
            // 
            this.balanceIsLabel.AutoSize = true;
            this.balanceIsLabel.Location = new System.Drawing.Point(80, 146);
            this.balanceIsLabel.Name = "balanceIsLabel";
            this.balanceIsLabel.Size = new System.Drawing.Size(108, 13);
            this.balanceIsLabel.TabIndex = 3;
            this.balanceIsLabel.Text = "Баланс составляет:";
            // 
            // balanceValueLabel
            // 
            this.balanceValueLabel.AutoSize = true;
            this.balanceValueLabel.Location = new System.Drawing.Point(194, 146);
            this.balanceValueLabel.Name = "balanceValueLabel";
            this.balanceValueLabel.Size = new System.Drawing.Size(13, 13);
            this.balanceValueLabel.TabIndex = 4;
            this.balanceValueLabel.Text = "0";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(104, 184);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // WalletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 278);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.balanceValueLabel);
            this.Controls.Add(this.balanceIsLabel);
            this.Controls.Add(this.cardNumberComboBox);
            this.Controls.Add(this.cardTypeComboBox);
            this.Controls.Add(this.okButton);
            this.Name = "WalletForm";
            this.Text = "WalletForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.okButton_Click);
            this.Load += new System.EventHandler(this.WalletForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox cardTypeComboBox;
        private System.Windows.Forms.ComboBox cardNumberComboBox;
        private System.Windows.Forms.Label balanceIsLabel;
        private System.Windows.Forms.Label balanceValueLabel;
        private System.Windows.Forms.Button applyButton;
    }
}