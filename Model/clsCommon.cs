using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_Book.Model
{
    class clsCommon
    {
        public static string MANV;
        public static string NAME;
        public static string CHINHANH = "CH001";
        public static string DC_CHINHANH = "Kha Vạn Cân, Đường Linh Trung, TP Thủ Đức.";
        public static string TEN_CHINHANH = "Z-BOOK CHI NHÁNH 1";

        public static string km = "";
        public static bool trangthai = false;

        
        
        //lộc dấu tiếng việt
        public static string convertToUnSign2(string s)
        {
            string stFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD));
        }

        // tạo stt cho datgridview
        public static void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {               
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }      

        // tạo hình cột sửa xóa
        public static void setImageED(DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.icons8_database_administrator_12px.Width;
                var h = Properties.Resources.icons8_database_administrator_12px.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                
                e.Graphics.DrawImage(Properties.Resources.icons8_database_administrator_12px, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            else if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.icons8_delete_database_12px.Width;
                var h = Properties.Resources.icons8_delete_database_12px.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.icons8_delete_database_12px, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        public static void AddControlsToTab(Control c, TabPage tabpage)
        {
            c.Dock = DockStyle.Fill;
            tabpage.Controls.Clear();
            tabpage.Controls.Add(c);
        }

        public static void ExportExcel(DataGridView dataGridView1, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý sản phẩm";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        public static DataTable _getMaQuyen()
        {
            string query = string.Format("SELECT MA_QUYEN , TEN_QUYEN FROM NHANVIEN_QUYEN");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
    }
}
