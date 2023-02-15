
namespace Z_Book.UserControls
{
    partial class uc_Order_detail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_nhanvien_ma = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbo_khachhang_ma = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtp_ngayban = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_tongtien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_giagiam = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_mahd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_order_detail = new System.Windows.Forms.DataGridView();
            this.HOADON_MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SANPHAM_MA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHUYENMAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.cbo_nhanvien_ma);
            this.panel1.Controls.Add(this.cbo_khachhang_ma);
            this.panel1.Controls.Add(this.dtp_ngayban);
            this.panel1.Controls.Add(this.txt_tongtien);
            this.panel1.Controls.Add(this.txt_giagiam);
            this.panel1.Controls.Add(this.txt_mahd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 155);
            this.panel1.TabIndex = 0;
            // 
            // cbo_nhanvien_ma
            // 
            this.cbo_nhanvien_ma.BackColor = System.Drawing.Color.Transparent;
            this.cbo_nhanvien_ma.BorderRadius = 15;
            this.cbo_nhanvien_ma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_nhanvien_ma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nhanvien_ma.Enabled = false;
            this.cbo_nhanvien_ma.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_nhanvien_ma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_nhanvien_ma.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_nhanvien_ma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_nhanvien_ma.ItemHeight = 30;
            this.cbo_nhanvien_ma.Location = new System.Drawing.Point(143, 62);
            this.cbo_nhanvien_ma.Name = "cbo_nhanvien_ma";
            this.cbo_nhanvien_ma.Size = new System.Drawing.Size(170, 36);
            this.cbo_nhanvien_ma.TabIndex = 21;
            // 
            // cbo_khachhang_ma
            // 
            this.cbo_khachhang_ma.BackColor = System.Drawing.Color.Transparent;
            this.cbo_khachhang_ma.BorderRadius = 15;
            this.cbo_khachhang_ma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_khachhang_ma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_khachhang_ma.Enabled = false;
            this.cbo_khachhang_ma.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_khachhang_ma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_khachhang_ma.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_khachhang_ma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_khachhang_ma.ItemHeight = 30;
            this.cbo_khachhang_ma.Location = new System.Drawing.Point(143, 108);
            this.cbo_khachhang_ma.Name = "cbo_khachhang_ma";
            this.cbo_khachhang_ma.Size = new System.Drawing.Size(170, 36);
            this.cbo_khachhang_ma.TabIndex = 22;
            // 
            // dtp_ngayban
            // 
            this.dtp_ngayban.Animated = true;
            this.dtp_ngayban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dtp_ngayban.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtp_ngayban.BorderRadius = 15;
            this.dtp_ngayban.BorderThickness = 2;
            this.dtp_ngayban.Checked = true;
            this.dtp_ngayban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_ngayban.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngayban.Enabled = false;
            this.dtp_ngayban.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dtp_ngayban.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtp_ngayban.ForeColor = System.Drawing.Color.Black;
            this.dtp_ngayban.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayban.Location = new System.Drawing.Point(484, 17);
            this.dtp_ngayban.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngayban.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_ngayban.Name = "dtp_ngayban";
            this.dtp_ngayban.Size = new System.Drawing.Size(170, 36);
            this.dtp_ngayban.TabIndex = 23;
            this.dtp_ngayban.Value = new System.DateTime(2022, 11, 1, 0, 0, 0, 0);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.BorderRadius = 15;
            this.txt_tongtien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tongtien.DefaultText = "";
            this.txt_tongtien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tongtien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tongtien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tongtien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tongtien.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.ForeColor = System.Drawing.Color.Black;
            this.txt_tongtien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tongtien.Location = new System.Drawing.Point(484, 108);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.PasswordChar = '\0';
            this.txt_tongtien.PlaceholderText = "Tổng tiền";
            this.txt_tongtien.SelectedText = "";
            this.txt_tongtien.Size = new System.Drawing.Size(170, 36);
            this.txt_tongtien.TabIndex = 25;
            // 
            // txt_giagiam
            // 
            this.txt_giagiam.BorderRadius = 15;
            this.txt_giagiam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_giagiam.DefaultText = "";
            this.txt_giagiam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_giagiam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_giagiam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_giagiam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_giagiam.Enabled = false;
            this.txt_giagiam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_giagiam.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giagiam.ForeColor = System.Drawing.Color.Black;
            this.txt_giagiam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_giagiam.Location = new System.Drawing.Point(484, 62);
            this.txt_giagiam.Name = "txt_giagiam";
            this.txt_giagiam.PasswordChar = '\0';
            this.txt_giagiam.PlaceholderText = "Giá giảm";
            this.txt_giagiam.SelectedText = "";
            this.txt_giagiam.Size = new System.Drawing.Size(170, 36);
            this.txt_giagiam.TabIndex = 24;
            // 
            // txt_mahd
            // 
            this.txt_mahd.BorderRadius = 15;
            this.txt_mahd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mahd.DefaultText = "";
            this.txt_mahd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mahd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mahd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mahd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mahd.Enabled = false;
            this.txt_mahd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mahd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahd.ForeColor = System.Drawing.Color.Black;
            this.txt_mahd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mahd.Location = new System.Drawing.Point(143, 17);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.PasswordChar = '\0';
            this.txt_mahd.PlaceholderText = "Mã hóa đơn";
            this.txt_mahd.SelectedText = "";
            this.txt_mahd.Size = new System.Drawing.Size(170, 36);
            this.txt_mahd.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tổng tiền (vnđ)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giá giảm (vnđ)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // dgv_order_detail
            // 
            this.dgv_order_detail.AllowUserToAddRows = false;
            this.dgv_order_detail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_order_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_order_detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_order_detail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgv_order_detail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_order_detail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_order_detail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_order_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_order_detail.ColumnHeadersHeight = 45;
            this.dgv_order_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HOADON_MA,
            this.SANPHAM_MA,
            this.SOLUONG,
            this.DONGIA,
            this.KHUYENMAI});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_order_detail.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_order_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_order_detail.EnableHeadersVisualStyles = false;
            this.dgv_order_detail.Location = new System.Drawing.Point(0, 155);
            this.dgv_order_detail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_order_detail.Name = "dgv_order_detail";
            this.dgv_order_detail.ReadOnly = true;
            this.dgv_order_detail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_order_detail.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_order_detail.RowHeadersWidth = 20;
            this.dgv_order_detail.RowTemplate.Height = 28;
            this.dgv_order_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_order_detail.Size = new System.Drawing.Size(700, 345);
            this.dgv_order_detail.TabIndex = 31;
            // 
            // HOADON_MA
            // 
            this.HOADON_MA.DataPropertyName = "HOADON_MA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HOADON_MA.DefaultCellStyle = dataGridViewCellStyle3;
            this.HOADON_MA.FillWeight = 45F;
            this.HOADON_MA.HeaderText = "Mã hóa đơn";
            this.HOADON_MA.Name = "HOADON_MA";
            this.HOADON_MA.ReadOnly = true;
            // 
            // SANPHAM_MA
            // 
            this.SANPHAM_MA.DataPropertyName = "SANPHAM_MA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SANPHAM_MA.DefaultCellStyle = dataGridViewCellStyle4;
            this.SANPHAM_MA.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.SANPHAM_MA.FillWeight = 45F;
            this.SANPHAM_MA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SANPHAM_MA.HeaderText = "sản phẩm";
            this.SANPHAM_MA.Name = "SANPHAM_MA";
            this.SANPHAM_MA.ReadOnly = true;
            this.SANPHAM_MA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SANPHAM_MA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SOLUONG.DefaultCellStyle = dataGridViewCellStyle5;
            this.SOLUONG.FillWeight = 45F;
            this.SOLUONG.HeaderText = "số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DONGIA.DefaultCellStyle = dataGridViewCellStyle6;
            this.DONGIA.FillWeight = 45F;
            this.DONGIA.HeaderText = "đơn giá";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            this.DONGIA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // KHUYENMAI
            // 
            this.KHUYENMAI.DataPropertyName = "KHUYENMAI";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.KHUYENMAI.DefaultCellStyle = dataGridViewCellStyle7;
            this.KHUYENMAI.FillWeight = 45F;
            this.KHUYENMAI.HeaderText = "khuyến mãi";
            this.KHUYENMAI.Name = "KHUYENMAI";
            this.KHUYENMAI.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 24F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Z_Book.Properties.Resources.icons8_edit_24px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 24F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Z_Book.Properties.Resources.icons8_trash_can_24px;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 59;
            // 
            // uc_Order_detail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dgv_order_detail);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_Order_detail";
            this.Size = new System.Drawing.Size(700, 500);
            this.Load += new System.EventHandler(this.uc_Order_detail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_detail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_order_detail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_mahd;
        private Guna.UI2.WinForms.Guna2TextBox txt_tongtien;
        private Guna.UI2.WinForms.Guna2TextBox txt_giagiam;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngayban;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_nhanvien_ma;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_khachhang_ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOADON_MA;
        private System.Windows.Forms.DataGridViewComboBoxColumn SANPHAM_MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHUYENMAI;
    }
}
