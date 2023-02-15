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
    public partial class uc_nhanvien : UserControl
    {
        public uc_nhanvien()
        {
            InitializeComponent();
        }
        private bool check = false;
       
        private void uc_nhanvien_Load(object sender, EventArgs e)
        {
            dgvNhanvien.DataSource = clsEmploys._getNhanVien();

            cbo_quyen.DataSource = clsCommon._getMaQuyen();
            cbo_quyen.DisplayMember = "TEN_QUYEN";
            cbo_quyen.ValueMember = "MA_QUYEN";
        }

        private void changeBtn(bool b)
        {
            btn_them.Enabled = b;
            btn_sua.Enabled = b;

            btn_luu.Enabled = !b;
            btn_huy.Enabled = !b;
            btn_xoa.Enabled = b;

          
            txt_hoten.Enabled = !b;
            dtp_ngay.Enabled = !b;
            txt_diachi.Enabled = !b;
            txt_sdt.Enabled = !b;
            txt_chucvu.Enabled = !b;
            cbo_quyen.Enabled = !b;
            txt_taikhoan.Enabled = !b;
            txt_mk.Enabled = !b;
        }

        
        private void textClear()
        {
            txt_ma.Text = "";
            txt_hoten.Text = "";
            dtp_ngay.Text= "";
            txt_diachi.Text = "";
            txt_sdt.Text= "";
            txt_chucvu.Text = "";
            cbo_quyen.Text = "";
            txt_taikhoan.Text = "";
            txt_mk.Text ="";
        }
        private void checkSearch(string colName, string searchValue)
        {
            for (var i = 0; i < dgvNhanvien.RowCount; i++)
            {
                if (searchValue == "")
                {
                    for (int j = 0; j < dgvNhanvien.RowCount; j++)
                    {
                        dgvNhanvien.Rows[j].Selected = false;
                    }
                    break;
                }
                else if (clsCommon.convertToUnSign2(dgvNhanvien.Rows[i].Cells[colName].Value.ToString().ToLower())
                    .Contains(clsCommon.convertToUnSign2(searchValue.ToString()).ToLower().Trim()))
                {
                    dgvNhanvien.Rows[i].Selected = true;
                    break;
                }
                else
                {
                    dgvNhanvien.Rows[i].Selected = false;
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text;
            if (cbo_tim_kiem.Text == "Theo mã")
            {
                checkSearch("MANV", searchValue);
            }
            else
            {
                checkSearch("TENNV", searchValue);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {         
            textClear();
            changeBtn(false);
            check = true;
            txt_ma.Text = clsEmploys._CreateMaNV();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            changeBtn(false);
            check = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(dgvNhanvien.RowCount > 0)
            {
                string ma = dgvNhanvien.Rows[dgvNhanvien.SelectedRows[0].Index].Cells["MANV"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn muốn xóa nhân viên có Mã : " + ma, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    if (clsEmploys._delNV(ma))
                    {
                        MessageBox.Show("Xóa nhân viên thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        uc_nhanvien_Load(sender, e);
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
            string ma = txt_ma.Text;
            string hoten = txt_hoten.Text;
            DateTime ngay = DateTime.Parse(dtp_ngay.Text);
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            string chucvu = txt_chucvu.Text;
            string quyen = cbo_quyen.SelectedValue.ToString();
            string tk = txt_taikhoan.Text;
            string mk = txt_mk.Text;

            if (check == true) // thêm
            {
                if (clsEmploys._insertNV(ma,hoten,ngay.ToString("yyyy/MM/dd"),diachi,sdt,chucvu,quyen,tk,mk))
                {
                    MessageBox.Show("Thêm nhân viên thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uc_nhanvien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textClear();
                changeBtn(true);
            }
            else
            {
                if (clsEmploys._updateNV(ma, hoten, ngay.ToString("yyyy/MM/dd"), diachi, sdt, chucvu, quyen, tk, mk))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uc_nhanvien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
                textClear();
                changeBtn(true);
            }
            
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            changeBtn(true);
            textClear();
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _getContent();
        }

        private void _getContent()
        {
            txt_ma.Text = dgvNhanvien.Rows[dgvNhanvien.SelectedRows[0].Index].Cells["MANV"].Value.ToString();
            txt_hoten.Text = dgvNhanvien.Rows[dgvNhanvien.SelectedRows[0].Index].Cells["TENNV"].Value.ToString();
            DateTime time = DateTime.Parse(dgvNhanvien.Rows[dgvNhanvien.SelectedRows[0].Index].Cells["NGAYSINH"].Value.ToString());
            dtp_ngay.Text = time.ToString("dd/MM/yyyy");
            txt_diachi.Text = dgvNhanvien.Rows[dgvNhanvien.SelectedRows[0].Index].Cells["DIACHI"].Value.ToString();
            txt_sdt.Text = dgvNhanvien.Rows[dgvNhanvien.SelectedRows[0].Index].Cells["SDT"].Value.ToString();
            txt_chucvu.Text = dgvNhanvien.Rows[dgvNhanvien.SelectedRows[0].Index].Cells["CHUCVU"].Value.ToString();
            cbo_quyen.SelectedValue = dgvNhanvien.Rows[dgvNhanvien.SelectedRows[0].Index].Cells["QUYENHAN_MA"].Value.ToString();
            txt_taikhoan.Text = dgvNhanvien.Rows[dgvNhanvien.SelectedRows[0].Index].Cells["TK"].Value.ToString();
            txt_mk.Text = dgvNhanvien.Rows[dgvNhanvien.SelectedRows[0].Index].Cells["MK"].Value.ToString();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Export Excel";
            saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                clsCommon.ExportExcel(dgvNhanvien, saveFileDialog1.FileName);
            }
        }
    }
}
