using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_Book.UserControls
{
     //public enum LoaiSp {SachGiaoKhoa, SachKhoaHoc, SachNgonTinh, VanPhongPham };
    public partial class ucWidget : UserControl
    {
        private int _loaiSp;
        private int sl;
        private double gia;
        private int km;

        public event EventHandler OnSelect = null;
        public ucWidget()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }


        public int LoaiSP { get => _loaiSp; set => _loaiSp = value; }


        public String Ma { get => lblMa.Text; set => lblMa.Text = value; }
        public String Ten { get => lblTen.Text; set => lblTen.Text = value; }
        public String Dvt { get => lblDvt.Text; set => lblDvt.Text = value; }
        public int Sl { get => sl; set { sl = value; lbl.Text = sl.ToString(); } }
        public double Gia { get => gia; set { gia = value;lblGia.Text = string.Format("{0:#,###}", gia); } }
        public Image Hinh { get => imgHinh.Image; set => imgHinh.Image = value; }
        
        public int KM { get => km ; set { km = value;  lblKm.Text =  ( (int) gia * km / 100 ).ToString(); } }

        private void lblMa_Click(object sender, EventArgs e)
        { 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
