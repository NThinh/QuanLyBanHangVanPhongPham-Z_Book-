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
    public partial class uc_nhacungcap : UserControl
    {
        public uc_nhacungcap()
        {
            InitializeComponent();
        }
        private bool check = false;

        private void changeBtn(bool b)
        {
            btn_them.Enabled = b;
            btn_sua.Enabled = b;
            btn_luu.Enabled = !b;
            btn_huy.Enabled = !b;
            btn_xoa.Enabled = b;

            txt_hoten.Enabled = !b;
            txt_diachi.Enabled = !b;
            txt_sdt.Enabled = !b;
            txt_stk.Enabled = !b;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _getContent()
        {
            txt_ma.Text = dgvNCC.Rows[dgvNCC.SelectedRows[0].Index].Cells["MA_NCC"].Value.ToString();
            txt_hoten.Text = dgvNCC.Rows[dgvNCC.SelectedRows[0].Index].Cells["TEN_NCC"].Value.ToString();
            txt_diachi.Text = dgvNCC.Rows[dgvNCC.SelectedRows[0].Index].Cells["DIACHI"].Value.ToString();
            txt_stk.Text = dgvNCC.Rows[dgvNCC.SelectedRows[0].Index].Cells["STK"].Value.ToString();
            txt_sdt.Text = dgvNCC.Rows[dgvNCC.SelectedRows[0].Index].Cells["SDT"].Value.ToString();
        }

        private void checkSearch(string colName, string searchValue)
        {
            for (var i = 0; i < dgvNCC.RowCount; i++)
            {
                if (searchValue == "")
                {
                    for (int j = 0; j < dgvNCC.RowCount; j++)
                    {
                        dgvNCC.Rows[j].Selected = false;
                    }
                    break;
                }
                else if (clsCommon.convertToUnSign2(dgvNCC.Rows[i].Cells[colName].Value.ToString().ToLower())
                    .Contains(clsCommon.convertToUnSign2(searchValue.ToString()).ToLower().Trim()))
                {
                    dgvNCC.Rows[i].Selected = true;
                    break;
                }
                else
                {
                    dgvNCC.Rows[i].Selected = false;
                }
            }
        }

        private void uc_nhacungcap_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = clsSupplier._getNCC();
        }

        private void cbo_tim_kiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text;
            if (cbo_tim_kiem.Text == "Theo mã")
            {                
                checkSearch("MA_NCC", searchValue);
            }else
            {               
                checkSearch("TEN_NCC", searchValue);
            }
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _getContent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            textClear();
            changeBtn(false);
            check = true;
            txt_ma.Text = clsSupplier._CreateMANCC();

        }

        private void textClear()
        {
            txt_ma.Text = "";
            txt_hoten.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            txt_stk.Text = "";
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            changeBtn(false);
            check = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgvNCC.RowCount > 0)
            {
                string ma = dgvNCC.Rows[dgvNCC.SelectedRows[0].Index].Cells["MA_NCC"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn muốn xóa nhà cung cấp có Mã : " + ma, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (clsSupplier._delNCC(ma))
                    {
                        MessageBox.Show("Xóa nhân viên thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textClear();
                        uc_nhacungcap_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên Thất bại ", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string ma = txt_ma.Text ;
            string hoten = txt_hoten.Text;
            string diachi = txt_diachi.Text ;
            string stk = txt_stk.Text ;
            string sdt = txt_sdt.Text ;

            if (check == true) // thêm
            {
                if (clsSupplier._insertNCC(ma, hoten, diachi, stk, sdt))
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uc_nhacungcap_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp  thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textClear();
                changeBtn(true);
            }
            else
            {

                if (clsSupplier._updateNCC(ma, hoten, diachi, stk, sdt))
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uc_nhacungcap_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textClear();
                changeBtn(true);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            textClear();
            changeBtn(true);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Export Excel";
            saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                clsCommon.ExportExcel(dgvNCC, saveFileDialog1.FileName);
            }
        }
    }
}
