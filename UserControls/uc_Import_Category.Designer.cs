
namespace Z_Book.UserControls
{
    partial class uc_Import_Category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_tim_kiem = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_ngay_cuoi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_ngay_dau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbo_timkiem_chitiet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_xem_chitiet = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cbo_tim_kiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_them_phieunhap = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_tong_tienhang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nhapkho = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_import = new System.Windows.Forms.DataGridView();
            this.MA_PNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHANVIEN_MA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NHACUNGCAP_MA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.VITRI_NHAP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_import)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.btn_tim_kiem);
            this.panel1.Controls.Add(this.dtp_ngay_cuoi);
            this.panel1.Controls.Add(this.dtp_ngay_dau);
            this.panel1.Controls.Add(this.cbo_timkiem_chitiet);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.btn_xem_chitiet);
            this.panel1.Controls.Add(this.cbo_tim_kiem);
            this.panel1.Controls.Add(this.btn_them_phieunhap);
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 70);
            this.panel1.TabIndex = 3;
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
            this.dtp_ngay_cuoi.Value = new System.DateTime(2022, 11, 4, 0, 0, 0, 0);
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
            this.dtp_ngay_dau.Value = new System.DateTime(2022, 11, 4, 0, 0, 0, 0);
            // 
            // cbo_timkiem_chitiet
            // 
            this.cbo_timkiem_chitiet.BackColor = System.Drawing.Color.Transparent;
            this.cbo_timkiem_chitiet.BorderRadius = 15;
            this.cbo_timkiem_chitiet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_timkiem_chitiet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_timkiem_chitiet.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_timkiem_chitiet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_timkiem_chitiet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_timkiem_chitiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_timkiem_chitiet.ItemHeight = 30;
            this.cbo_timkiem_chitiet.Location = new System.Drawing.Point(146, 11);
            this.cbo_timkiem_chitiet.Name = "cbo_timkiem_chitiet";
            this.cbo_timkiem_chitiet.Size = new System.Drawing.Size(318, 36);
            this.cbo_timkiem_chitiet.TabIndex = 22;
            this.cbo_timkiem_chitiet.SelectedIndexChanged += new System.EventHandler(this.cbo_timkiem_chitiet_SelectedIndexChanged);
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
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_xem_chitiet
            // 
            this.btn_xem_chitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xem_chitiet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_xem_chitiet.BorderThickness = 1;
            this.btn_xem_chitiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xem_chitiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xem_chitiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xem_chitiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xem_chitiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xem_chitiet.FillColor = System.Drawing.Color.White;
            this.btn_xem_chitiet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_xem_chitiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_xem_chitiet.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.btn_xem_chitiet.Image = global::Z_Book.Properties.Resources.icons8_edit_property_24px;
            this.btn_xem_chitiet.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_xem_chitiet.Location = new System.Drawing.Point(764, 13);
            this.btn_xem_chitiet.Name = "btn_xem_chitiet";
            this.btn_xem_chitiet.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_xem_chitiet.Size = new System.Drawing.Size(32, 32);
            this.btn_xem_chitiet.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btn_xem_chitiet, "Xem chi tiết");
            this.btn_xem_chitiet.Click += new System.EventHandler(this.btn_xem_chitiet_Click);
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
            "Theo nhân viên",
            "Theo nhà cung cấp"});
            this.cbo_tim_kiem.Location = new System.Drawing.Point(14, 11);
            this.cbo_tim_kiem.Name = "cbo_tim_kiem";
            this.cbo_tim_kiem.Size = new System.Drawing.Size(122, 36);
            this.cbo_tim_kiem.StartIndex = 3;
            this.cbo_tim_kiem.TabIndex = 17;
            this.cbo_tim_kiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbo_tim_kiem.SelectedIndexChanged += new System.EventHandler(this.cbo_tim_kiem_SelectedIndexChanged);
            // 
            // btn_them_phieunhap
            // 
            this.btn_them_phieunhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_them_phieunhap.BorderColor = System.Drawing.Color.Green;
            this.btn_them_phieunhap.BorderThickness = 1;
            this.btn_them_phieunhap.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_them_phieunhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them_phieunhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them_phieunhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them_phieunhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them_phieunhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them_phieunhap.FillColor = System.Drawing.Color.White;
            this.btn_them_phieunhap.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_them_phieunhap.ForeColor = System.Drawing.Color.Green;
            this.btn_them_phieunhap.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_them_phieunhap.Image = global::Z_Book.Properties.Resources.icons8_add_36px;
            this.btn_them_phieunhap.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_them_phieunhap.Location = new System.Drawing.Point(725, 13);
            this.btn_them_phieunhap.Name = "btn_them_phieunhap";
            this.btn_them_phieunhap.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_them_phieunhap.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_them_phieunhap.Size = new System.Drawing.Size(32, 32);
            this.btn_them_phieunhap.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btn_them_phieunhap, "Thêm phiếu nhập");
            this.btn_them_phieunhap.Click += new System.EventHandler(this.btn_them_phieunhap_Click);
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
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btn_nhapkho);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 60);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel4.BackgroundImage = global::Z_Book.Properties.Resources.imgVuong;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.lbl_tong_tienhang);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 60);
            this.panel4.TabIndex = 59;
            // 
            // lbl_tong_tienhang
            // 
            this.lbl_tong_tienhang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_tong_tienhang.AutoSize = true;
            this.lbl_tong_tienhang.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tong_tienhang.ForeColor = System.Drawing.Color.Green;
            this.lbl_tong_tienhang.Location = new System.Drawing.Point(164, 25);
            this.lbl_tong_tienhang.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbl_tong_tienhang.MinimumSize = new System.Drawing.Size(150, 0);
            this.lbl_tong_tienhang.Name = "lbl_tong_tienhang";
            this.lbl_tong_tienhang.Size = new System.Drawing.Size(150, 18);
            this.lbl_tong_tienhang.TabIndex = 1;
            this.lbl_tong_tienhang.Text = "0,000";
            this.lbl_tong_tienhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(66, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_nhapkho
            // 
            this.btn_nhapkho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nhapkho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_nhapkho.BorderRadius = 5;
            this.btn_nhapkho.BorderThickness = 1;
            this.btn_nhapkho.CheckedState.FillColor = System.Drawing.Color.DarkGreen;
            this.btn_nhapkho.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_nhapkho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nhapkho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_nhapkho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_nhapkho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_nhapkho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_nhapkho.FillColor = System.Drawing.Color.Green;
            this.btn_nhapkho.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapkho.ForeColor = System.Drawing.Color.White;
            this.btn_nhapkho.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_nhapkho.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_nhapkho.Image = global::Z_Book.Properties.Resources.icons8_save_36px;
            this.btn_nhapkho.ImageSize = new System.Drawing.Size(36, 36);
            this.btn_nhapkho.Location = new System.Drawing.Point(551, 10);
            this.btn_nhapkho.Name = "btn_nhapkho";
            this.btn_nhapkho.Size = new System.Drawing.Size(282, 40);
            this.btn_nhapkho.TabIndex = 58;
            this.btn_nhapkho.Text = "Nhập kho";
            this.btn_nhapkho.Click += new System.EventHandler(this.btn_nhapkho_Click);
            // 
            // dgv_import
            // 
            this.dgv_import.AllowUserToAddRows = false;
            this.dgv_import.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_import.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_import.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_import.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgv_import.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_import.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_import.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_import.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_import.ColumnHeadersHeight = 45;
            this.dgv_import.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_PNK,
            this.NGAYNHAP,
            this.NHANVIEN_MA,
            this.NHACUNGCAP_MA,
            this.TONGTIEN,
            this.CONNO,
            this.TRANGTHAI,
            this.VITRI_NHAP});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_import.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_import.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_import.EnableHeadersVisualStyles = false;
            this.dgv_import.Location = new System.Drawing.Point(0, 70);
            this.dgv_import.Name = "dgv_import";
            this.dgv_import.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_import.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_import.RowHeadersWidth = 30;
            this.dgv_import.RowTemplate.Height = 28;
            this.dgv_import.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_import.Size = new System.Drawing.Size(848, 347);
            this.dgv_import.TabIndex = 6;
            // 
            // MA_PNK
            // 
            this.MA_PNK.DataPropertyName = "MA_PNK";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MA_PNK.DefaultCellStyle = dataGridViewCellStyle3;
            this.MA_PNK.FillWeight = 82.02242F;
            this.MA_PNK.HeaderText = "Mã phiếu nhập";
            this.MA_PNK.Name = "MA_PNK";
            this.MA_PNK.ReadOnly = true;
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.DataPropertyName = "NGAYNHAP";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            this.NGAYNHAP.DefaultCellStyle = dataGridViewCellStyle4;
            this.NGAYNHAP.FillWeight = 100.0224F;
            this.NGAYNHAP.HeaderText = "Ngày nhập";
            this.NGAYNHAP.Name = "NGAYNHAP";
            this.NGAYNHAP.ReadOnly = true;
            this.NGAYNHAP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NHANVIEN_MA
            // 
            this.NHANVIEN_MA.DataPropertyName = "NHANVIEN_MA";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NHANVIEN_MA.DefaultCellStyle = dataGridViewCellStyle5;
            this.NHANVIEN_MA.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.NHANVIEN_MA.FillWeight = 82.02242F;
            this.NHANVIEN_MA.HeaderText = "Nhân viên";
            this.NHANVIEN_MA.Name = "NHANVIEN_MA";
            this.NHANVIEN_MA.ReadOnly = true;
            this.NHANVIEN_MA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NHANVIEN_MA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NHACUNGCAP_MA
            // 
            this.NHACUNGCAP_MA.DataPropertyName = "NHACUNGCAP_MA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NHACUNGCAP_MA.DefaultCellStyle = dataGridViewCellStyle6;
            this.NHACUNGCAP_MA.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.NHACUNGCAP_MA.FillWeight = 82.02242F;
            this.NHACUNGCAP_MA.HeaderText = "Nhà cung cấp";
            this.NHACUNGCAP_MA.Name = "NHACUNGCAP_MA";
            this.NHACUNGCAP_MA.ReadOnly = true;
            this.NHACUNGCAP_MA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NHACUNGCAP_MA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TONGTIEN.DefaultCellStyle = dataGridViewCellStyle7;
            this.TONGTIEN.FillWeight = 100.0224F;
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            this.TONGTIEN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CONNO
            // 
            this.CONNO.DataPropertyName = "CONNO";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CONNO.DefaultCellStyle = dataGridViewCellStyle8;
            this.CONNO.FillWeight = 82.02242F;
            this.CONNO.HeaderText = "Nợ còn";
            this.CONNO.Name = "CONNO";
            this.CONNO.ReadOnly = true;
            this.CONNO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TRANGTHAI.DefaultCellStyle = dataGridViewCellStyle9;
            this.TRANGTHAI.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TRANGTHAI.FillWeight = 82F;
            this.TRANGTHAI.HeaderText = "Trạng thái";
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.ReadOnly = true;
            this.TRANGTHAI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TRANGTHAI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // VITRI_NHAP
            // 
            this.VITRI_NHAP.DataPropertyName = "VITRI_NHAP";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VITRI_NHAP.DefaultCellStyle = dataGridViewCellStyle10;
            this.VITRI_NHAP.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.VITRI_NHAP.FillWeight = 82F;
            this.VITRI_NHAP.HeaderText = "Vị trí";
            this.VITRI_NHAP.Name = "VITRI_NHAP";
            this.VITRI_NHAP.ReadOnly = true;
            this.VITRI_NHAP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VITRI_NHAP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // uc_Import_Category
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.dgv_import);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_Import_Category";
            this.Size = new System.Drawing.Size(848, 477);
            this.Load += new System.EventHandler(this.uc_Import_Category_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_import)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_timkiem_chitiet;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2CircleButton btn_xem_chitiet;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_tim_kiem;
        private Guna.UI2.WinForms.Guna2CircleButton btn_them_phieunhap;
        private Guna.UI2.WinForms.Guna2CircleButton btnExportExcel;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngay_dau;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngay_cuoi;
        private Guna.UI2.WinForms.Guna2Button btn_tim_kiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_import;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_PNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewComboBoxColumn NHANVIEN_MA;
        private System.Windows.Forms.DataGridViewComboBoxColumn NHACUNGCAP_MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONNO;
        private System.Windows.Forms.DataGridViewComboBoxColumn TRANGTHAI;
        private System.Windows.Forms.DataGridViewComboBoxColumn VITRI_NHAP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_tong_tienhang;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_nhapkho;
    }
}
