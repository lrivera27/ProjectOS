namespace Squashids
{
    partial class mainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.hidsBtn = new System.Windows.Forms.Button();
            this.nidsBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.hidsPanel = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outputBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hidsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intrusion Detection System Menu";
            // 
            // hidsBtn
            // 
            this.hidsBtn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.hidsBtn.Location = new System.Drawing.Point(12, 139);
            this.hidsBtn.Name = "hidsBtn";
            this.hidsBtn.Size = new System.Drawing.Size(479, 222);
            this.hidsBtn.TabIndex = 1;
            this.hidsBtn.Text = "Hosted IDS";
            this.hidsBtn.UseVisualStyleBackColor = true;
            this.hidsBtn.Click += new System.EventHandler(this.hidsBtn_Click);
            // 
            // nidsBtn
            // 
            this.nidsBtn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.nidsBtn.Location = new System.Drawing.Point(497, 139);
            this.nidsBtn.Name = "nidsBtn";
            this.nidsBtn.Size = new System.Drawing.Size(462, 222);
            this.nidsBtn.TabIndex = 2;
            this.nidsBtn.Text = "Network IDS";
            this.nidsBtn.UseVisualStyleBackColor = true;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.aboutBtn.Location = new System.Drawing.Point(12, 382);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(479, 222);
            this.aboutBtn.TabIndex = 3;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.exitBtn.Location = new System.Drawing.Point(497, 382);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(462, 222);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "EXIT / LOGOUT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // hidsPanel
            // 
            this.hidsPanel.Controls.Add(this.groupBox2);
            this.hidsPanel.Controls.Add(this.groupBox1);
            this.hidsPanel.Controls.Add(this.outputBtn);
            this.hidsPanel.Controls.Add(this.backBtn);
            this.hidsPanel.Controls.Add(this.label2);
            this.hidsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hidsPanel.Location = new System.Drawing.Point(0, 0);
            this.hidsPanel.Name = "hidsPanel";
            this.hidsPanel.Size = new System.Drawing.Size(971, 651);
            this.hidsPanel.TabIndex = 5;
            this.hidsPanel.Visible = false;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.backBtn.Location = new System.Drawing.Point(815, 592);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(144, 47);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hosted Intrusion Detection System";
            // 
            // outputBtn
            // 
            this.outputBtn.Location = new System.Drawing.Point(12, 592);
            this.outputBtn.Name = "outputBtn";
            this.outputBtn.Size = new System.Drawing.Size(169, 52);
            this.outputBtn.TabIndex = 8;
            this.outputBtn.Text = "Export Data";
            this.outputBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 394);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU Monitor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Warnings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 30);
            this.label8.TabIndex = 10;
            this.label8.Text = "Current CPU usage";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 169);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 76);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(238, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(118, 28);
            this.textBox4.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox2.Location = new System.Drawing.Point(593, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 394);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAM Monitor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(6, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Warnings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Available RAM";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 169);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 76);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 28);
            this.textBox2.TabIndex = 8;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(971, 651);
            this.Controls.Add(this.hidsPanel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.nidsBtn);
            this.Controls.Add(this.hidsBtn);
            this.Controls.Add(this.label1);
            this.Name = "mainMenu";
            this.Text = "mainMenu";
            this.hidsPanel.ResumeLayout(false);
            this.hidsPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hidsBtn;
        private System.Windows.Forms.Button nidsBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel hidsPanel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button outputBtn;
    }
}