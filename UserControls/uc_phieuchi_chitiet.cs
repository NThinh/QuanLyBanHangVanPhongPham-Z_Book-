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
    public partial class uc_phieuchi_chitiet : UserControl
    {
        public uc_phieuchi_chitiet()
        {
            InitializeComponent();
        }
        NumberStyles styles = NumberStyles.AllowThousands;
        private bool SAVE = false;
        private DataTable dt ;
        private void uc_phieuchi_chitiet_Load(object sender, EventArgs e)
        {
            DataTable dt = clsProduct._getGroupStores();
            dt.Rows.Add("0", "TẤT CẢ", "TPHCM");
            cbo_vitri.DataSource = dt;
            cbo_vitri.DisplayMember = "TEN_CHINHANH";
            cbo_vitri.ValueMember = "MA_CHINHANH";

            cbo_nhanvien.DataSource = clsOrder._getGroupNV();
            cbo_nhanvien.DisplayMember = "TENNV";
            cbo_nhanvien.ValueMember = "MANV";

            setData();         
        }
        private void setData()
        {
            if (clsPhieuChi.check_phieuchi == false)
            {
                txt_ma_phieu.Text = clsPhieuChi.mapc;
                dtp_ngaychi.Text = clsPhieuChi.ngaylap;
                cbo_nhanvien.SelectedValue = clsPhieuChi.nhanvien;
                cbo_vitri.SelectedValue = clsPhieuChi.chinhanh;                            
                txt_ghichu.Text = clsPhieuChi.ghichu;

                if (Convert.ToInt32(clsPhieuChi.tongtien.Trim()) != 0) 
                    txt_tongtien.Text = string.Format("{0:#,###}", Convert.ToInt32(clsPhieuChi.tongtien.Trim()));
                else txt_tongtien.Text = "0";
                txt_noidung.Text = clsPhieuChi.noidung;

                dgv_detail.DataSource = clsPhieuChi._getPhieuChiDetail(clsPhieuChi.mapc);

            }
            else
            {
                changeText();
            }

        }

        private void changeText()
        {
            txt_ma_phieu.Text = "";
            dtp_ngaychi.Text = "";
            txt_ghichu.Text = "";
            txt_tongtien.Text = "";          
            txt_noidung.Text = "";
            cbo_nhanvien.SelectedValue = clsCommon.MANV;
            cbo_vitri.SelectedValue = "0";
            clsPhieuChi.array_PC.Clear();
            if (dt != null) dt.Rows.Clear();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            changeText();
            clsPhieuChi.mapc_new = clsPhieuChi._CreateMaPC();
            txt_ma_phieu.Text = clsPhieuChi.mapc_new;
            //dgv_import_detail.DataSource = cls_Import._getImportDetail(txt_ma_phieunhap.Text);

            var dt = dgv_detail.DataSource as DataTable;
            if (dt != null) dt.Rows.Clear();
            dgv_detail.DataSource = dt;

            changeButton(false);
            SAVE = true;

        }

        private void changeButton(bool b)
        {
            btn_them.Enabled = b;
            btn_luu.Enabled = !b;
            btn_huy.Enabled = !b;

            btn_them_chitiet.Enabled = !b;
            btn_xoa_chitiet.Enabled = !b;

            cbo_vitri.Enabled = !b;
            txt_noidung.Enabled = !b;
            txt_ghichu.Enabled = !b;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            setData();
            changeButton(true);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (SAVE)
            {
                int tong = 0;
                if (txt_tongtien.Text != "") tong = Int32.Parse(txt_tongtien.Text, styles);
              
                 if (txt_noidung.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dgv_detail.RowCount == 0)
                {
                    MessageBox.Show("Thêm sản phẩm cần nhập !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string ma = clsPhieuChi.mapc_new;
                    string date = DateTime.Now.ToString("yyyy/MM/dd");
                    string nhanvien = cbo_nhanvien.SelectedValue.ToString();
                    
                    int tongtien = Int32.Parse(txt_tongtien.Text, styles);
                    string noidung = txt_noidung.Text;
                    string ghichu = txt_ghichu.Text;
                    string vitri = cbo_vitri.SelectedValue.ToString();
                    // tạo hóa đơn, thêm chi tiết hóa đơn
                    if (clsPhieuChi._addNewPC(ma, noidung, date, nhanvien, tongtien, ghichu, vitri))
                    {
                        for (int i = 0; i < dgv_detail.RowCount; i++)
                        {
                            int stt = Int32.Parse(dgv_detail.Rows[i].Cells["STT"].Value.ToString(), styles);
                            string noidung_ct = dgv_detail.Rows[i].Cells["NOIDUNG_CT"].Value.ToString();
                            int soluong = Int32.Parse(dgv_detail.Rows[i].Cells["SOLUONG"].Value.ToString(), styles);
                            int gia = Int32.Parse(dgv_detail.Rows[i].Cells["GIA"].Value.ToString(), styles);

                            clsPhieuChi._insertDetailPC(ma,stt, noidung_ct, soluong, gia);
                        }                       
                        MessageBox.Show("Thêm thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changeButton(true);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi thêm phiếu chi !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btn_them_chitiet_Click(object sender, EventArgs e)
        {
            clsPhieuChi.stt = dgv_detail.RowCount;
            frmDialog f = new frmDialog();
            f.Size = new Size(420, 320);

            f.AddControlsToPanelDialog(new uc_phieuchi_add_ct());
            f.ShowDialog();
            setDataDetail();
        }

        private void setDataDetail()
        {
            int tongtien = 0;
            dt = new DataTable();            
            dt.Columns.Add("STT");
            dt.Columns.Add("NOIDUNG");
            dt.Columns.Add("SOLUONG");
            dt.Columns.Add("GIA");
            if (dt != null) dt.Rows.Clear();
            for (int i = 0; i < clsPhieuChi.array_PC.Count; i++)
            {
                cls_objectPC aa = (cls_objectPC)clsPhieuChi.array_PC[i];
                DataRow dRow = dt.NewRow();              
                dRow["STT"] = aa.Stt;
                dRow["NOIDUNG"] = aa.Noidung;
                dRow["SOLUONG"] = aa.Soluong.Trim();
                dRow["GIA"] = aa.Gia.Trim();
                dt.Rows.Add(dRow);
                tongtien += Convert.ToInt32(dRow["SOLUONG"].ToString()) * Convert.ToInt32(dRow["GIA"].ToString());
            }
            dgv_detail.DataSource = dt;
            txt_tongtien.Text = string.Format("{0:#,###}", tongtien);
        }

        private void btn_xoa_chitiet_Click(object sender, EventArgs e)
        {
            if (dgv_detail.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn Sản phẩm cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dgv_detail.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vui lòng chọn 1 Sản phẩm cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgv_detail.Rows.RemoveAt(dgv_detail.SelectedRows[0].Index);
            }
        }
    }
}
