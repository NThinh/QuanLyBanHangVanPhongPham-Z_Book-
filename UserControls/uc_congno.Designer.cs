
namespace Z_Book.UserControls
{
    partial class uc_congno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btn_tattoan = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_tong_congno = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_soluong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgv_congno = new System.Windows.Forms.DataGridView();
            this.MA_NCC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MA_PHIEUNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            this.guna2ShadowPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_congno)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 70);
            this.panel1.TabIndex = 5;
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
            this.txt_search.Location = new System.Drawing.Point(18, 9);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_search.PlaceholderText = "Tìm kiếm theo mã";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(318, 36);
            this.txt_search.TabIndex = 19;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
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
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.btn_tattoan);
            this.guna2ShadowPanel2.Controls.Add(this.lbl_tong_congno);
            this.guna2ShadowPanel2.Controls.Add(this.label11);
            this.guna2ShadowPanel2.Controls.Add(this.panel3);
            this.guna2ShadowPanel2.Controls.Add(this.lbl_soluong);
            this.guna2ShadowPanel2.Controls.Add(this.label1);
            this.guna2ShadowPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(0, 408);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(848, 69);
            this.guna2ShadowPanel2.TabIndex = 6;
            // 
            // btn_tattoan
            // 
            this.btn_tattoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tattoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_tattoan.BorderRadius = 5;
            this.btn_tattoan.BorderThickness = 1;
            this.btn_tattoan.CheckedState.FillColor = System.Drawing.Color.DarkGreen;
            this.btn_tattoan.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_tattoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tattoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tattoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tattoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tattoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tattoan.FillColor = System.Drawing.Color.Green;
            this.btn_tattoan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tattoan.ForeColor = System.Drawing.Color.White;
            this.btn_tattoan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_tattoan.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_tattoan.Image = global::Z_Book.Properties.Resources.icons8_checked_checkbox_36px;
            this.btn_tattoan.ImageSize = new System.Drawing.Size(36, 36);
            this.btn_tattoan.Location = new System.Drawing.Point(644, 15);
            this.btn_tattoan.Name = "btn_tattoan";
            this.btn_tattoan.Size = new System.Drawing.Size(189, 40);
            this.btn_tattoan.TabIndex = 12;
            this.btn_tattoan.Text = "Tất toán";
            this.btn_tattoan.Click += new System.EventHandler(this.btn_tattoan_Click);
            // 
            // lbl_tong_congno
            // 
            this.lbl_tong_congno.AutoSize = true;
            this.lbl_tong_congno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tong_congno.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_tong_congno.Location = new System.Drawing.Point(346, 27);
            this.lbl_tong_congno.MinimumSize = new System.Drawing.Size(60, 17);
            this.lbl_tong_congno.Name = "lbl_tong_congno";
            this.lbl_tong_congno.Size = new System.Drawing.Size(60, 17);
            this.lbl_tong_congno.TabIndex = 11;
            this.lbl_tong_congno.Text = "0";
            this.lbl_tong_congno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(220, 27);
            this.label11.MinimumSize = new System.Drawing.Size(120, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tổng công nợ : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(199, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 35);
            this.panel3.TabIndex = 9;
            // 
            // lbl_soluong
            // 
            this.lbl_soluong.AutoSize = true;
            this.lbl_soluong.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soluong.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_soluong.Location = new System.Drawing.Point(120, 27);
            this.lbl_soluong.MinimumSize = new System.Drawing.Size(60, 17);
            this.lbl_soluong.Name = "lbl_soluong";
            this.lbl_soluong.Size = new System.Drawing.Size(60, 17);
            this.lbl_soluong.TabIndex = 1;
            this.lbl_soluong.Text = "0";
            this.lbl_soluong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng : ";
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.dgv_congno);
            this.guna2ShadowPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(0, 70);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(848, 338);
            this.guna2ShadowPanel3.TabIndex = 7;
            // 
            // dgv_congno
            // 
            this.dgv_congno.AllowUserToAddRows = false;
            this.dgv_congno.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_congno.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_congno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_congno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgv_congno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_congno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_congno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_congno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_congno.ColumnHeadersHeight = 45;
            this.dgv_congno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_NCC,
            this.MA_PHIEUNHAP,
            this.THANHTIEN,
            this.CONNO,
            this.TRANGTHAI});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_congno.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_congno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_congno.EnableHeadersVisualStyles = false;
            this.dgv_congno.Location = new System.Drawing.Point(5, 5);
            this.dgv_congno.Name = "dgv_congno";
            this.dgv_congno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_congno.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_congno.RowHeadersWidth = 30;
            this.dgv_congno.RowTemplate.Height = 28;
            this.dgv_congno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_congno.Size = new System.Drawing.Size(838, 328);
            this.dgv_congno.TabIndex = 7;
            // 
            // MA_NCC
            // 
            this.MA_NCC.DataPropertyName = "MA_NCC";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MA_NCC.DefaultCellStyle = dataGridViewCellStyle3;
            this.MA_NCC.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MA_NCC.FillWeight = 120F;
            this.MA_NCC.HeaderText = "Nhà cung cấp";
            this.MA_NCC.Name = "MA_NCC";
            this.MA_NCC.ReadOnly = true;
            // 
            // MA_PHIEUNHAP
            // 
            this.MA_PHIEUNHAP.DataPropertyName = "MA_PHIEUNHAP";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MA_PHIEUNHAP.DefaultCellStyle = dataGridViewCellStyle4;
            this.MA_PHIEUNHAP.HeaderText = "Mã phiếu";
            this.MA_PHIEUNHAP.Name = "MA_PHIEUNHAP";
            this.MA_PHIEUNHAP.ReadOnly = true;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.THANHTIEN.DefaultCellStyle = dataGridViewCellStyle5;
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            // 
            // CONNO
            // 
            this.CONNO.DataPropertyName = "CONNO";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CONNO.DefaultCellStyle = dataGridViewCellStyle6;
            this.CONNO.HeaderText = "Công nợ";
            this.CONNO.Name = "CONNO";
            this.CONNO.ReadOnly = true;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TRANGTHAI.DefaultCellStyle = dataGridViewCellStyle7;
            this.TRANGTHAI.HeaderText = "Trạng thái";
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.ReadOnly = true;
            // 
            // uc_congno
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.guna2ShadowPanel3);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_congno";
            this.Size = new System.Drawing.Size(848, 477);
            this.Load += new System.EventHandler(this.uc_congno_Load);
            this.panel1.ResumeLayout(false);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.guna2ShadowPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_congno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2CircleButton btnExportExcel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private System.Windows.Forms.Label lbl_tong_congno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_soluong;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private System.Windows.Forms.DataGridView dgv_congno;
        private System.Windows.Forms.DataGridViewComboBoxColumn MA_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_PHIEUNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private Guna.UI2.WinForms.Guna2Button btn_tattoan;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
