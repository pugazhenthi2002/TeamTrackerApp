namespace TeamTrackerApp
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
            this.ucSignUp1 = new TeamTrackerApp.UCSignUp();
            this.SuspendLayout();
            // 
            // ucSignUp1
            // 
            this.ucSignUp1.BackColor = System.Drawing.SystemColors.Info;
            this.ucSignUp1.Location = new System.Drawing.Point(185, 128);
            this.ucSignUp1.Name = "ucSignUp1";
            this.ucSignUp1.Size = new System.Drawing.Size(500, 300);
            this.ucSignUp1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 485);
            this.Controls.Add(this.ucSignUp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UCSignUp ucSignUp1;
    }
}

