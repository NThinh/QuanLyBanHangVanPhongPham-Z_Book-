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
using Z_Book.UserControls;

namespace Z_Book
{
    public partial class frmDialogCustomer : Form
    {
        public frmDialogCustomer()
        {
            InitializeComponent();           
        }

       
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmDialog f = new frmDialog();
            
            f.Size = new Size(410, 360);          
            f.AddControlsToPanelDialog(new uc_Add_Customer());
            f.ShowDialog();
            frmDialogCustomer_Load(sender, e);

        }
        private void checkSearch(string colName, string searchValue)
        {
            for (var i = 0; i < dgvCustomer.RowCount; i++)
            {
                if(searchValue == "" )
                {
                    for (int j = 0; j < dgvCustomer.RowCount; j++)
                    {
                        dgvCustomer.Rows[j].Selected = false;  
                    }
                    break;
                }
                else if (clsCommon.convertToUnSign2(dgvCustomer.Rows[i].Cells[colName].Value.ToString().ToLower())
                    .Contains(clsCommon.convertToUnSign2(searchValue.ToString()).ToLower().Trim()))
                {
                    dgvCustomer.Rows[i].Selected = true;                                        
                   
                }
                else
                {
                    dgvCustomer.Rows[i].Selected = false;
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text;

            switch (cbo_tim_kiem.Text)
            {
                case "Theo mã":
                    checkSearch("MAKH", searchValue);
                    break;
                case "Theo tên":
                    checkSearch("TEN_KH", searchValue);
                    break;
                case "Theo sđt":
                    checkSearch("SDT", searchValue);
                    break;
                case "Theo địa chỉ":
                    checkSearch("DIACHI", searchValue);
                    break;

            }

        }

        private void frmDialogCustomer_Load(object sender, EventArgs e)
        {
            NHOM_MA.DataSource = clsCustomer._getGroupCustomer();
            NHOM_MA.ValueMember = "MALOAI_KH";
            NHOM_MA.DisplayMember = "NHOM_KH";
            dgvCustomer.DataSource = clsCustomer._getCustomer();
            clsCommon.setRowNumber(dgvCustomer);
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCustomer.SelectedRows.Count > 0)
            {
                clsCustomer.nhomKH = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells["NHOM_MA"].Value);
                clsCustomer.tenKH = dgvCustomer.SelectedRows[0].Cells["TEN_KH"].Value.ToString();
                clsCustomer.maKH = dgvCustomer.SelectedRows[0].Cells["MAKH"].Value.ToString();             

                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
