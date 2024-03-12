namespace TeamTrackerApp.TabPages.IssuePage
{
    partial class UCAddIssue
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rippleButton1 = new TeamTrackerApp.RippleButton();
            this.rippleButton2 = new TeamTrackerApp.RippleButton();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Head:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 38);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Location = new System.Drawing.Point(0, 133);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 91);
            this.textBox2.TabIndex = 3;
            // 
            // rippleButton1
            // 
            this.rippleButton1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rippleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rippleButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.rippleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rippleButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rippleButton1.Location = new System.Drawing.Point(0, 267);
            this.rippleButton1.Name = "rippleButton1";
            this.rippleButton1.Size = new System.Drawing.Size(300, 75);
            this.rippleButton1.TabIndex = 6;
            this.rippleButton1.Text = "Create";
            this.rippleButton1.UseVisualStyleBackColor = false;
            // 
            // rippleButton2
            // 
            this.rippleButton2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rippleButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rippleButton2.FlatAppearance.BorderSize = 0;
            this.rippleButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.rippleButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rippleButton2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rippleButton2.Location = new System.Drawing.Point(0, 224);
            this.rippleButton2.Name = "rippleButton2";
            this.rippleButton2.Size = new System.Drawing.Size(300, 43);
            this.rippleButton2.TabIndex = 7;
            this.rippleButton2.Text = "Add Attachments";
            this.rippleButton2.UseVisualStyleBackColor = false;
            // 
            // UCAddIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rippleButton1);
            this.Controls.Add(this.rippleButton2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "UCAddIssue";
            this.Size = new System.Drawing.Size(300, 342);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private RippleButton rippleButton1;
        private RippleButton rippleButton2;
    }
}
