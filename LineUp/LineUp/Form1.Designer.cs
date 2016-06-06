namespace LineUp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Connectbtn = new System.Windows.Forms.Button();
            this.ConnectPort = new System.Windows.Forms.TextBox();
            this.ConnectIp = new System.Windows.Forms.TextBox();
            this.Iplbl = new System.Windows.Forms.Label();
            this.Portlbl = new System.Windows.Forms.Label();
            this.Pathlbl = new System.Windows.Forms.Label();
            this.Pathtb = new System.Windows.Forms.TextBox();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connectbtn
            // 
            this.Connectbtn.Location = new System.Drawing.Point(161, 81);
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.Size = new System.Drawing.Size(75, 23);
            this.Connectbtn.TabIndex = 5;
            this.Connectbtn.Text = "Connect";
            this.Connectbtn.UseVisualStyleBackColor = true;
            this.Connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // ConnectPort
            // 
            this.ConnectPort.Location = new System.Drawing.Point(25, 81);
            this.ConnectPort.Name = "ConnectPort";
            this.ConnectPort.Size = new System.Drawing.Size(67, 21);
            this.ConnectPort.TabIndex = 4;
            this.ConnectPort.Text = "6100";
            this.ConnectPort.TextChanged += new System.EventHandler(this.ConnectPort_TextChanged);
            // 
            // ConnectIp
            // 
            this.ConnectIp.Location = new System.Drawing.Point(25, 33);
            this.ConnectIp.Name = "ConnectIp";
            this.ConnectIp.Size = new System.Drawing.Size(171, 21);
            this.ConnectIp.TabIndex = 3;
            this.ConnectIp.Text = "localhost";
            this.ConnectIp.TextChanged += new System.EventHandler(this.ConnectIp_TextChanged);
            // 
            // Iplbl
            // 
            this.Iplbl.AutoSize = true;
            this.Iplbl.Location = new System.Drawing.Point(25, 13);
            this.Iplbl.Name = "Iplbl";
            this.Iplbl.Size = new System.Drawing.Size(17, 12);
            this.Iplbl.TabIndex = 6;
            this.Iplbl.Text = "IP";
            // 
            // Portlbl
            // 
            this.Portlbl.AutoSize = true;
            this.Portlbl.Location = new System.Drawing.Point(25, 61);
            this.Portlbl.Name = "Portlbl";
            this.Portlbl.Size = new System.Drawing.Size(29, 12);
            this.Portlbl.TabIndex = 7;
            this.Portlbl.Text = "Port";
            // 
            // Pathlbl
            // 
            this.Pathlbl.AutoSize = true;
            this.Pathlbl.Location = new System.Drawing.Point(25, 130);
            this.Pathlbl.Name = "Pathlbl";
            this.Pathlbl.Size = new System.Drawing.Size(59, 12);
            this.Pathlbl.TabIndex = 8;
            this.Pathlbl.Text = "ScenePath";
            // 
            // Pathtb
            // 
            this.Pathtb.Location = new System.Drawing.Point(27, 157);
            this.Pathtb.Name = "Pathtb";
            this.Pathtb.Size = new System.Drawing.Size(209, 21);
            this.Pathtb.TabIndex = 9;
            // 
            // Loadbtn
            // 
            this.Loadbtn.Location = new System.Drawing.Point(161, 195);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(75, 23);
            this.Loadbtn.TabIndex = 10;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 268);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.Pathtb);
            this.Controls.Add(this.Pathlbl);
            this.Controls.Add(this.Portlbl);
            this.Controls.Add(this.Iplbl);
            this.Controls.Add(this.Connectbtn);
            this.Controls.Add(this.ConnectPort);
            this.Controls.Add(this.ConnectIp);
            this.Name = "Form1";
            this.Text = "LineUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connectbtn;
        private System.Windows.Forms.TextBox ConnectPort;
        private System.Windows.Forms.TextBox ConnectIp;
        private System.Windows.Forms.Label Iplbl;
        private System.Windows.Forms.Label Portlbl;
        private System.Windows.Forms.Label Pathlbl;
        private System.Windows.Forms.TextBox Pathtb;
        private System.Windows.Forms.Button Loadbtn;
    }
}

