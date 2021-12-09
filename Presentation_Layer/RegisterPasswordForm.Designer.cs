
namespace Presentation_Layer
{
    partial class RegisterPasswordForm
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
            this.infoText = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(135, 258);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Location = new System.Drawing.Point(123, 51);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(97, 13);
            this.infoText.TabIndex = 1;
            this.infoText.Text = "Создайте пароль:";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(120, 108);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 2;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(106, 174);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(133, 26);
            this.continueButton.TabIndex = 3;
            this.continueButton.Text = "Создать аккаунт";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // RegisterPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 323);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.exitButton);
            this.Name = "RegisterPasswordForm";
            this.Text = "RegisterPasswordForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exitButton_Click);
            this.Load += new System.EventHandler(this.RegisterPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button continueButton;
    }
}