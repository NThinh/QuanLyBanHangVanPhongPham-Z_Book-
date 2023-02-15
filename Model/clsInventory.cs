using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Z_Book.Model
{
    class clsInventory
    {

        public static string makk = "";
        public static DataTable _getMaTK()
        {
            string query = string.Format("SELECT MATON FROM TONKHO");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static string _CreateMaKK()
        {
            /*
             * Mã tự động tăng HD001-> HD999
             * Nếu bảng có mã HD001 và HD003 thì HD002 sẽ được thêm vào
            */
            DataTable dt = new DataTable();
            //hàm get cột MaHD
            dt = _getMaTK();
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
                return "TK00" + temp;
            }
            if (temp < 100)
            {
                return "TK0" + temp;
            }
            return "TK" + temp;
        }

        internal static DataTable _getPhieuChiTiet(string makk)
        {
            String query = String.Format("SELECT * FROM TONKHO_CT WHERE TONKH_MA = '{0}'", makk);
            DataTable dt = clsData.TableRead(query);

            return dt;
        }

        internal static DataTable _getPhieuKiemKe(string makk)
        {
            String query = String.Format("SELECT * FROM TONKHO WHERE MATON = '{0}'", makk);
            DataTable dt = clsData.TableRead(query);

            return dt;
        }

        internal static bool _addNewKiemKe(string maton, string vitri, string tennv, string date, string tongThatThoat)
        {
            try
            {
                string query = String.Format("INSERT INTO TONKHO VALUES ('{0}','{1}','{2}','{3}',{4})"
                    , maton, vitri, tennv, date, tongThatThoat.Trim());
                clsData.AED(query);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi insert Phiếu tồn kho");
                return false;
            }
        }

        internal static bool _addKiemKeChiTiet(string maton, string masp, int sl, int sl_tt, int gianhap, string ghiChu)
        {
            try
            {
                string query = String.Format("INSERT INTO TONKHO_CT VALUES ('{0}','{1}',{2},{3},{4},N'{5}')"
                    , maton, masp, sl, sl_tt, gianhap, ghiChu);
                clsData.AED(query);
                return true;
            }
            catch (Exception)
            {
               // MessageBox.Show("lỗi insert Phiếu tồn kho chi tiết");
                return false;
            }
        }

        internal static void _updateTongTien(string maton , int tongThatThoat)
        {
            try
            {
                string query = String.Format("UPDATE TONKHO SET TONG_THATTHOAT = {1} WHERE MATON = '{0}'"
                   , maton, tongThatThoat);
                clsData.AED(query);
                
            }
            catch (Exception)
            {
                 MessageBox.Show("lỗi update Phiếu tồn kho chi tiết");              
            }
        }

        public static DataTable _getTongThatThoat(string makk)
        {
            String query = String.Format("SELECT TONG_THATTHOAT, VITRI_HANG FROM TONKHO WHERE MATON = '{0}'",makk);
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
    }
}
