using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_Book
{
    public partial class frmLoggin : Form
    {
        public Point downPoint = Point.Empty;
        public frmLoggin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            String tk = txtAccount.Text;
            String mk = txtPassword.Text;
            String ID = Model.clsEmploys._checkLogin(tk, mk);
            if(ID != "ERROR")
            {
                Model.clsCommon.MANV = ID;             
                this.Hide();
                frmMain f = new frmMain();             
                f.Show();

                frmDialogChooseStore f1 = new frmDialogChooseStore();
                f1.ShowDialog();

            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAccount.Focus();
            }

        }

        private void frmLoggin_Load(object sender, EventArgs e)
        {

        }
        //forcus enter
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (this.ActiveControl.Handle != btnLoggin.Handle)
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // di chuyển form
        // 
        private void frmLoggin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = new Point(e.X, e.Y);
        }

        private void frmLoggin_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y - downPoint.Y);
        }

        private void frmLoggin_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }

        private void cbk_display_CheckedChanged(object sender, EventArgs e)
        {

        }
    }       
}
