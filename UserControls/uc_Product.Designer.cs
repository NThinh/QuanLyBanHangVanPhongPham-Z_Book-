
namespace Z_Book.UserControls
{
    partial class uc_Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cbo_timkiem_chitiet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_xem_chitiet = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cbo_tim_kiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_them_sanpham = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.MASP_CH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP_CH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONVITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHUYENMAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THELOAI = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.VITRI = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.cbo_timkiem_chitiet);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.btn_xem_chitiet);
            this.panel1.Controls.Add(this.cbo_tim_kiem);
            this.panel1.Controls.Add(this.btn_them_sanpham);
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 70);
            this.panel1.TabIndex = 2;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xoa.BorderColor = System.Drawing.Color.Maroon;
            this.btn_xoa.BorderThickness = 1;
            this.btn_xoa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoa.FillColor = System.Drawing.Color.White;
            this.btn_xoa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_xoa.ForeColor = System.Drawing.Color.Maroon;
            this.btn_xoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_xoa.Image = global::Z_Book.Properties.Resources.icons8_minus_36px;
            this.btn_xoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_xoa.Location = new System.Drawing.Point(771, 13);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_xoa.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_xoa.Size = new System.Drawing.Size(32, 32);
            this.btn_xoa.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btn_xoa, "Xóa sản phẩm");
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
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
            this.cbo_timkiem_chitiet.Location = new System.Drawing.Point(157, 11);
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
            this.txt_search.Location = new System.Drawing.Point(157, 13);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_search.PlaceholderText = "Tìm kiếm";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(318, 32);
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
            this.btn_xem_chitiet.Location = new System.Drawing.Point(732, 13);
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
            "Theo tên",
            "Theo thể loại",
            "Theo vị trí"});
            this.cbo_tim_kiem.Location = new System.Drawing.Point(14, 11);
            this.cbo_tim_kiem.Name = "cbo_tim_kiem";
            this.cbo_tim_kiem.Size = new System.Drawing.Size(122, 36);
            this.cbo_tim_kiem.StartIndex = 0;
            this.cbo_tim_kiem.TabIndex = 17;
            this.cbo_tim_kiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.cbo_tim_kiem, "Chọn tìm kiếm");
            this.cbo_tim_kiem.SelectedIndexChanged += new System.EventHandler(this.cbo_tim_kiem_SelectedIndexChanged);
            // 
            // btn_them_sanpham
            // 
            this.btn_them_sanpham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_them_sanpham.BorderColor = System.Drawing.Color.Green;
            this.btn_them_sanpham.BorderThickness = 1;
            this.btn_them_sanpham.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_them_sanpham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them_sanpham.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them_sanpham.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them_sanpham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them_sanpham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them_sanpham.FillColor = System.Drawing.Color.White;
            this.btn_them_sanpham.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_them_sanpham.ForeColor = System.Drawing.Color.Green;
            this.btn_them_sanpham.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_them_sanpham.Image = global::Z_Book.Properties.Resources.icons8_add_36px;
            this.btn_them_sanpham.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_them_sanpham.Location = new System.Drawing.Point(694, 13);
            this.btn_them_sanpham.Name = "btn_them_sanpham";
            this.btn_them_sanpham.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_them_sanpham.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_them_sanpham.Size = new System.Drawing.Size(32, 32);
            this.btn_them_sanpham.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btn_them_sanpham, "Thêm sản phẩm");
            this.btn_them_sanpham.Click += new System.EventHandler(this.btn_them_sanpham_Click);
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
            this.btnExportExcel.Location = new System.Drawing.Point(809, 13);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExportExcel.Size = new System.Drawing.Size(32, 32);
            this.btnExportExcel.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnExportExcel, "Xuất excel");
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // dgv_product
            // 
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_product.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgv_product.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_product.ColumnHeadersHeight = 45;
            this.dgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP_CH,
            this.TENSP_CH,
            this.SOLUONG,
            this.DONVITINH,
            this.KHUYENMAI,
            this.GIABAN,
            this.HINH,
            this.THELOAI,
            this.VITRI});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_product.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_product.EnableHeadersVisualStyles = false;
            this.dgv_product.Location = new System.Drawing.Point(0, 0);
            this.dgv_product.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.ReadOnly = true;
            this.dgv_product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_product.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_product.RowHeadersWidth = 20;
            this.dgv_product.RowTemplate.Height = 28;
            this.dgv_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_product.Size = new System.Drawing.Size(856, 450);
            this.dgv_product.TabIndex = 32;
            // 
            // MASP_CH
            // 
            this.MASP_CH.DataPropertyName = "MASP_CH";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MASP_CH.DefaultCellStyle = dataGridViewCellStyle3;
            this.MASP_CH.HeaderText = "Mã sản phẩm";
            this.MASP_CH.Name = "MASP_CH";
            this.MASP_CH.ReadOnly = true;
            // 
            // TENSP_CH
            // 
            this.TENSP_CH.DataPropertyName = "TENSP_CH";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TENSP_CH.DefaultCellStyle = dataGridViewCellStyle4;
            this.TENSP_CH.HeaderText = "Tên sản phẩm";
            this.TENSP_CH.Name = "TENSP_CH";
            this.TENSP_CH.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SOLUONG.DefaultCellStyle = dataGridViewCellStyle5;
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // DONVITINH
            // 
            this.DONVITINH.DataPropertyName = "DONVITINH";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DONVITINH.DefaultCellStyle = dataGridViewCellStyle6;
            this.DONVITINH.HeaderText = "Đơn vị";
            this.DONVITINH.Name = "DONVITINH";
            this.DONVITINH.ReadOnly = true;
            // 
            // KHUYENMAI
            // 
            this.KHUYENMAI.DataPropertyName = "KHUYENMAI";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.KHUYENMAI.DefaultCellStyle = dataGridViewCellStyle7;
            this.KHUYENMAI.HeaderText = "Khuyến mãi";
            this.KHUYENMAI.Name = "KHUYENMAI";
            this.KHUYENMAI.ReadOnly = true;
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GIABAN.DefaultCellStyle = dataGridViewCellStyle8;
            this.GIABAN.HeaderText = "Giá bán";
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.ReadOnly = true;
            // 
            // HINH
            // 
            this.HINH.DataPropertyName = "HINH";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HINH.DefaultCellStyle = dataGridViewCellStyle9;
            this.HINH.HeaderText = "Hình ảnh";
            this.HINH.Name = "HINH";
            this.HINH.ReadOnly = true;
            // 
            // THELOAI
            // 
            this.THELOAI.DataPropertyName = "THELOAI";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.THELOAI.DefaultCellStyle = dataGridViewCellStyle10;
            this.THELOAI.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.THELOAI.HeaderText = "Thể loại";
            this.THELOAI.Name = "THELOAI";
            this.THELOAI.ReadOnly = true;
            // 
            // VITRI
            // 
            this.VITRI.DataPropertyName = "VITRI";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VITRI.DefaultCellStyle = dataGridViewCellStyle11;
            this.VITRI.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.VITRI.HeaderText = "Vị trí";
            this.VITRI.Name = "VITRI";
            this.VITRI.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_product);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 450);
            this.panel2.TabIndex = 33;
            // 
            // uc_Product
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "uc_Product";
            this.Size = new System.Drawing.Size(856, 520);
            this.Load += new System.EventHandler(this.uc_Product_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_xem_chitiet;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_tim_kiem;
        private Guna.UI2.WinForms.Guna2CircleButton btn_them_sanpham;
        private Guna.UI2.WinForms.Guna2CircleButton btnExportExcel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_timkiem_chitiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP_CH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP_CH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONVITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHUYENMAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINH;
        private System.Windows.Forms.DataGridViewComboBoxColumn THELOAI;
        private System.Windows.Forms.DataGridViewComboBoxColumn VITRI;
        private Guna.UI2.WinForms.Guna2CircleButton btn_xoa;
        public System.Windows.Forms.DataGridView dgv_product;
    }
}
