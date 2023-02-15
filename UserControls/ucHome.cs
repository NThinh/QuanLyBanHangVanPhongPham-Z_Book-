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
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            DataTable dt = clsOrder._getTongSp();
            DataTable dt1 = clsOrder._getTongSLMUA();
            DataTable dt2 = clsOrder._getTongKH();

            lbl_slban.Text = dt.Rows[0][0].ToString();
            lbl_slkh.Text = dt2.Rows[0][0].ToString();
            lbl_sl_damua.Text = dt1.Rows[0][0].ToString();
        }
        
    }
}
