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
    public partial class uc_phieuchi : UserControl
    {
        public uc_phieuchi()
        {
            InitializeComponent();
        }

        public void uc_phieuchi_Load(object sender, EventArgs e)
        {
            DataTable dt = clsProduct._getGroupStores();
            dt.Rows.Add("0", "TẤT CẢ", "TPHCM");
            CHINHANH.DataSource = dt ;
            CHINHANH.DisplayMember = "TEN_CHINHANH";
            CHINHANH.ValueMember = "MA_CHINHANH";

            NHANVIEN.DataSource = clsOrder._getGroupNV();
            NHANVIEN.DisplayMember = "TENNV";
            NHANVIEN.ValueMember = "MANV";

            dgv_phieuchi.DataSource = clsPhieuChi._getPhieuChi();

            profit();
        }
        private void profit()
        {
            DateTime date = DateTime.Now;
            string time = String.Format("{0:dd/MM/yyyy}", date);
            double profitDay = 0;
            double profitMonth = 0;
            double profitYear = 0;

            for (int i = 0; i < dgv_phieuchi.RowCount; i++)
            {
                DateTime str = DateTime.Parse(dgv_phieuchi.Rows[i].Cells["NGAYLAP"].Value.ToString());
                double total_money = Convert.ToInt32(dgv_phieuchi.Rows[i].Cells["TONGTIEN"].Value.ToString());
                string time1 = String.Format("{0:dd/MM/yyyy}", str);

                if (time1.Substring(0, 10).Equals(time.Substring(0, 10)))
                {
                    profitDay += total_money;
                }
                if (time1.Substring(3, 7).Equals(time.Substring(3, 7)))
                {
                    profitMonth += total_money;
                }
                if (time1.Substring(6, 4).Equals(time.Substring(6, 4)))
                {
                    profitYear += total_money;
                }
            }

            if (profitDay != 0) lbl_chitieu_day.Text = string.Format("{0:#,###}", profitDay);
            if (profitMonth != 0) lbl_chitieu_month.Text = string.Format("{0:#,###}", profitMonth);
            if (profitYear != 0) lbl_chitieu_year.Text = string.Format("{0:#,###}", profitYear);
        }

        // BỘ TÌM KIẾM BEGIN      
        private void checkSearch(string colName, string searchValue)
        {
            for (var i = 0; i < dgv_phieuchi.RowCount; i++)
            {
                if (searchValue == "")
                {
                    for (int j = 0; j < dgv_phieuchi.RowCount; j++)
                    {
                        dgv_phieuchi.Rows[j].Selected = false;
                    }
                    break;
                }
                else if (clsCommon.convertToUnSign2(dgv_phieuchi.Rows[i].Cells[colName].Value.ToString().ToLower())
                    .Contains(clsCommon.convertToUnSign2(searchValue.ToString()).ToLower().Trim()))
                {
                    dgv_phieuchi.Rows[i].Selected = true;
                    break;
                }
                else
                {
                    dgv_phieuchi.Rows[i].Selected = false;
                }
            }
        }
        private void changeSearch( bool dtp_d, bool dtp_c, bool btn, bool txt)
        {           
            dtp_ngay_dau.Visible = dtp_d;
            dtp_ngay_cuoi.Visible = dtp_c;
            btn_tim_kiem.Visible = btn;
            txt_search.Visible = txt;
        }     

        private void txt_search_TextChanged_1(object sender, EventArgs e)
        {
                string searchValue = txt_search.Text;
            if(cbo_tim_kiem.Text == "Theo mã")
            {
                checkSearch("MA_PHIEUCHI", searchValue);
            }else
            {
                checkSearch("NOIDUNG", searchValue);
            }
            
        }

        private void btn_tim_kiem_Click(object sender, EventArgs e)
        {
            DateTime ngaydau = Convert.ToDateTime(dtp_ngay_dau.Text);
            DateTime ngaycuoi = Convert.ToDateTime(dtp_ngay_cuoi.Text);

            for (int i = 0; i < dgv_phieuchi.RowCount; i++)
            {
                DateTime ngaysosanh = Convert.ToDateTime(dgv_phieuchi.Rows[i].Cells["NGAYLAP"].Value);
                if (ngaydau.Year <= ngaysosanh.Year && ngaysosanh.Year <= ngaycuoi.Year)
                {
                    if (ngaydau.Month <= ngaysosanh.Month && ngaysosanh.Month <= ngaycuoi.Month)
                    {
                        if (ngaydau.Day <= ngaysosanh.Day && ngaysosanh.Day <= ngaycuoi.Day)
                        {
                            dgv_phieuchi.Rows[i].Selected = true;
                        }
                        else
                        {
                            dgv_phieuchi.Rows[i].Selected = false;
                        }
                    }
                    else
                    {
                        dgv_phieuchi.Rows[i].Selected = false;
                    }
                }
                else
                {
                    dgv_phieuchi.Rows[i].Selected = false;
                }

            }
        }

        private void cbo_tim_kiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo_tim_kiem.Text)
            {
                case "Theo mã":
                    changeSearch(false, false, false, true);
                    break;
                case "Theo nội dung":
                    changeSearch(false, false, false, true);
                    break;
                case "Theo ngày":
                    changeSearch(true, true, true, false);
                    break;
                default:
                    break;
            }

        }

        private void btn_them_phieuchi_Click(object sender, EventArgs e)
        {
            if(dgv_phieuchi.SelectedRows.Count > 0)
            {
                clsPhieuChi.check_phieuchi = true;
                frmDialog f = new frmDialog();
                f.Size = new Size(740, 520);
                f.AddControlsToPanelDialog(new uc_phieuchi_chitiet());
                f.ShowDialog();
                uc_phieuchi_Load(sender, e);
            }
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            if (dgv_phieuchi.SelectedRows.Count == 1)
            {
                clsPhieuChi.check_phieuchi = false;
                setData();

                frmDialog f = new frmDialog();
                f.Size = new Size(740, 520);
                f.AddControlsToPanelDialog(new uc_phieuchi_chitiet());
                f.ShowDialog();
                uc_phieuchi_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void setData()
        {
           clsPhieuChi.mapc = dgv_phieuchi.Rows[dgv_phieuchi.SelectedRows[0].Index].Cells["MA_PHIEUCHI"].Value.ToString();
           clsPhieuChi.noidung = dgv_phieuchi.Rows[dgv_phieuchi.SelectedRows[0].Index].Cells["NOIDUNG"].Value.ToString();
           clsPhieuChi.ngaylap = dgv_phieuchi.Rows[dgv_phieuchi.SelectedRows[0].Index].Cells["NGAYLAP"].Value.ToString();
           clsPhieuChi.nhanvien = dgv_phieuchi.Rows[dgv_phieuchi.SelectedRows[0].Index].Cells["NHANVIEN"].Value.ToString();
           clsPhieuChi.tongtien = dgv_phieuchi.Rows[dgv_phieuchi.SelectedRows[0].Index].Cells["TONGTIEN"].Value.ToString();
           clsPhieuChi.ghichu = dgv_phieuchi.Rows[dgv_phieuchi.SelectedRows[0].Index].Cells["GHICHU"].Value.ToString();
           clsPhieuChi.chinhanh = dgv_phieuchi.Rows[dgv_phieuchi.SelectedRows[0].Index].Cells["CHINHANH"].Value.ToString();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Export Excel";
            saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                clsCommon.ExportExcel(dgv_phieuchi, saveFileDialog1.FileName);
            }
        }

        //END BỘ TÌM KIẾM


    }
}
