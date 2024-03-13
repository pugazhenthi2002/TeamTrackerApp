﻿namespace TeamTrackerApp.TabPages.ProfilePage
{
    partial class UCUserProfileDp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUserProfileDp));
            this.ReceiverNameLabel = new System.Windows.Forms.Label();
            this.chatDpPicBox = new TeamTrackerApp.TabPages.ProfilePage.RoundPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chatDpPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ReceiverNameLabel
            // 
            this.ReceiverNameLabel.AutoSize = true;
            this.ReceiverNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiverNameLabel.Location = new System.Drawing.Point(36, 127);
            this.ReceiverNameLabel.Name = "ReceiverNameLabel";
            this.ReceiverNameLabel.Size = new System.Drawing.Size(86, 16);
            this.ReceiverNameLabel.TabIndex = 3;
            this.ReceiverNameLabel.Text = "User Name";
            // 
            // chatDpPicBox
            // 
            this.chatDpPicBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatDpPicBox.Image = ((System.Drawing.Image)(resources.GetObject("chatDpPicBox.Image")));
            this.chatDpPicBox.Location = new System.Drawing.Point(0, 0);
            this.chatDpPicBox.Name = "chatDpPicBox";
            this.chatDpPicBox.Size = new System.Drawing.Size(149, 124);
            this.chatDpPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chatDpPicBox.TabIndex = 4;
            this.chatDpPicBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Designation";
            // 
            // UCUserProfileDp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReceiverNameLabel);
            this.Controls.Add(this.chatDpPicBox);
            this.Name = "UCUserProfileDp";
            this.Size = new System.Drawing.Size(149, 169);
            ((System.ComponentModel.ISupportInitialize)(this.chatDpPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReceiverNameLabel;
        private RoundPictureBox chatDpPicBox;
        private System.Windows.Forms.Label label1;
    }
}
