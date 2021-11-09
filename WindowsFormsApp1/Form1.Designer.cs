namespace WindowsFormsApp1
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
            this.buttonGetPage = new System.Windows.Forms.Button();
            this.textBoxPage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGetPage
            // 
            this.buttonGetPage.Location = new System.Drawing.Point(341, 75);
            this.buttonGetPage.Name = "buttonGetPage";
            this.buttonGetPage.Size = new System.Drawing.Size(75, 23);
            this.buttonGetPage.TabIndex = 0;
            this.buttonGetPage.Text = "GetPage";
            this.buttonGetPage.UseVisualStyleBackColor = true;
            this.buttonGetPage.Click += new System.EventHandler(this.buttonGetPage_Click);
            // 
            // textBoxPage
            // 
            this.textBoxPage.Location = new System.Drawing.Point(297, 212);
            this.textBoxPage.Multiline = true;
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.Size = new System.Drawing.Size(222, 21);
            this.textBoxPage.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPage);
            this.Controls.Add(this.buttonGetPage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetPage;
        private System.Windows.Forms.TextBox textBoxPage;
    }
}

