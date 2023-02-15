using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_Book.Model;
using Z_Book.UserControls;


namespace Z_Book
{
    public partial class frmMain : Form
    {
        int panelwidth;
        bool isCollapsed;
        private Form currentChilForm;
        public Point downPoint = Point.Empty;

        bool check_maxsize = false;
        public frmMain()
        {
            InitializeComponent();
            panelwidth = PanelLeft.Width;
            isCollapsed = false;
            panelSide.Visible = false;
            timerTime.Start();
            ucHome uch = new ucHome();
            AddControlsToPanel(uch);
            lblName.Text = clsCommon.NAME;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ẩn form
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                PanelLeft.Width += 10;
                if(PanelLeft.Width >= panelwidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                    LabelTitle.Visible = true;

                    String hinh = "icons8_Double_Left_25px.png";
                    btnMenu.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + hinh);
                }
            }else
            {
                PanelLeft.Width -= 10;
                if (PanelLeft.Width <= 60)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                    LabelTitle.Visible = false;

                    String hinh = "icons8_double_right_25px.png";
                    btnMenu.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + hinh);

                }
            }
        }       

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void moveSidePanel ( Control btn)
        {
            panelSide.Visible = true;
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel (Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }
        private void OpenChilForm(Form chilForm)
        {
            if (currentChilForm != null)
            {
                // chỉ mở 1 form
                currentChilForm.Close();
            }
            currentChilForm = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(chilForm);
            panelControl.Tag = chilForm;
            chilForm.BringToFront();
            chilForm.Show();
            
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            check_maxsize = true;
            if (check_maxsize) button3.Enabled = false;
            else button3.Enabled = true;

            moveSidePanel(btnPos);
            frmPos f = new frmPos();
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                
            }
            OpenChilForm(f);         

        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            check_maxsize = false;
            if (check_maxsize) button3.Enabled = false;
            else button3.Enabled = true;

            moveSidePanel(btnBanHang);
            frmQlBanHang f = new frmQlBanHang();
            OpenChilForm(f);
            
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            check_maxsize = false;
            if (check_maxsize) button3.Enabled = false;
            else button3.Enabled = true;
            moveSidePanel(btnKhoHang);
            frmQlKhoHang f = new frmQlKhoHang();
            OpenChilForm(f);
        }

        private void btnThuChi_Click(object sender, EventArgs e)
        {
            check_maxsize = false;
            if (check_maxsize) button3.Enabled = false;
            else button3.Enabled = true;
            moveSidePanel(btnThuChi);
            frmQlThuChi f = new frmQlThuChi();
            OpenChilForm(f);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            check_maxsize = true;
            if (check_maxsize) button3.Enabled = false;
            else button3.Enabled = true;
            moveSidePanel(btnBaoCao);
            frmQlBaoCao f = new frmQlBaoCao();
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            OpenChilForm(f);
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            bool check = false;
            DataTable dt = clsEmploys._getNhanVien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {               
                if (clsCommon.MANV.Trim() == dt.Rows[i]["MANV"].ToString().Trim() && dt.Rows[i]["QUYENHAN_MA"].ToString().Trim() == "Q001")
                {
                    check = true;
                    break;
                }
            }
            if(check == true)
            {
                check_maxsize = true;
                if (check_maxsize) button3.Enabled = false;
                else button3.Enabled = true;
                moveSidePanel(btnHeThong);
                frmQlHeThong f = new frmQlHeThong();
                if (WindowState == FormWindowState.Normal)
                {
                    WindowState = FormWindowState.Maximized;
                }
                OpenChilForm(f);
            }else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này !"
                    , "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            LabelTime.Text = String.Format("{0:d/M/yyyy HH:mm:ss}", dt);
            //dt.ToString("HH:MM:ss");
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            ucHome uch = new ucHome();
            AddControlsToPanel(uch);
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new frmLoggin();
            f.Closed += (s, agrs) => this.Close();
            f.Show();
        }

        //code lậu
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void PanelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2GradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            frmDialog f = new frmDialog();
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
