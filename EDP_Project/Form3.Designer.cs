namespace EDP_Project
{
    partial class reg_form
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
            this.item_list_view = new System.Windows.Forms.DataGridView();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reports_link = new System.Windows.Forms.ToolStripMenuItem();
            this.about_link = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.change_text = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cash_text = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subtotal_text = new System.Windows.Forms.RichTextBox();
            this.tax_text = new System.Windows.Forms.RichTextBox();
            this.total_text = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.print_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.pay_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.one_btn = new System.Windows.Forms.Button();
            this.two_btn = new System.Windows.Forms.Button();
            this.three_btn = new System.Windows.Forms.Button();
            this.four_btn = new System.Windows.Forms.Button();
            this.five_btn = new System.Windows.Forms.Button();
            this.six_btn = new System.Windows.Forms.Button();
            this.seven_btn = new System.Windows.Forms.Button();
            this.eight_btn = new System.Windows.Forms.Button();
            this.nine_btn = new System.Windows.Forms.Button();
            this.zero_btn = new System.Windows.Forms.Button();
            this.period_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.itemchoice_list = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.item_list_view)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemchoice_list)).BeginInit();
            this.SuspendLayout();
            // 
            // item_list_view
            // 
            this.item_list_view.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_list_view.BackgroundColor = System.Drawing.Color.Gray;
            this.item_list_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.item_list_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.item_list_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod_id,
            this.prod_name,
            this.prod_amount});
            this.item_list_view.Location = new System.Drawing.Point(877, 38);
            this.item_list_view.Name = "item_list_view";
            this.item_list_view.RowHeadersWidth = 51;
            this.item_list_view.RowTemplate.Height = 24;
            this.item_list_view.Size = new System.Drawing.Size(971, 495);
            this.item_list_view.TabIndex = 0;
            // 
            // prod_id
            // 
            this.prod_id.HeaderText = "ID";
            this.prod_id.MinimumWidth = 6;
            this.prod_id.Name = "prod_id";
            this.prod_id.Width = 125;
            // 
            // prod_name
            // 
            this.prod_name.HeaderText = "Product";
            this.prod_name.MinimumWidth = 6;
            this.prod_name.Name = "prod_name";
            this.prod_name.Width = 125;
            // 
            // prod_amount
            // 
            this.prod_amount.HeaderText = "Price";
            this.prod_amount.MinimumWidth = 6;
            this.prod_amount.Name = "prod_amount";
            this.prod_amount.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reports_link,
            this.about_link,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.aPIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1860, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reports_link
            // 
            this.reports_link.Name = "reports_link";
            this.reports_link.Size = new System.Drawing.Size(74, 24);
            this.reports_link.Text = "Reports";
            this.reports_link.Click += new System.EventHandler(this.reports_link_Click);
            // 
            // about_link
            // 
            this.about_link.Name = "about_link";
            this.about_link.Size = new System.Drawing.Size(64, 24);
            this.about_link.Text = "About";
            this.about_link.Click += new System.EventHandler(this.about_link_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aPIToolStripMenuItem
            // 
            this.aPIToolStripMenuItem.Name = "aPIToolStripMenuItem";
            this.aPIToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.aPIToolStripMenuItem.Text = "API";
            this.aPIToolStripMenuItem.Click += new System.EventHandler(this.aPIToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.change_text);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cash_text);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.subtotal_text);
            this.panel1.Controls.Add(this.tax_text);
            this.panel1.Controls.Add(this.total_text);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.print_btn);
            this.panel1.Controls.Add(this.remove_btn);
            this.panel1.Controls.Add(this.pay_btn);
            this.panel1.Controls.Add(this.reset_btn);
            this.panel1.Controls.Add(this.one_btn);
            this.panel1.Controls.Add(this.two_btn);
            this.panel1.Controls.Add(this.three_btn);
            this.panel1.Controls.Add(this.four_btn);
            this.panel1.Controls.Add(this.five_btn);
            this.panel1.Controls.Add(this.six_btn);
            this.panel1.Controls.Add(this.seven_btn);
            this.panel1.Controls.Add(this.eight_btn);
            this.panel1.Controls.Add(this.nine_btn);
            this.panel1.Controls.Add(this.zero_btn);
            this.panel1.Controls.Add(this.period_btn);
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 495);
            this.panel1.TabIndex = 3;
            // 
            // change_text
            // 
            this.change_text.Enabled = false;
            this.change_text.Location = new System.Drawing.Point(293, 13);
            this.change_text.Name = "change_text";
            this.change_text.Size = new System.Drawing.Size(118, 27);
            this.change_text.TabIndex = 50;
            this.change_text.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 27);
            this.label5.TabIndex = 49;
            this.label5.Text = "CHANGE";
            // 
            // cash_text
            // 
            this.cash_text.Enabled = false;
            this.cash_text.Location = new System.Drawing.Point(74, 13);
            this.cash_text.Name = "cash_text";
            this.cash_text.Size = new System.Drawing.Size(118, 27);
            this.cash_text.TabIndex = 48;
            this.cash_text.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 27);
            this.label4.TabIndex = 47;
            this.label4.Text = "CASH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 46;
            this.label3.Text = "SUB TOTAL";
            // 
            // subtotal_text
            // 
            this.subtotal_text.Enabled = false;
            this.subtotal_text.Location = new System.Drawing.Point(142, 55);
            this.subtotal_text.Name = "subtotal_text";
            this.subtotal_text.Size = new System.Drawing.Size(273, 27);
            this.subtotal_text.TabIndex = 45;
            this.subtotal_text.Text = "";
            // 
            // tax_text
            // 
            this.tax_text.Enabled = false;
            this.tax_text.Location = new System.Drawing.Point(142, 88);
            this.tax_text.Name = "tax_text";
            this.tax_text.Size = new System.Drawing.Size(273, 27);
            this.tax_text.TabIndex = 44;
            this.tax_text.Text = "";
            // 
            // total_text
            // 
            this.total_text.Enabled = false;
            this.total_text.Location = new System.Drawing.Point(142, 121);
            this.total_text.Name = "total_text";
            this.total_text.Size = new System.Drawing.Size(273, 27);
            this.total_text.TabIndex = 43;
            this.total_text.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 41;
            this.label2.Text = "TOTAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "TAX";
            // 
            // print_btn
            // 
            this.print_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.Location = new System.Drawing.Point(3, 326);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(133, 80);
            this.print_btn.TabIndex = 40;
            this.print_btn.Text = "PRINT";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(3, 412);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(133, 80);
            this.remove_btn.TabIndex = 39;
            this.remove_btn.Text = "REMOVE";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // pay_btn
            // 
            this.pay_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.Location = new System.Drawing.Point(3, 154);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(133, 80);
            this.pay_btn.TabIndex = 38;
            this.pay_btn.Text = "PAY";
            this.pay_btn.UseVisualStyleBackColor = true;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Location = new System.Drawing.Point(3, 240);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(133, 80);
            this.reset_btn.TabIndex = 37;
            this.reset_btn.Text = "RESET";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // one_btn
            // 
            this.one_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one_btn.Location = new System.Drawing.Point(142, 154);
            this.one_btn.Name = "one_btn";
            this.one_btn.Size = new System.Drawing.Size(87, 80);
            this.one_btn.TabIndex = 35;
            this.one_btn.Text = "1";
            this.one_btn.UseVisualStyleBackColor = true;
            this.one_btn.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // two_btn
            // 
            this.two_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two_btn.Location = new System.Drawing.Point(235, 154);
            this.two_btn.Name = "two_btn";
            this.two_btn.Size = new System.Drawing.Size(87, 80);
            this.two_btn.TabIndex = 34;
            this.two_btn.Text = "2";
            this.two_btn.UseVisualStyleBackColor = true;
            this.two_btn.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // three_btn
            // 
            this.three_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three_btn.Location = new System.Drawing.Point(328, 154);
            this.three_btn.Name = "three_btn";
            this.three_btn.Size = new System.Drawing.Size(87, 80);
            this.three_btn.TabIndex = 33;
            this.three_btn.Text = "3";
            this.three_btn.UseVisualStyleBackColor = true;
            this.three_btn.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // four_btn
            // 
            this.four_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four_btn.Location = new System.Drawing.Point(142, 240);
            this.four_btn.Name = "four_btn";
            this.four_btn.Size = new System.Drawing.Size(87, 80);
            this.four_btn.TabIndex = 32;
            this.four_btn.Text = "4";
            this.four_btn.UseVisualStyleBackColor = true;
            this.four_btn.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // five_btn
            // 
            this.five_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five_btn.Location = new System.Drawing.Point(235, 240);
            this.five_btn.Name = "five_btn";
            this.five_btn.Size = new System.Drawing.Size(87, 80);
            this.five_btn.TabIndex = 31;
            this.five_btn.Text = "5";
            this.five_btn.UseVisualStyleBackColor = true;
            this.five_btn.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // six_btn
            // 
            this.six_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six_btn.Location = new System.Drawing.Point(328, 240);
            this.six_btn.Name = "six_btn";
            this.six_btn.Size = new System.Drawing.Size(87, 80);
            this.six_btn.TabIndex = 30;
            this.six_btn.Text = "6";
            this.six_btn.UseVisualStyleBackColor = true;
            this.six_btn.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // seven_btn
            // 
            this.seven_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven_btn.Location = new System.Drawing.Point(142, 326);
            this.seven_btn.Name = "seven_btn";
            this.seven_btn.Size = new System.Drawing.Size(87, 80);
            this.seven_btn.TabIndex = 29;
            this.seven_btn.Text = "7";
            this.seven_btn.UseVisualStyleBackColor = true;
            this.seven_btn.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // eight_btn
            // 
            this.eight_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight_btn.Location = new System.Drawing.Point(235, 326);
            this.eight_btn.Name = "eight_btn";
            this.eight_btn.Size = new System.Drawing.Size(87, 80);
            this.eight_btn.TabIndex = 28;
            this.eight_btn.Text = "8";
            this.eight_btn.UseVisualStyleBackColor = true;
            this.eight_btn.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // nine_btn
            // 
            this.nine_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine_btn.Location = new System.Drawing.Point(328, 326);
            this.nine_btn.Name = "nine_btn";
            this.nine_btn.Size = new System.Drawing.Size(87, 80);
            this.nine_btn.TabIndex = 27;
            this.nine_btn.Text = "9";
            this.nine_btn.UseVisualStyleBackColor = true;
            this.nine_btn.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // zero_btn
            // 
            this.zero_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero_btn.Location = new System.Drawing.Point(142, 412);
            this.zero_btn.Name = "zero_btn";
            this.zero_btn.Size = new System.Drawing.Size(87, 80);
            this.zero_btn.TabIndex = 26;
            this.zero_btn.Text = "0";
            this.zero_btn.UseVisualStyleBackColor = true;
            this.zero_btn.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // period_btn
            // 
            this.period_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_btn.Location = new System.Drawing.Point(235, 412);
            this.period_btn.Name = "period_btn";
            this.period_btn.Size = new System.Drawing.Size(87, 80);
            this.period_btn.TabIndex = 25;
            this.period_btn.Text = ".";
            this.period_btn.UseVisualStyleBackColor = true;
            this.period_btn.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(328, 412);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(87, 80);
            this.clear_btn.TabIndex = 0;
            this.clear_btn.Text = "CLR";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // itemchoice_list
            // 
            this.itemchoice_list.AllowUserToAddRows = false;
            this.itemchoice_list.AllowUserToDeleteRows = false;
            this.itemchoice_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemchoice_list.Location = new System.Drawing.Point(440, 38);
            this.itemchoice_list.Name = "itemchoice_list";
            this.itemchoice_list.ReadOnly = true;
            this.itemchoice_list.RowHeadersWidth = 51;
            this.itemchoice_list.RowTemplate.Height = 24;
            this.itemchoice_list.Size = new System.Drawing.Size(431, 495);
            this.itemchoice_list.TabIndex = 4;
            // 
            // reg_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1860, 545);
            this.Controls.Add(this.itemchoice_list);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.item_list_view);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "reg_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.reg_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.item_list_view)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemchoice_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView item_list_view;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reports_link;
        private System.Windows.Forms.ToolStripMenuItem about_link;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button one_btn;
        private System.Windows.Forms.Button two_btn;
        private System.Windows.Forms.Button three_btn;
        private System.Windows.Forms.Button four_btn;
        private System.Windows.Forms.Button five_btn;
        private System.Windows.Forms.Button six_btn;
        private System.Windows.Forms.Button seven_btn;
        private System.Windows.Forms.Button eight_btn;
        private System.Windows.Forms.Button nine_btn;
        private System.Windows.Forms.Button zero_btn;
        private System.Windows.Forms.Button period_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox total_text;
        private System.Windows.Forms.RichTextBox tax_text;
        private System.Windows.Forms.RichTextBox change_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox cash_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox subtotal_text;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView itemchoice_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_amount;
        private System.Windows.Forms.ToolStripMenuItem aPIToolStripMenuItem;
    }
}