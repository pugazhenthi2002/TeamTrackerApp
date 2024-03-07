﻿namespace TeamTrackerApp
{
    partial class WelcomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pageSwitchTimer = new System.Windows.Forms.Timer(this.components);
            this.loginPage1 = new TeamTrackerApp.LoginPage();
            this.SuspendLayout();
            // 
            // pageSwitchTimer
            // 
            this.pageSwitchTimer.Interval = 1;
            this.pageSwitchTimer.Tick += new System.EventHandler(this.pageSwitchTick);
            // 
            // loginPage1
            // 
            this.loginPage1.BackColor = System.Drawing.Color.Black;
            this.loginPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPage1.Location = new System.Drawing.Point(0, 0);
            this.loginPage1.Name = "loginPage1";
            this.loginPage1.Size = new System.Drawing.Size(619, 363);
            this.loginPage1.TabIndex = 0;
            this.loginPage1.NewUserClick += new TeamTrackerApp.LoginPage.LoginHandler(this.OnPageSwitch);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(207)))));
            this.Controls.Add(this.loginPage1);
            this.Name = "WelcomePage";
            this.Size = new System.Drawing.Size(619, 363);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WelcomePagePaint);
            this.ResumeLayout(false);

        }

        #endregion

        private LoginPage loginPage1;
        private System.Windows.Forms.Timer pageSwitchTimer;
    }
}