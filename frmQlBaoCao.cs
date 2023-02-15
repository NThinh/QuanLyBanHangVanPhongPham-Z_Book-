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

namespace Z_Book
{
    public partial class frmQlBaoCao : Form
    {
        public frmQlBaoCao()
        {
            InitializeComponent();
        }
        DataTable dt;

        private void _getTongCommon()
        {
            int phiVanHanh = 0;
            int loiNhuan = 0;
            DataTable dt = clsBaoCao._getDoanhThu_GiaGiam();
            int tongDoanhThu = Convert.ToInt32(dt.Rows[0]["TONGTIEN"].ToString());
            int tongGiaGiam = Convert.ToInt32(dt.Rows[0]["GIAGIAM"].ToString());

            DataTable dt1 = clsBaoCao._getCongNo_TongTien();
            int tongTienPhieuNhap = Convert.ToInt32(dt1.Rows[0]["TONGTIEN"].ToString());
            int tongCongNo = Convert.ToInt32(dt1.Rows[0]["TONGCONGNO"].ToString());

            DataTable dt2 = clsBaoCao._getTongTienPhieuChi();
            int tongTienPhieuChi = Convert.ToInt32(dt2.Rows[0]["TONGTIEN"].ToString());

            phiVanHanh = tongTienPhieuNhap + tongTienPhieuChi;
            loiNhuan = tongDoanhThu - phiVanHanh;

            if (tongDoanhThu != 0) lbl_Doanhthu_tong.Text = string.Format("{0:#,###}", tongDoanhThu);
            else lbl_Doanhthu_tong.Text = "0";

            if (tongGiaGiam != 0) lbl_tiengiamgia_tong.Text = string.Format("{0:#,###}", tongGiaGiam);
            else lbl_tiengiamgia_tong.Text = "0";

            if (tongCongNo != 0) lbl_congno_tong.Text = string.Format("{0:#,###}", tongCongNo);
            else lbl_congno_tong.Text = "0";

            if (phiVanHanh != 0) lbl_phivanhanh_tong.Text = string.Format("{0:#,###}", phiVanHanh);
            else lbl_phivanhanh_tong.Text = "0";

            if (loiNhuan != 0) lbl_loinhuan_tong.Text = string.Format("{0:#,###}", loiNhuan);
            else lbl_loinhuan_tong.Text = "0";
        }
        private void frmQlBaoCao_Load(object sender, EventArgs e)
        {         
            _getTongCommon();
            

            dt = clsProduct._getGroupStores();
            dt.Rows.Add(new object[] { "0", "TẤT CẢ", "HCM" });
            cbo_tim_kiem.DataSource = dt;
            cbo_tim_kiem.ValueMember = "MA_CHINHANH";
            cbo_tim_kiem.DisplayMember = "TEN_CHINHANH";

            cbo_tim_kiem.StartIndex = dt.Rows.Count - 1;
        }

        private void _getdgvLoiNhuan(DataTable dt, DataTable dt1)
        {
            
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["MA_PNK"] = dt1.Rows[i]["MA_PHIEUCHI"].ToString();
                dr["NGAYLAP"] = dt1.Rows[i]["NGAYLAP"].ToString();
                dr["TONGTIEN"] = dt1.Rows[i]["TONGTIEN"].ToString();

                dt.Rows.Add(dr);
            }
            dgv_loinhuan.DataSource = dt;
        }
        private void _getContent_bottom()
        {
            int tongDoanhThu = 0;
            int tongGiaGiam = 0;
            int soluongban = 0;

            int tongCongNo = 0;
            int loiNhuan = 0;
            int tongChiPhi = 0;


            for (int i = 0; i < dgv_doanhthu.RowCount; i++)
            {
                tongDoanhThu += Convert.ToInt32(dgv_doanhthu.Rows[i].Cells["TONGTIENBAN"].Value.ToString());
                tongGiaGiam += Convert.ToInt32(dgv_doanhthu.Rows[i].Cells["TONGKHUYENMAI"].Value.ToString());
                soluongban += Convert.ToInt32(dgv_doanhthu.Rows[i].Cells["SOLUONGBAN"].Value.ToString());

            }
            for (int i = 0; i < dgv_loinhuan.RowCount; i++)
            {
                if(dgv_loinhuan.Rows[i].Cells["CONNO"].Value.ToString().Trim() != "")
                {
                    tongCongNo += Convert.ToInt32(dgv_loinhuan.Rows[i].Cells["CONNO"].Value.ToString().Trim());
                }
                tongChiPhi += Convert.ToInt32(dgv_loinhuan.Rows[i].Cells["TONGTIEN"].Value.ToString());
            }

            loiNhuan = tongDoanhThu - tongChiPhi;

            if (tongDoanhThu != 0) lbl_doanhthu_bottom.Text = string.Format("{0:#,###}", tongDoanhThu);
            else lbl_doanhthu_bottom.Text = "0";

            if (tongGiaGiam != 0) lbl_tongkm_bottom.Text = string.Format("{0:#,###}", tongGiaGiam);
            else lbl_tongkm_bottom.Text = "0";

            if (tongCongNo != 0) lbl_tongcongno_bottom.Text = string.Format("{0:#,###}", tongCongNo);
            else lbl_tongcongno_bottom.Text = "0";

            if (soluongban != 0) lbl_tongsanpham_bottom.Text = string.Format("{0:#,###}", soluongban);
            else lbl_tongsanpham_bottom.Text = "0";

            if (loiNhuan != 0) lbl_loinhuan_bottom.Text = string.Format("{0:#,###}", loiNhuan);
            else lbl_loinhuan_bottom.Text = "0";

            if (tongChiPhi != 0) lbl_tongchiphi_bottom.Text = string.Format("{0:#,###}", tongChiPhi);
            else lbl_tongchiphi_bottom.Text = "0";
        }

        private void cbo_tim_kiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_tim_kiem.SelectedValue.ToString().Trim() == "0" )
            {
                DataTable dt = clsBaoCao._getPhieunhapkho_baocao();
                DataTable dt1 = clsBaoCao._getPhieuchi_baocao();
                _getdgvLoiNhuan(dt, dt1);
                dgv_doanhthu.DataSource = clsBaoCao._getdgvDoanhThu();
                _getContent_bottom();



            }else
            {
                DataTable dt = clsBaoCao._getPhieunhapkho_baocao(cbo_tim_kiem.SelectedValue.ToString().Trim());
                DataTable dt1 = clsBaoCao._getPhieuchi_baocao(cbo_tim_kiem.SelectedValue.ToString().Trim());
                _getdgvLoiNhuan(dt, dt1);
                dgv_doanhthu.DataSource = clsBaoCao._getdgvDoanhThu(cbo_tim_kiem.SelectedValue.ToString().Trim());
                _getContent_bottom();
            }
        }
    }
}
