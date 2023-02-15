
namespace Z_Book.UserControls
{
    partial class uc_shipping_add_product
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_nhanvien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clear_all = new Guna.UI2.WinForms.Guna2Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_noixuat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_noinhan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maphieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 88;
            this.label5.Text = "Nhân viên";
            // 
            // cbo_nhanvien
            // 
            this.cbo_nhanvien.BackColor = System.Drawing.Color.Transparent;
            this.cbo_nhanvien.BorderRadius = 15;
            this.cbo_nhanvien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_nhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nhanvien.Enabled = false;
            this.cbo_nhanvien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_nhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_nhanvien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_nhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_nhanvien.ItemHeight = 30;
            this.cbo_nhanvien.Items.AddRange(new object[] {
            ""});
            this.cbo_nhanvien.Location = new System.Drawing.Point(153, 130);
            this.cbo_nhanvien.Name = "cbo_nhanvien";
            this.cbo_nhanvien.Size = new System.Drawing.Size(191, 36);
            this.cbo_nhanvien.TabIndex = 86;
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
            this.btn_save.Location = new System.Drawing.Point(173, 290);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(72, 34);
            this.btn_save.TabIndex = 82;
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
            this.btn_clear_all.Location = new System.Drawing.Point(251, 290);
            this.btn_clear_all.Name = "btn_clear_all";
            this.btn_clear_all.Size = new System.Drawing.Size(93, 34);
            this.btn_clear_all.TabIndex = 83;
            this.btn_clear_all.Text = "Xóa";
            this.btn_clear_all.Click += new System.EventHandler(this.btn_clear_all_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(101, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 23);
            this.label11.TabIndex = 81;
            this.label11.Text = "Thêm phiếu chuyển";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 90;
            this.label1.Text = "Nơi xuất";
            // 
            // cbo_noixuat
            // 
            this.cbo_noixuat.BackColor = System.Drawing.Color.Transparent;
            this.cbo_noixuat.BorderRadius = 15;
            this.cbo_noixuat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_noixuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_noixuat.Enabled = false;
            this.cbo_noixuat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_noixuat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_noixuat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_noixuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_noixuat.ItemHeight = 30;
            this.cbo_noixuat.Items.AddRange(new object[] {
            ""});
            this.cbo_noixuat.Location = new System.Drawing.Point(153, 177);
            this.cbo_noixuat.Name = "cbo_noixuat";
            this.cbo_noixuat.Size = new System.Drawing.Size(191, 36);
            this.cbo_noixuat.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 92;
            this.label2.Text = "Nơi nhận";
            // 
            // cbo_noinhan
            // 
            this.cbo_noinhan.BackColor = System.Drawing.Color.Transparent;
            this.cbo_noinhan.BorderRadius = 15;
            this.cbo_noinhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_noinhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_noinhan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_noinhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_noinhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_noinhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_noinhan.ItemHeight = 30;
            this.cbo_noinhan.Items.AddRange(new object[] {
            ""});
            this.cbo_noinhan.Location = new System.Drawing.Point(153, 227);
            this.cbo_noinhan.Name = "cbo_noinhan";
            this.cbo_noinhan.Size = new System.Drawing.Size(191, 36);
            this.cbo_noinhan.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 96;
            this.label4.Text = "Mã phiếu";
            // 
            // txt_maphieu
            // 
            this.txt_maphieu.BorderRadius = 15;
            this.txt_maphieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maphieu.DefaultText = "";
            this.txt_maphieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maphieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maphieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maphieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maphieu.Enabled = false;
            this.txt_maphieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maphieu.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maphieu.ForeColor = System.Drawing.Color.Black;
            this.txt_maphieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maphieu.Location = new System.Drawing.Point(153, 80);
            this.txt_maphieu.Name = "txt_maphieu";
            this.txt_maphieu.PasswordChar = '\0';
            this.txt_maphieu.PlaceholderText = "Mã phiếu";
            this.txt_maphieu.SelectedText = "";
            this.txt_maphieu.Size = new System.Drawing.Size(191, 36);
            this.txt_maphieu.TabIndex = 95;
            // 
            // uc_shipping_add_product
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_maphieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_noinhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_noixuat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_nhanvien);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear_all);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_shipping_add_product";
            this.Size = new System.Drawing.Size(380, 350);
            this.Load += new System.EventHandler(this.uc_shipping_add_product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_nhanvien;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2Button btn_clear_all;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_noixuat;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_noinhan;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_maphieu;
    }
}
