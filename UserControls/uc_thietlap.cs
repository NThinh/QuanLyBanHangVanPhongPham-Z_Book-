using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Z_Book.Model;

namespace Z_Book.UserControls
{
    public partial class uc_thietlap : UserControl
    {
       
        uc_Customer cus = new uc_Customer();
        uc_nhacungcap ncc = new uc_nhacungcap();
        uc_nhanvien nv = new uc_nhanvien();

        public uc_thietlap()
        {
            InitializeComponent();
            clsCommon.AddControlsToTab(cus, tabPage1);
            clsCommon.AddControlsToTab(nv, tabPage2);
            clsCommon.AddControlsToTab(ncc, tabPage3);
            
        }

       

        public void uc_thietlap_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
