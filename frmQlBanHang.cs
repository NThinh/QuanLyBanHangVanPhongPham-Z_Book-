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
    public partial class frmQlBanHang : Form
    {
        ImageList imageList;

        public frmQlBanHang()
        {
            InitializeComponent();

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

            uc_Order uc = new uc_Order();
            clsCommon.AddControlsToTab(uc, tabPage1);

            uc_Product ucus = new uc_Product();
            clsCommon.AddControlsToTab(ucus, tabPage2);
        }

       
    }
}
