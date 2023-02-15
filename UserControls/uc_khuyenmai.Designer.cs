
namespace Z_Book.UserControls
{
    partial class uc_khuyenmai
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_taokhuyenmai = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_ngaydau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_ngaycuoi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_money = new System.Windows.Forms.Label();
            this.sw_tiền = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txt_khuyenmai = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_luu = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txt_tien_cuoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tien_dau = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btn_taokhuyenmai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 60);
            this.panel2.TabIndex = 5;
            // 
            // btn_taokhuyenmai
            // 
            this.btn_taokhuyenmai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_taokhuyenmai.BorderRadius = 5;
            this.btn_taokhuyenmai.BorderThickness = 1;
            this.btn_taokhuyenmai.CheckedState.FillColor = System.Drawing.Color.DarkGreen;
            this.btn_taokhuyenmai.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_taokhuyenmai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_taokhuyenmai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_taokhuyenmai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_taokhuyenmai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_taokhuyenmai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_taokhuyenmai.FillColor = System.Drawing.Color.Green;
            this.btn_taokhuyenmai.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taokhuyenmai.ForeColor = System.Drawing.Color.White;
            this.btn_taokhuyenmai.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_taokhuyenmai.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_taokhuyenmai.Image = global::Z_Book.Properties.Resources.icons8_Gift_24px;
            this.btn_taokhuyenmai.ImageSize = new System.Drawing.Size(36, 36);
            this.btn_taokhuyenmai.Location = new System.Drawing.Point(14, 10);
            this.btn_taokhuyenmai.Name = "btn_taokhuyenmai";
            this.btn_taokhuyenmai.Size = new System.Drawing.Size(282, 40);
            this.btn_taokhuyenmai.TabIndex = 58;
            this.btn_taokhuyenmai.Text = "Tạo khuyến mãi";
            this.btn_taokhuyenmai.Click += new System.EventHandler(this.btn_taokhuyenmai_Click);
            // 
            // dtp_ngaydau
            // 
            this.dtp_ngaydau.Animated = true;
            this.dtp_ngaydau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dtp_ngaydau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtp_ngaydau.BorderRadius = 15;
            this.dtp_ngaydau.BorderThickness = 2;
            this.dtp_ngaydau.Checked = true;
            this.dtp_ngaydau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_ngaydau.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaydau.Enabled = false;
            this.dtp_ngaydau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dtp_ngaydau.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtp_ngaydau.ForeColor = System.Drawing.Color.Black;
            this.dtp_ngaydau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaydau.Location = new System.Drawing.Point(97, 40);
            this.dtp_ngaydau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngaydau.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_ngaydau.Name = "dtp_ngaydau";
            this.dtp_ngaydau.Size = new System.Drawing.Size(191, 36);
            this.dtp_ngaydau.TabIndex = 87;
            this.dtp_ngaydau.Value = new System.DateTime(2022, 11, 8, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 86;
            this.label6.Text = "Từ ngày";
            // 
            // dtp_ngaycuoi
            // 
            this.dtp_ngaycuoi.Animated = true;
            this.dtp_ngaycuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dtp_ngaycuoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtp_ngaycuoi.BorderRadius = 15;
            this.dtp_ngaycuoi.BorderThickness = 2;
            this.dtp_ngaycuoi.Checked = true;
            this.dtp_ngaycuoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_ngaycuoi.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaycuoi.Enabled = false;
            this.dtp_ngaycuoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dtp_ngaycuoi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtp_ngaycuoi.ForeColor = System.Drawing.Color.Black;
            this.dtp_ngaycuoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaycuoi.Location = new System.Drawing.Point(414, 40);
            this.dtp_ngaycuoi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngaycuoi.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_ngaycuoi.Name = "dtp_ngaycuoi";
            this.dtp_ngaycuoi.Size = new System.Drawing.Size(191, 36);
            this.dtp_ngaycuoi.TabIndex = 89;
            this.dtp_ngaycuoi.Value = new System.DateTime(2022, 11, 8, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 88;
            this.label1.Text = "Đến ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_money);
            this.groupBox1.Controls.Add(this.sw_tiền);
            this.groupBox1.Controls.Add(this.txt_khuyenmai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.guna2CirclePictureBox1);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.txt_tien_cuoi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_tien_dau);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(30, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 157);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Áp dụng với HÓA ĐƠN";
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_money.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_money.Location = new System.Drawing.Point(522, 107);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(18, 19);
            this.lbl_money.TabIndex = 108;
            this.lbl_money.Text = "$";
            // 
            // sw_tiền
            // 
            this.sw_tiền.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sw_tiền.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sw_tiền.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.sw_tiền.CheckedState.InnerColor = System.Drawing.Color.White;
            this.sw_tiền.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_tiền.Location = new System.Drawing.Point(481, 106);
            this.sw_tiền.Name = "sw_tiền";
            this.sw_tiền.Size = new System.Drawing.Size(35, 20);
            this.sw_tiền.TabIndex = 107;
            this.sw_tiền.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sw_tiền.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sw_tiền.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.sw_tiền.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.sw_tiền.CheckedChanged += new System.EventHandler(this.sw_tiền_CheckedChanged);
            // 
            // txt_khuyenmai
            // 
            this.txt_khuyenmai.BorderRadius = 15;
            this.txt_khuyenmai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_khuyenmai.DefaultText = "";
            this.txt_khuyenmai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_khuyenmai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_khuyenmai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_khuyenmai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_khuyenmai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_khuyenmai.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khuyenmai.ForeColor = System.Drawing.Color.Black;
            this.txt_khuyenmai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_khuyenmai.Location = new System.Drawing.Point(203, 98);
            this.txt_khuyenmai.Name = "txt_khuyenmai";
            this.txt_khuyenmai.PasswordChar = '\0';
            this.txt_khuyenmai.PlaceholderText = "Tổng tiền ";
            this.txt_khuyenmai.SelectedText = "";
            this.txt_khuyenmai.Size = new System.Drawing.Size(257, 36);
            this.txt_khuyenmai.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(105, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 105;
            this.label3.Text = "Khuyến mãi";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Z_Book.Properties.Resources.icons8_Gift_24px;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(62, 101);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(37, 31);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 104;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BorderColor = System.Drawing.Color.Maroon;
            this.btn_xoa.BorderThickness = 1;
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoa.FillColor = System.Drawing.Color.White;
            this.btn_xoa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_xoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.btn_xoa.Image = global::Z_Book.Properties.Resources.icons8_close_36px;
            this.btn_xoa.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_xoa.Location = new System.Drawing.Point(646, 38);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_xoa.Size = new System.Drawing.Size(40, 40);
            this.btn_xoa.TabIndex = 103;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_luu.BorderThickness = 1;
            this.btn_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_luu.FillColor = System.Drawing.Color.White;
            this.btn_luu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_luu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_luu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.btn_luu.Image = global::Z_Book.Properties.Resources.icons8_save_36px;
            this.btn_luu.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_luu.Location = new System.Drawing.Point(577, 41);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_luu.Size = new System.Drawing.Size(40, 40);
            this.btn_luu.TabIndex = 102;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_tien_cuoi
            // 
            this.txt_tien_cuoi.BorderRadius = 15;
            this.txt_tien_cuoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tien_cuoi.DefaultText = "";
            this.txt_tien_cuoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tien_cuoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tien_cuoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tien_cuoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tien_cuoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tien_cuoi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tien_cuoi.ForeColor = System.Drawing.Color.Black;
            this.txt_tien_cuoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tien_cuoi.Location = new System.Drawing.Point(356, 45);
            this.txt_tien_cuoi.Name = "txt_tien_cuoi";
            this.txt_tien_cuoi.PasswordChar = '\0';
            this.txt_tien_cuoi.PlaceholderText = "Tổng tiền ";
            this.txt_tien_cuoi.SelectedText = "";
            this.txt_tien_cuoi.Size = new System.Drawing.Size(191, 36);
            this.txt_tien_cuoi.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(297, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "Đến";
            // 
            // txt_tien_dau
            // 
            this.txt_tien_dau.BorderRadius = 15;
            this.txt_tien_dau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tien_dau.DefaultText = "";
            this.txt_tien_dau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tien_dau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tien_dau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tien_dau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tien_dau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tien_dau.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tien_dau.ForeColor = System.Drawing.Color.Black;
            this.txt_tien_dau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tien_dau.Location = new System.Drawing.Point(62, 45);
            this.txt_tien_dau.Name = "txt_tien_dau";
            this.txt_tien_dau.PasswordChar = '\0';
            this.txt_tien_dau.PlaceholderText = "Tổng tiền ";
            this.txt_tien_dau.SelectedText = "";
            this.txt_tien_dau.Size = new System.Drawing.Size(191, 36);
            this.txt_tien_dau.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 99;
            this.label5.Text = "Từ";
            // 
            // uc_khuyenmai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtp_ngaycuoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_ngaydau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_khuyenmai";
            this.Size = new System.Drawing.Size(848, 477);
            this.Load += new System.EventHandler(this.uc_khuyenmai_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_taokhuyenmai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngaydau;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngaycuoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_tien_cuoi;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_tien_dau;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CircleButton btn_luu;
        private Guna.UI2.WinForms.Guna2CircleButton btn_xoa;
        private Guna.UI2.WinForms.Guna2TextBox txt_khuyenmai;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lbl_money;
        private Guna.UI2.WinForms.Guna2ToggleSwitch sw_tiền;
    }
}
