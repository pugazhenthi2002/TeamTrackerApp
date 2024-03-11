namespace TeamTrackerApp.TabPages.Colloborate.Colloborate_Control
{
    partial class ChatTemplate
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.colloborateMessageBox1 = new TeamTrackerApp.TabPages.Colloborate.Colloborate_Control.ColloborateMessageBox();
            this.chatProfile2 = new TeamTrackerApp.TabPages.Colloborate.Colloborate_Control.ChatProfile();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(690, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 724);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.colloborateMessageBox1);
            this.panel2.Controls.Add(this.chatProfile2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 724);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 617);
            this.panel3.TabIndex = 2;
            // 
            // colloborateMessageBox1
            // 
            this.colloborateMessageBox1.BackColor = System.Drawing.Color.Khaki;
            this.colloborateMessageBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.colloborateMessageBox1.Location = new System.Drawing.Point(0, 671);
            this.colloborateMessageBox1.Margin = new System.Windows.Forms.Padding(2);
            this.colloborateMessageBox1.Name = "colloborateMessageBox1";
            this.colloborateMessageBox1.Size = new System.Drawing.Size(690, 53);
            this.colloborateMessageBox1.TabIndex = 1;
            // 
            // chatProfile2
            // 
            this.chatProfile2.BackColor = System.Drawing.Color.Khaki;
            this.chatProfile2.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatProfile2.Location = new System.Drawing.Point(0, 0);
            this.chatProfile2.Margin = new System.Windows.Forms.Padding(2);
            this.chatProfile2.Name = "chatProfile2";
            this.chatProfile2.Size = new System.Drawing.Size(690, 54);
            this.chatProfile2.TabIndex = 0;
            // 
            // ChatTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChatTemplate";
            this.Size = new System.Drawing.Size(855, 724);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ChatProfile chatProfile2;
        private System.Windows.Forms.Panel panel3;
        private ColloborateMessageBox colloborateMessageBox1;
    }
}
