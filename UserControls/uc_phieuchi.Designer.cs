
namespace Z_Book.UserControls
{
    partial class uc_phieuchi
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_detail = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_them_phieuchi = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_tim_kiem = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_ngay_cuoi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_ngay_dau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbo_tim_kiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_chitieu_month = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_chitieu_year = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_chitieu_day = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgv_phieuchi = new System.Windows.Forms.DataGridView();
            this.MA_PHIEUCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHANVIEN = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHINHANH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuchi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.btn_detail);
            this.panel1.Controls.Add(this.btn_them_phieuchi);
            this.panel1.Controls.Add(this.btn_tim_kiem);
            this.panel1.Controls.Add(this.dtp_ngay_cuoi);
            this.panel1.Controls.Add(this.dtp_ngay_dau);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.cbo_tim_kiem);
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 70);
            this.panel1.TabIndex = 5;
            // 
            // btn_detail
            // 
            this.btn_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_detail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_detail.BorderThickness = 1;
            this.btn_detail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_detail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_detail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_detail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_detail.FillColor = System.Drawing.Color.White;
            this.btn_detail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_detail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_detail.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.btn_detail.Image = global::Z_Book.Properties.Resources.icons8_edit_property_24px;
            this.btn_detail.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_detail.Location = new System.Drawing.Point(763, 13);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_detail.Size = new System.Drawing.Size(32, 32);
            this.btn_detail.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btn_detail, "Xem chi tiết");
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // btn_them_phieuchi
            // 
            this.btn_them_phieuchi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_them_phieuchi.BorderColor = System.Drawing.Color.Green;
            this.btn_them_phieuchi.BorderThickness = 1;
            this.btn_them_phieuchi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_them_phieuchi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them_phieuchi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them_phieuchi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them_phieuchi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them_phieuchi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them_phieuchi.FillColor = System.Drawing.Color.White;
            this.btn_them_phieuchi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_them_phieuchi.ForeColor = System.Drawing.Color.Green;
            this.btn_them_phieuchi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_them_phieuchi.Image = global::Z_Book.Properties.Resources.icons8_add_36px;
            this.btn_them_phieuchi.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_them_phieuchi.Location = new System.Drawing.Point(725, 13);
            this.btn_them_phieuchi.Name = "btn_them_phieuchi";
            this.btn_them_phieuchi.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_them_phieuchi.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_them_phieuchi.Size = new System.Drawing.Size(32, 32);
            this.btn_them_phieuchi.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btn_them_phieuchi, "Thêm phiếu chi");
            this.btn_them_phieuchi.Click += new System.EventHandler(this.btn_them_phieuchi_Click);
            // 
            // btn_tim_kiem
            // 
            this.btn_tim_kiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_tim_kiem.BorderRadius = 5;
            this.btn_tim_kiem.BorderThickness = 1;
            this.btn_tim_kiem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btn_tim_kiem.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_tim_kiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tim_kiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tim_kiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tim_kiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tim_kiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tim_kiem.FillColor = System.Drawing.Color.White;
            this.btn_tim_kiem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim_kiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_tim_kiem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.btn_tim_kiem.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_tim_kiem.Location = new System.Drawing.Point(481, 11);
            this.btn_tim_kiem.Name = "btn_tim_kiem";
            this.btn_tim_kiem.Size = new System.Drawing.Size(91, 36);
            this.btn_tim_kiem.TabIndex = 26;
            this.btn_tim_kiem.Text = "Tìm kiếm";
            this.btn_tim_kiem.Visible = false;
            this.btn_tim_kiem.Click += new System.EventHandler(this.btn_tim_kiem_Click);
            // 
            // dtp_ngay_cuoi
            // 
            this.dtp_ngay_cuoi.Animated = true;
            this.dtp_ngay_cuoi.BackColor = System.Drawing.Color.Transparent;
            this.dtp_ngay_cuoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.dtp_ngay_cuoi.BorderRadius = 2;
            this.dtp_ngay_cuoi.BorderThickness = 2;
            this.dtp_ngay_cuoi.Checked = true;
            this.dtp_ngay_cuoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_ngay_cuoi.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngay_cuoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.dtp_ngay_cuoi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtp_ngay_cuoi.ForeColor = System.Drawing.Color.White;
            this.dtp_ngay_cuoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngay_cuoi.Location = new System.Drawing.Point(308, 11);
            this.dtp_ngay_cuoi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngay_cuoi.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_ngay_cuoi.Name = "dtp_ngay_cuoi";
            this.dtp_ngay_cuoi.Size = new System.Drawing.Size(156, 36);
            this.dtp_ngay_cuoi.TabIndex = 24;
            this.dtp_ngay_cuoi.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            this.dtp_ngay_cuoi.Visible = false;
            // 
            // dtp_ngay_dau
            // 
            this.dtp_ngay_dau.Animated = true;
            this.dtp_ngay_dau.BackColor = System.Drawing.Color.Transparent;
            this.dtp_ngay_dau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.dtp_ngay_dau.BorderRadius = 2;
            this.dtp_ngay_dau.BorderThickness = 2;
            this.dtp_ngay_dau.Checked = true;
            this.dtp_ngay_dau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_ngay_dau.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngay_dau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.dtp_ngay_dau.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtp_ngay_dau.ForeColor = System.Drawing.Color.White;
            this.dtp_ngay_dau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngay_dau.Location = new System.Drawing.Point(146, 11);
            this.dtp_ngay_dau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngay_dau.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_ngay_dau.Name = "dtp_ngay_dau";
            this.dtp_ngay_dau.Size = new System.Drawing.Size(156, 36);
            this.dtp_ngay_dau.TabIndex = 25;
            this.dtp_ngay_dau.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            this.dtp_ngay_dau.Visible = false;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.Transparent;
            this.txt_search.BorderColor = System.Drawing.Color.Empty;
            this.txt_search.BorderRadius = 15;
            this.txt_search.BorderThickness = 0;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.Black;
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.txt_search.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txt_search.IconRight = global::Z_Book.Properties.Resources.icons8_search_25px_1;
            this.txt_search.Location = new System.Drawing.Point(146, 11);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_search.PlaceholderText = "Tìm kiếm";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(318, 36);
            this.txt_search.TabIndex = 19;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged_1);
            // 
            // cbo_tim_kiem
            // 
            this.cbo_tim_kiem.BackColor = System.Drawing.Color.Transparent;
            this.cbo_tim_kiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.cbo_tim_kiem.BorderRadius = 5;
            this.cbo_tim_kiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_tim_kiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_tim_kiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tim_kiem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_tim_kiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_tim_kiem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tim_kiem.ForeColor = System.Drawing.Color.Black;
            this.cbo_tim_kiem.ItemHeight = 30;
            this.cbo_tim_kiem.Items.AddRange(new object[] {
            "Theo mã",
            "Theo ngày",
            "Theo nội dung"});
            this.cbo_tim_kiem.Location = new System.Drawing.Point(14, 11);
            this.cbo_tim_kiem.Name = "cbo_tim_kiem";
            this.cbo_tim_kiem.Size = new System.Drawing.Size(122, 36);
            this.cbo_tim_kiem.StartIndex = 0;
            this.cbo_tim_kiem.TabIndex = 17;
            this.cbo_tim_kiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbo_tim_kiem.SelectedIndexChanged += new System.EventHandler(this.cbo_tim_kiem_SelectedIndexChanged);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BorderColor = System.Drawing.Color.White;
            this.btnExportExcel.BorderThickness = 1;
            this.btnExportExcel.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(222)))), ((int)(((byte)(0)))));
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExportExcel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.ForeColor = System.Drawing.Color.Green;
            this.btnExportExcel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnExportExcel.Image = global::Z_Book.Properties.Resources.icons8_download_24px;
            this.btnExportExcel.Location = new System.Drawing.Point(801, 13);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExportExcel.Size = new System.Drawing.Size(32, 32);
            this.btnExportExcel.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnExportExcel, "Xuất file Excel");
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.panel5);
            this.guna2ShadowPanel1.Controls.Add(this.panel6);
            this.guna2ShadowPanel1.Controls.Add(this.panel4);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 397);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(848, 80);
            this.guna2ShadowPanel1.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel5.BackgroundImage = global::Z_Book.Properties.Resources.imgVuong;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.lbl_chitieu_month);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(282, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 70);
            this.panel5.TabIndex = 6;
            // 
            // lbl_chitieu_month
            // 
            this.lbl_chitieu_month.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_chitieu_month.AutoSize = true;
            this.lbl_chitieu_month.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chitieu_month.ForeColor = System.Drawing.Color.Green;
            this.lbl_chitieu_month.Location = new System.Drawing.Point(138, 25);
            this.lbl_chitieu_month.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbl_chitieu_month.Name = "lbl_chitieu_month";
            this.lbl_chitieu_month.Size = new System.Drawing.Size(100, 18);
            this.lbl_chitieu_month.TabIndex = 3;
            this.lbl_chitieu_month.Text = "0,000";
            this.lbl_chitieu_month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(55, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chi tiêu\r\ntrong tháng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel6.BackgroundImage = global::Z_Book.Properties.Resources.imgVuong;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.lbl_chitieu_year);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(566, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(282, 70);
            this.panel6.TabIndex = 5;
            // 
            // lbl_chitieu_year
            // 
            this.lbl_chitieu_year.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_chitieu_year.AutoSize = true;
            this.lbl_chitieu_year.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chitieu_year.ForeColor = System.Drawing.Color.Green;
            this.lbl_chitieu_year.Location = new System.Drawing.Point(132, 25);
            this.lbl_chitieu_year.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbl_chitieu_year.Name = "lbl_chitieu_year";
            this.lbl_chitieu_year.Size = new System.Drawing.Size(100, 18);
            this.lbl_chitieu_year.TabIndex = 3;
            this.lbl_chitieu_year.Text = "0,000";
            this.lbl_chitieu_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(54, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chi tiêu\r\ntrong năm";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel4.BackgroundImage = global::Z_Book.Properties.Resources.imgVuong;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.lbl_chitieu_day);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 70);
            this.panel4.TabIndex = 4;
            // 
            // lbl_chitieu_day
            // 
            this.lbl_chitieu_day.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_chitieu_day.AutoSize = true;
            this.lbl_chitieu_day.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chitieu_day.ForeColor = System.Drawing.Color.Green;
            this.lbl_chitieu_day.Location = new System.Drawing.Point(121, 25);
            this.lbl_chitieu_day.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbl_chitieu_day.Name = "lbl_chitieu_day";
            this.lbl_chitieu_day.Size = new System.Drawing.Size(100, 18);
            this.lbl_chitieu_day.TabIndex = 1;
            this.lbl_chitieu_day.Text = "0,000";
            this.lbl_chitieu_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiêu \r\ntrong ngày";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.dgv_phieuchi);
            this.guna2ShadowPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(0, 70);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(848, 327);
            this.guna2ShadowPanel2.TabIndex = 13;
            // 
            // dgv_phieuchi
            // 
            this.dgv_phieuchi.AllowUserToAddRows = false;
            this.dgv_phieuchi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_phieuchi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_phieuchi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phieuchi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgv_phieuchi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_phieuchi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_phieuchi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_phieuchi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_phieuchi.ColumnHeadersHeight = 45;
            this.dgv_phieuchi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_PHIEUCHI,
            this.NOIDUNG,
            this.NGAYLAP,
            this.NHANVIEN,
            this.TONGTIEN,
            this.GHICHU,
            this.CHINHANH});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_phieuchi.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_phieuchi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_phieuchi.EnableHeadersVisualStyles = false;
            this.dgv_phieuchi.Location = new System.Drawing.Point(5, 5);
            this.dgv_phieuchi.Name = "dgv_phieuchi";
            this.dgv_phieuchi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_phieuchi.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_phieuchi.RowHeadersWidth = 30;
            this.dgv_phieuchi.RowTemplate.Height = 28;
            this.dgv_phieuchi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_phieuchi.Size = new System.Drawing.Size(838, 317);
            this.dgv_phieuchi.TabIndex = 10;
            // 
            // MA_PHIEUCHI
            // 
            this.MA_PHIEUCHI.DataPropertyName = "MA_PHIEUCHI";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MA_PHIEUCHI.DefaultCellStyle = dataGridViewCellStyle3;
            this.MA_PHIEUCHI.HeaderText = "Mã phiếu";
            this.MA_PHIEUCHI.Name = "MA_PHIEUCHI";
            this.MA_PHIEUCHI.ReadOnly = true;
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.DataPropertyName = "NOIDUNG";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NOIDUNG.DefaultCellStyle = dataGridViewCellStyle4;
            this.NOIDUNG.FillWeight = 150F;
            this.NOIDUNG.HeaderText = "Nội dung";
            this.NOIDUNG.Name = "NOIDUNG";
            this.NOIDUNG.ReadOnly = true;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NGAYLAP.DefaultCellStyle = dataGridViewCellStyle5;
            this.NGAYLAP.HeaderText = "Ngày lập";
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.ReadOnly = true;
            // 
            // NHANVIEN
            // 
            this.NHANVIEN.DataPropertyName = "NHANVIEN";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NHANVIEN.DefaultCellStyle = dataGridViewCellStyle6;
            this.NHANVIEN.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.NHANVIEN.HeaderText = "Nhân viên";
            this.NHANVIEN.Name = "NHANVIEN";
            this.NHANVIEN.ReadOnly = true;
            this.NHANVIEN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NHANVIEN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TONGTIEN.DefaultCellStyle = dataGridViewCellStyle7;
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            // 
            // GHICHU
            // 
            this.GHICHU.DataPropertyName = "GHICHU";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GHICHU.DefaultCellStyle = dataGridViewCellStyle8;
            this.GHICHU.FillWeight = 150F;
            this.GHICHU.HeaderText = "Ghi chú";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.ReadOnly = true;
            // 
            // CHINHANH
            // 
            this.CHINHANH.DataPropertyName = "CHINHANH";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CHINHANH.DefaultCellStyle = dataGridViewCellStyle9;
            this.CHINHANH.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.CHINHANH.HeaderText = "Chi nhánh";
            this.CHINHANH.Name = "CHINHANH";
            this.CHINHANH.ReadOnly = true;
            this.CHINHANH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // uc_phieuchi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_phieuchi";
            this.Size = new System.Drawing.Size(848, 477);
            this.Load += new System.EventHandler(this.uc_phieuchi_Load);
            this.panel1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.guna2ShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuchi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_them_phieuchi;
        private Guna.UI2.WinForms.Guna2Button btn_tim_kiem;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngay_cuoi;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngay_dau;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_tim_kiem;
        private Guna.UI2.WinForms.Guna2CircleButton btnExportExcel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_chitieu_month;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_chitieu_year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_chitieu_day;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private System.Windows.Forms.DataGridView dgv_phieuchi;
        private Guna.UI2.WinForms.Guna2CircleButton btn_detail;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_PHIEUCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewComboBoxColumn NHANVIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
        private System.Windows.Forms.DataGridViewComboBoxColumn CHINHANH;
    }
}
