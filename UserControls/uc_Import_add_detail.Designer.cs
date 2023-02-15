
namespace Z_Book.UserControls
{
    partial class uc_Import_add_detail
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
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_gianhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_soluog = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbo_sanpham = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_clear_all = new Guna.UI2.WinForms.Guna2Button();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(117, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 23);
            this.label11.TabIndex = 34;
            this.label11.Text = "Thêm sản phẩm";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 78;
            this.label2.Text = "Giá nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "Số lượng";
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.BorderRadius = 15;
            this.txt_gianhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gianhap.DefaultText = "";
            this.txt_gianhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_gianhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_gianhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gianhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gianhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gianhap.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gianhap.ForeColor = System.Drawing.Color.Black;
            this.txt_gianhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gianhap.Location = new System.Drawing.Point(156, 179);
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.PasswordChar = '\0';
            this.txt_gianhap.PlaceholderText = "Giá nhập";
            this.txt_gianhap.SelectedText = "";
            this.txt_gianhap.Size = new System.Drawing.Size(191, 36);
            this.txt_gianhap.TabIndex = 75;
            this.txt_gianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gianhap_KeyPress);
            // 
            // txt_soluog
            // 
            this.txt_soluog.BorderRadius = 15;
            this.txt_soluog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soluog.DefaultText = "";
            this.txt_soluog.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_soluog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_soluog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soluog.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soluog.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soluog.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluog.ForeColor = System.Drawing.Color.Black;
            this.txt_soluog.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soluog.Location = new System.Drawing.Point(156, 134);
            this.txt_soluog.Name = "txt_soluog";
            this.txt_soluog.PasswordChar = '\0';
            this.txt_soluog.PlaceholderText = "Số lượng";
            this.txt_soluog.SelectedText = "";
            this.txt_soluog.Size = new System.Drawing.Size(191, 36);
            this.txt_soluog.TabIndex = 76;
            this.txt_soluog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluog_KeyPress);
            // 
            // cbo_sanpham
            // 
            this.cbo_sanpham.BackColor = System.Drawing.Color.Transparent;
            this.cbo_sanpham.BorderRadius = 15;
            this.cbo_sanpham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_sanpham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sanpham.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_sanpham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_sanpham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_sanpham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_sanpham.ItemHeight = 30;
            this.cbo_sanpham.Items.AddRange(new object[] {
            ""});
            this.cbo_sanpham.Location = new System.Drawing.Point(156, 89);
            this.cbo_sanpham.Name = "cbo_sanpham";
            this.cbo_sanpham.Size = new System.Drawing.Size(191, 36);
            this.cbo_sanpham.TabIndex = 77;
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
            this.btn_clear_all.Location = new System.Drawing.Point(242, 250);
            this.btn_clear_all.Name = "btn_clear_all";
            this.btn_clear_all.Size = new System.Drawing.Size(105, 34);
            this.btn_clear_all.TabIndex = 39;
            this.btn_clear_all.Text = "Xóa tất cả";
            this.btn_clear_all.Click += new System.EventHandler(this.btn_clear_all_Click);
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
            this.btn_save.Location = new System.Drawing.Point(164, 250);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(72, 34);
            this.btn_save.TabIndex = 38;
            this.btn_save.Text = "Lưu";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // uc_Import_add_detail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_gianhap);
            this.Controls.Add(this.txt_soluog);
            this.Controls.Add(this.cbo_sanpham);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear_all);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_Import_add_detail";
            this.Size = new System.Drawing.Size(380, 320);
            this.Load += new System.EventHandler(this.uc_Import_add_detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_gianhap;
        private Guna.UI2.WinForms.Guna2TextBox txt_soluog;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_sanpham;
        private Guna.UI2.WinForms.Guna2Button btn_clear_all;
        private Guna.UI2.WinForms.Guna2Button btn_save;
    }
}
