namespace EDP_Project
{
    partial class Form6
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.pos_txt = new System.Windows.Forms.TextBox();
            this.sal_txt = new System.Windows.Forms.TextBox();
            this.branch_txt = new System.Windows.Forms.TextBox();
            this.get_btn = new System.Windows.Forms.Button();
            this.post_btn = new System.Windows.Forms.Button();
            this.key_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(13, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 224);
            this.panel1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(454, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(0, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(454, 193);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.key_txt);
            this.panel2.Controls.Add(this.post_btn);
            this.panel2.Controls.Add(this.get_btn);
            this.panel2.Controls.Add(this.branch_txt);
            this.panel2.Controls.Add(this.sal_txt);
            this.panel2.Controls.Add(this.pos_txt);
            this.panel2.Controls.Add(this.name_txt);
            this.panel2.Location = new System.Drawing.Point(13, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 212);
            this.panel2.TabIndex = 3;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(107, 10);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(293, 22);
            this.name_txt.TabIndex = 0;
            // 
            // pos_txt
            // 
            this.pos_txt.Location = new System.Drawing.Point(107, 38);
            this.pos_txt.Name = "pos_txt";
            this.pos_txt.Size = new System.Drawing.Size(293, 22);
            this.pos_txt.TabIndex = 1;
            // 
            // sal_txt
            // 
            this.sal_txt.Location = new System.Drawing.Point(107, 66);
            this.sal_txt.Name = "sal_txt";
            this.sal_txt.Size = new System.Drawing.Size(293, 22);
            this.sal_txt.TabIndex = 2;
            // 
            // branch_txt
            // 
            this.branch_txt.Location = new System.Drawing.Point(107, 94);
            this.branch_txt.Name = "branch_txt";
            this.branch_txt.Size = new System.Drawing.Size(293, 22);
            this.branch_txt.TabIndex = 3;
            // 
            // get_btn
            // 
            this.get_btn.Location = new System.Drawing.Point(4, 148);
            this.get_btn.Name = "get_btn";
            this.get_btn.Size = new System.Drawing.Size(222, 61);
            this.get_btn.TabIndex = 4;
            this.get_btn.Text = "GET";
            this.get_btn.UseVisualStyleBackColor = true;
            this.get_btn.Click += new System.EventHandler(this.get_btn_Click);
            // 
            // post_btn
            // 
            this.post_btn.Location = new System.Drawing.Point(229, 148);
            this.post_btn.Name = "post_btn";
            this.post_btn.Size = new System.Drawing.Size(222, 61);
            this.post_btn.TabIndex = 5;
            this.post_btn.Text = "POST";
            this.post_btn.UseVisualStyleBackColor = true;
            this.post_btn.Click += new System.EventHandler(this.post_btn_Click);
            // 
            // key_txt
            // 
            this.key_txt.Location = new System.Drawing.Point(107, 122);
            this.key_txt.Name = "key_txt";
            this.key_txt.Size = new System.Drawing.Size(293, 22);
            this.key_txt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Branch:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Key:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form6";
            this.Text = "API";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button post_btn;
        private System.Windows.Forms.Button get_btn;
        private System.Windows.Forms.TextBox branch_txt;
        private System.Windows.Forms.TextBox sal_txt;
        private System.Windows.Forms.TextBox pos_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox key_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}