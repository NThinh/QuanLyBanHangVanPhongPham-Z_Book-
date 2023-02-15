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
    public partial class uc_Import_Category : UserControl
    {
        public uc_Import_Category()
        {
            InitializeComponent();
            changeSearch(false, false, false, false, true);
        }
        private bool TRANG_THAI = false;
       
        private void changeSearch(bool cbo, bool dtp_d, bool dtp_c, bool btn, bool txt)
        {
            cbo_timkiem_chitiet.Visible = cbo;
            dtp_ngay_dau.Visible = dtp_d;
            dtp_ngay_cuoi.Visible = dtp_c;
            btn_tim_kiem.Visible = btn;
            txt_search.Visible = txt;
        }

        private void checkSearch1(string colName, string searchValue)
        {
            for (var i = 0; i < dgv_import.RowCount; i++)
            {

                if (clsCommon.convertToUnSign2(dgv_import.Rows[i].Cells[colName].Value.ToString().ToLower())
                    .Contains(clsCommon.convertToUnSign2(searchValue.ToString()).ToLower().Trim()))
                {
                    dgv_import.Rows[i].Selected = true;
                }
                else
                {
                    dgv_import.Rows[i].Selected = false;
                }
            }
        }
        private void checkSearch(string colName, string searchValue)
        {
            for (var i = 0; i < dgv_import.RowCount; i++)
            {
                if (searchValue == "")
                {
                    for (int j = 0; j < dgv_import.RowCount; j++)
                    {
                        dgv_import.Rows[j].Selected = false;
                    }
                    break;
                }
                else if (clsCommon.convertToUnSign2(dgv_import.Rows[i].Cells[colName].Value.ToString().ToLower())
                    .Contains(clsCommon.convertToUnSign2(searchValue.ToString()).ToLower().Trim()))
                {
                    dgv_import.Rows[i].Selected = true;
                    break;
                }
                else
                {
                    dgv_import.Rows[i].Selected = false;
                }
            }
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
                case "Theo nhà cung cấp":
                    changeSearch(true, false, false, false, false);
                    cbo_timkiem_chitiet.DataSource = clsSupplier._getGroupNCC();
                    cbo_timkiem_chitiet.DisplayMember = "TEN_NCC";
                    cbo_timkiem_chitiet.ValueMember = "MA_NCC";
                    break;
                default:
                    break;
            }
        }

        public void uc_Import_Category_Load(object sender, EventArgs e)
        {
            NHANVIEN_MA.DataSource = clsOrder._getGroupNV();
            NHANVIEN_MA.ValueMember = "MANV";
            NHANVIEN_MA.DisplayMember = "TENNV";

            NHACUNGCAP_MA.DataSource = clsSupplier._getGroupNCC();
            NHACUNGCAP_MA.ValueMember = "MA_NCC";
            NHACUNGCAP_MA.DisplayMember = "TEN_NCC";

            VITRI_NHAP.DataSource = clsProduct._getGroupStores();
            VITRI_NHAP.DisplayMember = "TEN_CHINHANH";
            VITRI_NHAP.ValueMember = "MA_CHINHANH";

            TRANGTHAI.DataSource = new Dictionary<bool, string>()
                {
                    {false, "Kho chờ"},
                    {true, "Đã nhập kho"},                  
                }.ToList();
            TRANGTHAI.ValueMember = "Key";
            TRANGTHAI.DisplayMember = "Value";

            dgv_import.DataSource = cls_Import._getImport();
            clsCommon.setRowNumber(dgv_import);

            totalMoney();

        }

        private void totalMoney()
        {
            double total = 0;
            for (int i = 0; i < dgv_import.RowCount; i++)
            {
                double total_money = Convert.ToInt32(dgv_import.Rows[i].Cells["TONGTIEN"].Value.ToString());             
                total += total_money;
            }

            if (total != 0) lbl_tong_tienhang.Text = string.Format("{0:#,###}", total);
        }

        private void btn_nhapkho_Click(object sender, EventArgs e)
        {
            if(dgv_import.SelectedRows.Count == 1)
            {
                if(Convert.ToBoolean(dgv_import.Rows[dgv_import.SelectedRows[0].Index].Cells["TRANGTHAI"].Value.ToString()) == TRANG_THAI)               
                {
                    string vitri = dgv_import.Rows[dgv_import.SelectedRows[0].Index].Cells["VITRI_NHAP"].Value.ToString();
                    string ma = dgv_import.Rows[dgv_import.SelectedRows[0].Index].Cells["MA_PNK"].Value.ToString();

                    if ( cls_Import._updateStatus(!TRANG_THAI, ma, vitri) )
                    {                       
                        if(updateProductSL(ma, vitri))
                        {
                            MessageBox.Show("Nhập kho thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            uc_Import_Category_Load(sender, e);
                        }else
                        {
                            MessageBox.Show("Lỗi nhập kho !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                                        
                }
                else
                {
                    MessageBox.Show("Phiểu này đã nhập rồi !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool updateProductSL(string ma, string vitri)
        {
            bool check = false;
            DataTable dt = cls_Import._getImportDetail(ma);
            DataTable dtsp = clsProduct._getProduct();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int soluongpnct = Convert.ToInt32(dt.Rows[i]["SOLUONG"].ToString());
                string maspct = dt.Rows[i]["TENSANPHAM_MA"].ToString();

                for (int j = 0; j < dtsp.Rows.Count; j++)
                {
                    string masp = dtsp.Rows[j]["MASP_CH"].ToString();
                    string vitrisp = dtsp.Rows[j]["VITRI"].ToString(); 
                    int soluongsp = Convert.ToInt32(dtsp.Rows[j]["SOLUONG"].ToString());                    
                    string ten = dtsp.Rows[j]["TENSP_CH"].ToString();                  
                    string dvt = dtsp.Rows[j]["DONVITINH"].ToString();
                    string khuyenmai = dtsp.Rows[j]["KHUYENMAI"].ToString();
                    string hinh = dtsp.Rows[j]["HINH"].ToString();
                    string giaban = dtsp.Rows[j]["GIABAN"].ToString();
                    string theloai = dtsp.Rows[j]["THELOAI"].ToString();

                    string sl = (soluongpnct + soluongsp).ToString();

                    if (maspct == masp && vitri == vitrisp)
                    {
                         
                        check = clsProduct._updateProductSL(masp, sl, vitrisp);
                        
                    }
                    else if (maspct == masp && vitri != vitrisp)
                    {
                        check = clsProduct._insertProduct(masp, ten, soluongpnct.ToString(),  
                            dvt, khuyenmai, giaban, hinh, theloai, vitri);
                    }
                }

            }
            return check;
        }

        private void btn_them_phieunhap_Click(object sender, EventArgs e)
        {
            cls_Import.checkThemPhieuNhap = true;
            frmDialog f = new frmDialog();
            f.Size = new Size(740, 520);
            f.AddControlsToPanelDialog(new uc_Import_Categort_Detail());
            f.ShowDialog();
            uc_Import_Category_Load(sender, e);
        }

        private void btn_xem_chitiet_Click(object sender, EventArgs e)
        {
            if(dgv_import.SelectedRows.Count == 1)
            {
                cls_Import.checkThemPhieuNhap = false;
                setData();

                frmDialog f = new frmDialog();
                f.Size = new Size(740, 520);
                f.AddControlsToPanelDialog(new uc_Import_Categort_Detail());
                f.ShowDialog();
                uc_Import_Category_Load(sender, e);
            }else
            {
                MessageBox.Show("Vui lòng chọn một thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public void setData()
        {
            cls_Import.ma = dgv_import.Rows[dgv_import.SelectedRows[0].Index].Cells["MA_PNK"].Value.ToString();
            cls_Import.ngaynhap = dgv_import.Rows[dgv_import.SelectedRows[0].Index].Cells["NGAYNHAP"].Value.ToString();
            cls_Import.nhanvien = dgv_import.Rows[dgv_import.SelectedRows[0].Index].Cells["NHANVIEN_MA"].Value.ToString();
            cls_Import.nhacungcap = dgv_import.Rows[dgv_import.SelectedRows[0].Index].Cells["NHACUNGCAP_MA"].Value.ToString();
            cls_Import.tongtien = dgv_import.Rows[dgv_import.SelectedRows[0].Index].Cells["TONGTIEN"].Value.ToString();
            cls_Import.no = dgv_import.Rows[dgv_import.SelectedRows[0].Index].Cells["CONNO"].Value.ToString();
            cls_Import.vitri = dgv_import.Rows[dgv_import.SelectedRows[0].Index].Cells["VITRI_NHAP"].Value.ToString();
            cls_Import.trangthai = dgv_import.Rows[dgv_import.SelectedRows[0].Index].Cells["TRANGTHAI"].Value.ToString();
            
        }

        private void btn_tim_kiem_Click(object sender, EventArgs e)
        {
            DateTime ngaydau = Convert.ToDateTime(dtp_ngay_dau.Text);
            DateTime ngaycuoi = Convert.ToDateTime(dtp_ngay_cuoi.Text);

            for (int i = 0; i < dgv_import.RowCount; i++)
            {
                DateTime ngaysosanh = Convert.ToDateTime(dgv_import.Rows[i].Cells["NGAYNHAP"].Value);
                if (ngaydau.Year <= ngaysosanh.Year && ngaysosanh.Year <= ngaycuoi.Year)
                {
                    if (ngaydau.Month <= ngaysosanh.Month && ngaysosanh.Month <= ngaycuoi.Month)
                    {
                        if (ngaydau.Day <= ngaysosanh.Day && ngaysosanh.Day <= ngaycuoi.Day)
                        {
                            dgv_import.Rows[i].Selected = true;
                        }
                        else
                        {
                            dgv_import.Rows[i].Selected = false;
                        }
                    }
                    else
                    {
                        dgv_import.Rows[i].Selected = false;
                    }
                }
                else
                {
                    dgv_import.Rows[i].Selected = false;
                }

            }
        }

        private void cbo_timkiem_chitiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_tim_kiem.Text == "Theo nhân viên")
            {
                string searchcbo = cbo_timkiem_chitiet.SelectedValue.ToString();
                checkSearch1("NHANVIEN_MA", searchcbo);

            }
            else
            {
                string searchcbo = cbo_timkiem_chitiet.SelectedValue.ToString();
                checkSearch1("NHACUNGCAP_MA", searchcbo);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text;
            checkSearch("MA_PNK", searchValue);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Export Excel";
            saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                clsCommon.ExportExcel(dgv_import, saveFileDialog1.FileName);
            }
        }
    }
}
