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

namespace Z_Book.UserControls
{
    public partial class uc_Import_Categort_Detail : UserControl
    {
        public uc_Import_Categort_Detail()
        {
            InitializeComponent();
        }
        // xóa string.format
        NumberStyles styles = NumberStyles.AllowThousands;
        private bool SAVE = false;
        private DataTable dt;
        private void changeButton(bool b)
        {
            btn_them.Enabled = b;
            btn_luu.Enabled = !b;
            btn_huy.Enabled = !b;

            btn_them_chitiet.Enabled = !b;
            btn_xoa_chitiet.Enabled = !b;                 
            cbo_nhacungcap.Enabled = !b;           
           
            txt_conno.Enabled = !b;           
        }


        private void uc_Import_Categort_Detail_Load(object sender, EventArgs e)
        {
          
            cbo_vitri.DataSource =  clsProduct._getGroupStores();
            cbo_vitri.ValueMember = "MA_CHINHANH";
            cbo_vitri.DisplayMember = "TEN_CHINHANH";

            cbo_nhacungcap.DataSource = clsSupplier._getGroupNCC();
            cbo_nhacungcap.DisplayMember = "TEN_NCC";
            cbo_nhacungcap.ValueMember = "MA_NCC";

            cbo_nhanvien.DataSource = clsOrder._getGroupNV();
            cbo_nhanvien.DisplayMember = "TENNV";
            cbo_nhanvien.ValueMember = "MANV";

            TENSANPHAM_MA.DataSource = clsProduct._getProduct();
            TENSANPHAM_MA.DisplayMember = "TENSP_CH";
            TENSANPHAM_MA.ValueMember = "MASP_CH";

            cbo_trangthai.DataSource = new Dictionary<bool, string>()
                {
                    {false, "Kho chờ"},
                    {true, "Đã nhập kho"},
                }.ToList();
            cbo_trangthai.ValueMember = "Key";
            cbo_trangthai.DisplayMember = "Value";

            setData();
        
            clsCommon.setRowNumber(dgv_import_detail);
        }
       
        private void setData()
        {
            if (cls_Import.checkThemPhieuNhap == false)
            {             
                txt_ma_phieunhap.Text = cls_Import.ma;
                dtp_ngaynhap.Text = cls_Import.ngaynhap;
                cbo_nhanvien.SelectedValue = cls_Import.nhanvien;
                cbo_nhacungcap.SelectedValue = cls_Import.nhacungcap;
                cbo_trangthai.SelectedValue = Convert.ToBoolean(cls_Import.trangthai.Trim());
                cbo_vitri.SelectedValue = cls_Import.vitri;

                if (Convert.ToInt32(cls_Import.no.Trim()) != 0)
                    txt_conno.Text = string.Format("{0:#,###}", Convert.ToInt32(cls_Import.no.Trim()));
                else txt_conno.Text = "0";

                if (Convert.ToInt32(cls_Import.tongtien.Trim()) != 0)
                    txt_tongtien.Text = string.Format("{0:#,###}", Convert.ToInt32(cls_Import.tongtien.Trim()));
                else txt_tongtien.Text = "0";
                
                dgv_import_detail.DataSource = cls_Import._getImportDetail(cls_Import.ma);          

            }
            else
            {
                changeText();
            }
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            changeText();          
            cls_Import.mapnk_new = cls_Import._CreateMaPNK();
            txt_ma_phieunhap.Text = cls_Import.mapnk_new;
            //dgv_import_detail.DataSource = cls_Import._getImportDetail(txt_ma_phieunhap.Text);

            var dt = dgv_import_detail.DataSource as DataTable;
             if(dt != null) dt.Rows.Clear();
            dgv_import_detail.DataSource = dt;

            changeButton(false);
            SAVE = true;
            
        }

        private void changeText()
        {
            //setEnabled(true);  
            txt_ma_phieunhap.Text = "";       
            dtp_ngaynhap.Text = "";           
            txt_conno.Text = "";
            txt_tongtien.Text = "";
            cbo_trangthai.SelectedValue = false;
            cbo_nhanvien.SelectedValue = clsCommon.MANV;
            cbo_nhacungcap.Text = "";
            cbo_vitri.SelectedValue = clsCommon.CHINHANH;
            cls_Import.array_PN.Clear();
            if (dt != null) dt.Rows.Clear();
            //setEnabled(false);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {           
            if(SAVE)
            {
                int tong = 0;
                int no = 0;
                if (txt_tongtien.Text != "") tong = Int32.Parse(txt_tongtien.Text, styles);              
                if (txt_conno.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else
                {
                    no = Int32.Parse(txt_conno.Text, styles);
                }

                if (dgv_import_detail.RowCount == 0)
                {
                    MessageBox.Show("Thêm sản phẩm cần nhập !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if(no > tong)
                {
                    MessageBox.Show("Nợ không quá tổng tiền nhập !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string ma = cls_Import.mapnk_new;
                    string date = DateTime.Now.ToString("yyyy/MM/dd");                    
                    string nhanvien = cbo_nhanvien.SelectedValue.ToString();
                    string nhacungcap = cbo_nhacungcap.SelectedValue.ToString();
                    int tongtien = Int32.Parse(txt_tongtien.Text, styles);
                    string conno = txt_conno.Text;
                    string trangthai = cbo_trangthai.SelectedValue.ToString();
                    string vitri = cbo_vitri.SelectedValue.ToString();
                    // tạo hóa đơn, thêm chi tiết hóa đơn
                    if (cls_Import._addNewPnk(ma,date,nhanvien,nhacungcap,tongtien,conno,trangthai,vitri))
                    {
                        for (int i = 0; i < dgv_import_detail.RowCount; i++)
                        {
                            int soluong = Int32.Parse(dgv_import_detail.Rows[i].Cells["SOLUONG"].Value.ToString(), styles);
                            int gianhap = Int32.Parse(dgv_import_detail.Rows[i].Cells["GIANHAP"].Value.ToString(), styles);
                            string ten = dgv_import_detail.Rows[i].Cells["TENSANPHAM_MA"].Value.ToString();

                            cls_Import._insertDetailPnk(ma, ten, soluong, gianhap);                          
                        }
                        if(Convert.ToInt32(conno.Trim()) != 0)
                        {
                            string trangthaino = "CHỜ XỬ LÝ";
                            clsSupplier._insertCongNo(nhacungcap,ma,tongtien,conno,trangthaino);
                        }
                        MessageBox.Show("Thêm thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                       
                        changeButton(true);
                    }else
                    {
                        MessageBox.Show("Lỗi thêm phiếu nhập !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }              
                }
                    
            }          
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            setData();
            changeButton(true);   
            
        }

        private void txt_conno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_them_chitiet_Click(object sender, EventArgs e)
        {          
            frmDialog f = new frmDialog();
            f.Size = new Size(400, 340);
            f.AddControlsToPanelDialog(new uc_Import_add_detail());
            f.ShowDialog();
            setDataDetail();
        }

        
        private void setDataDetail()
        {
            int tongtien = 0;
           
            dt = new DataTable();
            dt.Columns.Add("PNK_MA");
            dt.Columns.Add("TENSANPHAM_MA");
            dt.Columns.Add("SOLUONG");
            dt.Columns.Add("GIANHAP");
            if(dt != null) dt.Rows.Clear();
            for (int i = 0; i < cls_Import.array_PN.Count; i++)
            {             
                cls_objectPN aa = (cls_objectPN) cls_Import.array_PN[i];
                DataRow dRow = dt.NewRow();
                dRow["PNK_MA"] = aa.Mapnk_new;
                dRow["TENSANPHAM_MA"] = aa.Tensp_pnk;
                dRow["SOLUONG"]  = aa.Soluong_pnk.Trim();
                dRow["GIANHAP"] = aa.Gianhap_pnk.Trim();
                dt.Rows.Add(dRow);
                tongtien += Convert.ToInt32(dRow["SOLUONG"].ToString()) * Convert.ToInt32(dRow["GIANHAP"].ToString());
            }          
            dgv_import_detail.DataSource = dt;
            txt_tongtien.Text = string.Format("{0:#,###}", tongtien);

        }

        private void txt_conno_Validating(object sender, CancelEventArgs e)
        {

            if (txt_tongtien.Text != "")
            {
                int tong = Int32.Parse(txt_tongtien.Text, styles);
                int no = Int32.Parse(txt_conno.Text, styles);
                if (no > tong)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txt_conno, "Tiền nợ không thể lớn hơn tổng giá trị");
                }
                else
                {
                    errorProvider.SetError(txt_conno, "");
                }
            }
            
        }

        private void btn_xoa_chitiet_Click(object sender, EventArgs e)
        {
            if (dgv_import_detail.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn Sản phẩm cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dgv_import_detail.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vui lòng chọn 1 Sản phẩm cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgv_import_detail.Rows.RemoveAt(dgv_import_detail.SelectedRows[0].Index);                                              
            }
        }
    }
}
