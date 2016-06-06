namespace LineUp
{
    partial class changeInfo
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
            this.imagePb = new System.Windows.Forms.PictureBox();
            this.Nametb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePb)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePb
            // 
            this.imagePb.Location = new System.Drawing.Point(12, 12);
            this.imagePb.Name = "imagePb";
            this.imagePb.Size = new System.Drawing.Size(213, 233);
            this.imagePb.TabIndex = 0;
            this.imagePb.TabStop = false;
            // 
            // Nametb
            // 
            this.Nametb.Location = new System.Drawing.Point(12, 285);
            this.Nametb.Name = "Nametb";
            this.Nametb.Size = new System.Drawing.Size(162, 21);
            this.Nametb.TabIndex = 1;
            // 
            // changeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 365);
            this.Controls.Add(this.Nametb);
            this.Controls.Add(this.imagePb);
            this.Name = "changeInfo";
            this.Text = "changeInfo";
            ((System.ComponentModel.ISupportInitialize)(this.imagePb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePb;
        private System.Windows.Forms.TextBox Nametb;
    }
}