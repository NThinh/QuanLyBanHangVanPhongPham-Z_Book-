
namespace Z_Book.UserControls
{
    partial class uc_Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Order));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_ngay_dau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_ngay_cuoi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbo_tim_kiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_tim_kiem = new Guna.UI2.WinForms.Guna2Button();
            this.btn_detail = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_xuat_excel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_profit_month = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_profit_year = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_profit_day = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHANVIEN_MA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NGAYBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAGIAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHACHHANG_MA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.VITRI = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_ngay_dau);
            this.panel1.Controls.Add(this.dtp_ngay_cuoi);
            this.panel1.Controls.Add(this.cbo_tim_kiem);
            this.panel1.Controls.Add(this.btn_tim_kiem);
            this.panel1.Controls.Add(this.btn_detail);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.btn_xuat_excel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 70);
            this.panel1.TabIndex = 0;
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
            this.dtp_ngay_dau.Location = new System.Drawing.Point(11, 13);
            this.dtp_ngay_dau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngay_dau.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_ngay_dau.Name = "dtp_ngay_dau";
            this.dtp_ngay_dau.Size = new System.Drawing.Size(156, 32);
            this.dtp_ngay_dau.TabIndex = 17;
            this.toolTip1.SetToolTip(this.dtp_ngay_dau, "Từ ngày");
            this.dtp_ngay_dau.Value = new System.DateTime(2022, 11, 1, 0, 0, 0, 0);
            this.dtp_ngay_dau.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_ngay_dau_Validating);
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
            this.dtp_ngay_cuoi.Location = new System.Drawing.Point(173, 13);
            this.dtp_ngay_cuoi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngay_cuoi.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_ngay_cuoi.Name = "dtp_ngay_cuoi";
            this.dtp_ngay_cuoi.Size = new System.Drawing.Size(156, 32);
            this.dtp_ngay_cuoi.TabIndex = 12;
            this.toolTip1.SetToolTip(this.dtp_ngay_cuoi, "Đến ngày");
            this.dtp_ngay_cuoi.Value = new System.DateTime(2022, 11, 1, 0, 0, 0, 0);
            this.dtp_ngay_cuoi.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_ngay_cuoi_Validating);
            // 
            // cbo_tim_kiem
            // 
            this.cbo_tim_kiem.BackColor = System.Drawing.Color.Transparent;
            this.cbo_tim_kiem.BorderThickness = 0;
            this.cbo_tim_kiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_tim_kiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_tim_kiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tim_kiem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_tim_kiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_tim_kiem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tim_kiem.ForeColor = System.Drawing.Color.Black;
            this.cbo_tim_kiem.ItemHeight = 30;
            this.cbo_tim_kiem.Items.AddRange(new object[] {
            "Theo thời gian",
            "Theo mã hóa đơn"});
            this.cbo_tim_kiem.Location = new System.Drawing.Point(336, 11);
            this.cbo_tim_kiem.Name = "cbo_tim_kiem";
            this.cbo_tim_kiem.Size = new System.Drawing.Size(133, 36);
            this.cbo_tim_kiem.StartIndex = 1;
            this.cbo_tim_kiem.TabIndex = 16;
            this.cbo_tim_kiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbo_tim_kiem.SelectedIndexChanged += new System.EventHandler(this.cbo_tim_kiem_SelectedIndexChanged);
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
            this.btn_tim_kiem.Location = new System.Drawing.Point(475, 13);
            this.btn_tim_kiem.Name = "btn_tim_kiem";
            this.btn_tim_kiem.Size = new System.Drawing.Size(91, 32);
            this.btn_tim_kiem.TabIndex = 11;
            this.btn_tim_kiem.Text = "Tìm kiếm";
            this.btn_tim_kiem.Click += new System.EventHandler(this.btn_tim_kiem_Click);
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
            this.btn_detail.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btn_detail, "Chi tiết hóa đơn");
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
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
            this.txt_search.Location = new System.Drawing.Point(11, 13);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_search.PlaceholderText = "Tìm kiếm";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(318, 32);
            this.txt_search.TabIndex = 13;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_xuat_excel
            // 
            this.btn_xuat_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xuat_excel.BorderColor = System.Drawing.Color.White;
            this.btn_xuat_excel.BorderThickness = 1;
            this.btn_xuat_excel.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(222)))), ((int)(((byte)(0)))));
            this.btn_xuat_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xuat_excel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xuat_excel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xuat_excel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xuat_excel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xuat_excel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_xuat_excel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_xuat_excel.ForeColor = System.Drawing.Color.Green;
            this.btn_xuat_excel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btn_xuat_excel.Image = global::Z_Book.Properties.Resources.icons8_download_24px;
            this.btn_xuat_excel.Location = new System.Drawing.Point(801, 13);
            this.btn_xuat_excel.Name = "btn_xuat_excel";
            this.btn_xuat_excel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_xuat_excel.Size = new System.Drawing.Size(32, 32);
            this.btn_xuat_excel.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btn_xuat_excel, "Xuất Excel");
            this.btn_xuat_excel.Click += new System.EventHandler(this.btn_xuat_excel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 407);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 70);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel5.BackgroundImage = global::Z_Book.Properties.Resources.imgVuong;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.lbl_profit_month);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(282, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 70);
            this.panel5.TabIndex = 3;
            // 
            // lbl_profit_month
            // 
            this.lbl_profit_month.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_profit_month.AutoSize = true;
            this.lbl_profit_month.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profit_month.ForeColor = System.Drawing.Color.Green;
            this.lbl_profit_month.Location = new System.Drawing.Point(138, 25);
            this.lbl_profit_month.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbl_profit_month.Name = "lbl_profit_month";
            this.lbl_profit_month.Size = new System.Drawing.Size(100, 18);
            this.lbl_profit_month.TabIndex = 3;
            this.lbl_profit_month.Text = "0,000";
            this.lbl_profit_month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label4.Text = "Doanh thu\r\n theo tháng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel6.BackgroundImage = global::Z_Book.Properties.Resources.imgVuong;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.lbl_profit_year);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(566, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(282, 70);
            this.panel6.TabIndex = 2;
            // 
            // lbl_profit_year
            // 
            this.lbl_profit_year.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_profit_year.AutoSize = true;
            this.lbl_profit_year.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profit_year.ForeColor = System.Drawing.Color.Green;
            this.lbl_profit_year.Location = new System.Drawing.Point(132, 25);
            this.lbl_profit_year.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbl_profit_year.Name = "lbl_profit_year";
            this.lbl_profit_year.Size = new System.Drawing.Size(100, 18);
            this.lbl_profit_year.TabIndex = 3;
            this.lbl_profit_year.Text = "0,000";
            this.lbl_profit_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(54, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Doanh thu\r\n theo năm\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel4.BackgroundImage = global::Z_Book.Properties.Resources.imgVuong;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.lbl_profit_day);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 70);
            this.panel4.TabIndex = 0;
            // 
            // lbl_profit_day
            // 
            this.lbl_profit_day.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_profit_day.AutoSize = true;
            this.lbl_profit_day.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profit_day.ForeColor = System.Drawing.Color.Green;
            this.lbl_profit_day.Location = new System.Drawing.Point(121, 25);
            this.lbl_profit_day.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbl_profit_day.Name = "lbl_profit_day";
            this.lbl_profit_day.Size = new System.Drawing.Size(100, 18);
            this.lbl_profit_day.TabIndex = 1;
            this.lbl_profit_day.Text = "0,000";
            this.lbl_profit_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label1.Text = "Doanh thu\r\n theo ngày";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_order);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 337);
            this.panel2.TabIndex = 3;
            // 
            // dgv_order
            // 
            this.dgv_order.AllowUserToAddRows = false;
            this.dgv_order.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_order.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgv_order.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_order.ColumnHeadersHeight = 45;
            this.dgv_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.NHANVIEN_MA,
            this.NGAYBAN,
            this.GIAGIAM,
            this.TONGTIEN,
            this.KHACHHANG_MA,
            this.VITRI});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_order.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_order.EnableHeadersVisualStyles = false;
            this.dgv_order.Location = new System.Drawing.Point(0, 0);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_order.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_order.RowHeadersWidth = 30;
            this.dgv_order.RowTemplate.Height = 28;
            this.dgv_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_order.Size = new System.Drawing.Size(848, 337);
            this.dgv_order.TabIndex = 5;
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MAHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.MAHD.FillWeight = 82.02242F;
            this.MAHD.HeaderText = "Mã hóa đơn";
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            // 
            // NHANVIEN_MA
            // 
            this.NHANVIEN_MA.DataPropertyName = "NHANVIEN_MA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NHANVIEN_MA.DefaultCellStyle = dataGridViewCellStyle4;
            this.NHANVIEN_MA.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.NHANVIEN_MA.FillWeight = 100.0224F;
            this.NHANVIEN_MA.HeaderText = "Tên nhân viên";
            this.NHANVIEN_MA.Name = "NHANVIEN_MA";
            this.NHANVIEN_MA.ReadOnly = true;
            this.NHANVIEN_MA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NHANVIEN_MA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NGAYBAN
            // 
            this.NGAYBAN.DataPropertyName = "NGAYBAN";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NGAYBAN.DefaultCellStyle = dataGridViewCellStyle5;
            this.NGAYBAN.FillWeight = 100.0224F;
            this.NGAYBAN.HeaderText = "Ngày bán";
            this.NGAYBAN.Name = "NGAYBAN";
            this.NGAYBAN.ReadOnly = true;
            this.NGAYBAN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GIAGIAM
            // 
            this.GIAGIAM.DataPropertyName = "GIAGIAM";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GIAGIAM.DefaultCellStyle = dataGridViewCellStyle6;
            this.GIAGIAM.FillWeight = 82.02242F;
            this.GIAGIAM.HeaderText = "Giá giảm";
            this.GIAGIAM.Name = "GIAGIAM";
            this.GIAGIAM.ReadOnly = true;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TONGTIEN.DefaultCellStyle = dataGridViewCellStyle7;
            this.TONGTIEN.FillWeight = 82.02242F;
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            // 
            // KHACHHANG_MA
            // 
            this.KHACHHANG_MA.DataPropertyName = "KHACHHANG_MA";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.KHACHHANG_MA.DefaultCellStyle = dataGridViewCellStyle8;
            this.KHACHHANG_MA.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.KHACHHANG_MA.FillWeight = 82.02242F;
            this.KHACHHANG_MA.HeaderText = "Tên khách hàng";
            this.KHACHHANG_MA.Name = "KHACHHANG_MA";
            this.KHACHHANG_MA.ReadOnly = true;
            this.KHACHHANG_MA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // VITRI
            // 
            this.VITRI.DataPropertyName = "VITRI";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VITRI.DefaultCellStyle = dataGridViewCellStyle9;
            this.VITRI.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.VITRI.FillWeight = 82F;
            this.VITRI.HeaderText = "Vị trí";
            this.VITRI.Name = "VITRI";
            this.VITRI.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle12.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewImageColumn1.FillWeight = 10F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Z_Book.Properties.Resources.icons8_menu_25px1;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Sửa";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle13.NullValue")));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Gray;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewImageColumn2.FillWeight = 15F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Z_Book.Properties.Resources.icons8_trash_can_24px;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.ToolTipText = "Xóa";
            // 
            // uc_Order
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_Order";
            this.Size = new System.Drawing.Size(848, 477);
            this.Load += new System.EventHandler(this.uc_Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngay_dau;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngay_cuoi;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_tim_kiem;
        private Guna.UI2.WinForms.Guna2Button btn_tim_kiem;
        private Guna.UI2.WinForms.Guna2CircleButton btn_detail;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2CircleButton btn_xuat_excel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_profit_month;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_profit_year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_profit_day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn NHANVIEN_MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAGIAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewComboBoxColumn KHACHHANG_MA;
        private System.Windows.Forms.DataGridViewComboBoxColumn VITRI;
    }
}
