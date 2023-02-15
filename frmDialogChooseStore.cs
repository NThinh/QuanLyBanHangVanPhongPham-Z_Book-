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

namespace Z_Book
{
    public partial class frmDialogChooseStore : Form
    {
        public frmDialogChooseStore()
        {
            InitializeComponent();
        }
        DataTable dtCH ;

        private void frmDialogChooseStore_Load(object sender, EventArgs e)
        {
            dtCH = clsProduct._getGroupStores();
            cbo_chon_cuahang.DataSource = clsProduct._getGroupStores();
            cbo_chon_cuahang.ValueMember = "MA_CHINHANH";
            cbo_chon_cuahang.DisplayMember = "TEN_CHINHANH";

        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            clsCommon.CHINHANH = cbo_chon_cuahang.SelectedValue.ToString();
            
            for (int i = 0; i < dtCH.Rows.Count; i++)
            {
                string ma = dtCH.Rows[i]["MA_CHINHANH"].ToString();
                if (clsCommon.CHINHANH.Equals(ma))
                {
                    clsCommon.DC_CHINHANH = dtCH.Rows[i]["DIACHI"].ToString();
                    clsCommon.TEN_CHINHANH = dtCH.Rows[i]["TEN_CHINHANH"].ToString();
                    this.Close();                  
                }
            }
        }
        //forcus enter
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (this.ActiveControl.Handle != btn_xacnhan.Handle)
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
