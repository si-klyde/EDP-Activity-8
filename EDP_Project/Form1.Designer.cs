namespace EDP_Project
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sign_in_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recover_link = new System.Windows.Forms.LinkLabel();
            this.key_text = new System.Windows.Forms.TextBox();
            this.pass_field = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.TextBox();
            this.id_field = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.sign_in_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.recover_link);
            this.panel1.Controls.Add(this.key_text);
            this.panel1.Controls.Add(this.pass_field);
            this.panel1.Controls.Add(this.id_text);
            this.panel1.Controls.Add(this.id_field);
            this.panel1.Location = new System.Drawing.Point(214, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 426);
            this.panel1.TabIndex = 0;
            // 
            // sign_in_btn
            // 
            this.sign_in_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_btn.Location = new System.Drawing.Point(56, 342);
            this.sign_in_btn.Name = "sign_in_btn";
            this.sign_in_btn.Size = new System.Drawing.Size(289, 35);
            this.sign_in_btn.TabIndex = 6;
            this.sign_in_btn.Text = "SIGN IN";
            this.sign_in_btn.UseVisualStyleBackColor = true;
            this.sign_in_btn.Click += new System.EventHandler(this.sign_in_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // recover_link
            // 
            this.recover_link.AutoSize = true;
            this.recover_link.Location = new System.Drawing.Point(84, 305);
            this.recover_link.Name = "recover_link";
            this.recover_link.Size = new System.Drawing.Size(238, 16);
            this.recover_link.TabIndex = 4;
            this.recover_link.TabStop = true;
            this.recover_link.Text = "Have you forgotten your key? Click me!";
            // 
            // key_text
            // 
            this.key_text.Location = new System.Drawing.Point(110, 264);
            this.key_text.Name = "key_text";
            this.key_text.PasswordChar = '*';
            this.key_text.Size = new System.Drawing.Size(236, 22);
            this.key_text.TabIndex = 3;
            // 
            // pass_field
            // 
            this.pass_field.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pass_field.AutoSize = true;
            this.pass_field.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_field.ForeColor = System.Drawing.Color.White;
            this.pass_field.Location = new System.Drawing.Point(54, 262);
            this.pass_field.Name = "pass_field";
            this.pass_field.Size = new System.Drawing.Size(50, 24);
            this.pass_field.TabIndex = 2;
            this.pass_field.Text = "KEY";
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(110, 222);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(236, 22);
            this.id_text.TabIndex = 1;
            // 
            // id_field
            // 
            this.id_field.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.id_field.AutoSize = true;
            this.id_field.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_field.ForeColor = System.Drawing.Color.White;
            this.id_field.Location = new System.Drawing.Point(75, 222);
            this.id_field.Name = "id_field";
            this.id_field.Size = new System.Drawing.Size(29, 24);
            this.id_field.TabIndex = 0;
            this.id_field.Text = "ID";
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Access";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label id_field;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.TextBox key_text;
        private System.Windows.Forms.Label pass_field;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel recover_link;
        private System.Windows.Forms.Button sign_in_btn;
    }
}

