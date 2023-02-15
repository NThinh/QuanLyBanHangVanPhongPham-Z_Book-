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
    public partial class uc_congno : UserControl
    {
        public uc_congno()
        {
            InitializeComponent();
        }
        private const string CHOXULY = "CHỜ XỬ LÝ";
        private const string DATHANHTOAN = "ĐÃ THANH TOÁN";
        public void uc_congno_Load(object sender, EventArgs e)
        {
            MA_NCC.DataSource = clsSupplier._getGroupNCC();
            MA_NCC.DisplayMember = "TEN_NCC";
            MA_NCC.ValueMember = "MA_NCC";

            dgv_congno.DataSource = clsSupplier._getCongNo();

            if(dgv_congno.RowCount > 0)
            {
                int tong = 0;
                for (int i = 0; i < dgv_congno.RowCount; i++)
                {
                    if( dgv_congno.Rows[i].Cells["TRANGTHAI"].Value.ToString() == CHOXULY)
                    {
                        tong += Convert.ToInt32(dgv_congno.Rows[i].Cells["CONNO"].Value.ToString());
                        dgv_congno.Rows[i].Cells["TRANGTHAI"].Style.ForeColor = Color.Red;
                    }else
                    {                        
                        dgv_congno.Rows[i].Cells["TRANGTHAI"].Style.ForeColor = Color.Green;                    
                    }
                }
                lbl_soluong.Text = dgv_congno.RowCount.ToString().Trim();

                if (tong == 0) lbl_tong_congno.Text = "0";
                else lbl_tong_congno.Text = String.Format("{0:#,###}", tong);
            }
        }
        private void checkSearch(string colName, string searchValue)
        {
            for (var i = 0; i < dgv_congno.RowCount; i++)
            {
                if (searchValue == "")
                {
                    for (int j = 0; j < dgv_congno.RowCount; j++)
                    {
                        dgv_congno.Rows[j].Selected = false;
                    }
                    break;
                }
                else if (clsCommon.convertToUnSign2(dgv_congno.Rows[i].Cells[colName].Value.ToString().ToLower())
                    .Contains(clsCommon.convertToUnSign2(searchValue.ToString()).ToLower().Trim()))
                {
                    dgv_congno.Rows[i].Selected = true;
                    break;
                }
                else
                {
                    dgv_congno.Rows[i].Selected = false;
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text;
            checkSearch("MA_PHIEUNHAP", searchValue);
        }

        private void btn_tattoan_Click(object sender, EventArgs e)
        {
            if(dgv_congno.RowCount > 0)
            {
                string trangthaino = dgv_congno.Rows[dgv_congno.SelectedRows[0].Index].Cells["TRANGTHAI"].Value.ToString();
                string nhacungcap = dgv_congno.Rows[dgv_congno.SelectedRows[0].Index].Cells["MA_NCC"].Value.ToString();
                string mapn = dgv_congno.Rows[dgv_congno.SelectedRows[0].Index].Cells["MA_PHIEUNHAP"].Value.ToString();
                if(trangthaino == CHOXULY)
                {
                    trangthaino = DATHANHTOAN;
                    if(clsSupplier._updateTrangThaiCongNo(nhacungcap, mapn, trangthaino))
                    {
                        cls_Import._updateConNo(mapn, "0");
                        MessageBox.Show("Thanh toán thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        uc_congno_Load(sender, e);
                    }                    
                   
                }else
                {
                    MessageBox.Show("Công nợ đã được thanh toán", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                clsCommon.ExportExcel(dgv_congno, saveFileDialog1.FileName);
            }
        }
    }
}
