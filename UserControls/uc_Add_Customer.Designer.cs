
namespace Z_Book.UserControls
{
    partial class uc_Add_Customer
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
            this.label11 = new System.Windows.Forms.Label();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clear_all = new Guna.UI2.WinForms.Guna2Button();
            this.txt_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_phone_number = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_name_customer = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(114, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 23);
            this.label11.TabIndex = 27;
            this.label11.Text = "Thêm khách hàng";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btn_save.BorderRadius = 5;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(168, 275);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(72, 34);
            this.btn_save.TabIndex = 32;
            this.btn_save.Text = "Lưu";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear_all
            // 
            this.btn_clear_all.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_clear_all.BorderRadius = 5;
            this.btn_clear_all.BorderThickness = 1;
            this.btn_clear_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear_all.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear_all.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear_all.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear_all.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear_all.FillColor = System.Drawing.Color.White;
            this.btn_clear_all.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btn_clear_all.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.btn_clear_all.Location = new System.Drawing.Point(246, 275);
            this.btn_clear_all.Name = "btn_clear_all";
            this.btn_clear_all.Size = new System.Drawing.Size(105, 34);
            this.btn_clear_all.TabIndex = 33;
            this.btn_clear_all.Text = "Xóa tất cả";
            this.btn_clear_all.Click += new System.EventHandler(this.btn_clear_all_Click);
            // 
            // txt_address
            // 
            this.txt_address.AutoRoundedCorners = true;
            this.txt_address.BackColor = System.Drawing.Color.White;
            this.txt_address.BorderColor = System.Drawing.Color.Silver;
            this.txt_address.BorderRadius = 17;
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.DefaultText = "";
            this.txt_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txt_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_address.ForeColor = System.Drawing.Color.Black;
            this.txt_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.IconLeft = global::Z_Book.Properties.Resources.icons8_address_24px;
            this.txt_address.Location = new System.Drawing.Point(51, 194);
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.PlaceholderText = "Địa chỉ";
            this.txt_address.SelectedText = "";
            this.txt_address.Size = new System.Drawing.Size(300, 36);
            this.txt_address.TabIndex = 30;
            // 
            // txt_phone_number
            // 
            this.txt_phone_number.BackColor = System.Drawing.Color.White;
            this.txt_phone_number.BorderColor = System.Drawing.Color.Silver;
            this.txt_phone_number.BorderRadius = 15;
            this.txt_phone_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phone_number.DefaultText = "";
            this.txt_phone_number.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_phone_number.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_phone_number.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone_number.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone_number.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txt_phone_number.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone_number.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone_number.ForeColor = System.Drawing.Color.Black;
            this.txt_phone_number.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone_number.IconLeft = global::Z_Book.Properties.Resources.icons8_phone_24px;
            this.txt_phone_number.Location = new System.Drawing.Point(51, 137);
            this.txt_phone_number.Name = "txt_phone_number";
            this.txt_phone_number.PasswordChar = '\0';
            this.txt_phone_number.PlaceholderText = "Số điện thoại";
            this.txt_phone_number.SelectedText = "";
            this.txt_phone_number.Size = new System.Drawing.Size(300, 36);
            this.txt_phone_number.TabIndex = 29;
            this.txt_phone_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_number_KeyPress);
            this.txt_phone_number.Validating += new System.ComponentModel.CancelEventHandler(this.txt_phone_number_Validating);
            // 
            // txt_name_customer
            // 
            this.txt_name_customer.BackColor = System.Drawing.Color.White;
            this.txt_name_customer.BorderColor = System.Drawing.Color.Silver;
            this.txt_name_customer.BorderRadius = 15;
            this.txt_name_customer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name_customer.DefaultText = "";
            this.txt_name_customer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name_customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name_customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name_customer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name_customer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txt_name_customer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name_customer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_customer.ForeColor = System.Drawing.Color.Black;
            this.txt_name_customer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name_customer.IconLeft = global::Z_Book.Properties.Resources.icons8_checked_user_male_24px;
            this.txt_name_customer.Location = new System.Drawing.Point(51, 80);
            this.txt_name_customer.Name = "txt_name_customer";
            this.txt_name_customer.PasswordChar = '\0';
            this.txt_name_customer.PlaceholderText = "Tên khách hàng";
            this.txt_name_customer.SelectedText = "";
            this.txt_name_customer.Size = new System.Drawing.Size(300, 36);
            this.txt_name_customer.TabIndex = 28;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // uc_Add_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear_all);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_phone_number);
            this.Controls.Add(this.txt_name_customer);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_Add_Customer";
            this.Size = new System.Drawing.Size(400, 350);
            this.Load += new System.EventHandler(this.uc_Add_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txt_name_customer;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone_number;
        private Guna.UI2.WinForms.Guna2TextBox txt_address;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2Button btn_clear_all;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
