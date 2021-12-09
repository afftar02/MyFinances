
namespace Presentation_Layer
{
    partial class DebtsForm
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
            this.debtsTreeView = new System.Windows.Forms.TreeView();
            this.addDebtButton = new System.Windows.Forms.Button();
            this.deleteDebtButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.changeDebtButton = new System.Windows.Forms.Button();
            this.debtDateOverLabel = new System.Windows.Forms.Label();
            this.myProgressBar = new Presentation_Layer.FsProgressBar();
            this.SuspendLayout();
            // 
            // debtsTreeView
            // 
            this.debtsTreeView.Location = new System.Drawing.Point(12, 12);
            this.debtsTreeView.Name = "debtsTreeView";
            this.debtsTreeView.Size = new System.Drawing.Size(330, 318);
            this.debtsTreeView.TabIndex = 0;
            this.debtsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.debtsTreeView_AfterSelect);
            // 
            // addDebtButton
            // 
            this.addDebtButton.Location = new System.Drawing.Point(390, 12);
            this.addDebtButton.Name = "addDebtButton";
            this.addDebtButton.Size = new System.Drawing.Size(135, 55);
            this.addDebtButton.TabIndex = 1;
            this.addDebtButton.Text = "Добавить";
            this.addDebtButton.UseVisualStyleBackColor = true;
            this.addDebtButton.Click += new System.EventHandler(this.addDebtButton_Click);
            // 
            // deleteDebtButton
            // 
            this.deleteDebtButton.Location = new System.Drawing.Point(390, 85);
            this.deleteDebtButton.Name = "deleteDebtButton";
            this.deleteDebtButton.Size = new System.Drawing.Size(135, 57);
            this.deleteDebtButton.TabIndex = 2;
            this.deleteDebtButton.Text = "Удалить";
            this.deleteDebtButton.UseVisualStyleBackColor = true;
            this.deleteDebtButton.Click += new System.EventHandler(this.deleteDebtButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(443, 304);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(82, 26);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // changeDebtButton
            // 
            this.changeDebtButton.Location = new System.Drawing.Point(390, 161);
            this.changeDebtButton.Name = "changeDebtButton";
            this.changeDebtButton.Size = new System.Drawing.Size(135, 57);
            this.changeDebtButton.TabIndex = 4;
            this.changeDebtButton.Text = "Изменить";
            this.changeDebtButton.UseVisualStyleBackColor = true;
            this.changeDebtButton.Click += new System.EventHandler(this.changeDebtButton_Click);
            // 
            // debtDateOverLabel
            // 
            this.debtDateOverLabel.AutoSize = true;
            this.debtDateOverLabel.Location = new System.Drawing.Point(400, 235);
            this.debtDateOverLabel.Name = "debtDateOverLabel";
            this.debtDateOverLabel.Size = new System.Drawing.Size(0, 13);
            this.debtDateOverLabel.TabIndex = 6;
            // 
            // myProgressBar
            // 
            this.myProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.myProgressBar.BorderColor = System.Drawing.Color.Black;
            this.myProgressBar.BorderWidth = 0;
            this.myProgressBar.ForeColor = System.Drawing.Color.Black;
            this.myProgressBar.Location = new System.Drawing.Point(390, 265);
            this.myProgressBar.MaxValue = 100;
            this.myProgressBar.MinValue = 0;
            this.myProgressBar.Name = "myProgressBar";
            this.myProgressBar.ProgressColor = System.Drawing.Color.Yellow;
            this.myProgressBar.ProgressTextType = Presentation_Layer.FsProgressBar.FsProgressTextType.AsIs;
            this.myProgressBar.ShowProgressText = true;
            this.myProgressBar.Size = new System.Drawing.Size(135, 22);
            this.myProgressBar.TabIndex = 7;
            this.myProgressBar.Text = "fsProgressBar1";
            this.myProgressBar.Value = 0;
            // 
            // DebtsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 342);
            this.Controls.Add(this.myProgressBar);
            this.Controls.Add(this.debtDateOverLabel);
            this.Controls.Add(this.changeDebtButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.deleteDebtButton);
            this.Controls.Add(this.addDebtButton);
            this.Controls.Add(this.debtsTreeView);
            this.Name = "DebtsForm";
            this.Text = "DebtsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.okButton_Click);
            this.Load += new System.EventHandler(this.DebtsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView debtsTreeView;
        private System.Windows.Forms.Button addDebtButton;
        private System.Windows.Forms.Button deleteDebtButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button changeDebtButton;
        private System.Windows.Forms.Label debtDateOverLabel;
        private FsProgressBar myProgressBar;
    }
}