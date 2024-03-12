namespace TeamTrackerApp
{
    partial class Draft
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
            this.placeHolderTextBox2 = new TeamTrackerApp.PlaceHolderTextBox();
            this.placeHolderTextBox1 = new TeamTrackerApp.PlaceHolderTextBox();
            this.SuspendLayout();
            // 
            // placeHolderTextBox2
            // 
            this.placeHolderTextBox2.IsPasswordType = false;
            this.placeHolderTextBox2.Location = new System.Drawing.Point(560, 280);
            this.placeHolderTextBox2.Name = "placeHolderTextBox2";
            this.placeHolderTextBox2.PlaceHolder = "World";
            this.placeHolderTextBox2.Size = new System.Drawing.Size(100, 20);
            this.placeHolderTextBox2.TabIndex = 1;
            // 
            // placeHolderTextBox1
            // 
            this.placeHolderTextBox1.IsPasswordType = true;
            this.placeHolderTextBox1.Location = new System.Drawing.Point(298, 60);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolder = "Hello";
            this.placeHolderTextBox1.Size = new System.Drawing.Size(100, 20);
            this.placeHolderTextBox1.TabIndex = 0;
            // 
            // Draft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 580);
            this.Controls.Add(this.placeHolderTextBox2);
            this.Controls.Add(this.placeHolderTextBox1);
            this.Name = "Draft";
            this.Text = "Draft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceHolderTextBox placeHolderTextBox1;
        private PlaceHolderTextBox placeHolderTextBox2;
    }
}