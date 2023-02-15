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
    public partial class uc_Import_add_detail : UserControl
    {
        public uc_Import_add_detail()
        {
            InitializeComponent();
        }

        private void uc_Import_add_detail_Load(object sender, EventArgs e)
        {
            cbo_sanpham.DataSource = clsProduct._getGroupProduct();
            cbo_sanpham.DisplayMember = "TENSP_CH";
            cbo_sanpham.ValueMember = "MASP_CH";

        }

        private void txt_soluog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_gianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void _clear()
        {
            cbo_sanpham.TabIndex = 0;
            txt_gianhap.Text = "";
            txt_soluog.Text = "";
        }
        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            _clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_gianhap.Text == "" || txt_soluog.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                if(cls_Import.array_PN.Count > 0)
                {
                    bool check = false;
                    foreach (cls_objectPN item in cls_Import.array_PN)
                    {
                        if (cbo_sanpham.SelectedValue.ToString() == item.Tensp_pnk)
                        {
                            item.Soluong_pnk = (Convert.ToInt32(item.Soluong_pnk) + Convert.ToInt32(txt_soluog.Text.Trim())).ToString();
                            item.Gianhap_pnk = txt_gianhap.Text;
                            check = true;
                            break;                         
                        }                      
                    }
                    if (!check)
                    {
                        cls_Import.array_PN.Add(new cls_objectPN(cls_Import.mapnk_new, txt_soluog.Text.Trim(), txt_gianhap.Text.Trim()
                     , cbo_sanpham.SelectedValue.ToString()));
                    }                
                }
                else
                {
                    cls_Import.array_PN.Add(new cls_objectPN(cls_Import.mapnk_new, txt_soluog.Text.Trim(), txt_gianhap.Text.Trim()
                      , cbo_sanpham.SelectedValue.ToString()));

                }
                
                MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _clear();
            }
        }
    }
}
