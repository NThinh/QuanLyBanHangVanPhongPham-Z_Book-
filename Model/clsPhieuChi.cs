using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Z_Book.Model
{
    class clsPhieuChi
    {      
        public static bool check_phieuchi = false;

        public static string mapc = "";
        public static string noidung = "";
        public static string ngaylap = "";
        public static string nhanvien = "";
        public static string tongtien = "";
        public static string ghichu = "";
        public static string chinhanh = "";

        public static string mapc_new = "";
        public static int  stt = 0;

        public static ArrayList array_PC = new ArrayList();

        public static DataTable _getMaPC()
        {
            string query = string.Format("SELECT MA_PHIEUCHI FROM PHIEUCHI");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static string _CreateMaPC()
        { /*
             * Mã tự động tăng HD001-> HD999
             * Nếu bảng có mã HD001 và HD003 thì HD002 sẽ được thêm vào
            */
            DataTable dt = new DataTable();
            //hàm get cột MaHD
            dt = _getMaPC();
            // tạo temp để lưu số thứ tự của mã hd
            int temp = 0;
            //nếu danh sánh hd rỗng
            if (dt.Rows.Count == 0)
            {
                temp = 1;
            }
            // nếu ds có 1 hóa đơn và mahd = HD001
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) == 1)
            {
                temp = 2;
            }
            //nếu ds có 1 hóa đơn và mahd # HD001
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) > 1)
            {
                temp = 1;
            }
            //nếu ds có > 1 hd
            else
            {
                for (int i = 0; i < dt.Rows.Count - 1; i++)
                {
                    if (int.Parse(dt.Rows[i + 1][0].ToString().Substring(2, 3)) - int.Parse(dt.Rows[i][0].ToString().Substring(2, 3)) > 1)
                    {
                        temp = int.Parse(dt.Rows[i][0].ToString().Substring(2, 3)) + 1;
                        break;
                    }
                }

                if (temp == 0)
                {
                    temp = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3)) + 1;
                }
            }

            if (temp < 10)
            {
                return "PC00" + temp ;
            }
            if (temp < 100)
            {
                return "PC0" ;
            }
            return "PC" ;
        }

        internal static DataTable _getPhieuChiDetail(string mapc)
        {
            String query = String.Format("SELECT STT, NOIDUNG, SOLUONG, GIA FROM PHIEUCHI_CT WHERE MA_PHIEUCHI_CT = '{0}'", mapc);
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        public static DataTable _getPhieuChi()
        {
            String query = String.Format("SELECT * FROM PHIEUCHI");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        internal static bool _addNewPC(string ma, string noidung, string date, string nhanvien, int tongtien, string ghichu, string vitri)
        {
            try
            {
                string query = string.Format("INSERT INTO PHIEUCHI " +
                    "(MA_PHIEUCHI, NOIDUNG, NGAYLAP, NHANVIEN, TONGTIEN, GHICHU, CHINHANH) " +
                    "VALUES ('{0}', N'{1}', '{2}', '{3}', {4}, N'{5}', '{6}')"
                    , ma, noidung, date, nhanvien, tongtien, ghichu, vitri);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi !\n" + e.Message);
                return false;
            }
        }

        internal static void _insertDetailPC(string ma, int stt, string noidung_ct, int soluong, int gia)
        {
            try
            {
                string query = string.Format("INSERT INTO PHIEUCHI_CT " +
                    "(MA_PHIEUCHI_CT, STT, NOIDUNG, SOLUONG,GIA) " +
                    "VALUES ('{0}', {1}, N'{2}', {3}, {4})"
                    , ma, stt, noidung_ct, soluong, gia);
                clsData.AED(query);
            }
            catch (Exception e)
            {

                MessageBox.Show("Lỗi thêm chi tiết pc !" + e.Message);
            }
        }
    }
}
