namespace ScoreBoard
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
            this.ConnectIp = new System.Windows.Forms.TextBox();
            this.ConnectPort = new System.Windows.Forms.TextBox();
            this.Connectbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.A_1 = new System.Windows.Forms.Button();
            this.A_2 = new System.Windows.Forms.Button();
            this.A_3 = new System.Windows.Forms.Button();
            this.B_1 = new System.Windows.Forms.Button();
            this.B_2 = new System.Windows.Forms.Button();
            this.B_3 = new System.Windows.Forms.Button();
            this.cmdLoadscene = new System.Windows.Forms.Button();
            this.cmdLoadData = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.lbpath = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectIp
            // 
            this.ConnectIp.Location = new System.Drawing.Point(46, 37);
            this.ConnectIp.Name = "ConnectIp";
            this.ConnectIp.Size = new System.Drawing.Size(171, 21);
            this.ConnectIp.TabIndex = 0;
            this.ConnectIp.Text = "localhost";
            // 
            // ConnectPort
            // 
            this.ConnectPort.Location = new System.Drawing.Point(235, 37);
            this.ConnectPort.Name = "ConnectPort";
            this.ConnectPort.Size = new System.Drawing.Size(67, 21);
            this.ConnectPort.TabIndex = 1;
            this.ConnectPort.Text = "6100";
            // 
            // Connectbtn
            // 
            this.Connectbtn.Location = new System.Drawing.Point(326, 37);
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.Size = new System.Drawing.Size(75, 23);
            this.Connectbtn.TabIndex = 2;
            this.Connectbtn.Text = "Connect";
            this.Connectbtn.UseVisualStyleBackColor = true;
            this.Connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(80, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(80, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Team B";
            // 
            // A_1
            // 
            this.A_1.Location = new System.Drawing.Point(221, 230);
            this.A_1.Name = "A_1";
            this.A_1.Size = new System.Drawing.Size(63, 23);
            this.A_1.TabIndex = 5;
            this.A_1.Text = "+1";
            this.A_1.UseVisualStyleBackColor = true;
            this.A_1.Click += new System.EventHandler(this.A_1_Click);
            // 
            // A_2
            // 
            this.A_2.Location = new System.Drawing.Point(359, 231);
            this.A_2.Name = "A_2";
            this.A_2.Size = new System.Drawing.Size(63, 23);
            this.A_2.TabIndex = 6;
            this.A_2.Text = "+2";
            this.A_2.UseVisualStyleBackColor = true;
            this.A_2.Click += new System.EventHandler(this.A_2_Click);
            // 
            // A_3
            // 
            this.A_3.Location = new System.Drawing.Point(487, 231);
            this.A_3.Name = "A_3";
            this.A_3.Size = new System.Drawing.Size(63, 23);
            this.A_3.TabIndex = 7;
            this.A_3.Text = "+3";
            this.A_3.UseVisualStyleBackColor = true;
            this.A_3.Click += new System.EventHandler(this.A_3_Click);
            // 
            // B_1
            // 
            this.B_1.Location = new System.Drawing.Point(221, 313);
            this.B_1.Name = "B_1";
            this.B_1.Size = new System.Drawing.Size(63, 23);
            this.B_1.TabIndex = 8;
            this.B_1.Text = "+1";
            this.B_1.UseVisualStyleBackColor = true;
            this.B_1.Click += new System.EventHandler(this.B_1_Click);
            // 
            // B_2
            // 
            this.B_2.Location = new System.Drawing.Point(359, 314);
            this.B_2.Name = "B_2";
            this.B_2.Size = new System.Drawing.Size(63, 23);
            this.B_2.TabIndex = 9;
            this.B_2.Text = "+2";
            this.B_2.UseVisualStyleBackColor = true;
            this.B_2.Click += new System.EventHandler(this.B_2_Click);
            // 
            // B_3
            // 
            this.B_3.Location = new System.Drawing.Point(487, 313);
            this.B_3.Name = "B_3";
            this.B_3.Size = new System.Drawing.Size(63, 23);
            this.B_3.TabIndex = 10;
            this.B_3.Text = "+3";
            this.B_3.UseVisualStyleBackColor = true;
            this.B_3.Click += new System.EventHandler(this.B_3_Click);
            // 
            // cmdLoadscene
            // 
            this.cmdLoadscene.Location = new System.Drawing.Point(100, 118);
            this.cmdLoadscene.Name = "cmdLoadscene";
            this.cmdLoadscene.Size = new System.Drawing.Size(172, 60);
            this.cmdLoadscene.TabIndex = 11;
            this.cmdLoadscene.Text = "Load Scene";
            this.cmdLoadscene.UseVisualStyleBackColor = true;
            this.cmdLoadscene.Click += new System.EventHandler(this.cmdLoadscene_Click);
            // 
            // cmdLoadData
            // 
            this.cmdLoadData.Location = new System.Drawing.Point(378, 118);
            this.cmdLoadData.Name = "cmdLoadData";
            this.cmdLoadData.Size = new System.Drawing.Size(172, 60);
            this.cmdLoadData.TabIndex = 12;
            this.cmdLoadData.Text = "Load Data";
            this.cmdLoadData.UseVisualStyleBackColor = true;
            this.cmdLoadData.Click += new System.EventHandler(this.cmdLoadData_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(100, 184);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(260, 21);
            this.path.TabIndex = 13;
            this.path.Text = "vizrt/Viz_Datapool_Tutorial/tst";
            // 
            // lbpath
            // 
            this.lbpath.AutoSize = true;
            this.lbpath.Location = new System.Drawing.Point(65, 187);
            this.lbpath.Name = "lbpath";
            this.lbpath.Size = new System.Drawing.Size(29, 12);
            this.lbpath.TabIndex = 14;
            this.lbpath.Text = "Path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 69);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbpath);
            this.Controls.Add(this.path);
            this.Controls.Add(this.cmdLoadData);
            this.Controls.Add(this.cmdLoadscene);
            this.Controls.Add(this.B_3);
            this.Controls.Add(this.B_2);
            this.Controls.Add(this.B_1);
            this.Controls.Add(this.A_3);
            this.Controls.Add(this.A_2);
            this.Controls.Add(this.A_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connectbtn);
            this.Controls.Add(this.ConnectPort);
            this.Controls.Add(this.ConnectIp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConnectIp;
        private System.Windows.Forms.TextBox ConnectPort;
        private System.Windows.Forms.Button Connectbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button A_1;
        private System.Windows.Forms.Button A_2;
        private System.Windows.Forms.Button A_3;
        private System.Windows.Forms.Button B_1;
        private System.Windows.Forms.Button B_2;
        private System.Windows.Forms.Button B_3;
        private System.Windows.Forms.Button cmdLoadscene;
        private System.Windows.Forms.Button cmdLoadData;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label lbpath;
        private System.Windows.Forms.Button button1;
    }
}

