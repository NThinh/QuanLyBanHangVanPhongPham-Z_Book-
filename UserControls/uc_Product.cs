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
    public partial class uc_Product : UserControl
    {
        public uc_Product()
        {
            InitializeComponent();
            changSearch(true);
        }

       
        private void changSearch(bool s)
        {
            txt_search.Visible = s;
            cbo_timkiem_chitiet.Visible = !s;
        }

        private void checkSearch(string colName, string searchValue)
        {
            for (var i = 0; i < dgv_product.RowCount; i++)
            {

                if (clsCommon.convertToUnSign2(dgv_product.Rows[i].Cells[colName].Value.ToString().ToLower())
                    .Contains(clsCommon.convertToUnSign2(searchValue.ToString()).ToLower().Trim()))
                {
                    dgv_product.Rows[i].Selected = true;                  
                }               
                else
                {
                    dgv_product.Rows[i].Selected = false;
                }
            }
        }
        private void cbo_tim_kiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo_tim_kiem.Text)
            {
                case "Theo mã":
                    changSearch(true);                    
                    break;
                case "Theo tên":
                    changSearch(true);                   
                    break;
                case "Theo thể loại":              
                    changSearch(false);
                    cbo_timkiem_chitiet.DataSource = clsProduct._getGroupCategory();
                    cbo_timkiem_chitiet.DisplayMember = "TENLOAI";
                    cbo_timkiem_chitiet.ValueMember = "ID";
                    break;
                case "Theo vị trí":                 
                    changSearch(false);
                    cbo_timkiem_chitiet.DataSource = clsProduct._getGroupStores();
                    cbo_timkiem_chitiet.DisplayMember = "TEN_CHINHANH";
                    cbo_timkiem_chitiet.ValueMember = "MA_CHINHANH";
                    break;
            }
        }
        private void cbo_timkiem_chitiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_tim_kiem.Text == "Theo thể loại")
            {
                string searchcbo = cbo_timkiem_chitiet.SelectedValue.ToString();
                checkSearch("THELOAI", searchcbo);

            }else
            {
                string searchcbo = cbo_timkiem_chitiet.SelectedValue.ToString();
                checkSearch("VITRI", searchcbo);
            }

        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text;       

            switch (cbo_tim_kiem.Text)
            {
                case "Theo mã":               
                    checkSearch("MASP_CH", searchValue);
                    if(searchValue == "")
                    {
                        for(int i = 0; i < dgv_product.RowCount; i++)
                        {
                            dgv_product.Rows[i].Selected = false;
                        }
                    }
                    break;
                case "Theo tên":                    
                    checkSearch("TENSP_CH", searchValue);
                    if (searchValue == "")
                    {
                        for (int i = 0; i < dgv_product.RowCount; i++)
                        {
                            dgv_product.Rows[i].Selected = false;
                        }
                    }
                    break;                            
            }

        }

        private void setData()
        {
            clsProduct.ma = dgv_product.Rows[dgv_product.SelectedRows[0].Index].Cells["MASP_CH"].Value.ToString();
            clsProduct.ten = dgv_product.Rows[dgv_product.SelectedRows[0].Index].Cells["TENSP_CH"].Value.ToString();
            clsProduct.soluong = dgv_product.Rows[dgv_product.SelectedRows[0].Index].Cells["SOLUONG"].Value.ToString();
            clsProduct.donvitinh = dgv_product.Rows[dgv_product.SelectedRows[0].Index].Cells["DONVITINH"].Value.ToString();
            clsProduct.khuyenmai = dgv_product.Rows[dgv_product.SelectedRows[0].Index].Cells["KHUYENMAI"].Value.ToString();
            clsProduct.giaban = dgv_product.Rows[dgv_product.SelectedRows[0].Index].Cells["GIABAN"].Value.ToString();
            clsProduct.hinh = dgv_product.Rows[dgv_product.SelectedRows[0].Index].Cells["HINH"].Value.ToString();
            clsProduct.theloai = dgv_product.Rows[dgv_product.SelectedRows[0].Index].Cells["THELOAI"].Value.ToString();
            clsProduct.vitri = dgv_product.Rows[dgv_product.SelectedRows[0].Index].Cells["VITRI"].Value.ToString();
        }

        private void btn_xem_chitiet_Click(object sender, EventArgs e)
        {
            clsProduct.checkThemSanpham = false;

            if (dgv_product.SelectedRows.Count == 1)
            {
                // gán thông tin
                setData();

                frmDialog f = new frmDialog();
                f.Size = new Size(720, 520);
                f.AddControlsToPanelDialog(new uc_product_detail());
                f.ShowDialog();
                uc_Product_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 thông tin !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_them_sanpham_Click(object sender, EventArgs e)
        {
            clsProduct.checkThemSanpham = true;
            frmDialog f = new frmDialog();
            f.Size = new Size(720, 520);
            f.AddControlsToPanelDialog(new uc_product_detail());
            f.ShowDialog();
            uc_Product_Load(sender, e);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Export Excel";
            saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                clsCommon.ExportExcel(dgv_product, saveFileDialog1.FileName);
            }
        }

        private void uc_Product_Load(object sender, EventArgs e)
        {
            THELOAI.DataSource = clsProduct._getGroupCategory();
            THELOAI.DisplayMember = "TENLOAI";
            THELOAI.ValueMember = "ID";

            VITRI.DataSource = clsProduct._getGroupStores();
            VITRI.DisplayMember = "TEN_CHINHANH";
            VITRI.ValueMember = "MA_CHINHANH";
                 

            dgv_product.DataSource = clsProduct._getProduct(clsCommon.CHINHANH);
            clsCommon.setRowNumber(dgv_product);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_product.SelectedRows.Count == 1)
            {
                string ma = dgv_product.Rows[dgv_product.SelectedRows[0].Index].Cells["MASP_CH"].Value.ToString().Trim();
                string vitri = dgv_product.Rows[dgv_product.SelectedRows[0].Index].Cells["VITRI"].Value.ToString().Trim();

                DialogResult result =  MessageBox.Show("Bạn muốn xóa sản phẩm ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (clsProduct._delProduct(ma, vitri))
                    {
                        MessageBox.Show("Bạn đã xóa thành công !"
                       , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        uc_Product_Load(sender,e);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa sản phẩm"
                      , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 thông tin !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
