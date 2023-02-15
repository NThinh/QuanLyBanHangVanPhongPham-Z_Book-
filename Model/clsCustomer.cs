using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_Book.Model
{
    class clsCustomer
    {
        public static string maKH = "KH001";
        public static string tenKH = "Khách vãng lai";
        public static int nhomKH = 1;

        
        public static DataTable _getCustomer()
        {
            String query = String.Format("SELECT * FROM KHACHHANG");
            DataTable dt = clsData.TableRead(query);
           
            return dt;
        }
        public static DataTable _getGroupCustomer ()
        {
            String query = String.Format("SELECT MALOAI_KH, NHOM_KH FROM KHACHHANG_NHOM");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static DataTable _getMAKH()
        {
            string query = string.Format("SELECT MAKH FROM KHACHHANG");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static string _CreateMAKH()
        {
            /*
             * Mã tự động tăng HD001-> HD999
             * Nếu bảng có mã HD001 và HD003 thì HD002 sẽ được thêm vào
            */
            DataTable dt = new DataTable();
            //hàm get cột Makh
            dt = _getMAKH();
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
                return "KH00" + temp;
            }
            if (temp < 100)
            {
                return "KH0" + temp;
            }
            return "KH" + temp;
        }
        public static bool _addNewKH(string makh, String tenkh, string sdt,string diachi, int nhomkh)
        {
            try
            {               
                string query = string.Format("INSERT INTO KHACHHANG(MAKH, TEN_KH, SDT, DIACHI, NHOM_MA) " +
                    "VALUES ('{0}', N'{1}', '{2}', N'{3}',{4})"
                    , makh, tenkh, sdt, diachi, nhomkh );
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi thêm khách hàng !\n" + e.Message);
                return false;
            }
        }
           

        public static bool _updateKH(string makh, String tenkh, string sdt, string diachi, int nhomkh)
        {
            try
            {
                string query = string.Format("UPDATE KHACHHANG SET TEN_KH = N'{1}', SDT = '{2}', DIACHI = N'{3}'," +
                    " NHOM_MA = '{4}'"
                    + "WHERE MAKH = '{0}'", makh, tenkh, sdt, diachi, nhomkh);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi ! \n" + e.Message.ToString());
                return false;
            }
        }

        public static bool _delKH(string ma)
        {
            try
            {
                string query = string.Format("DELETE FROM KHACHHANG WHERE MAKH = '{0}'", ma);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    }
}
