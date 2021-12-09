
namespace Presentation_Layer
{
    partial class AddCardForm
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
            this.cardTypeComboBox = new System.Windows.Forms.ComboBox();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pinCodeLabel = new System.Windows.Forms.Label();
            this.pinCodeTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cardTypeComboBox
            // 
            this.cardTypeComboBox.FormattingEnabled = true;
            this.cardTypeComboBox.Location = new System.Drawing.Point(121, 22);
            this.cardTypeComboBox.Name = "cardTypeComboBox";
            this.cardTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.cardTypeComboBox.TabIndex = 0;
            this.cardTypeComboBox.Text = "тип карты";
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(131, 90);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.cardNumberTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер карты(xxxx xxxx xxxx xxxx):";
            // 
            // pinCodeLabel
            // 
            this.pinCodeLabel.AutoSize = true;
            this.pinCodeLabel.Location = new System.Drawing.Point(153, 130);
            this.pinCodeLabel.Name = "pinCodeLabel";
            this.pinCodeLabel.Size = new System.Drawing.Size(51, 13);
            this.pinCodeLabel.TabIndex = 3;
            this.pinCodeLabel.Text = "Пин-код:";
            // 
            // pinCodeTextBox
            // 
            this.pinCodeTextBox.Location = new System.Drawing.Point(131, 161);
            this.pinCodeTextBox.Name = "pinCodeTextBox";
            this.pinCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.pinCodeTextBox.TabIndex = 4;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(87, 209);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Отмена";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(193, 209);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AddCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 256);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pinCodeTextBox);
            this.Controls.Add(this.pinCodeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardNumberTextBox);
            this.Controls.Add(this.cardTypeComboBox);
            this.Name = "AddCardForm";
            this.Text = "AddCardForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exitButton_Click);
            this.Load += new System.EventHandler(this.AddCardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cardTypeComboBox;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pinCodeLabel;
        private System.Windows.Forms.TextBox pinCodeTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button okButton;
    }
}