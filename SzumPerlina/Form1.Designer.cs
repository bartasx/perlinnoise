namespace SzumPerlina
{
    partial class Form1
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
            this.gnerateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gnerateButton
            // 
            this.gnerateButton.Location = new System.Drawing.Point(200, 242);
            this.gnerateButton.Name = "gnerateButton";
            this.gnerateButton.Size = new System.Drawing.Size(203, 73);
            this.gnerateButton.TabIndex = 0;
            this.gnerateButton.Text = "Generuj";
            this.gnerateButton.UseVisualStyleBackColor = true;
            this.gnerateButton.Click += new System.EventHandler(this.gnerateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 371);
            this.Controls.Add(this.gnerateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gnerateButton;
    }
}

