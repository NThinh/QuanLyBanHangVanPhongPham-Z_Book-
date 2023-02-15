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
    public partial class uc_Order : UserControl
    {
        public uc_Order()
        {
            InitializeComponent();
            changSearch(false);
           
        }

        private void changSearch (bool s)
        {
            dtp_ngay_dau.Visible = s;
            dtp_ngay_cuoi.Visible = s;
            txt_search.Visible = !s;
            txt_search.Location = new Point(11, 13);
            btn_tim_kiem.Visible = s;
        }      

        private void cbo_tim_kiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_tim_kiem.Text == "Theo thời gian")
            {
                changSearch(true);
            }else
            {
                changSearch(false);
            }
        }      

        private void checkSearch(string colName, string searchValue)
        {
            for (var i = 0; i < dgv_order.RowCount; i++)
            {
                if (searchValue == "")
                {
                    for (int j = 0; j < dgv_order.RowCount; j++)
                    {
                        dgv_order.Rows[j].Selected = false;
                    }
                    break;
                }
                else if (clsCommon.convertToUnSign2(dgv_order.Rows[i].Cells[colName].Value.ToString().ToLower())
                    .Contains(clsCommon.convertToUnSign2(searchValue.ToString()).ToLower().Trim()))
                {
                    dgv_order.Rows[i].Selected = true;
                    break;
                }
                else
                {
                    dgv_order.Rows[i].Selected = false;
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text;

            switch (cbo_tim_kiem.Text)
            {
                case "Theo mã hóa đơn":
                    checkSearch("MAHD", searchValue);
                    break;                      
            }

        }

        private void btn_tim_kiem_Click(object sender, EventArgs e)
        {
            DateTime ngaydau = Convert.ToDateTime(dtp_ngay_dau.Text);
            DateTime ngaycuoi = Convert.ToDateTime(dtp_ngay_cuoi.Text);
            
            for (int i = 0; i < dgv_order.RowCount; i++)
            {
                DateTime ngaysosanh = Convert.ToDateTime(dgv_order.Rows[i].Cells["NGAYBAN"].Value);
                if( ngaydau.Year <= ngaysosanh.Year && ngaysosanh.Year <= ngaycuoi.Year)
                {
                    if (ngaydau.Month <= ngaysosanh.Month && ngaysosanh.Month <= ngaycuoi.Month)
                    {
                        if(ngaydau.Day <= ngaysosanh.Day && ngaysosanh.Day <= ngaycuoi.Day)
                        {
                            dgv_order.Rows[i].Selected = true;
                        }else
                        {
                            dgv_order.Rows[i].Selected = false;
                        }
                    }
                    else
                    {
                        dgv_order.Rows[i].Selected = false;
                    }
                }
                else
                {
                    dgv_order.Rows[i].Selected = false;
                }

            }

        }

        private void uc_Order_Load(object sender, EventArgs e)
        {
            NHANVIEN_MA.DataSource = clsOrder._getGroupNV();
            NHANVIEN_MA.DisplayMember = "TENNV";
            NHANVIEN_MA.ValueMember = "MANV";

            KHACHHANG_MA.DataSource = clsOrder._getGroupKH();
            KHACHHANG_MA.DisplayMember = "TEN_KH";
            KHACHHANG_MA.ValueMember = "MAKH";

            VITRI.DataSource = clsProduct._getGroupStores();
            VITRI.ValueMember = "MA_CHINHANH";
            VITRI.DisplayMember = "TEN_CHINHANH";

            dgv_order.DataSource = clsOrder._getBill(clsCommon.CHINHANH);
            clsCommon.setRowNumber(dgv_order);

            profit();

        }

        private  void profit()
        {
            DateTime date = DateTime.Now;
            string time = String.Format("{0:dd/MM/yyyy}", date);
            double profitDay = 0;
            double profitMonth = 0;
            double profitYear = 0;

            for (int i = 0; i < dgv_order.RowCount; i++)
            {
                DateTime str = DateTime.Parse( dgv_order.Rows[i].Cells["NGAYBAN"].Value.ToString());
                double total_money = Convert.ToInt32(dgv_order.Rows[i].Cells["TONGTIEN"].Value.ToString() );
                string time1 = String.Format("{0:dd/MM/yyyy}", str);

                if (time1.Substring(0, 10).Equals(time.Substring(0, 10)))
                {
                    profitDay += total_money;
                }
                if (time1.Substring(3, 7).Equals(time.Substring(3, 7)))
                {
                    profitMonth += total_money;
                }
                if(time1.Substring(6,4).Equals(time.Substring(6,4)))
                {
                    profitYear += total_money;
                }
            }
            
            if (profitDay != 0) lbl_profit_day.Text = string.Format("{0:#,###}", profitDay);
            if (profitMonth != 0) lbl_profit_month.Text = string.Format("{0:#,###}", profitMonth);
            if (profitYear != 0) lbl_profit_year.Text = string.Format("{0:#,###}", profitYear);
        }

        //private void dgv_order_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        //{
        //   // clsCommon.setImageED(e);
        //}

        private void btn_detail_Click(object sender, EventArgs e)
        {
            if (dgv_order.SelectedRows.Count == 1)
            {

                clsOrder.mahd = dgv_order.Rows[dgv_order.SelectedRows[0].Index].Cells["MAHD"].Value.ToString();
                clsOrder.nhanvien = dgv_order.Rows[dgv_order.SelectedRows[0].Index].Cells["NHANVIEN_MA"].Value.ToString();
                clsOrder.khachhang = dgv_order.Rows[dgv_order.SelectedRows[0].Index].Cells["KHACHHANG_MA"].Value.ToString();
                clsOrder.ngayban = dgv_order.Rows[dgv_order.SelectedRows[0].Index].Cells["NGAYBAN"].Value.ToString();
                clsOrder.giamgia = Convert.ToDouble(dgv_order.Rows[dgv_order.SelectedRows[0].Index].Cells["GIAGIAM"].Value.ToString());
                clsOrder.tongtien = Convert.ToDouble(dgv_order.Rows[dgv_order.SelectedRows[0].Index].Cells["TONGTIEN"].Value.ToString());


                frmDialog f = new frmDialog();
                f.Size = new Size(720, 520);
                f.AddControlsToPanelDialog(new uc_Order_detail());
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 thông tin !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }         
        }

       
       
        private void dtp_ngay_cuoi_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngaydau = Convert.ToDateTime(dtp_ngay_dau.Text);
            DateTime ngaycuoi = Convert.ToDateTime(dtp_ngay_cuoi.Text);

            TimeSpan time = ngaycuoi.Subtract(ngaydau);
            // dòng tiền doanh thu lợi nhuận
            // hàng tồn kho , giá vốn bình quân đầu vào
            if(time.Days < 0)
            {
                errorProvider1.SetError(dtp_ngay_cuoi, "Lỗi chọn ngày !");
                e.Cancel = true;
            }else
            {
                errorProvider1.SetError(dtp_ngay_cuoi, "");
                e.Cancel = false;
            }
        }

        private void dtp_ngay_dau_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngaydau = Convert.ToDateTime(dtp_ngay_dau.Text);
            DateTime ngaycuoi = Convert.ToDateTime(dtp_ngay_cuoi.Text);

            TimeSpan time = ngaydau.Subtract(ngaycuoi);

            if(time.Days <= 0)
            {
                errorProvider1.SetError(dtp_ngay_dau, "");
                e.Cancel = false;
            }else
            {
                errorProvider1.SetError(dtp_ngay_dau, "Lỗi chọn ngày");
                e.Cancel = true;
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
                clsCommon.ExportExcel(dgv_order, saveFileDialog1.FileName);
            }
        }
    }
}
