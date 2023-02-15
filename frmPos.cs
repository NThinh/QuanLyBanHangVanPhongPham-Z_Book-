using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_Book.Model;
using Z_Book.UserControls;

namespace Z_Book
{
    public partial class frmPos : Form
    {
        // xóa string.format
        NumberStyles styles = NumberStyles.AllowThousands;
        DataTable dt;
        public frmPos()
        {           
            InitializeComponent();
            lblID.Text = clsCommon.MANV;
            dt = clsKhuyenMai._getKhuyenmai();
            if(dt.Rows.Count > 0)
            {
                lbl_khuyenmai_them.Visible = true;

                int tien = Convert.ToInt32(dt.Rows[0]["TONGTIEN"].ToString().Trim());
                string dentien = dt.Rows[0]["TIEN_CUOI"].ToString();
                if (dentien == "0") dentien = "trở lên";
                if (tien > 0 && tien < 100)
                {
                    lbl_khuyenmai_them.Text = "Khuyến mãi cho hóa đơn từ " + dt.Rows[0]["TIEN_TU"].ToString() + " - " +
                         dentien + " thêm " + tien + " %";
                }else
                {
                    lbl_khuyenmai_them.Text = "Khuyến mãi cho hóa đơn từ " + dt.Rows[0]["TIEN_TU"].ToString() + " - " +
                         dentien + " thêm " + tien + " đ";
                }
            }
            else
            {
                lbl_khuyenmai_them.Visible = false;
            }
        }

        public void AddItem (String code, String name, int Amount, String dvt, int km, double price, String icon, int category)
        {
            var w = new ucWidget()
            {
                Ma = code,
                Ten = name,
                Sl = Amount,
                Gia = price,
                Dvt = dvt,
                KM = km,
                LoaiSP = category,
                Hinh = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources\\" + icon),          
            } ;
            flowLayoutPanel1.Controls.Add(w);
            w.OnSelect += (ss, ee) =>
            {
                if(w.Sl <= 0)
                {
                    MessageBox.Show("Số lượng không đủ để bán", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else
                {

                    var wdg = (ucWidget)ss;
                    foreach (DataGridViewRow item in dgvOrder.Rows)
                    {
                        if (item.Cells[0].Value.ToString() == wdg.lblMa.Text)
                        {
                            item.Cells[1].Value = wdg.lblTen.Text;
                            item.Cells[2].Value = int.Parse(item.Cells[2].Value.ToString()) + 1;
                            item.Cells[3].Value = (int.Parse(item.Cells[2].Value.ToString())
                            * double.Parse(wdg.lblGia.Text)).ToString();

                            item.Cells[4].Value = (int.Parse(wdg.lblKm.Text) * int.Parse(item.Cells[2].Value.ToString()));

                            calculateTotal();
                            return;
                        }
                    }
                    dgvOrder.Rows.Add(new object[] { wdg.lblMa.Text, wdg.lblTen.Text, 1, wdg.lblGia.Text, wdg.lblKm.Text });
                    calculateTotal();
                    clsCommon.setRowNumber(dgvOrder);
                }
            };
        }
        
        private void calculateTotal()
        {
            double tot = 0;
            double km = 0;
           
            foreach (DataGridViewRow item in dgvOrder.Rows) 
            {
                tot += double.Parse(item.Cells[3].Value.ToString());
                km += double.Parse(item.Cells[4].Value.ToString());
            }
           
             tot -= km;
            if(clsCustomer.nhomKH != 1)
            {
                double themkm = 0;
                themkm = (double) tot * 5 / 100;
                km += themkm;
                tot -=  km;
            }
            if (dt.Rows.Count > 0)
            {
                int tien = Convert.ToInt32(dt.Rows[0]["TONGTIEN"].ToString().Trim());
                int tien_tu = Convert.ToInt32(dt.Rows[0]["TIEN_TU"].ToString());
                
                if (tien > 0 && tien < 100)
                {

                    double themkm = 0;
                    themkm = (double)tot * tien / 100;
                    km += themkm;
                    tot -= km;
                }
                else if(Int32.Parse(lblTong.Text.ToString(),styles) >= tien_tu)
                {
                    km += tien;
                    tot -= km;
                }
            }

            //String.Format("#,###", lblTong.Text = tot.ToString());
            if (tot != 0) lblTong.Text = string.Format("{0:#,###}", tot);
            else lblTong.Text = "0,000";
            if (km != 0) lblKm.Text = string.Format("{0:#,###}", km);
            else lblKm.Text = "0,000";

        }
  
        private void frmPos_Shown(object sender, EventArgs e)
        {

            //đọc dữ liệu vào datatable > từ table gán vào từng additem
            DataTable dt = clsProduct._getProduct(clsCommon.CHINHANH);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {               
                String code = Convert.ToString(dt.Rows[i]["MASP_CH"]);
                String name = Convert.ToString(dt.Rows[i]["TENSP_CH"]);
                int Amount = Convert.ToInt32(dt.Rows[i]["SOLUONG"]);
                String dvt = Convert.ToString(dt.Rows[i]["DONVITINH"]);
                int km = Convert.ToInt32(dt.Rows[i]["KHUYENMAI"]);
                double price = Convert.ToDouble(dt.Rows[i]["GIABAN"]);
                int category = Convert.ToInt32(dt.Rows[i]["THELOAI"]); 
                String icon = Convert.ToString(dt.Rows[i]["HINH"]);
                AddItem(code, name, Amount, dvt, km, price, icon,category);
            }         
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {           
            if(guna2ToggleSwitch1.Checked == true)
            {
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    var wdg = (ucWidget)item;
                    wdg.Visible = clsCommon.convertToUnSign2(wdg.lblMa.Text.ToLower()).ToLower()
                        .Contains(clsCommon.convertToUnSign2(txtSearch.Text).Trim().ToLower());                               
                }
            }else
            {
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    var wdg = (ucWidget)item;
                    wdg.Visible = clsCommon.convertToUnSign2(wdg.lblTen.Text.ToLower()).ToLower()
                        .Contains(clsCommon.convertToUnSign2(txtSearch.Text).Trim().ToLower());                           
                }
            }      
        }


        // xử lý lỗi nhập số sửa số trong order
        private int gia1sp = 0;
        private double phantramkm = 0 ;
       
        private void dgvOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {           
            dgvOrder.Rows[e.RowIndex].Cells[3].Value = (Int32.Parse(dgvOrder.Rows[e.RowIndex].Cells[2].Value.ToString(),styles) *
                            double.Parse(gia1sp.ToString())).ToString();
            dgvOrder.Rows[e.RowIndex].Cells[4].Value = (double.Parse(gia1sp.ToString()) 
                            * double.Parse(phantramkm.ToString()) / 100 
                            * Int32.Parse(dgvOrder.Rows[e.RowIndex].Cells[2].Value.ToString(),styles)).ToString();

            calculateTotal();
            dgvOrder.Rows[e.RowIndex].Cells[1].ErrorText = "";
        }

        private void dgvOrder_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
            int sl = Int32.Parse(dgvOrder.Rows[e.RowIndex].Cells[2].Value.ToString(), styles);
            int gia = Int32.Parse(dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString(), styles);
            int km = Int32.Parse(dgvOrder.Rows[e.RowIndex].Cells[4].Value.ToString(), styles);
            gia1sp = gia / sl;
            phantramkm = (double) km / gia * 100;         
        }

        private void dgvOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvOrder_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = dgvOrder.Columns[e.ColumnIndex].HeaderText;

            // Abort validation if cell is not in the sl column.
            if (!headerText.Equals("Số lượng")) return;
            int output;
            // Confirm that the cell is an integer.
            if (!int.TryParse(e.FormattedValue.ToString(), out output))
            {
                dgvOrder.Rows[e.RowIndex].Cells[1].ErrorText = "Lỗi nhập số";
                e.Cancel = true;
            }
            else
            {
                // kiểm tra số lượng
                // e.FormattedValue : lấy kết quả khi đang nhập
                int slValia = Convert.ToInt32(e.FormattedValue.ToString());
                string maSP = dgvOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
                string query = string.Format("SELECT SOLUONG FROM SANPHAM_CH WHERE MASP_CH = '{0}' AND VITRI = '{1}'"
                    , maSP, clsCommon.CHINHANH);
                DataTable dt = new DataTable();
                dt = clsData.TableRead(query);
                int slCategory = Int32.Parse(dt.Rows[0][0].ToString(), styles);
                if (slValia > slCategory || slValia <= 0)
                {
                    dgvOrder.Rows[e.RowIndex].Cells[1].ErrorText = "Số lượng quá tải";
                    e.Cancel = true;
                }
            }           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn Sản phẩm cần xóa !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (dgvOrder.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vui lòng chọn 1 Sản phẩm cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {              
                dgvOrder.Rows.RemoveAt(dgvOrder.SelectedRows[0].Index);
                calculateTotal();
                if(dgvOrder.Rows.Count == 0)
                {
                    lblKm.Text = "0,000";
                    lblTong.Text = "0,000";
                }           
            }
            
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa tất cả?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Clear();
            }
        }
        private void Clear()
        {
            dgvOrder.Rows.Clear();
            calculateTotal();
            lblKm.Text = "0,000";
            lblTong.Text = "0,000";
        }
        private void _resetPayment()
        {
            clsCustomer.maKH = "KH001";
            clsCustomer.tenKH = "Khách vãng lai";
            clsCustomer.nhomKH = 1;
            _checkNhomKH(clsCustomer.nhomKH);
        }
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true){

                txtSearch.PlaceholderText = "Tìm kiếm theo mã";
                lbl_search.Text = "Theo Mã";
            }else
            {
                txtSearch.PlaceholderText = "Tìm kiếm theo Tên";
                lbl_search.Text = "Theo Tên";


            }
        }

        private void filCategory(string category)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var wdg = (ucWidget)item;
                wdg.Visible = wdg.LoaiSP.ToString().Contains(category);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            cimgTitle.Image = Z_Book.Properties.Resources.icons8_menu_25px;
            lblTitle.Text = "Tất cả";
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var wdg = (ucWidget)item;
                wdg.Visible = true;
                    //cls.convertToUnSign2(wdg.lblMa.Text.ToLower()).ToLower()
                   // .Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void btnSachGiaoKhoa_Click(object sender, EventArgs e)
        {
            cimgTitle.Image = Z_Book.Properties.Resources.icons8_books_25px;
            lblTitle.Text = "Sách giáo khoa";
            filCategory(1 + "");
        }

        private void btnSachKhoaHoc_Click(object sender, EventArgs e)
        {
            cimgTitle.Image = Z_Book.Properties.Resources.icons8_math_book_25px;
            lblTitle.Text = "Sách khoa học";
            filCategory(2 + "");
        }

        private void btnSachNgonTinh_Click(object sender, EventArgs e)
        {
            cimgTitle.Image = Z_Book.Properties.Resources.icons8_love_book_25px;
            lblTitle.Text = "Sách ngôn tình";
            filCategory(3 + "");
        }

        private void btnVanPhongPham_Click(object sender, EventArgs e)
        {
            cimgTitle.Image = Z_Book.Properties.Resources.icons8_drawing_25px;
            lblTitle.Text = "Văn phòng phẩm";
            filCategory(4 + "");
        }
 
        private void btn_payment_Click(object sender, EventArgs e)
        {        
            if (dgvOrder.Rows.Count > 0)
            {              

                String mahd = clsOrder._CreateMaHD();              
                int tong = Int32.Parse(lblTong.Text, styles);
                string khachhang = clsCustomer.maKH;
                int giamgia = Int32.Parse(lblKm.Text, styles);

                if (clsOrder._addNewHD(mahd, lblID.Text, khachhang, tong, giamgia))
                {
                    for (int i = 0; i < dgvOrder.Rows.Count; i++)
                    {
                        
                        int soluong = Int32.Parse(dgvOrder.Rows[i].Cells[2].Value.ToString(), styles);
                        int dongia = Int32.Parse(dgvOrder.Rows[i].Cells[3].Value.ToString(), styles);
                        int khuyenmai = Int32.Parse(dgvOrder.Rows[i].Cells[4].Value.ToString(), styles);
                        

                        clsOrder._updateCTHD(mahd, dgvOrder.Rows[i].Cells[0].Value.ToString(), soluong, dongia, khuyenmai);
                        clsOrder._updateSP(dgvOrder.Rows[i].Cells[0].Value.ToString(), Int32.Parse(dgvOrder.Rows[i].Cells[2].Value.ToString(), styles),clsCommon.CHINHANH);               
                    
                    }     
                    MessageBox.Show("Thanh toán thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _resetPayment();
                    Clear();
                    flowLayoutPanel1.Controls.Clear();
                    frmPos_Shown(sender, e);                   
                }
            }else
            {
                MessageBox.Show("Lỗi thanh toán !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void _checkNhomKH( int check)
        {
            if (check != 1)
            {
                lblCustomer.Text = clsCustomer.tenKH.ToString();
                imgSale.Visible = true;
                lblSale.Visible = true;
                calculateTotal();
            }
            else
            {
                lblCustomer.Text = clsCustomer.tenKH.ToString();
                imgSale.Visible = false;
                lblSale.Visible = false;
                calculateTotal();
            }
        }

        private void btn_add_customer_Click(object sender, EventArgs e)
        {                 
            frmDialogCustomer f = new frmDialogCustomer();         
            f.ShowDialog();

            //f.Size = new Size(860, 530);          
            //f.AddControlsToPanelDialog(new uc_Customer());
            _checkNhomKH (clsCustomer.nhomKH);
           
        }

       
    }
}
