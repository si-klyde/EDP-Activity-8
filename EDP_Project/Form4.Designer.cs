namespace EDP_Project
{
    partial class reports_form
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
            this.report_list_view = new System.Windows.Forms.DataGridView();
            this.return_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.item_combo_box = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.report_list_view)).BeginInit();
            this.SuspendLayout();
            // 
            // report_list_view
            // 
            this.report_list_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.report_list_view.Location = new System.Drawing.Point(247, 12);
            this.report_list_view.Name = "report_list_view";
            this.report_list_view.RowHeadersWidth = 51;
            this.report_list_view.RowTemplate.Height = 24;
            this.report_list_view.Size = new System.Drawing.Size(541, 426);
            this.report_list_view.TabIndex = 0;
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(12, 12);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(229, 49);
            this.return_btn.TabIndex = 1;
            this.return_btn.Text = "RETURN";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(12, 67);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(229, 49);
            this.print_btn.TabIndex = 2;
            this.print_btn.Text = "PRINT";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // item_combo_box
            // 
            this.item_combo_box.FormattingEnabled = true;
            this.item_combo_box.Items.AddRange(new object[] {
            "branches",
            "employees",
            "products",
            "registers",
            "sales",
            "transaction_table"});
            this.item_combo_box.Location = new System.Drawing.Point(12, 122);
            this.item_combo_box.Name = "item_combo_box";
            this.item_combo_box.Size = new System.Drawing.Size(229, 24);
            this.item_combo_box.TabIndex = 3;
            this.item_combo_box.SelectedIndexChanged += new System.EventHandler(this.item_combo_box_SelectedIndexChanged);
            // 
            // reports_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.item_combo_box);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.report_list_view);
            this.Name = "reports_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.report_list_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView report_list_view;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.ComboBox item_combo_box;
    }
}