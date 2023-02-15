using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Z_Book.Model
{
    class clsMoveWarehouse
    {
        public static string ma_pck = "";
        public static string noinhan = "";
        

        public static DataTable _getMaPCK()
        {
            string query = string.Format("SELECT MA_PCK FROM PHIEUCHUYEN_KHO");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static string _CreateMaPCK()
        {
            /*
             * Mã tự động tăng HD001-> HD999
             * Nếu bảng có mã HD001 và HD003 thì HD002 sẽ được thêm vào
            */
            DataTable dt = new DataTable();
            //hàm get cột MaHD
            dt = _getMaPCK();
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
                return "PCK00" + temp;
            }
            if (temp < 100)
            {
                return "PCK0" + temp;
            }
            return "PCK" + temp;
        }

        public static DataTable _getMoveWarehouse()
        {
            String query = String.Format("SELECT * FROM PHIEUCHUYEN_KHO");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        public static bool _updateSL_NoiXuat(int soluong, string ma, string vitri)
        {
            try
            {
                String query = String.Format("UPDATE SANPHAM_CH SET SOLUONG = {0} " +
                    "WHERE MASP_CH = '{1}' AND VITRI = '{2}'", soluong, ma, vitri);
                clsData.AED(query);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public static bool _updateSL_NoiNhan(int soluong, string ma, string vitri)
        {
            try
            {
                String query = String.Format("UPDATE SANPHAM_CH SET SOLUONG = {0} " +
                    "WHERE MASP_CH = '{1}' AND VITRI = '{2}'", soluong, ma, vitri);
                clsData.AED(query);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }


        internal static object _getMWarehouseDetail(string ma)
        {
            String query = String.Format("SELECT * FROM PHIEUCHUYEN_KHO_CT WHERE PCK_MA = '{0}'",ma);
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        internal static bool _addNewPck(string ma, string nhanvien ,string noinhan, string ngayxuat, string noixuat)
        {
            try
            {
                string query = string.Format("INSERT INTO PHIEUCHUYEN_KHO" +
                    "(MA_PCK, NHANVIEN_MA, CHINHANH_MA, NGAYXUAT, NOIXUAT_MA) " +
                    "VALUES ('{0}','{1}','{2}','{3}','{4}')"
                    , ma, nhanvien, noinhan, ngayxuat, noixuat);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi thêm phiếu nhập !\n" + e.Message);
                return false;
            }
        }
        internal static bool _insertDetailPck(string ma, string ten, int soluong)
        {
            try
            {
                string query = string.Format("INSERT INTO PHIEUCHUYEN_KHO_CT " +
                    "(PCK_MA, SANPHAM_MA, SOLUONG ) " +
                    "VALUES ('{0}', '{1}', {2})"
                    , ma, ten, soluong );
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi thêm chi tiết pck !\n" + e.Message);
                return false;
            }
        }
    }
}
