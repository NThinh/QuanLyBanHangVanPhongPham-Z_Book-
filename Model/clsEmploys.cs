using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Z_Book.Model
{
    class clsEmploys
    {
     
        public static string _checkLogin(string username, string password)
        {
            string NguoiDungID = null;
            string query = string.Format("SELECT MANV, TENNV FROM NHANVIEN WHERE TK = '{0}' and MK = '{1}'"
                , username, password);
            DataTable dt = clsData.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                NguoiDungID = dt.Rows[0]["MANV"].ToString();
                clsCommon.NAME = dt.Rows[0]["TENNV"].ToString();
                return NguoiDungID;
            }

            return "ERROR";
        }

        public static DataTable _getNhanVien()
        {
            string query = string.Format("SELECT * FROM NHANVIEN");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        public static DataTable _getMaNV()
        {
            string query = string.Format("SELECT MANV FROM NHANVIEN");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        public static string _CreateMaNV()
        {
            /*
             * Mã tự động tăng HD001-> HD999
             * Nếu bảng có mã HD001 và HD003 thì HD002 sẽ được thêm vào
            */
            DataTable dt = new DataTable();
            //hàm get cột MaHD
            dt = _getMaNV();
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
                return "NV00" + temp;
            }
            if (temp < 100)
            {
                return "NV0" + temp;
            }
            return "NV" + temp;
        }
        internal static bool _insertNV(string ma, string ten,string ngay,string diachi, 
            string sdt, string chucvu,string quyen, string tk, string mk)
        {
            try
            {
                string query = string.Format("INSERT INTO NHANVIEN "
                    + "VALUES (N'{0}', N'{1}', N'{2}', N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')"
                    , ma, ten, ngay, diachi,sdt,chucvu,quyen,tk,mk);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi thêm chi tiết pn !" + e.Message);
                return false;
            }
        }

        public static bool _updateNV(string ma, string ten, string ngay, string diachi,
            string sdt, string chucvu, string quyen, string tk, string mk)
        {
            try
            {
                string query = string.Format("UPDATE NHANVIEN SET TENNV = N'{1}', NGAYSINH =N'{2}', DIACHI = N'{3}'," +
                    " SDT= N'{4}' ,CHUCVU= N'{5}', QUYENHAN_MA = '{6}', TK= '{7}',MK= '{8}'"
                    + "WHERE MANV = '{0}'", ma, ten,ngay,diachi,sdt,chucvu,quyen,tk,mk);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi ! \n" + e.Message.ToString());
                return false;
            }
        }

        public static bool _delNV(string ma)
        {
            try
            {
                string query = string.Format("DELETE FROM NHANVIEN WHERE MANV = '{0}'", ma);
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
