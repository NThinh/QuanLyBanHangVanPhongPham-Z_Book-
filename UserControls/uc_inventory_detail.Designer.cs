
namespace Z_Book.UserControls
{
    partial class uc_inventory_detail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_nhanvien_ma = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbo_vitri_ma = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtp_ngaykiem = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_tongthatthoat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_makk = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_inventory_detail = new System.Windows.Forms.DataGridView();
            this.TONKH_MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SANPHAM_MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_THUCTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA_TB_NHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.cbo_nhanvien_ma);
            this.panel1.Controls.Add(this.cbo_vitri_ma);
            this.panel1.Controls.Add(this.dtp_ngaykiem);
            this.panel1.Controls.Add(this.txt_tongthatthoat);
            this.panel1.Controls.Add(this.txt_makk);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 168);
            this.panel1.TabIndex = 1;
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
            // cbo_vitri_ma
            // 
            this.cbo_vitri_ma.BackColor = System.Drawing.Color.Transparent;
            this.cbo_vitri_ma.BorderRadius = 15;
            this.cbo_vitri_ma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_vitri_ma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_vitri_ma.Enabled = false;
            this.cbo_vitri_ma.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_vitri_ma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_vitri_ma.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_vitri_ma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_vitri_ma.ItemHeight = 30;
            this.cbo_vitri_ma.Location = new System.Drawing.Point(143, 108);
            this.cbo_vitri_ma.Name = "cbo_vitri_ma";
            this.cbo_vitri_ma.Size = new System.Drawing.Size(170, 36);
            this.cbo_vitri_ma.TabIndex = 22;
            // 
            // dtp_ngaykiem
            // 
            this.dtp_ngaykiem.Animated = true;
            this.dtp_ngaykiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dtp_ngaykiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtp_ngaykiem.BorderRadius = 15;
            this.dtp_ngaykiem.BorderThickness = 2;
            this.dtp_ngaykiem.Checked = true;
            this.dtp_ngaykiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_ngaykiem.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaykiem.Enabled = false;
            this.dtp_ngaykiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dtp_ngaykiem.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtp_ngaykiem.ForeColor = System.Drawing.Color.Black;
            this.dtp_ngaykiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaykiem.Location = new System.Drawing.Point(487, 17);
            this.dtp_ngaykiem.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngaykiem.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_ngaykiem.Name = "dtp_ngaykiem";
            this.dtp_ngaykiem.Size = new System.Drawing.Size(170, 36);
            this.dtp_ngaykiem.TabIndex = 23;
            this.dtp_ngaykiem.Value = new System.DateTime(2022, 11, 1, 0, 0, 0, 0);
            // 
            // txt_tongthatthoat
            // 
            this.txt_tongthatthoat.BorderRadius = 15;
            this.txt_tongthatthoat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tongthatthoat.DefaultText = "";
            this.txt_tongthatthoat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tongthatthoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tongthatthoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tongthatthoat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tongthatthoat.Enabled = false;
            this.txt_tongthatthoat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tongthatthoat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongthatthoat.ForeColor = System.Drawing.Color.Black;
            this.txt_tongthatthoat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tongthatthoat.Location = new System.Drawing.Point(487, 62);
            this.txt_tongthatthoat.Name = "txt_tongthatthoat";
            this.txt_tongthatthoat.PasswordChar = '\0';
            this.txt_tongthatthoat.PlaceholderText = "Tổng thất thoát";
            this.txt_tongthatthoat.SelectedText = "";
            this.txt_tongthatthoat.Size = new System.Drawing.Size(170, 36);
            this.txt_tongthatthoat.TabIndex = 25;
            // 
            // txt_makk
            // 
            this.txt_makk.BorderRadius = 15;
            this.txt_makk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_makk.DefaultText = "";
            this.txt_makk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_makk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_makk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_makk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_makk.Enabled = false;
            this.txt_makk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_makk.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makk.ForeColor = System.Drawing.Color.Black;
            this.txt_makk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_makk.Location = new System.Drawing.Point(143, 17);
            this.txt_makk.Name = "txt_makk";
            this.txt_makk.PasswordChar = '\0';
            this.txt_makk.PlaceholderText = "Mã kiểm kê";
            this.txt_makk.SelectedText = "";
            this.txt_makk.Size = new System.Drawing.Size(170, 36);
            this.txt_makk.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tổng thất thoát (vnđ)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày kiểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vị trí kiểm kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã kiểm kê";
            // 
            // dgv_inventory_detail
            // 
            this.dgv_inventory_detail.AllowUserToAddRows = false;
            this.dgv_inventory_detail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_inventory_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_inventory_detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_inventory_detail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgv_inventory_detail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_inventory_detail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_inventory_detail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_inventory_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_inventory_detail.ColumnHeadersHeight = 45;
            this.dgv_inventory_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TONKH_MA,
            this.SANPHAM_MA,
            this.SOLUONG,
            this.SL_THUCTE,
            this.GIA_TB_NHAP,
            this.GHICHU});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_inventory_detail.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_inventory_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_inventory_detail.EnableHeadersVisualStyles = false;
            this.dgv_inventory_detail.Location = new System.Drawing.Point(0, 168);
            this.dgv_inventory_detail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_inventory_detail.Name = "dgv_inventory_detail";
            this.dgv_inventory_detail.ReadOnly = true;
            this.dgv_inventory_detail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_inventory_detail.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_inventory_detail.RowHeadersWidth = 20;
            this.dgv_inventory_detail.RowTemplate.Height = 28;
            this.dgv_inventory_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_inventory_detail.Size = new System.Drawing.Size(700, 332);
            this.dgv_inventory_detail.TabIndex = 32;
            // 
            // TONKH_MA
            // 
            this.TONKH_MA.DataPropertyName = "TONKH_MA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TONKH_MA.DefaultCellStyle = dataGridViewCellStyle3;
            this.TONKH_MA.HeaderText = "Mã kiểm kê";
            this.TONKH_MA.Name = "TONKH_MA";
            this.TONKH_MA.ReadOnly = true;
            // 
            // SANPHAM_MA
            // 
            this.SANPHAM_MA.DataPropertyName = "SANPHAM_MA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SANPHAM_MA.DefaultCellStyle = dataGridViewCellStyle4;
            this.SANPHAM_MA.HeaderText = "Sản phẩm";
            this.SANPHAM_MA.Name = "SANPHAM_MA";
            this.SANPHAM_MA.ReadOnly = true;
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
            // SL_THUCTE
            // 
            this.SL_THUCTE.DataPropertyName = "SL_THUCTE";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SL_THUCTE.DefaultCellStyle = dataGridViewCellStyle6;
            this.SL_THUCTE.HeaderText = "Số lượng thực tế";
            this.SL_THUCTE.Name = "SL_THUCTE";
            this.SL_THUCTE.ReadOnly = true;
            // 
            // GIA_TB_NHAP
            // 
            this.GIA_TB_NHAP.DataPropertyName = "GIA_TB_NHAP";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GIA_TB_NHAP.DefaultCellStyle = dataGridViewCellStyle7;
            this.GIA_TB_NHAP.HeaderText = "Giá nhập trung bình";
            this.GIA_TB_NHAP.Name = "GIA_TB_NHAP";
            this.GIA_TB_NHAP.ReadOnly = true;
            // 
            // GHICHU
            // 
            this.GHICHU.DataPropertyName = "GHICHU";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GHICHU.DefaultCellStyle = dataGridViewCellStyle8;
            this.GHICHU.HeaderText = "Ghi chú";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.ReadOnly = true;
            // 
            // uc_inventory_detail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.dgv_inventory_detail);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_inventory_detail";
            this.Size = new System.Drawing.Size(700, 500);
            this.Load += new System.EventHandler(this.uc_inventory_detail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory_detail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_nhanvien_ma;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_vitri_ma;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngaykiem;
        private Guna.UI2.WinForms.Guna2TextBox txt_tongthatthoat;
        private Guna.UI2.WinForms.Guna2TextBox txt_makk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_inventory_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONKH_MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SANPHAM_MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_THUCTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA_TB_NHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
    }
}
