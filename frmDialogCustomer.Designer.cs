
namespace Z_Book
{
    partial class frmDialogCustomer
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

        #region Windows Form Designer generated code

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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddCustomer = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHOM_MA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbo_tim_kiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnAddCustomer.BorderThickness = 1;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCustomer.FillColor = System.Drawing.Color.White;
            this.btnAddCustomer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnAddCustomer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.btnAddCustomer.Image = global::Z_Book.Properties.Resources.icons8_Add_Male_User_24px;
            this.btnAddCustomer.Location = new System.Drawing.Point(553, 13);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddCustomer.Size = new System.Drawing.Size(32, 32);
            this.btnAddCustomer.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnAddCustomer, "Thêm mới khách hàng");
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 32);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Danh sách khách hàng";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Z_Book.Properties.Resources.icons8_multiply_25px;
            this.button1.Location = new System.Drawing.Point(559, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 25);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvCustomer);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 385);
            this.panel1.TabIndex = 19;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomer.ColumnHeadersHeight = 45;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TEN_KH,
            this.SDT,
            this.DIACHI,
            this.NHOM_MA});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 64);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCustomer.RowHeadersWidth = 40;
            this.dgvCustomer.RowTemplate.Height = 28;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(594, 321);
            this.dgvCustomer.TabIndex = 5;
//            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            this.dgvCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellDoubleClick);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MAKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.MAKH.FillWeight = 45F;
            this.MAKH.HeaderText = "Mã";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            // 
            // TEN_KH
            // 
            this.TEN_KH.DataPropertyName = "TEN_KH";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TEN_KH.DefaultCellStyle = dataGridViewCellStyle4;
            this.TEN_KH.FillWeight = 86F;
            this.TEN_KH.HeaderText = "Họ và Tên";
            this.TEN_KH.Name = "TEN_KH";
            this.TEN_KH.ReadOnly = true;
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
            // NHOM_MA
            // 
            this.NHOM_MA.DataPropertyName = "NHOM_MA";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NHOM_MA.DefaultCellStyle = dataGridViewCellStyle7;
            this.NHOM_MA.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.NHOM_MA.FillWeight = 50F;
            this.NHOM_MA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NHOM_MA.HeaderText = "Nhóm khách hàng";
            this.NHOM_MA.Name = "NHOM_MA";
            this.NHOM_MA.ReadOnly = true;
            this.NHOM_MA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NHOM_MA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel3.Controls.Add(this.cbo_tim_kiem);
            this.panel3.Controls.Add(this.btnAddCustomer);
            this.panel3.Controls.Add(this.txt_search);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 64);
            this.panel3.TabIndex = 2;
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
            "Theo sđt",
            "Theo địa chỉ"});
            this.cbo_tim_kiem.Location = new System.Drawing.Point(9, 11);
            this.cbo_tim_kiem.Name = "cbo_tim_kiem";
            this.cbo_tim_kiem.Size = new System.Drawing.Size(122, 36);
            this.cbo_tim_kiem.StartIndex = 0;
            this.cbo_tim_kiem.TabIndex = 17;
            this.cbo_tim_kiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txt_search.Location = new System.Drawing.Point(148, 13);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_search.PlaceholderText = "Tìm kiếm";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(318, 32);
            this.txt_search.TabIndex = 13;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Column3";
            this.dataGridViewImageColumn1.Image = global::Z_Book.Properties.Resources.icons8_database_administrator_12px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 205;
            // 
            // frmDialogCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDialogCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDialogCustomer";
            this.Load += new System.EventHandler(this.frmDialogCustomer_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_tim_kiem;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewComboBoxColumn NHOM_MA;
        private System.Windows.Forms.Label label1;
    }
}