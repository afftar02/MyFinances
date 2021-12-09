
namespace Presentation_Layer
{
    partial class DeleteCardForm
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
            this.cardNumberComboBox = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cardTypeComboBox
            // 
            this.cardTypeComboBox.FormattingEnabled = true;
            this.cardTypeComboBox.Location = new System.Drawing.Point(118, 40);
            this.cardTypeComboBox.Name = "cardTypeComboBox";
            this.cardTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.cardTypeComboBox.TabIndex = 0;
            this.cardTypeComboBox.Text = "тип карты";
            this.cardTypeComboBox.SelectionChangeCommitted += new System.EventHandler(this.cardTypeComboBox_SelectionChangeCommitted);
            // 
            // cardNumberComboBox
            // 
            this.cardNumberComboBox.FormattingEnabled = true;
            this.cardNumberComboBox.Location = new System.Drawing.Point(118, 95);
            this.cardNumberComboBox.Name = "cardNumberComboBox";
            this.cardNumberComboBox.Size = new System.Drawing.Size(121, 21);
            this.cardNumberComboBox.TabIndex = 1;
            this.cardNumberComboBox.Text = "номер карты";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(85, 149);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Отмена";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(201, 149);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // DeleteCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 194);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cardNumberComboBox);
            this.Controls.Add(this.cardTypeComboBox);
            this.Name = "DeleteCardForm";
            this.Text = "DeleteCardForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exitButton_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cardTypeComboBox;
        private System.Windows.Forms.ComboBox cardNumberComboBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button okButton;
    }
}