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
    public partial class frmQlKhoHang : Form
    {
        ImageList imageList;
        uc_inventory ucus = new uc_inventory();
        uc_Import_Category uc = new uc_Import_Category();
        uc_shipping_product ucship = new uc_shipping_product();
        public frmQlKhoHang()
        {
            InitializeComponent();
            String hinh = "icons8_Order_History_25px_1.png";
            String hinh2 = "icons8_product_25px_1.png";
            String hinh3 = "icons8_product_25px_1.png";

            imageList = new ImageList();
            imageList.Images.Add(Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + hinh));
            imageList.Images.Add(Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + hinh2));
            imageList.Images.Add(Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + hinh3));
            tabControl1.ImageList = imageList;

            tabPage1.ImageIndex = 0;
            tabPage2.ImageIndex = 1;
            tabPage3.ImageIndex = 2;

            tabControl1.TabPages[0].BackgroundImageLayout = ImageLayout.Zoom;
            tabControl1.TabPages[1].BackgroundImageLayout = ImageLayout.Zoom;
            tabControl1.TabPages[2].BackgroundImageLayout = ImageLayout.Zoom;

            
            clsCommon.AddControlsToTab(uc, tabPage1); 
            clsCommon.AddControlsToTab(ucus, tabPage2);    
            clsCommon.AddControlsToTab(ucship, tabPage3);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPage1)
            {
                uc.uc_Import_Category_Load(sender, e);

            }else if(tabControl1.SelectedTab == tabPage2)
            {
                ucus.uc_inventory_Load(sender,e);
            }
            else
            {
                ucship.uc_shipping_product_Load(sender,e);
            }
        }
    }
}
