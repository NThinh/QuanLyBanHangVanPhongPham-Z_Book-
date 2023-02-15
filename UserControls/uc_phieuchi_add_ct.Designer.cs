
namespace Z_Book.UserControls
{
    partial class uc_phieuchi_add_ct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.txt_gia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soluong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_noidung = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clear_all = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(45, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 108;
            this.label6.Text = "Giá";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_gia
            // 
            this.txt_gia.BackColor = System.Drawing.Color.Transparent;
            this.txt_gia.BorderColor = System.Drawing.Color.Silver;
            this.txt_gia.BorderRadius = 15;
            this.txt_gia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gia.DefaultText = "";
            this.txt_gia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_gia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_gia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gia.ForeColor = System.Drawing.Color.Black;
            this.txt_gia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gia.Location = new System.Drawing.Point(137, 165);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.PasswordChar = '\0';
            this.txt_gia.PlaceholderText = "Giá";
            this.txt_gia.SelectedText = "";
            this.txt_gia.Size = new System.Drawing.Size(218, 36);
            this.txt_gia.TabIndex = 105;
            this.txt_gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 107;
            this.label4.Text = "Số lượng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_soluong
            // 
            this.txt_soluong.BackColor = System.Drawing.Color.Transparent;
            this.txt_soluong.BorderColor = System.Drawing.Color.Silver;
            this.txt_soluong.BorderRadius = 15;
            this.txt_soluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soluong.DefaultText = "";
            this.txt_soluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_soluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_soluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soluong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soluong.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.ForeColor = System.Drawing.Color.Black;
            this.txt_soluong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soluong.Location = new System.Drawing.Point(137, 123);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.PasswordChar = '\0';
            this.txt_soluong.PlaceholderText = "Số lượng";
            this.txt_soluong.SelectedText = "";
            this.txt_soluong.Size = new System.Drawing.Size(218, 36);
            this.txt_soluong.TabIndex = 104;
            this.txt_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 106;
            this.label1.Text = "Nội dung";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_noidung
            // 
            this.txt_noidung.BackColor = System.Drawing.Color.Transparent;
            this.txt_noidung.BorderColor = System.Drawing.Color.Silver;
            this.txt_noidung.BorderRadius = 15;
            this.txt_noidung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_noidung.DefaultText = "";
            this.txt_noidung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_noidung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_noidung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_noidung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_noidung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_noidung.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_noidung.ForeColor = System.Drawing.Color.Black;
            this.txt_noidung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_noidung.Location = new System.Drawing.Point(137, 54);
            this.txt_noidung.Multiline = true;
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.PasswordChar = '\0';
            this.txt_noidung.PlaceholderText = "Nội dung";
            this.txt_noidung.SelectedText = "";
            this.txt_noidung.Size = new System.Drawing.Size(218, 63);
            this.txt_noidung.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(100, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 19);
            this.label2.TabIndex = 111;
            this.label2.Text = "Thêm chi tiết phiếu chi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btn_save.BorderRadius = 5;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(169, 221);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(72, 34);
            this.btn_save.TabIndex = 112;
            this.btn_save.Text = "Lưu";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear_all
            // 
            this.btn_clear_all.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_clear_all.BorderRadius = 5;
            this.btn_clear_all.BorderThickness = 1;
            this.btn_clear_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear_all.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear_all.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear_all.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear_all.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear_all.FillColor = System.Drawing.Color.White;
            this.btn_clear_all.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_clear_all.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.btn_clear_all.Location = new System.Drawing.Point(247, 221);
            this.btn_clear_all.Name = "btn_clear_all";
            this.btn_clear_all.Size = new System.Drawing.Size(105, 34);
            this.btn_clear_all.TabIndex = 113;
            this.btn_clear_all.Text = "Xóa tất cả";
            this.btn_clear_all.Click += new System.EventHandler(this.btn_clear_all_Click);
            // 
            // uc_phieuchi_add_ct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear_all);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_noidung);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_phieuchi_add_ct";
            this.Size = new System.Drawing.Size(400, 300);
            this.Load += new System.EventHandler(this.uc_phieuchi_add_ct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_gia;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_soluong;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_noidung;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2Button btn_clear_all;
    }
}
