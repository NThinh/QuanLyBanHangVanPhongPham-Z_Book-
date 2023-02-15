using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_Book.Model;
using Z_Book.UserControls;

namespace Z_Book
{
    public partial class frmQlHeThong : Form
    {
        uc_thietlap uc = new uc_thietlap();
        uc_khuyenmai uc_km = new uc_khuyenmai();
        public frmQlHeThong()
        {
            InitializeComponent();
            ImageList imageList;
            String hinh = "icons8_Order_History_25px_1.png";
            String hinh2 = "icons8_product_25px_1.png";
      

            imageList = new ImageList();
            imageList.Images.Add(Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + hinh));
            imageList.Images.Add(Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + hinh2));            
            tabControl1.ImageList = imageList;

            tabPage1.ImageIndex = 0;
            tabPage2.ImageIndex = 1;            

            tabControl1.TabPages[0].BackgroundImageLayout = ImageLayout.Zoom;
            tabControl1.TabPages[1].BackgroundImageLayout = ImageLayout.Zoom;            


            clsCommon.AddControlsToTab(uc, tabPage1);
            clsCommon.AddControlsToTab(uc_km, tabPage2);           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                uc.uc_thietlap_Load(sender, e);              
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                uc_km.uc_khuyenmai_Load(sender, e);
            }
        }
    }
}
