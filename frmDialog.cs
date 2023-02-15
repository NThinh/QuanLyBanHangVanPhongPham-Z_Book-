using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_Book.Model;

namespace Z_Book
{
    public partial class frmDialog : Form
    {
        public frmDialog()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void AddControlsToPanelDialog(Control c)
        {
            c.Dock = DockStyle.Fill;
            guna2PanelContain.Controls.Clear();           
            guna2PanelContain.Controls.Add(c);
        }

        private void frmDialog_Load(object sender, EventArgs e)
        {
            txt_address_store.Text = clsCommon.DC_CHINHANH;
            txt_name_store.Text = clsCommon.TEN_CHINHANH;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            frmDialogChooseStore f = new frmDialogChooseStore();
            f.ShowDialog();
            frmDialog_Load(sender, e);
        }
    }
}
