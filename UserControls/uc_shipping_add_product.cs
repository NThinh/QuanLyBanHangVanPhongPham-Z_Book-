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
    public partial class uc_shipping_add_product : UserControl
    {
        public uc_shipping_add_product()
        {
            InitializeComponent();
        }
        string ma = "";

        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            cbo_noinhan.StartIndex = -1;           
            if( cbo_noinhan.Text != "")
            {
                cbo_noinhan.StartIndex = -1;                
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(cbo_noinhan.Text != "")
            {
                string nhanvien = cbo_nhanvien.SelectedValue.ToString().Trim();
                string noixuat = cbo_noixuat.SelectedValue.ToString().Trim();
                string noinhan = cbo_noinhan.SelectedValue.ToString().Trim();             
                string date = DateTime.Now.ToString("yyyy/MM/dd");
               
                if (clsMoveWarehouse._addNewPck(ma, nhanvien, noinhan, date, noixuat))
                {
                    clsMoveWarehouse.ma_pck = ma;
                    clsMoveWarehouse.noinhan = noinhan;
                    MessageBox.Show("Tạo phiếu chuyển kho thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((Form)this.TopLevelControl).Close();
                }
                else
                {
                    MessageBox.Show("Tạo phiếu chuyển kho thất bại", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void uc_shipping_add_product_Load(object sender, EventArgs e)
        {
            ma = clsMoveWarehouse._CreateMaPCK();

            cbo_nhanvien.DataSource = clsOrder._getGroupNV();
            cbo_nhanvien.DisplayMember = "TENNV";
            cbo_nhanvien.ValueMember = "MANV";

            cbo_noinhan.DataSource = clsProduct._getGroupStores();
            cbo_noinhan.DisplayMember = "TEN_CHINHANH";
            cbo_noinhan.ValueMember = "MA_CHINHANH";
            cbo_noinhan.StartIndex = -1;

            cbo_noixuat.DataSource = clsProduct._getGroupStores();
            cbo_noixuat.DisplayMember = "TEN_CHINHANH";
            cbo_noixuat.ValueMember = "MA_CHINHANH";
            

            cbo_nhanvien.SelectedValue = clsCommon.MANV;
            txt_maphieu.Text = ma;
            cbo_noixuat.SelectedValue = clsCommon.CHINHANH;

        }

        
    }
}
