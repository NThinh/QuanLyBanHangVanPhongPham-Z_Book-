
namespace Z_Book.UserControls
{
    partial class uc_nhacungcap
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
            this.cbo_tim_kiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_diachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_hoten = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_sdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_stk = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ma = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_luu = new Guna.UI2.WinForms.Guna2Button();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.MA_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.cbo_tim_kiem);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 57);
            this.panel1.TabIndex = 2;
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
            "Theo tên"});
            this.cbo_tim_kiem.Location = new System.Drawing.Point(14, 11);
            this.cbo_tim_kiem.Name = "cbo_tim_kiem";
            this.cbo_tim_kiem.Size = new System.Drawing.Size(122, 36);
            this.cbo_tim_kiem.StartIndex = 0;
            this.cbo_tim_kiem.TabIndex = 17;
            this.cbo_tim_kiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbo_tim_kiem.SelectedIndexChanged += new System.EventHandler(this.cbo_tim_kiem_SelectedIndexChanged);
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
            this.txt_search.Location = new System.Drawing.Point(159, 13);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_search.PlaceholderText = "Tìm kiếm";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(318, 32);
            this.txt_search.TabIndex = 13;
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
            this.btnExportExcel.Location = new System.Drawing.Point(793, 13);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExportExcel.Size = new System.Drawing.Size(32, 32);
            this.btnExportExcel.TabIndex = 14;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel2.Controls.Add(this.txt_diachi);
            this.panel2.Controls.Add(this.txt_hoten);
            this.panel2.Controls.Add(this.txt_sdt);
            this.panel2.Controls.Add(this.txt_stk);
            this.panel2.Controls.Add(this.txt_ma);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 155);
            this.panel2.TabIndex = 6;
            // 
            // txt_diachi
            // 
            this.txt_diachi.BorderRadius = 15;
            this.txt_diachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_diachi.DefaultText = "";
            this.txt_diachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_diachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_diachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_diachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_diachi.Enabled = false;
            this.txt_diachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_diachi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.ForeColor = System.Drawing.Color.Black;
            this.txt_diachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_diachi.Location = new System.Drawing.Point(584, 17);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.PasswordChar = '\0';
            this.txt_diachi.PlaceholderText = "Địa chỉ";
            this.txt_diachi.SelectedText = "";
            this.txt_diachi.Size = new System.Drawing.Size(200, 36);
            this.txt_diachi.TabIndex = 28;
            // 
            // txt_hoten
            // 
            this.txt_hoten.BorderRadius = 15;
            this.txt_hoten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_hoten.DefaultText = "";
            this.txt_hoten.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_hoten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_hoten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hoten.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hoten.Enabled = false;
            this.txt_hoten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hoten.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoten.ForeColor = System.Drawing.Color.Black;
            this.txt_hoten.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hoten.Location = new System.Drawing.Point(146, 62);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.PasswordChar = '\0';
            this.txt_hoten.PlaceholderText = "Họ và tên";
            this.txt_hoten.SelectedText = "";
            this.txt_hoten.Size = new System.Drawing.Size(200, 36);
            this.txt_hoten.TabIndex = 27;
            // 
            // txt_sdt
            // 
            this.txt_sdt.BorderRadius = 15;
            this.txt_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sdt.DefaultText = "";
            this.txt_sdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_sdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_sdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sdt.Enabled = false;
            this.txt_sdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sdt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.ForeColor = System.Drawing.Color.Black;
            this.txt_sdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sdt.Location = new System.Drawing.Point(146, 108);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.PasswordChar = '\0';
            this.txt_sdt.PlaceholderText = "Số điện thoại";
            this.txt_sdt.SelectedText = "";
            this.txt_sdt.Size = new System.Drawing.Size(200, 36);
            this.txt_sdt.TabIndex = 25;
            // 
            // txt_stk
            // 
            this.txt_stk.BorderRadius = 15;
            this.txt_stk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_stk.DefaultText = "";
            this.txt_stk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_stk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_stk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_stk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_stk.Enabled = false;
            this.txt_stk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_stk.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stk.ForeColor = System.Drawing.Color.Black;
            this.txt_stk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_stk.Location = new System.Drawing.Point(584, 62);
            this.txt_stk.Name = "txt_stk";
            this.txt_stk.PasswordChar = '\0';
            this.txt_stk.PlaceholderText = "Số tài khoản";
            this.txt_stk.SelectedText = "";
            this.txt_stk.Size = new System.Drawing.Size(200, 36);
            this.txt_stk.TabIndex = 24;
            // 
            // txt_ma
            // 
            this.txt_ma.BorderRadius = 15;
            this.txt_ma.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ma.DefaultText = "";
            this.txt_ma.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ma.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ma.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ma.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ma.Enabled = false;
            this.txt_ma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ma.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma.ForeColor = System.Drawing.Color.Black;
            this.txt_ma.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ma.Location = new System.Drawing.Point(146, 17);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.PasswordChar = '\0';
            this.txt_ma.PlaceholderText = "Mã nhà cung cấp";
            this.txt_ma.SelectedText = "";
            this.txt_ma.Size = new System.Drawing.Size(200, 36);
            this.txt_ma.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(463, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NCC";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_xoa);
            this.panel3.Controls.Add(this.btn_sua);
            this.panel3.Controls.Add(this.btn_them);
            this.panel3.Controls.Add(this.btn_huy);
            this.panel3.Controls.Add(this.btn_luu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(840, 53);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_xoa.BorderRadius = 5;
            this.btn_xoa.BorderThickness = 1;
            this.btn_xoa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_xoa.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoa.FillColor = System.Drawing.Color.White;
            this.btn_xoa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_xoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_xoa.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Image = global::Z_Book.Properties.Resources.icons8_minus_36px;
            this.btn_xoa.ImageSize = new System.Drawing.Size(36, 36);
            this.btn_xoa.Location = new System.Drawing.Point(342, 15);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(91, 32);
            this.btn_xoa.TabIndex = 92;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_sua.BorderRadius = 5;
            this.btn_sua.BorderThickness = 1;
            this.btn_sua.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_sua.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sua.FillColor = System.Drawing.Color.White;
            this.btn_sua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_sua.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_sua.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Image = global::Z_Book.Properties.Resources.icons8_edit_property_24px;
            this.btn_sua.ImageSize = new System.Drawing.Size(36, 36);
            this.btn_sua.Location = new System.Drawing.Point(245, 15);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(91, 32);
            this.btn_sua.TabIndex = 91;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_them.BorderRadius = 5;
            this.btn_them.BorderThickness = 1;
            this.btn_them.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_them.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them.FillColor = System.Drawing.Color.White;
            this.btn_them.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_them.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_them.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_them.Image = global::Z_Book.Properties.Resources.icons8_add_36px;
            this.btn_them.ImageSize = new System.Drawing.Size(36, 36);
            this.btn_them.Location = new System.Drawing.Point(146, 15);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(91, 32);
            this.btn_them.TabIndex = 90;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_huy.BorderRadius = 5;
            this.btn_huy.BorderThickness = 1;
            this.btn_huy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_huy.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_huy.Enabled = false;
            this.btn_huy.FillColor = System.Drawing.Color.White;
            this.btn_huy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_huy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_huy.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Image = global::Z_Book.Properties.Resources.icons8_close_36px;
            this.btn_huy.ImageSize = new System.Drawing.Size(36, 36);
            this.btn_huy.Location = new System.Drawing.Point(587, 14);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(91, 32);
            this.btn_huy.TabIndex = 89;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_luu.BorderRadius = 5;
            this.btn_luu.BorderThickness = 1;
            this.btn_luu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_luu.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_luu.Enabled = false;
            this.btn_luu.FillColor = System.Drawing.Color.White;
            this.btn_luu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_luu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_luu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_luu.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Image = global::Z_Book.Properties.Resources.icons8_save_36px;
            this.btn_luu.ImageSize = new System.Drawing.Size(36, 36);
            this.btn_luu.Location = new System.Drawing.Point(490, 14);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(91, 32);
            this.btn_luu.TabIndex = 88;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // dgvNCC
            // 
            this.dgvNCC.AllowUserToAddRows = false;
            this.dgvNCC.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvNCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvNCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvNCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNCC.ColumnHeadersHeight = 45;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_NCC,
            this.TEN_NCC,
            this.SDT,
            this.DIACHI,
            this.STK});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNCC.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNCC.EnableHeadersVisualStyles = false;
            this.dgvNCC.Location = new System.Drawing.Point(0, 265);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNCC.RowHeadersWidth = 20;
            this.dgvNCC.RowTemplate.Height = 28;
            this.dgvNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNCC.Size = new System.Drawing.Size(840, 179);
            this.dgvNCC.TabIndex = 9;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            // 
            // MA_NCC
            // 
            this.MA_NCC.DataPropertyName = "MA_NCC";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MA_NCC.DefaultCellStyle = dataGridViewCellStyle3;
            this.MA_NCC.FillWeight = 40F;
            this.MA_NCC.HeaderText = "Mã";
            this.MA_NCC.Name = "MA_NCC";
            this.MA_NCC.ReadOnly = true;
            // 
            // TEN_NCC
            // 
            this.TEN_NCC.DataPropertyName = "TEN_NCC";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TEN_NCC.DefaultCellStyle = dataGridViewCellStyle4;
            this.TEN_NCC.FillWeight = 86F;
            this.TEN_NCC.HeaderText = "Họ và Tên";
            this.TEN_NCC.Name = "TEN_NCC";
            this.TEN_NCC.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SDT.DefaultCellStyle = dataGridViewCellStyle5;
            this.SDT.FillWeight = 38F;
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DIACHI.DefaultCellStyle = dataGridViewCellStyle6;
            this.DIACHI.FillWeight = 44.34095F;
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            // 
            // STK
            // 
            this.STK.DataPropertyName = "STK";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STK.DefaultCellStyle = dataGridViewCellStyle7;
            this.STK.FillWeight = 50F;
            this.STK.HeaderText = "Số tài khoản";
            this.STK.Name = "STK";
            this.STK.ReadOnly = true;
            this.STK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // uc_nhacungcap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_nhacungcap";
            this.Size = new System.Drawing.Size(840, 444);
            this.Load += new System.EventHandler(this.uc_nhacungcap_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_tim_kiem;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2CircleButton btnExportExcel;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_hoten;
        private Guna.UI2.WinForms.Guna2TextBox txt_sdt;
        private Guna.UI2.WinForms.Guna2TextBox txt_stk;
        private Guna.UI2.WinForms.Guna2TextBox txt_ma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private Guna.UI2.WinForms.Guna2Button btn_sua;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private Guna.UI2.WinForms.Guna2Button btn_huy;
        private Guna.UI2.WinForms.Guna2Button btn_luu;
        private System.Windows.Forms.DataGridView dgvNCC;
        private Guna.UI2.WinForms.Guna2TextBox txt_diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn STK;
    }
}
