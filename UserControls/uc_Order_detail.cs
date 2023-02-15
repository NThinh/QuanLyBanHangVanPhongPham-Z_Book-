using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_Book.Model;

namespace Z_Book.UserControls
{
    public partial class uc_Order_detail : UserControl
    {
       
        public uc_Order_detail()
        {
            InitializeComponent();
        }

        private void uc_Order_detail_Load(object sender, EventArgs e)
        {
            SANPHAM_MA.DataSource = clsProduct._getProduct(clsCommon.CHINHANH);
            SANPHAM_MA.ValueMember = "MASP_CH";
            SANPHAM_MA.DisplayMember = "TENSP_CH";

            cbo_nhanvien_ma.DataSource = clsOrder._getGroupNV();
            cbo_nhanvien_ma.ValueMember = "MANV";
            cbo_nhanvien_ma.DisplayMember = "TENNV";

            cbo_khachhang_ma.DataSource = clsOrder._getGroupKH();
            cbo_khachhang_ma.ValueMember = "MAKH";
            cbo_khachhang_ma.DisplayMember = "TEN_KH";

            setData();
                 
            dgv_order_detail.DataSource = clsOrder._getOrderDetail(clsOrder.mahd);
            clsCommon.setRowNumber(dgv_order_detail);
        }
        private void setData()
        {

            txt_mahd.Text = clsOrder.mahd;
            cbo_khachhang_ma.SelectedValue = clsOrder.khachhang;
            cbo_nhanvien_ma.SelectedValue = clsOrder.nhanvien;
            dtp_ngayban.Text = clsOrder.ngayban;
            txt_giagiam.Text = String.Format("{0:#,###}", clsOrder.giamgia);
            txt_tongtien.Text = String.Format("{0:#,###}", clsOrder.tongtien);
        }
    }
}
