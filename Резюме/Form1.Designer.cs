namespace Резюме
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_Resume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Resume
            // 
            this.BT_Resume.Location = new System.Drawing.Point(296, 164);
            this.BT_Resume.Name = "BT_Resume";
            this.BT_Resume.Size = new System.Drawing.Size(155, 109);
            this.BT_Resume.TabIndex = 0;
            this.BT_Resume.Text = "Моє резюме";
            this.BT_Resume.UseVisualStyleBackColor = true;
            this.BT_Resume.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_Resume);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BT_Resume;
    }
}