namespace ChessBoardGuiApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gigP = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.vCount = new System.Windows.Forms.Panel();
            this.VCB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.HSCORE = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BIGB = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.vCount.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Out the Possible Way to fill out All the Cells";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hard",
            "Easy"});
            this.comboBox1.Location = new System.Drawing.Point(1034, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(45, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 500);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1217, 602);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1034, 546);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(170, 43);
            this.exit.TabIndex = 1;
            this.exit.Text = "Quit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(819, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Restart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(592, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 48);
            this.button5.TabIndex = 5;
            this.button5.Text = "ShowPattern";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gigP
            // 
            this.gigP.Location = new System.Drawing.Point(0, -1);
            this.gigP.Name = "gigP";
            this.gigP.Size = new System.Drawing.Size(1220, 602);
            this.gigP.TabIndex = 2;
            this.gigP.Paint += new System.Windows.Forms.PaintEventHandler(this.gigP_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Victory Count";
            // 
            // vCount
            // 
            this.vCount.Controls.Add(this.VCB);
            this.vCount.Location = new System.Drawing.Point(567, 106);
            this.vCount.Name = "vCount";
            this.vCount.Size = new System.Drawing.Size(42, 28);
            this.vCount.TabIndex = 7;
            // 
            // VCB
            // 
            this.VCB.Location = new System.Drawing.Point(0, 0);
            this.VCB.Name = "VCB";
            this.VCB.Size = new System.Drawing.Size(42, 28);
            this.VCB.TabIndex = 0;
            this.VCB.Text = "0";
            this.VCB.UseVisualStyleBackColor = true;
            this.VCB.Click += new System.EventHandler(this.VCB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "HighScore";
            // 
            // HSCORE
            // 
            this.HSCORE.Location = new System.Drawing.Point(0, 0);
            this.HSCORE.Name = "HSCORE";
            this.HSCORE.Size = new System.Drawing.Size(42, 28);
            this.HSCORE.TabIndex = 1;
            this.HSCORE.Text = "0";
            this.HSCORE.UseVisualStyleBackColor = true;
            this.HSCORE.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.HSCORE);
            this.panel3.Location = new System.Drawing.Point(567, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(42, 28);
            this.panel3.TabIndex = 8;
            // 
            // BIGB
            // 
            this.BIGB.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIGB.Location = new System.Drawing.Point(276, 86);
            this.BIGB.Name = "BIGB";
            this.BIGB.Size = new System.Drawing.Size(603, 382);
            this.BIGB.TabIndex = 0;
            this.BIGB.Text = "Welcome To The Knight\'s Game\r\nGOAL:\r\n\r\n\r\n\r\nLead the knight to the right path\r\nunt" +
    "il it conquers the entire region\r\n";
            this.BIGB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BIGB.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(323, 266);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(246, 51);
            this.button6.TabIndex = 2;
            this.button6.Text = "Quit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gigP);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.BIGB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.vCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Knight\'s Game";
            this.panel2.ResumeLayout(false);
            this.vCount.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel gigP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel vCount;
        private System.Windows.Forms.Button VCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HSCORE;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button BIGB;
        private System.Windows.Forms.Button button6;
    }
}

