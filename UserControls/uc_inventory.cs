using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_Book.Model;
using System.IO;
//using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace Z_Book.UserControls
{
    public partial class uc_inventory : UserControl
    {
        public uc_inventory()
        {
            InitializeComponent();
           
        }
        DataTable dt ;
        // xóa string.format
        NumberStyles styles = NumberStyles.AllowThousands;
        int tong_that_thoat = 0;
        private void checkSearch(string colName, string searchValue)
        {
            for (var i = 0; i < dgv_inventory.RowCount; i++)
            {
                if (searchValue == "")
                {
                    for (int j = 0; j < dgv_inventory.RowCount; j++)
                    {
                        dgv_inventory.Rows[j].Selected = false;
                    }
                    break;
                }
                else if (clsCommon.convertToUnSign2(dgv_inventory.Rows[i].Cells[colName].Value.ToString().ToLower())
                    .Contains(clsCommon.convertToUnSign2(searchValue.ToString()).ToLower().Trim()))
                {
                    dgv_inventory.Rows[i].Selected = true;
                    break;
                }
                else
                {
                    dgv_inventory.Rows[i].Selected = false;
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text;
            checkSearch("MASP_CH", searchValue);

        }

        public void uc_inventory_Load(object sender, EventArgs e)
        {
            VITRI.DataSource = clsProduct._getGroupStores();
            VITRI.DisplayMember = "TEN_CHINHANH";
            VITRI.ValueMember = "MA_CHINHANH";

            //  dgv_inventory.DataSource = clsProduct._getProductInventory();

            dt = clsProduct._getGroupStores();
            dt.Rows.Add(new object[] { "0", "TẤT CẢ", "HCM" });
            cbo_timkiem.DataSource = dt;
            cbo_timkiem.ValueMember = "MA_CHINHANH";
            cbo_timkiem.DisplayMember = "TEN_CHINHANH";
            


            _getContent();
            _getPhieuKiemKe(-1);

            cbo_timkiem.StartIndex = dt.Rows.Count - 1;
            lbl_tong_thatthoat.Text = "0";
        }

        private void _getPhieuKiemKe(int startIndex)
        {
            DataTable dt = clsInventory._getMaTK();
            cbo_phieu_kiemke.DataSource = dt;
            cbo_phieu_kiemke.DisplayMember = "MATON";
            cbo_phieu_kiemke.ValueMember = "MATON";
            cbo_phieu_kiemke.StartIndex = startIndex;
        }
        private void cbo_timkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbo_timkiem.StartIndex == -1 ||
            if (cbo_timkiem.SelectedValue.ToString().Trim() == "0")
            {
                dgv_inventory.DataSource = clsProduct._getProductInventory();
                _getContent();

            }
            else
            {
                string vitri = cbo_timkiem.SelectedValue.ToString().Trim();
                dgv_inventory.DataSource = clsProduct._getProductInventory(vitri);
                _getContent();
            }
        }

        private void _getContent()
        {
            string ma = "";
            string tensp = "";
            if (dgv_inventory.RowCount > 0)
            {
                ma = dgv_inventory.Rows[dgv_inventory.SelectedRows[0].Index].Cells["MASP_CH"].Value.ToString().Trim();
                tensp = dgv_inventory.Rows[dgv_inventory.SelectedRows[0].Index].Cells["TENSP_CH"].Value.ToString().Trim();
            }
            string vitri = cbo_timkiem.SelectedValue.ToString().Trim();

            if (vitri == "0" || cbo_timkiem.StartIndex == -1)
            {
                DataTable dt = clsProduct._getSlTong(ma);
                if (dt.Rows[0]["TONG_SL"].ToString() != "")
                {
                    int sl = Convert.ToInt32(dt.Rows[0]["TONG_SL"].ToString());
                    lbl_soluong_tong.Text = string.Format("{0:#,###}", sl);
                }
                else
                {
                    lbl_soluong_tong.Text = "0";
                }
            }
            else
            {
                DataTable dt = clsProduct._getSlTong(ma, vitri);
                if (dt.Rows[0]["TONG_SL"].ToString() != "")
                {
                    int sl = Convert.ToInt32(dt.Rows[0]["TONG_SL"].ToString());
                    lbl_soluong_tong.Text = string.Format("{0:#,###}", sl);
                } else
                {
                    lbl_soluong_tong.Text = "0";
                }

            }


            DataTable dt_tb = clsProduct._getTbGianhap(ma);
            if (dt_tb.Rows[0]["TB_GIANHAP"].ToString() != "")
            {
                int s = Convert.ToInt32(dt_tb.Rows[0]["TB_GIANHAP"].ToString());
                lbl_gianhap_tb.Text = string.Format("{0:#,###}", s);
            } else
            {
                lbl_gianhap_tb.Text = "0";
            }

            txt_ma_sp.Text = ma;
            txt_ten_sp.Text = tensp;

        }
        private void dgv_inventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = txt_ma_sp.Text.Trim();
            _getContent();
            string maClick = dgv_inventory.Rows[dgv_inventory.SelectedRows[0].Index].Cells["MASP_CH"].Value.ToString().Trim();

            if (maClick != ma)
            {
                txt_ghichu.Text = "";
                txt_soluong_thucte.Text = "";
            }
        }

        private void txt_soluong_thucte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_kiem_ke_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn tạo đợt kiểm kê !", "Thông báo"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string maton = clsInventory._CreateMaKK();
                string vitri = cbo_timkiem.SelectedValue.ToString().Trim();
                string tennv = clsCommon.MANV;
                string date = DateTime.Now.ToString("yyyy/MM/dd");
                string tongThatThoat = "0";

                if (clsInventory._addNewKiemKe(maton, vitri, tennv, date, tongThatThoat))
                {
                    MessageBox.Show("Thêm thành công phiếu tồn kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataTable dt = clsInventory._getMaTK();
                    _getPhieuKiemKe(dt.Rows.Count - 1);
                }
                else
                {
                    MessageBox.Show("Lỗi thêm phiếu tồn kho", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_xemchitiet_Click(object sender, EventArgs e)
        {

            if (cbo_phieu_kiemke.Text != "")
            {
                clsInventory.makk = cbo_phieu_kiemke.SelectedValue.ToString().Trim();

                frmDialog f = new frmDialog();
                f.Size = new Size(720, 520);
                f.AddControlsToPanelDialog(new uc_inventory_detail());
                f.ShowDialog();
            }
        }

        private void txt_soluong_thucte_TextChanged(object sender, EventArgs e)
        {
            if (txt_soluong_thucte.Text == "")
            {
                btn_xacnhan.Enabled = false;
                lbl_giatri_thatthoat.Text = "0";
                lbl_soluong_chenhlech.Text = "0";
                lbl_tong_thatthoat.Text = string.Format("{0:#,###}", tong_that_thoat);
            } else
            {
                btn_xacnhan.Enabled = true;
                int slTong = Int32.Parse(lbl_soluong_tong.Text, styles);
                int sltt = Int32.Parse(txt_soluong_thucte.Text, styles);
                int gia_tb = Int32.Parse(lbl_gianhap_tb.Text, styles);

                int slLech = slTong - sltt;
                int giatri_thatthoat = gia_tb * slLech;



                if (giatri_thatthoat != 0) lbl_giatri_thatthoat.Text = string.Format("{0:#,###}", giatri_thatthoat);
                else lbl_giatri_thatthoat.Text = "0";
                if (slLech != 0) lbl_soluong_chenhlech.Text = string.Format("{0:#,###}", slLech);
                else lbl_soluong_chenhlech.Text = "0";

                if (TongThatThoat() != 0) lbl_tong_thatthoat.Text = string.Format("{0:#,###}", TongThatThoat());
                else lbl_tong_thatthoat.Text = "0";

            }
        }
        private int TongThatThoat()
        {
            int tongThatThoat = 0;
            int gthatthoat = Int32.Parse(lbl_giatri_thatthoat.Text, styles);

            tongThatThoat = gthatthoat + tong_that_thoat;

            return tongThatThoat;
        }
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            string maton = cbo_phieu_kiemke.SelectedValue.ToString().Trim();
            string masp = txt_ma_sp.Text.Trim();
            int sl = Int32.Parse(lbl_soluong_tong.Text, styles);
            int sl_tt = Int32.Parse(txt_soluong_thucte.Text, styles);
            int gianhap = Int32.Parse(lbl_gianhap_tb.Text, styles);
            string ghiChu = txt_ghichu.Text;

            //int tongThatThoat = Int32.Parse(lbl_tong_thatthoat.Text, styles);
            //tongThatThoat += ( (sl - sl_tt)  * gianhap );

           
            if (clsInventory._addKiemKeChiTiet(maton, masp, sl, sl_tt, gianhap, ghiChu))
            {
                clsInventory._updateTongTien(maton, TongThatThoat());
                tong_that_thoat = TongThatThoat();
                MessageBox.Show("Thêm thành công phiếu tồn kho chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {
                MessageBox.Show("Mã này đã được kiểm kê", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbo_phieu_kiemke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_phieu_kiemke.Text != "")
            {
                clsInventory.makk = cbo_phieu_kiemke.SelectedValue.ToString().Trim();
                DataTable dt_ttt = clsInventory._getTongThatThoat(clsInventory.makk);

                

                if (dt_ttt.Rows.Count > 0)
                {
                    cbo_timkiem.SelectedValue = dt_ttt.Rows[0]["VITRI_HANG"].ToString();
                    tong_that_thoat = Convert.ToInt32(dt_ttt.Rows[0]["TONG_THATTHOAT"].ToString());
                    if(tong_that_thoat != 0)
                        lbl_tong_thatthoat.Text = string.Format("{0:#,###}",tong_that_thoat);
                    else
                        lbl_tong_thatthoat.Text = "0";
                }
                else lbl_tong_thatthoat.Text = "0";

                btn_xacnhan.Enabled = false;
                lbl_giatri_thatthoat.Text = "0";
                lbl_soluong_chenhlech.Text = "0";
            }
        }

       

        private void btn_xuat_excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Export Excel";
            saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                clsCommon.ExportExcel(dgv_inventory, saveFileDialog1.FileName);
            }
        }
    }
}
