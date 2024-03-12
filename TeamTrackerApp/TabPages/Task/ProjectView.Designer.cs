namespace TeamTrackerApp.TabPages.Task
{
    partial class ProjectView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.projectViewPanel = new System.Windows.Forms.Panel();
            this.rippleButton1 = new TeamTrackerApp.RippleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rippleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1546, 62);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1076, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 425);
            this.panel2.TabIndex = 1;
            // 
            // projectViewPanel
            // 
            this.projectViewPanel.AutoScroll = true;
            this.projectViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectViewPanel.Location = new System.Drawing.Point(0, 62);
            this.projectViewPanel.Name = "projectViewPanel";
            this.projectViewPanel.Size = new System.Drawing.Size(1076, 425);
            this.projectViewPanel.TabIndex = 2;
            // 
            // rippleButton1
            // 
            this.rippleButton1.Location = new System.Drawing.Point(289, 19);
            this.rippleButton1.Name = "rippleButton1";
            this.rippleButton1.Size = new System.Drawing.Size(75, 23);
            this.rippleButton1.TabIndex = 0;
            this.rippleButton1.Text = "rippleButton1";
            this.rippleButton1.UseVisualStyleBackColor = true;
            this.rippleButton1.Click += new System.EventHandler(this.rippleButton1_Click);
            // 
            // ProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.projectViewPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProjectView";
            this.Size = new System.Drawing.Size(1546, 487);
            this.Load += new System.EventHandler(this.ProjectView_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel projectViewPanel;
        private RippleButton rippleButton1;
    }
}
