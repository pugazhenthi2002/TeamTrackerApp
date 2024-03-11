namespace TeamTrackerApp.TabPages.ProfilePage
{
    partial class MyProfilePage
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ProfileTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnPersonalInfo = new System.Windows.Forms.Button();
            this.BtnWorkingStatus = new System.Windows.Forms.Button();
            this.BtnPassword = new System.Windows.Forms.Button();
            this.LanguageBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucUserProfileDp1 = new TeamTrackerApp.TabPages.ProfilePage.UCUserProfileDp();
            this.ucWorkingStatus1 = new TeamTrackerApp.TabPages.ProfilePage.UCWorkingStatus();
            this.ucPasswordPage1 = new TeamTrackerApp.TabPages.ProfilePage.UCPasswordPage();
            this.ucLanguageRegion1 = new TeamTrackerApp.TabPages.ProfilePage.UCLanguageRegion();
            this.TopPanel.SuspendLayout();
            this.ProfileTabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.ucUserProfileDp1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1028, 202);
            this.TopPanel.TabIndex = 0;
            // 
            // ProfileTabControl
            // 
            this.ProfileTabControl.Controls.Add(this.tabPage1);
            this.ProfileTabControl.Controls.Add(this.tabPage2);
            this.ProfileTabControl.Controls.Add(this.tabPage3);
            this.ProfileTabControl.Controls.Add(this.tabPage4);
            this.ProfileTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.ProfileTabControl.Location = new System.Drawing.Point(0, 0);
            this.ProfileTabControl.Name = "ProfileTabControl";
            this.ProfileTabControl.Padding = new System.Drawing.Point(50, 3);
            this.ProfileTabControl.SelectedIndex = 0;
            this.ProfileTabControl.Size = new System.Drawing.Size(1028, 583);
            this.ProfileTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ProfileTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1020, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucWorkingStatus1);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1020, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ucPasswordPage1);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1020, 574);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ucLanguageRegion1);
            this.tabPage4.Location = new System.Drawing.Point(4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1020, 574);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.BtnPersonalInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnWorkingStatus, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnPassword, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LanguageBtn, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 202);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 40);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // BtnPersonalInfo
            // 
            this.BtnPersonalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPersonalInfo.FlatAppearance.BorderSize = 0;
            this.BtnPersonalInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnPersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonalInfo.Location = new System.Drawing.Point(3, 3);
            this.BtnPersonalInfo.Name = "BtnPersonalInfo";
            this.BtnPersonalInfo.Size = new System.Drawing.Size(251, 34);
            this.BtnPersonalInfo.TabIndex = 0;
            this.BtnPersonalInfo.Text = "Personal Info";
            this.BtnPersonalInfo.UseVisualStyleBackColor = true;
            this.BtnPersonalInfo.Click += new System.EventHandler(this.OnClickPersonalInfo);
            // 
            // BtnWorkingStatus
            // 
            this.BtnWorkingStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnWorkingStatus.FlatAppearance.BorderSize = 0;
            this.BtnWorkingStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnWorkingStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWorkingStatus.Location = new System.Drawing.Point(260, 3);
            this.BtnWorkingStatus.Name = "BtnWorkingStatus";
            this.BtnWorkingStatus.Size = new System.Drawing.Size(251, 34);
            this.BtnWorkingStatus.TabIndex = 1;
            this.BtnWorkingStatus.Text = "Working Status";
            this.BtnWorkingStatus.UseVisualStyleBackColor = true;
            this.BtnWorkingStatus.Click += new System.EventHandler(this.OnClickWorkingStatus);
            // 
            // BtnPassword
            // 
            this.BtnPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPassword.FlatAppearance.BorderSize = 0;
            this.BtnPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPassword.Location = new System.Drawing.Point(517, 3);
            this.BtnPassword.Name = "BtnPassword";
            this.BtnPassword.Size = new System.Drawing.Size(251, 34);
            this.BtnPassword.TabIndex = 1;
            this.BtnPassword.Text = "Password";
            this.BtnPassword.UseVisualStyleBackColor = true;
            this.BtnPassword.Click += new System.EventHandler(this.OnClickPassword);
            // 
            // LanguageBtn
            // 
            this.LanguageBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LanguageBtn.FlatAppearance.BorderSize = 0;
            this.LanguageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.LanguageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LanguageBtn.Location = new System.Drawing.Point(774, 3);
            this.LanguageBtn.Name = "LanguageBtn";
            this.LanguageBtn.Size = new System.Drawing.Size(251, 34);
            this.LanguageBtn.TabIndex = 1;
            this.LanguageBtn.Text = "Language and Region";
            this.LanguageBtn.UseVisualStyleBackColor = true;
            this.LanguageBtn.Click += new System.EventHandler(this.OnClickLanguageRegion);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeamTrackerApp.Properties.Resources.icons8_close_30;
            this.pictureBox1.Location = new System.Drawing.Point(988, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.OnClickClose);
            // 
            // ucUserProfileDp1
            // 
            this.ucUserProfileDp1.Location = new System.Drawing.Point(408, 19);
            this.ucUserProfileDp1.Name = "ucUserProfileDp1";
            this.ucUserProfileDp1.Size = new System.Drawing.Size(143, 166);
            this.ucUserProfileDp1.TabIndex = 0;
            // 
            // ucWorkingStatus1
            // 
            this.ucWorkingStatus1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucWorkingStatus1.Location = new System.Drawing.Point(3, 244);
            this.ucWorkingStatus1.Margin = new System.Windows.Forms.Padding(5);
            this.ucWorkingStatus1.Name = "ucWorkingStatus1";
            this.ucWorkingStatus1.Size = new System.Drawing.Size(1014, 327);
            this.ucWorkingStatus1.TabIndex = 0;
            // 
            // ucPasswordPage1
            // 
            this.ucPasswordPage1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPasswordPage1.Location = new System.Drawing.Point(3, 242);
            this.ucPasswordPage1.Margin = new System.Windows.Forms.Padding(5);
            this.ucPasswordPage1.Name = "ucPasswordPage1";
            this.ucPasswordPage1.Size = new System.Drawing.Size(1014, 329);
            this.ucPasswordPage1.TabIndex = 0;
            // 
            // ucLanguageRegion1
            // 
            this.ucLanguageRegion1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucLanguageRegion1.Location = new System.Drawing.Point(3, 258);
            this.ucLanguageRegion1.Margin = new System.Windows.Forms.Padding(5);
            this.ucLanguageRegion1.Name = "ucLanguageRegion1";
            this.ucLanguageRegion1.Size = new System.Drawing.Size(1014, 313);
            this.ucLanguageRegion1.TabIndex = 0;
            // 
            // MyProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 583);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.ProfileTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyProfilePage";
            this.Text = "MyProfilePage";
            this.Load += new System.EventHandler(this.MyProfilePage_Load);
            this.TopPanel.ResumeLayout(false);
            this.ProfileTabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private UCUserProfileDp ucUserProfileDp1;
        private System.Windows.Forms.TabControl ProfileTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnPersonalInfo;
        private System.Windows.Forms.Button BtnWorkingStatus;
        private System.Windows.Forms.Button BtnPassword;
        private System.Windows.Forms.Button LanguageBtn;
        private UCWorkingStatus ucWorkingStatus1;
        private UCPasswordPage ucPasswordPage1;
        private UCLanguageRegion ucLanguageRegion1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}