using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_Book.Model;

namespace Z_Book.UserControls
{
    public partial class uc_product_detail : UserControl
    {
        public uc_product_detail()
        {
            InitializeComponent();
        }
        private bool CHECK_LUU_SUA = false; 
        private void changeButton(bool b)
        {
            btn_them.Enabled = b;
            btn_sua.Enabled = b;          
            btn_luu.Enabled = !b;
            btn_huy.Enabled = !b;
            btn_choose_img.Enabled = !b;

            txt_ten_sanpham.Enabled = !b;
            txt_soluong.Enabled = !b;
            txt_donvitinh.Enabled = !b;
            txt_khuyenmai.Enabled = !b;
            txt_giaban.Enabled = !b;
            cbo_theloai.Enabled = !b;
            cbo_vitri.Enabled = !b;
        }
        private void changeTextBox ()
        {
            txt_ma_sanpham.Text = "";
            txt_ten_sanpham.Text = "";
            txt_soluong.Text = ""; 
            txt_donvitinh.Text = ""; 
            txt_khuyenmai.Text = ""; 
            txt_giaban.Text = ""; 
            cbo_theloai.Text = ""; 
            cbo_vitri.Text = ""; 
            txt_path_img.Text = "";
            img_product.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources\\" + "ctd_0.jpg");
            
        }

        private void uc_product_detail_Load(object sender, EventArgs e)
        {
            cbo_theloai.DataSource = clsProduct._getGroupCategory();
            cbo_theloai.DisplayMember = "TENLOAI";
            cbo_theloai.ValueMember = "ID";

            cbo_vitri.DataSource = clsProduct._getGroupStores();
            cbo_vitri.DisplayMember = "TEN_CHINHANH";
            cbo_vitri.ValueMember = "MA_CHINHANH";

            setData();
        }

        private void setData()
        {
            if(!clsProduct.checkThemSanpham)
            {
                txt_ma_sanpham.Text = clsProduct.ma;
                txt_ten_sanpham.Text = clsProduct.ten;
                txt_soluong.Text = clsProduct.soluong;
                txt_donvitinh.Text = clsProduct.donvitinh;
                txt_khuyenmai.Text = clsProduct.khuyenmai;
                txt_giaban.Text = clsProduct.giaban;
                txt_path_img.Text = clsProduct.hinh;
                cbo_theloai.SelectedValue = clsProduct.theloai;
                cbo_vitri.SelectedValue = clsProduct.vitri;

                img_product.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath)
                    + "\\Resources\\" + clsProduct.hinh.Trim());
                img_product.SizeMode = PictureBoxSizeMode.Zoom;               
            }else
            {
                changeTextBox();
                btn_sua.Enabled = false;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            CHECK_LUU_SUA = true;
            changeButton(false);
            changeTextBox();
            txt_soluong.Text = "0";
            txt_soluong.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            CHECK_LUU_SUA = false;
            changeButton(false);
        }     

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(CHECK_LUU_SUA)
            {
                //btn thêm
                _insertDataProduct();
                

            }else
            {
                //btn sửa
                _updateDataProduct();
            }
            changeButton(true);
        }

        private void _updateDataProduct()
        {
            string ma = txt_ma_sanpham.Text;
            string ten = txt_ten_sanpham.Text;
            string soluong = txt_soluong.Text;
            string donvitinh = txt_donvitinh.Text;
            string khuyenmai = txt_khuyenmai.Text;
            string giaban = txt_giaban.Text;
            string theloai = cbo_theloai.SelectedValue.ToString();
            string vitri = cbo_vitri.SelectedValue.ToString();

            string hinh = txt_path_img.Text;
            if(clsProduct.hinh.Trim() != hinh.Trim() && hinh != "")
            {
                 img_product.Image.Save(Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources\\" + hinh);
            }

            if (clsProduct._updateProduct(ma, ten, soluong, donvitinh, khuyenmai, giaban, hinh, theloai, vitri))
            {
                MessageBox.Show("Cập nhật sản phẩm thành công !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi cập nhật sản phẩm !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void _insertDataProduct()
        {
            string ma = clsProduct._CreateMaSP();
            string ten = txt_ten_sanpham.Text;
            string soluong = txt_soluong.Text;
            string donvitinh = txt_donvitinh.Text;
            string khuyenmai = txt_khuyenmai.Text;
            string giaban = txt_giaban.Text;
            string theloai = cbo_theloai.SelectedValue.ToString();
            string vitri = cbo_vitri.SelectedValue.ToString();

            string hinh = txt_path_img.Text;
            if(hinh != "") img_product.Image.Save(Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources\\" + hinh);

            if (clsProduct._insertProduct(ma, ten, soluong, donvitinh, khuyenmai, giaban, hinh, theloai, vitri))
            {
                MessageBox.Show("Thêm sản phẩm mới thành công !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Lỗi thêm sản phẩm !"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            setData();         
            changeButton(true);
        }

        private void btn_choose_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Picture";
            openFileDialog.Filter = "JPEG|*.jpg|Windows Bitmap|*.bmp|PNG|*.png|All Files|*.*";



            DialogResult result = openFileDialog.ShowDialog();

            // kiểm tra xem người dùng đã chọn chưa
            if (result == DialogResult.OK)
            {
                //lấy ảnh
                
                Image img = Image.FromFile(openFileDialog.FileName);
                txt_path_img.Text = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf("\\") + 1);

                img_product.Image = img;
                img_product.SizeMode = PictureBoxSizeMode.Zoom;              
            }
        }
     
        // validating
        private void txt_khuyenmai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_giaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_ten_sanpham_Validating(object sender, CancelEventArgs e)
        {          

            if (txt_ten_sanpham.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(txt_ten_sanpham, "Không được để trống");
            }           
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_ten_sanpham, "");
            }
        }

        private void txt_donvitinh_Validating(object sender, CancelEventArgs e)
        {
         
            if (txt_donvitinh.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(txt_donvitinh, "Không được để trống");
            }
            else
            {
                errorProvider.SetError(txt_donvitinh, "");
            }

        }

        private void txt_khuyenmai_Validating(object sender, CancelEventArgs e)
        {
           if(txt_khuyenmai.Text != "")
            {
                int sl = Convert.ToInt32(txt_khuyenmai.Text.Trim());
                if (sl < 0 || sl > 100)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txt_khuyenmai, "");
                }
                else
                {
                    errorProvider.SetError(txt_khuyenmai, "");
                }
            }
                            
        }

        private void txt_path_img_Validating(object sender, CancelEventArgs e)
        {

            if (txt_path_img.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(txt_path_img, "Không được để trống");
            }
            else
            {
                errorProvider.SetError(txt_path_img, "");
            }
        }

       
    }
}
