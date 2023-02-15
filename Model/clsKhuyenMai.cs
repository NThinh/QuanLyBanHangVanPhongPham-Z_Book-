using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Z_Book.Model
{
    class clsKhuyenMai
    {

       
        public static DataTable _getKhuyenmai()
        {
            String query = String.Format("SELECT * FROM KHUYENMAI_LOAIHINH");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        public static bool _delKM(string ma)
        {
            try
            {
                string query = string.Format("DELETE FROM KHUYENMAI_LOAIHINH WHERE MALOAI_KM = '{0}'", ma);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static bool _insertKM(string Tientu, String tiencuoi, string ngaybatdau, string ngayketthuc, string trangthai, string tongiten)
        {
            try
            {
                string query = string.Format("INSERT INTO KHUYENMAI_LOAIHINH " +
                    "VALUES ({0} , {1}, N'{2}', N'{3}',N'{4}',{5})"
                    , Tientu, tiencuoi, ngaybatdau, ngayketthuc, trangthai, tongiten);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi thêm  !\n" + e.Message);
                return false;
            }
        }
    }
}
