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
    public partial class uc_inventory_detail : UserControl
    {
        public uc_inventory_detail()
        {
            InitializeComponent();
        }

        DataTable dt ;
        private void uc_inventory_detail_Load(object sender, EventArgs e)
        {
            DataTable table = clsProduct._getGroupStores();
            table.Rows.Add(new object[] { "0", "TẤT CẢ", "HCM" });
            cbo_vitri_ma.DataSource = table;
            cbo_vitri_ma.ValueMember = "MA_CHINHANH";
            cbo_vitri_ma.DisplayMember = "TEN_CHINHANH";

            cbo_nhanvien_ma.DataSource = clsOrder._getGroupNV();
            cbo_nhanvien_ma.ValueMember = "MANV";
            cbo_nhanvien_ma.DisplayMember = "TENNV";

            _getContent();
           
        }
        private void _getContent()
        {
            dt = clsInventory._getPhieuKiemKe(clsInventory.makk);
            txt_makk.Text = dt.Rows[0]["MATON"].ToString();
            cbo_vitri_ma.SelectedValue = dt.Rows[0]["VITRI_HANG"].ToString();
            cbo_nhanvien_ma.SelectedValue = dt.Rows[0]["TEN_NHANVIEN"].ToString();
            dtp_ngaykiem.Text = dt.Rows[0]["NGAYKIEM"].ToString();
            txt_tongthatthoat.Text = dt.Rows[0]["TONG_THATTHOAT"].ToString();

            dgv_inventory_detail.DataSource = clsInventory._getPhieuChiTiet(clsInventory.makk);
        }
    }
}
