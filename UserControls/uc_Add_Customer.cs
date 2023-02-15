using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_Book.Model;

namespace Z_Book.UserControls
{
    public partial class uc_Add_Customer : UserControl
    {
        public uc_Add_Customer()
        {
            InitializeComponent();
        }

        private void uc_Add_Customer_Load(object sender, EventArgs e)
        {          
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_name_customer.Text == "" || txt_phone_number.Text == "" || txt_address.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin khách hàng ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }else
            {
                //code content
                string makh = clsCustomer._CreateMAKH();
                string tenkh = txt_name_customer.Text;
                string phone = txt_phone_number.Text;
                string diachi = txt_address.Text;
                if (clsCustomer._addNewKH(makh, tenkh, phone, diachi, 2))
                {
                    MessageBox.Show("Khách hàng đã được lưu !");
                    _clear();
                }
            }
        }
        private void _clear()
        {
            txt_name_customer.Text = "";
            txt_phone_number.Text = "";
            txt_address.Text = "";
        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            _clear();
        }

        private void txt_phone_number_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^0[0-9]+$");
            if(txt_phone_number.Text == "")
            {
                e.Cancel = false;
                errorProvider.SetError(txt_phone_number, "");
            }
            else if (!regex.IsMatch(txt_phone_number.Text) 
                    || (txt_phone_number.Text.Length != 7 && txt_phone_number.Text.Length != 10) )
            {           
                    errorProvider.SetError(txt_phone_number,"Sai cú pháp : 0****** hoặc 0*********");
                    e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_phone_number, "");
            }
        }

        private void txt_phone_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
