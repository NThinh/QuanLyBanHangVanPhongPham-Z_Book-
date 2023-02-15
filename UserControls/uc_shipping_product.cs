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
    public partial class uc_shipping_product : UserControl
    {
        public uc_shipping_product()
        {
            InitializeComponent();
            changeSearch(false, false, false, false, true);
        }


        // BỘ TÌM KIẾM BEGIN
        private void checkSearch1(string colName, string searchValue)
        {
            for (var i = 0; i < dgv_ship_product.RowCount; i++)
            {

                if (clsCommon.convertToUnSign2(dgv_ship_product.Rows[i].Cells[colName].Value.ToString().ToLower())
                    .Contains(clsCommon.convertToUnSign2(searchValue.ToString()).ToLower().Trim()))
                {
                    dgv_ship_product.Rows[i].Selected = true;
                }
                else
                {
                    dgv_ship_product.Rows[i].Selected = false;
                }
            }
        }
        private void checkSearch(string colName, string searchValue)
        {
            for (var i = 0; i < dgv_ship_product.RowCount; i++)
            {
                if (searchValue == "")
                {
                    for (int j = 0; j < dgv_ship_product.RowCount; j++)
                    {
                        dgv_ship_product.Rows[j].Selected = false;
                    }
                    break;
                }
                else if (clsCommon.convertToUnSign2(dgv_ship_product.Rows[i].Cells[colName].Value.ToString().ToLower())
                    .Contains(clsCommon.convertToUnSign2(searchValue.ToString()).ToLower().Trim()))
                {
                    dgv_ship_product.Rows[i].Selected = true;                   
                    break;
                }
                else
                {
                    dgv_ship_product.Rows[i].Selected = false;
                }
            }
        }
        private void changeSearch(bool cbo, bool dtp_d, bool dtp_c, bool btn, bool txt)
        {
            cbo_timkiem_chitiet.Visible = cbo;
            dtp_ngay_dau.Visible = dtp_d;
            dtp_ngay_cuoi.Visible = dtp_c;
            btn_tim_kiem.Visible = btn;
            txt_search.Visible = txt;
        }

        private void cbo_tim_kiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo_tim_kiem.Text)
            {
                case "Theo mã":
                    changeSearch(false, false, false, false, true);
                    break;
                case "Theo ngày":
                    changeSearch(false, true, true, true, false);
                    break;
                case "Theo nhân viên":
                    changeSearch(true, false, false, false, false);
                    cbo_timkiem_chitiet.DataSource = clsOrder._getGroupNV();
                    cbo_timkiem_chitiet.DisplayMember = "TENNV";
                    cbo_timkiem_chitiet.ValueMember = "MANV";
                    break;
                case "Theo nơi xuất":
                    changeSearch(true, false, false, false, false);
                    cbo_timkiem_chitiet.DataSource = clsProduct._getGroupStores();
                    cbo_timkiem_chitiet.DisplayMember = "TEN_CHINHANH";
                    cbo_timkiem_chitiet.ValueMember = "MA_CHINHANH";
                    break;
                case "Theo nơi nhận":
                    changeSearch(true, false, false, false, false);
                    cbo_timkiem_chitiet.DataSource = clsProduct._getGroupStores();
                    cbo_timkiem_chitiet.DisplayMember = "TEN_CHINHANH";
                    cbo_timkiem_chitiet.ValueMember = "MA_CHINHANH";
                    break;
                default:
                    break;
            }
        }

        private void btn_tim_kiem_Click(object sender, EventArgs e)
        {
            DateTime ngaydau = Convert.ToDateTime(dtp_ngay_dau.Text);
            DateTime ngaycuoi = Convert.ToDateTime(dtp_ngay_cuoi.Text);

            for (int i = 0; i < dgv_ship_product.RowCount; i++)
            {
                DateTime ngaysosanh = Convert.ToDateTime(dgv_ship_product.Rows[i].Cells["NGAYXUAT"].Value);
                if (ngaydau.Year <= ngaysosanh.Year && ngaysosanh.Year <= ngaycuoi.Year)
                {
                    if (ngaydau.Month <= ngaysosanh.Month && ngaysosanh.Month <= ngaycuoi.Month)
                    {
                        if (ngaydau.Day <= ngaysosanh.Day && ngaysosanh.Day <= ngaycuoi.Day)
                        {
                            dgv_ship_product.Rows[i].Selected = true;
                        }
                        else
                        {
                            dgv_ship_product.Rows[i].Selected = false;
                        }
                    }
                    else
                    {
                        dgv_ship_product.Rows[i].Selected = false;
                    }
                }
                else
                {
                    dgv_ship_product.Rows[i].Selected = false;
                }

            }
        }

        private void cbo_timkiem_chitiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_tim_kiem.Text == "Theo nhân viên")
            {
                string searchcbo = cbo_timkiem_chitiet.SelectedValue.ToString();
                checkSearch1("NHANVIEN_MA", searchcbo);

            }else if (cbo_tim_kiem.Text == "Theo nơi xuất")
            {
                string searchcbo = cbo_timkiem_chitiet.SelectedValue.ToString();
                checkSearch1("NOIXUAT_MA", searchcbo);

            }
            else
            {
                string searchcbo = cbo_timkiem_chitiet.SelectedValue.ToString();
                checkSearch1("CHINHANH_MA", searchcbo);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text;
            checkSearch("MA_PCK", searchValue);
        }

        //END BỘ TÌM KIẾM

        public void uc_shipping_product_Load(object sender, EventArgs e)
        {
            cbo_sanpham.DataSource = clsProduct._getGroupProduct(clsCommon.CHINHANH);
            cbo_sanpham.ValueMember = "MASP_CH";
            cbo_sanpham.DisplayMember = "TENSP_CH";
            cbo_sanpham.StartIndex = -1;

            SANPHAM_MA.DataSource = clsProduct._getGroupProduct();
            SANPHAM_MA.ValueMember = "MASP_CH";
            SANPHAM_MA.DisplayMember = "TENSP_CH";

            _getContent();
                     
        }

        private void _getContentDetail(string ma)
        {                       
            dgv_ship_detail.DataSource = clsMoveWarehouse._getMWarehouseDetail(ma);
        }

        private void _getContent()
        {
            NHANVIEN_MA.DataSource = clsOrder._getGroupNV();
            NHANVIEN_MA.ValueMember = "MANV";
            NHANVIEN_MA.DisplayMember = "TENNV";

            NOIXUAT_MA.DataSource = clsProduct._getGroupStores();
            NOIXUAT_MA.DisplayMember = "TEN_CHINHANH";
            NOIXUAT_MA.ValueMember = "MA_CHINHANH";

            CHINHANH_MA.DataSource = clsProduct._getGroupStores();
            CHINHANH_MA.DisplayMember = "TEN_CHINHANH";
            CHINHANH_MA.ValueMember = "MA_CHINHANH";

            dgv_ship_product.DataSource = clsMoveWarehouse._getMoveWarehouse();

            string ma = clsMoveWarehouse.ma_pck;
            if (ma == "" && dgv_ship_product.Rows.Count > 0) ma = dgv_ship_product.Rows[0].Cells["MA_PCK"].Value.ToString().Trim();
            else
            {
                dgv_ship_product.Rows[dgv_ship_product.Rows.Count - 1].Selected = true;
                dgv_ship_product.Rows[0].Selected = false;
            }
            
            _getContentDetail(ma);
        }

        private void dgv_ship_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clsMoveWarehouse.ma_pck = dgv_ship_product.Rows[dgv_ship_product.SelectedRows[0].Index].Cells["MA_PCK"].Value.ToString().Trim();
            clsMoveWarehouse.noinhan = dgv_ship_product.Rows[dgv_ship_product.SelectedRows[0].Index].Cells["CHINHANH_MA"].Value.ToString().Trim();
            _getContentDetail(clsMoveWarehouse.ma_pck);
        }
        private void btn_them_phieuchuyen_Click(object sender, EventArgs e)
        {

            frmDialog f = new frmDialog();
            f.Size = new Size(400, 370);
            f.AddControlsToPanelDialog(new uc_shipping_add_product());
            f.ShowDialog();

            uc_shipping_product_Load(sender,e);
        }

        private void btn_them_chitiet_Click(object sender, EventArgs e)
        {
            // cập nhật nơi xuất, cập nhật nơi nhận, thêm vào datagridview
            string sp = cbo_sanpham.SelectedValue.ToString().Trim();
            int sl = Convert.ToInt32(txt_soluong.Text.Trim());

            if (clsMoveWarehouse._insertDetailPck(clsMoveWarehouse.ma_pck, sp, sl))
            {
                _getContentDetail(clsMoveWarehouse.ma_pck);
                _updateSoLuong(sp, sl);
               
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txt_soluong.Text = "";
                cbo_sanpham.StartIndex = -1;
            }else
            {
                MessageBox.Show("Lỗi thêm sản phẩm", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _updateSoLuong(string sp, int sl)
        {
            DataTable dt_noixuat = clsProduct._getSlTong(sp, clsCommon.CHINHANH);
            DataTable dt_noinhan = clsProduct._getSlTong(sp, clsMoveWarehouse.noinhan);
            int slTongNoiXuat = 0;
            int slTongNoiNhan = 0;

            if (dt_noixuat.Rows.Count > 0)
            {
                slTongNoiXuat = Convert.ToInt32(dt_noixuat.Rows[0]["TONG_SL"].ToString());
                slTongNoiXuat -= sl;
                clsMoveWarehouse._updateSL_NoiXuat(slTongNoiXuat, sp, clsCommon.CHINHANH);
            }

            if (dt_noinhan.Rows.Count > 0 && dt_noinhan.Rows[0]["TONG_SL"].ToString().Trim() != "")
            {
                
                slTongNoiNhan = Convert.ToInt32(dt_noinhan.Rows[0]["TONG_SL"].ToString().Trim());
                slTongNoiNhan += sl;
                clsMoveWarehouse._updateSL_NoiNhan(slTongNoiNhan, sp, clsMoveWarehouse.noinhan);
            }
            else
            {
                DataTable dt_chitiet_sp = clsProduct._getProductDetail(sp, clsCommon.CHINHANH);

                string ten = dt_chitiet_sp.Rows[0]["TENSP_CH"].ToString().Trim();
                string dvt = dt_chitiet_sp.Rows[0]["DONVITINH"].ToString().Trim();
                string khuyenmai = dt_chitiet_sp.Rows[0]["KHUYENMAI"].ToString().Trim();
                string giaban = dt_chitiet_sp.Rows[0]["GIABAN"].ToString().Trim();
                string hinh = dt_chitiet_sp.Rows[0]["HINH"].ToString().Trim();
                string theloai = dt_chitiet_sp.Rows[0]["THELOAI"].ToString().Trim();
                clsProduct._insertProduct(sp, ten, sl.ToString() , dvt, khuyenmai, giaban, hinh, theloai, clsMoveWarehouse.noinhan);
            }
                  
        }

        private void cbo_sanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_sanpham.Text != "")
            {                
                txt_soluong.Enabled = true;
            }else
            {
                txt_soluong.Enabled = false;
            }

            if (txt_soluong.Text != "" && cbo_sanpham.Text != "")
            {
                btn_them_chitiet.Enabled = true;              
            }else
            {
                btn_them_chitiet.Enabled = false;               
            }
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            if (txt_soluong.Text != "" && cbo_sanpham.Text != "")
            {
                btn_them_chitiet.Enabled = true;
            }else
            {
                btn_them_chitiet.Enabled = false;
            }
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;                
        }

        private void btn_xoa_chitiet_Click(object sender, EventArgs e)
        {
            txt_soluong.Text = "";
            cbo_sanpham.StartIndex = -1;
            if(cbo_sanpham.Text != "") cbo_sanpham.StartIndex = -1;
        }

        private void txt_soluong_Validating(object sender, CancelEventArgs e)
        {          
            string ma = cbo_sanpham.SelectedValue.ToString().Trim();
            DataTable dt = clsProduct._getSlTong(ma, clsCommon.CHINHANH);

            int soluongnhap = 0;                     
            if (txt_soluong.Text.Trim() != "") soluongnhap = Convert.ToInt32(txt_soluong.Text.Trim());

            int slTong = Convert.ToInt32( dt.Rows[0]["TONG_SL"].ToString().Trim() );

            if(soluongnhap > slTong || soluongnhap == 0)
            {

                errorProvider1.SetError(txt_soluong, "Số lượng quá tải ");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_soluong, "");
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Export Excel";
            saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                clsCommon.ExportExcel(dgv_ship_product, saveFileDialog1.FileName);
            }
        }
    }
}
