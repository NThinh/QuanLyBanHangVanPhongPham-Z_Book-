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
    public partial class uc_Customer : UserControl
    {
        public uc_Customer()
        {
            InitializeComponent();          
           
        }
        private bool check = false;

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Export Excel";
            saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                clsCommon.ExportExcel(dgvCustomer, saveFileDialog1.FileName);
            }
        }

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
            cbo_khachhang_ma.Enabled = !b;
        }
        private void _getContent()
        {
            txt_ma.Text = dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells["MAKH"].Value.ToString();
            txt_hoten.Text = dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells["TEN_KH"].Value.ToString();
            txt_diachi.Text = dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells["DIACHI"].Value.ToString();
            cbo_khachhang_ma.SelectedValue = dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells["NHOM_MA"].Value.ToString();
            txt_sdt.Text = dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells["SDT"].Value.ToString();
        }


        private void checkSearch(string colName, string searchValue)
        {
            for (var i = 0; i < dgvCustomer.RowCount; i++)
            {
                if (searchValue == "")
                {
                    for (int j = 0; j < dgvCustomer.RowCount; j++)
                    {
                        dgvCustomer.Rows[j].Selected = false;
                    }
                    break;
                }
                else if (clsCommon.convertToUnSign2(dgvCustomer.Rows[i].Cells[colName].Value.ToString().ToLower())
                    .Contains(clsCommon.convertToUnSign2(searchValue.ToString()).ToLower().Trim()))
                {
                    dgvCustomer.Rows[i].Selected = true;
                    break;
                }
                else
                {
                    dgvCustomer.Rows[i].Selected = false;
                }
            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            string searchValue = txt_search.Text;

            switch (cbo_tim_kiem.Text)
            {
                case "Theo mã":
                    checkSearch("MAKH", searchValue);
                    break;
                case "Theo tên":
                    checkSearch("TEN_KH", searchValue);
                    break;              
            }
        }

        private void uc_Customer_Load(object sender, EventArgs e)
        {
            NHOM_MA.DataSource = clsCustomer._getGroupCustomer();
            NHOM_MA.ValueMember = "MALOAI_KH";
            NHOM_MA.DisplayMember = "NHOM_KH";

            cbo_khachhang_ma.DataSource = clsCustomer._getGroupCustomer();
            cbo_khachhang_ma.ValueMember = "MALOAI_KH";
            cbo_khachhang_ma.DisplayMember = "NHOM_KH";

            dgvCustomer.DataSource = clsCustomer._getCustomer();          
            
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _getContent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            textClear();
            changeBtn(false);
            check = true;
            txt_ma.Text = clsCustomer._CreateMAKH();

        }

        private void textClear()
        {
            txt_ma.Text = "";
            txt_hoten.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            cbo_khachhang_ma.StartIndex = 0;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            changeBtn(false);
            check = false;

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.RowCount > 0)
            {
                string ma = dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells["MAKH"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn muốn xóa khách hàng có Mã : " + ma, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (clsCustomer._delKH(ma))
                    {
                        MessageBox.Show("Xóa khách hàng thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        uc_Customer_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng Thất bại ", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string makh = txt_ma.Text;
            string ten = txt_hoten.Text;
            string sdt = txt_sdt.Text;
            string diachi = txt_diachi.Text;
            int nhomkh = Convert.ToInt32(cbo_khachhang_ma.SelectedValue.ToString());
            if (check == true) // thêm
            {

                if (clsCustomer._addNewKH(makh, ten, sdt, diachi, nhomkh))
                {
                    MessageBox.Show("Thêm khách hàng thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uc_Customer_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textClear();
                changeBtn(true);
            }
            else
            {

                if (clsCustomer._updateKH(makh, ten, sdt, diachi, nhomkh))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uc_Customer_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
