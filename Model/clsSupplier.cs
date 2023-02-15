using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Z_Book.Model
{
    class clsSupplier
    {
        public static DataTable _getGroupNCC()
        {
            String query = String.Format("SELECT MA_NCC, TEN_NCC FROM NHACUNGCAP");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        public static DataTable _getCongNo()
        {
            String query = String.Format("SELECT * FROM NO_NHACUNGCAP");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        public static DataTable _getNCC()
        {
            String query = String.Format("SELECT * FROM NHACUNGCAP");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        public static DataTable _getMANCC()
        {
            string query = string.Format("SELECT MA_NCC FROM NHACUNGCAP");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static string _CreateMANCC()
        {
            /*
             * Mã tự động tăng HD001-> HD999
             * Nếu bảng có mã HD001 và HD003 thì HD002 sẽ được thêm vào
            */
            DataTable dt = new DataTable();
            //hàm get cột Makh
            dt = _getMANCC();
            // tạo temp để lưu số thứ tự của mã hd
            int temp = 0;
            //nếu danh sánh hd rỗng
            if (dt.Rows.Count == 0)
            {
                temp = 1;
            }
            // nếu ds có 1 hóa đơn và mahd = HD001
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(3, 3)) == 1)
            {
                temp = 2;
            }
            //nếu ds có 1 hóa đơn và mahd # HD001
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(3, 3)) > 1)
            {
                temp = 1;
            }
            //nếu ds có > 1 hd
            else
            {
                for (int i = 0; i < dt.Rows.Count - 1; i++)
                {
                    if (int.Parse(dt.Rows[i + 1][0].ToString().Substring(3, 3)) - int.Parse(dt.Rows[i][0].ToString().Substring(3, 3)) > 1)
                    {
                        temp = int.Parse(dt.Rows[i][0].ToString().Substring(3, 3)) + 1;
                        break;
                    }
                }

                if (temp == 0)
                {
                    temp = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(3, 3)) + 1;
                }
            }

            if (temp < 10)
            {
                return "NCC00" + temp;
            }
            if (temp < 100)
            {
                return "NCC0" + temp;
            }
            return "NCC" + temp;
        }
        public static bool _insertNCC(string ma, String ten,  string diachi ,  string stk ,string sdt)
        {
            try
            {
                string query = string.Format("INSERT INTO NHACUNGCAP(MA_NCC, TEN_NCC, DIACHI, STK, SDT) " +
                    "VALUES ('{0}', N'{1}', N'{2}', N'{3}',N'{4}')"
                    , ma, ten, diachi, stk, sdt);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi thêm  !\n" + e.Message);
                return false;
            }
        }


        public static bool _updateNCC(string ma, String ten, string diachi, string stk, string sdt)
        {
            try
            {
                string query = string.Format("UPDATE NHACUNGCAP SET TEN_NCC = N'{1}', DIACHI = N'{2}', STK = N'{3}'," +
                    " SDT = N'{4}'"
                    + "WHERE MA_NCC = '{0}'", ma, ten, diachi, stk, sdt);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi ! \n" + e.Message.ToString());
                return false;
            }
        }

        public static bool _delNCC(string ma)
        {
            try
            {
                string query = string.Format("DELETE FROM NHACUNGCAP WHERE MA_NCC = '{0}'", ma);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        internal static void _insertCongNo(string nhacungcap, string ma, int tongtien, string conno, string trangthaino)
        {
            try
            {
                string query = String.Format("INSERT INTO NO_NHACUNGCAP VALUES ('{0}','{1}',{2},{3},N'{4}')"
                    , nhacungcap, ma, tongtien, conno, trangthaino);
                clsData.AED(query);
                
            }
            catch (Exception e)
            {
                MessageBox.Show("lỗi ! \n" + e.Message);                
            }
        }

        public static bool _updateTrangThaiCongNo(string nhacungcap, string mapn, string trangthai)
        {
            try
            {
                string query = string.Format("UPDATE NO_NHACUNGCAP SET TRANGTHAI = N'{0}' " +
                    "WHERE MA_NCC = '{1}' AND MA_PHIEUNHAP = '{2}'", trangthai, nhacungcap, mapn);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi ! \n" + e.Message.ToString());
                return false;
            }
        }
    }
}
