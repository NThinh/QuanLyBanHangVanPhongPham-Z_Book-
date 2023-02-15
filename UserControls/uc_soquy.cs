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
    public partial class uc_soquy : UserControl
    {
        public uc_soquy()
        {
            InitializeComponent();
        }

        private void checkSearch(string colName, string searchValue)
        {
            for (var i = 0; i < dgv_soquy.RowCount; i++)
            {
                if (searchValue == "")
                {
                    for (int j = 0; j < dgv_soquy.RowCount; j++)
                    {
                        dgv_soquy.Rows[j].Selected = false;
                    }
                    break;
                }
                else if (clsCommon.convertToUnSign2(dgv_soquy.Rows[i].Cells[colName].Value.ToString().ToLower())
                    .Contains(clsCommon.convertToUnSign2(searchValue.ToString()).ToLower().Trim()))
                {
                    dgv_soquy.Rows[i].Selected = true;
                    break;
                }
                else
                {
                    dgv_soquy.Rows[i].Selected = false;
                }
            }
        }
        public void uc_soquy_Load(object sender, EventArgs e)
        {
            CHINHANH.DataSource = clsProduct._getGroupStores();
            CHINHANH.DisplayMember = "TEN_CHINHANH";
            CHINHANH.ValueMember = "MA_CHINHANH";

            lbl_ngay_today.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dgv_soquy.DataSource = clsCashBook._getCashBook(clsCommon.CHINHANH);   
            if(dgv_soquy.RowCount > 0)
            {
                _getContent();
            }else
            {
                tongDau = 0;
                tongCuoi = 0;
                _getMoney();
                _clearTextBoxStart();
                _clearTextBoxEnd();           
            }
        }

        private void _getMoney()
        {
            if(dgv_soquy.RowCount > 0)
            {
                int tiendaungay = 0;
                int tiencuoingay = 0;
                if (dgv_soquy.SelectedRows.Count > 0) 
                {
                    tiendaungay = Convert.ToInt32(dgv_soquy.Rows[dgv_soquy.SelectedRows[0].Index].Cells["TIENDAUNGAY"].Value.ToString());
                    tiencuoingay = Convert.ToInt32(dgv_soquy.Rows[dgv_soquy.SelectedRows[0].Index].Cells["TIENCUOINGAY"].Value.ToString());
                }
              

                if (tiendaungay == 0) lbl_tongtien_dau.Text = "0";
                else lbl_tongtien_dau.Text = string.Format("{0:#,###}", tiendaungay);
                if (tiencuoingay == 0) lbl_tongtien_cuoi.Text = "0";
                else lbl_tongtien_cuoi.Text = string.Format("{0:#,###}", tiencuoingay);
            }
        }

        private void _getContent()
        {
          
            string today = DateTime.Now.ToString("dd/MM/yyyy").Trim();
            lbl_ngay_today.Text = today;
            for (int i = 0; i < dgv_soquy.RowCount; i++)
            {
                DateTime date1 = DateTime.Parse( dgv_soquy.Rows[i].Cells["NGAY"].Value.ToString().Trim());
                string date = date1.ToString("dd/MM/yyyy"); 
                
                if (today == date.Substring(0,10))
                {
                    int tiendau_today = Convert.ToInt32(dgv_soquy.Rows[i].Cells["TIENDAUNGAY"].Value.ToString().Trim());
                    int tiencuoi_today = Convert.ToInt32(dgv_soquy.Rows[i].Cells["TIENCUOINGAY"].Value.ToString().Trim());

                    if (tiendau_today == 0) lbl_tienday_ngay_today.Text = "0";
                    else lbl_tienday_ngay_today.Text = string.Format("{0:#,###}", tiendau_today);
                    if (tiencuoi_today == 0) lbl_tiencuoi_ngay_today.Text = "0";
                    else lbl_tiencuoi_ngay_today.Text = string.Format("{0:#,###}", tiencuoi_today);
                }
            }
                     
            string ma = clsCashBook.id.Trim();
            if (ma == "" && dgv_soquy.Rows.Count > 0) ma = dgv_soquy.Rows[0].Cells["ID"].Value.ToString().Trim();
            else
            {
                dgv_soquy.Rows[dgv_soquy.Rows.Count - 1].Selected = true;
                dgv_soquy.Rows[0].Selected = false;
            }
            _getMoney();
            _getContentDetail(ma);


        }

        private void _clearTextBoxStart()
        {
            txt_to500_dau.Text = "";
            txt_to200_dau.Text = "";
            txt_to100_dau.Text = "";
            txt_to50_dau.Text = "";
            txt_to20_dau.Text = "";
            txt_to10_dau.Text = "";
            txt_to5_dau.Text = "";
            txt_to2_dau.Text = "";
            txt_to1_dau.Text = "";
            txt_to0_5_dau.Text = "";

        }
        private void _setTextBoxStart(DataTable dt, int i)
        {
            txt_to500_dau.Text = dt.Rows[i]["TO_500"].ToString();
            txt_to200_dau.Text = dt.Rows[i]["TO_200"].ToString();
            txt_to100_dau.Text = dt.Rows[i]["TO_100"].ToString();
            txt_to50_dau.Text = dt.Rows[i]["TO_50"].ToString();
            txt_to20_dau.Text = dt.Rows[i]["TO_20"].ToString();
            txt_to10_dau.Text = dt.Rows[i]["TO_10"].ToString();
            txt_to5_dau.Text = dt.Rows[i]["TO_5"].ToString();
            txt_to2_dau.Text = dt.Rows[i]["TO_2"].ToString();
            txt_to1_dau.Text = dt.Rows[i]["TO_1"].ToString();
            txt_to0_5_dau.Text = dt.Rows[i]["TO_0_5"].ToString();
        }
        private void _setTextBoxEnd(DataTable dt, int i)
        {
            txt_to500_cuoi.Text = dt.Rows[i]["TO_500"].ToString();
            txt_to200_cuoi.Text = dt.Rows[i]["TO_200"].ToString();
            txt_to100_cuoi.Text = dt.Rows[i]["TO_100"].ToString();
            txt_to50_cuoi.Text = dt.Rows[i]["TO_50"].ToString();
            txt_to20_cuoi.Text = dt.Rows[i]["TO_20"].ToString();
            txt_to10_cuoi.Text = dt.Rows[i]["TO_10"].ToString();
            txt_to5_cuoi.Text = dt.Rows[i]["TO_5"].ToString();
            txt_to2_cuoi.Text = dt.Rows[i]["TO_2"].ToString();
            txt_to1_cuoi.Text = dt.Rows[i]["TO_1"].ToString();
            txt_to0_5_cuoi.Text = dt.Rows[i]["TO_0_5"].ToString();
        }
        private void _clearTextBoxEnd()
        {
            txt_to500_cuoi.Text = "";
            txt_to200_cuoi.Text = "";
            txt_to100_cuoi.Text = "";
            txt_to50_cuoi.Text = "";
            txt_to20_cuoi.Text = "";
            txt_to10_cuoi.Text = "";
            txt_to5_cuoi.Text = "";
            txt_to2_cuoi.Text = "";
            txt_to1_cuoi.Text = "";
            txt_to0_5_cuoi.Text = "";
        }

        private void _getContentDetail(string ma)
        {
            DataTable dt = clsCashBook._getCashBook_detail(ma);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if(dt.Rows.Count > 1)
                    {
                        if (dt.Rows[i]["STT"].ToString() == "1")
                        {
                            _setTextBoxStart(dt, i);
                        }
                        else
                        {
                            _setTextBoxEnd(dt, i);
                        }
                    }else
                    {
                        if (dt.Rows[i]["STT"].ToString() == "1")
                        {
                            _setTextBoxStart(dt, i);
                            _clearTextBoxEnd();
                        }
                        else
                        {
                            _setTextBoxEnd(dt, i);
                            _clearTextBoxStart();
                        }
                    }
                }
            } else
            {
                _clearTextBoxStart();
                _clearTextBoxEnd();               
            }
        }

      

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text;
            checkSearch("NGAY", searchValue);
        }

        private void dgv_soquy_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            
            clsCashBook.id = dgv_soquy.Rows[dgv_soquy.SelectedRows[0].Index].Cells["ID"].Value.ToString();
            _getMoney();
            _getContentDetail(clsCashBook.id);
            string tiendau = dgv_soquy.Rows[dgv_soquy.SelectedRows[0].Index].Cells["TIENDAUNGAY"].Value.ToString();
            string tiencuoi = dgv_soquy.Rows[dgv_soquy.SelectedRows[0].Index].Cells["TIENCUOINGAY"].Value.ToString();
            if (tiendau == "0")
            {
                
                changeTextDau(true);
            }else
            {
                changeTextDau(false);
            }

            if (tiencuoi == "0")
            {
                changeTextCuoi(true);
            }
            else
            {
                changeTextCuoi(false);
            }
        }

        private void txt_to500_dau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_to500_cuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void changeTextDau(bool btn)
        {
            txt_to500_dau.Enabled = btn;
            txt_to200_dau.Enabled = btn;
            txt_to100_dau.Enabled = btn;
            txt_to50_dau.Enabled = btn;
            txt_to20_dau.Enabled = btn;
            txt_to10_dau.Enabled = btn;
            txt_to5_dau.Enabled = btn;
            txt_to2_dau.Enabled = btn;
            txt_to1_dau.Enabled = btn;
            txt_to0_5_dau.Enabled = btn;

            btn_xacnhan_dau.Enabled = btn;
            btn_xoa_dau.Enabled = btn;


        }
        private void changeTextCuoi(bool btn)
        {
            txt_to500_cuoi.Enabled = btn;
            txt_to200_cuoi.Enabled = btn;
            txt_to100_cuoi.Enabled = btn;
            txt_to50_cuoi.Enabled = btn;
            txt_to20_cuoi.Enabled = btn;
            txt_to10_cuoi.Enabled = btn;
            txt_to5_cuoi.Enabled = btn;
            txt_to2_cuoi.Enabled = btn;
            txt_to1_cuoi.Enabled = btn;
            txt_to0_5_cuoi.Enabled = btn;

            btn_xacnhan_cuoi.Enabled = btn;
            btn_xoa_cuoi.Enabled = btn;

        }
        private void btn_them_soquy_Click(object sender, EventArgs e)
        {
            Boolean check = false;
            string today = DateTime.Now.ToString("dd/MM/yyyy").Trim();
            for (int i = 0; i < dgv_soquy.RowCount; i++)
            {
                DateTime str = DateTime.Parse(dgv_soquy.Rows[i].Cells["NGAY"].Value.ToString());
                string date = string.Format("{0:dd/MM/yyyy}", str);
                if(today == date)
                {
                    MessageBox.Show("Sổ quỹ hôm nay đã được tạo !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = true;
                    break;
                }
            }
            if(!check)
            {
                clsCashBook.id = clsCashBook._CreateMaCash();
                string date = DateTime.Now.ToString("yyyy/MM/dd").Trim();
                if (clsCashBook._addNewCashBook(clsCashBook.id,date,"0","0",clsCommon.CHINHANH.Trim()))
                {
                    MessageBox.Show("Tạo sổ quỹ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uc_soquy_Load(sender, e);                    
                }else
                {
                    MessageBox.Show("Lỗi tạo sổ quỹ", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);                 
                }
                
            }
        }

        private int tongDau = 0;
        private int tongCuoi = 0;       

        private void txt_to500_dau_TextChanged(object sender, EventArgs e)
        {
            int t500 = 0;
            int t200 = 0;
            int t100 = 0;
            int t50 = 0;
            int t20 = 0;
            int t10 = 0;
            int t5 = 0;
            int t2 = 0;
            int t1 = 0;
            int t0_5 = 0;

            if (txt_to500_dau.Text != "") t500 = Convert.ToInt32(txt_to500_dau.Text);
            if (txt_to200_dau.Text != "") t200 = Convert.ToInt32(txt_to200_dau.Text);
            if (txt_to100_dau.Text != "") t100 = Convert.ToInt32(txt_to100_dau.Text);
            if (txt_to50_dau.Text != "") t50 = Convert.ToInt32(txt_to50_dau.Text);
            if (txt_to20_dau.Text != "") t20 = Convert.ToInt32(txt_to20_dau.Text);
            if (txt_to10_dau.Text != "") t10 = Convert.ToInt32(txt_to10_dau.Text);
            if (txt_to5_dau.Text != "") t5 = Convert.ToInt32(txt_to5_dau.Text);
            if (txt_to2_dau.Text != "") t2 = Convert.ToInt32(txt_to2_dau.Text);
            if (txt_to1_dau.Text != "") t1 = Convert.ToInt32(txt_to1_dau.Text);
            if (txt_to0_5_dau.Text != "") t0_5 = Convert.ToInt32(txt_to0_5_dau.Text);

            tongDau = (t500 * 500000) + (t200 * 200000) + (t100 * 100000) + (t50 * 50000)
                + (t20 * 20000) + (t10 * 10000) + (t5 * 5000) + (t2 * 2000) + (t1 * 1000) + (t0_5 * 500);
            if (tongDau == 0) lbl_tongtien_dau.Text = "0";
            else lbl_tongtien_dau.Text = string.Format("{0:#,###}", tongDau);
        }

        private void txt_to500_cuoi_TextChanged(object sender, EventArgs e)
        {
            int t500 = 0;
            int t200 = 0;
            int t100 = 0;
            int t50 = 0;
            int t20 = 0;
            int t10 = 0;
            int t5 = 0;
            int t2 = 0;
            int t1 = 0;
            int t0_5 = 0;

            if (txt_to500_cuoi.Text != "") t500 = Convert.ToInt32(txt_to500_cuoi.Text);
            if (txt_to200_cuoi.Text != "") t200 = Convert.ToInt32(txt_to200_cuoi.Text);
            if (txt_to100_cuoi.Text != "") t100 = Convert.ToInt32(txt_to100_cuoi.Text);
            if (txt_to50_cuoi.Text != "") t50 = Convert.ToInt32(txt_to50_cuoi.Text);
            if (txt_to20_cuoi.Text != "") t20 = Convert.ToInt32(txt_to20_cuoi.Text);
            if (txt_to10_cuoi.Text != "") t10 = Convert.ToInt32(txt_to10_cuoi.Text);
            if (txt_to5_cuoi.Text != "") t5 = Convert.ToInt32(txt_to5_cuoi.Text);
            if (txt_to2_cuoi.Text != "") t2 = Convert.ToInt32(txt_to2_cuoi.Text);
            if (txt_to1_cuoi.Text != "") t1 = Convert.ToInt32(txt_to1_cuoi.Text);
            if (txt_to0_5_cuoi.Text != "") t0_5 = Convert.ToInt32(txt_to0_5_cuoi.Text);

            tongCuoi = (t500 * 500000) + (t200 * 200000) + (t100 * 100000) + (t50 * 50000)
                + (t20 * 20000) + (t10 * 10000) + (t5 * 5000) + (t2 * 2000) + (t1 * 1000) + (t0_5 * 500);

            if (tongCuoi == 0) lbl_tongtien_cuoi.Text = "0";
            else lbl_tongtien_cuoi.Text = string.Format("{0:#,###}", tongCuoi);

        }

        private void btn_xacnhan_dau_Click(object sender, EventArgs e)
        {
            int stt = 1;
            int t500 = 0;
            int t200 = 0;
            int t100 = 0;
            int t50 = 0;
            int t20 = 0;
            int t10 = 0;
            int t5 = 0;
            int t2 = 0;
            int t1 = 0;
            int t0_5 = 0;

            if (txt_to500_dau.Text != "") t500 = Convert.ToInt32(txt_to500_dau.Text);
            if (txt_to200_dau.Text != "") t200 = Convert.ToInt32(txt_to200_dau.Text);
            if (txt_to100_dau.Text != "") t100 = Convert.ToInt32(txt_to100_dau.Text);
            if (txt_to50_dau.Text != "") t50 = Convert.ToInt32(txt_to50_dau.Text);
            if (txt_to20_dau.Text != "") t20 = Convert.ToInt32(txt_to20_dau.Text);
            if (txt_to10_dau.Text != "") t10 = Convert.ToInt32(txt_to10_dau.Text);
            if (txt_to5_dau.Text != "") t5 = Convert.ToInt32(txt_to5_dau.Text);
            if (txt_to2_dau.Text != "") t2 = Convert.ToInt32(txt_to2_dau.Text);
            if (txt_to1_dau.Text != "") t1 = Convert.ToInt32(txt_to1_dau.Text);
            if (txt_to0_5_dau.Text != "") t0_5 = Convert.ToInt32(txt_to0_5_dau.Text);

            if (clsCashBook._insertStartCash(clsCashBook.id, stt, t500, t200, t100, t50, t20, t10, t5, t2, t1, t0_5))
            {
                if (clsCashBook._updateMoneyStart(clsCashBook.id, tongDau))
                {
                    MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Lỗi khi thêm !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            uc_soquy_Load(sender, e);
        }

        private void btn_xoa_dau_Click(object sender, EventArgs e)
        {
            txt_to500_dau.Text = "";
            txt_to200_dau.Text = "";
            txt_to100_dau.Text = "";
            txt_to50_dau.Text = "";
            txt_to20_dau.Text = "";
            txt_to10_dau.Text = ""; 
            txt_to5_dau.Text = ""; 
            txt_to2_dau.Text = "";
            txt_to1_dau.Text = "";
            txt_to0_5_dau.Text = ""; 
        }

        private void btn_xacnhan_cuoi_Click(object sender, EventArgs e)
        {
            int stt = 2;
            int t500 = 0;
            int t200 = 0;
            int t100 = 0;
            int t50 = 0;
            int t20 = 0;
            int t10 = 0;
            int t5 = 0;
            int t2 = 0;
            int t1 = 0;
            int t0_5 = 0;

            if (txt_to500_cuoi.Text != "") t500 = Convert.ToInt32(txt_to500_cuoi.Text);
            if (txt_to200_cuoi.Text != "") t200 = Convert.ToInt32(txt_to200_cuoi.Text);
            if (txt_to100_cuoi.Text != "") t100 = Convert.ToInt32(txt_to100_cuoi.Text);
            if (txt_to50_cuoi.Text != "") t50 = Convert.ToInt32(txt_to50_cuoi.Text);
            if (txt_to20_cuoi.Text != "") t20 = Convert.ToInt32(txt_to20_cuoi.Text);
            if (txt_to10_cuoi.Text != "") t10 = Convert.ToInt32(txt_to10_cuoi.Text);
            if (txt_to5_cuoi.Text != "") t5 = Convert.ToInt32(txt_to5_cuoi.Text);
            if (txt_to2_cuoi.Text != "") t2 = Convert.ToInt32(txt_to2_cuoi.Text);
            if (txt_to1_cuoi.Text != "") t1 = Convert.ToInt32(txt_to1_cuoi.Text);
            if (txt_to0_5_cuoi.Text != "") t0_5 = Convert.ToInt32(txt_to0_5_cuoi.Text);

            // check doanh thu cửa hàng ngày hôm đó
            int doanhthungay = _checkdoanhthu();
            if(tongCuoi != (doanhthungay + tongDau))
            {
                DialogResult result = MessageBox.Show("Doanh thu lệch so với bảng kê tiền là : " 
                    + string.Format("{0:#,###}",(tongCuoi - (tongDau + doanhthungay)) )+ " đồng \nBạn có muốn tiếp tục ?"
                   , "Cảnh báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(result == DialogResult.OK)
                {
                    if (clsCashBook._insertStartCash(clsCashBook.id, stt, t500, t200, t100, t50, t20, t10, t5, t2, t1, t0_5))
                    {
                        if (clsCashBook._updateMoneyEnd(clsCashBook.id, tongCuoi))
                        {
                            MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi thêm !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    uc_soquy_Load(sender, e);
                }               
            }             
        }

        private int _checkdoanhthu()
        {
            DateTime time = DateTime.Parse( dgv_soquy.Rows[dgv_soquy.SelectedRows[0].Index].Cells["NGAY"].Value.ToString());

            DataTable dt_doanhthu = clsOrder._getDoanhThuNgay(time.ToString("yyyy/MM/dd"),clsCommon.CHINHANH);

            int doanhthu = Convert.ToInt32( dt_doanhthu.Rows[0][0].ToString());

           return doanhthu ;     
        }

        private void btn_xoa_cuoi_Click(object sender, EventArgs e)
        {
            txt_to500_cuoi.Text = "";
            txt_to200_cuoi.Text = "";
            txt_to100_cuoi.Text = "";
            txt_to50_cuoi.Text = "";
            txt_to20_cuoi.Text = "";
            txt_to10_cuoi.Text = "";
            txt_to5_cuoi.Text = "";
            txt_to2_cuoi.Text = "";
            txt_to1_cuoi.Text = "";
            txt_to0_5_cuoi.Text = "";
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Export Excel";
            saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                clsCommon.ExportExcel(dgv_soquy, saveFileDialog1.FileName);
            }
        }
    }
}
