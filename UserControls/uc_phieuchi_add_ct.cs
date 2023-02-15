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
    public partial class uc_phieuchi_add_ct : UserControl
    {
        public uc_phieuchi_add_ct()
        {
            InitializeComponent();
        }

        private void uc_phieuchi_add_ct_Load(object sender, EventArgs e)
        {

        }
        private void _clear()
        {
            txt_noidung.Text = "";
            txt_soluong .Text = "";
            txt_gia.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_noidung.Text == "" || txt_soluong.Text == "" || txt_gia.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (clsPhieuChi.array_PC.Count > 0)
                {
                    bool check = false;
                    foreach (cls_objectPC item in clsPhieuChi.array_PC)
                    {
                        if (txt_noidung.Text == item.Noidung)
                        {
                            item.Soluong = (Convert.ToInt32(item.Soluong) + Convert.ToInt32(txt_soluong.Text.Trim())).ToString();
                            item.Gia = txt_gia.Text;
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        clsPhieuChi.stt += 1;
                        clsPhieuChi.array_PC.Add(new cls_objectPC(clsPhieuChi.mapc_new, clsPhieuChi.stt, txt_noidung.Text ,txt_soluong.Text.Trim(), txt_gia.Text.Trim()));                    
                    }
                }
                else
                {
                    clsPhieuChi.stt += 1;
                    clsPhieuChi.array_PC.Add(new cls_objectPC(clsPhieuChi.mapc_new, clsPhieuChi.stt, txt_noidung.Text, txt_soluong.Text.Trim(), txt_gia.Text.Trim()));
                }

                MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _clear();
            }
        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            _clear();
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
