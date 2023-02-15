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
    public partial class uc_khuyenmai : UserControl
    {
        public uc_khuyenmai()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        public void uc_khuyenmai_Load(object sender, EventArgs e)
        {
            dt = clsKhuyenMai._getKhuyenmai();
            if(dt.Rows.Count > 0)
            {
                txt_tien_dau.Text = dt.Rows[0]["TIEN_TU"].ToString();
                txt_tien_cuoi.Text = dt.Rows[0]["TIEN_CUOI"].ToString();
                txt_khuyenmai.Text = dt.Rows[0]["TONGTIEN"].ToString();
                dtp_ngaydau.Text = dt.Rows[0]["NGAYBATDAU"].ToString();
                dtp_ngaycuoi.Text = dt.Rows[0]["NGAYKETTHUC"].ToString();
                sw_tiền.Checked = bool.Parse( dt.Rows[0]["TRANGTHAI"].ToString());

                changeEndable(false);
            }else
            {
                sw_tiền.Checked = false;
            }
        }
        private void textClear()
        {
            txt_tien_dau.Text = "";
            txt_tien_cuoi.Text = "";
            txt_khuyenmai.Text = "";
        }

        private void btn_taokhuyenmai_Click(object sender, EventArgs e)
        {
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn đã tạo khuyến mãi rồi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                changeEndable(true);
            }
        }
        private void changeEndable(bool b)
        {
            groupBox1.Enabled = b;
            dtp_ngaydau.Enabled = b;
            dtp_ngaycuoi.Enabled = b;
         
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                string ma = dt.Rows[0]["MALOAI_KM"].ToString();
                DialogResult result = MessageBox.Show("Bạn muốn xóa khuyến mãi này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (clsKhuyenMai._delKM(ma))
                    {
                        MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textClear();
                        changeEndable(false);
                        uc_khuyenmai_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất bại ", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(dt.Rows.Count == 0)
            {
                DateTime time1 = DateTime.Parse( dtp_ngaydau.Text.ToString());
                DateTime time2 = DateTime.Parse( dtp_ngaycuoi.Text.ToString());

                string ngaydau = time1.ToString("yyyy/MM/dd");
                string ngaycuoi = time2.ToString("yyyy/MM/dd");
                string tu_tien = txt_tien_dau.Text;
                if (txt_tien_dau.Text == "") tu_tien = "0";
                string tien_cuoi = txt_tien_cuoi.Text;
                if (txt_tien_cuoi.Text == "") tien_cuoi = "0";
                string km = txt_khuyenmai.Text;
                string trangthai = "";
                if (sw_tiền.Checked == false) trangthai = "false";
                else trangthai = "true";

                if (clsKhuyenMai._insertKM(tu_tien, tien_cuoi, ngaydau, ngaycuoi, trangthai, km))
                {
                    MessageBox.Show("Tạo thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    changeEndable(false);
                    uc_khuyenmai_Load(sender, e);

                }else
                {
                    MessageBox.Show("Tạo Thất bại ", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void sw_tiền_CheckedChanged(object sender, EventArgs e)
        {
            if(sw_tiền.Checked == false)
            {
                lbl_money.Text = "%";
            }else
            {
                lbl_money.Text = "$";
            }
        }
    }
}
