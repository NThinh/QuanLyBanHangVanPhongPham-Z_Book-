using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_Book.Model
{
    class clsProduct
    {
        public static bool checkThemSanpham = false;
        public static string ma = "111";
        public static string ten = "111";
        public static string soluong = "111";
        public static string donvitinh= "111";
        public static string khuyenmai = "111";
        public static string giaban = "111";
        public static string hinh = "111";
        public static string theloai = "111";
        public static string vitri = "111";


        public static DataTable _getProduct ()
        {
            String query = String.Format("SELECT * FROM SANPHAM_CH");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static DataTable _getProductDetail(string ma, string vitri)
        {
            String query = String.Format("SELECT * FROM SANPHAM_CH" +
                " WHERE VITRI = '{0}' AND MASP_CH = '{1}'"
               , vitri, ma);
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        public static DataTable _getProductInventory()
        {
            String query = String.Format("SELECT MASP_CH, TENSP_CH, VITRI, SOLUONG, DONVITINH FROM SANPHAM_CH");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static DataTable _getProductInventory(string vitri)
        {
            String query = String.Format("SELECT MASP_CH, TENSP_CH, VITRI, SOLUONG, DONVITINH FROM SANPHAM_CH WHERE VITRI = '{0}'"
                , vitri);
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static DataTable _getProduct(string vitri_cuahang)
        {
            String query = String.Format("SELECT * FROM SANPHAM_CH WHERE VITRI = '{0}'", vitri_cuahang);
            DataTable dt = clsData.TableRead(query);

            return dt;
        }
        public static DataTable _getGroupProduct()
        {
            String query = String.Format("SELECT DISTINCT TENSP_CH, MASP_CH FROM SANPHAM_CH ");
            DataTable dt = clsData.TableRead(query);

            return dt;
        }
        public static DataTable _getGroupProduct(string vitri_cuahang)
        {
            String query = String.Format("SELECT DISTINCT TENSP_CH, MASP_CH FROM SANPHAM_CH WHERE VITRI = '{0}'", vitri_cuahang);
            DataTable dt = clsData.TableRead(query);

            return dt;
        }

        public static DataTable _getGroupCategory()
        {
            String query = String.Format("SELECT ID, TENLOAI FROM SANPHAM_LOAI");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        internal static DataTable _getTbGianhap(string ma)
        {
            String query = String.Format("select AVG(GIANHAP) as TB_GIANHAP from PHIEUNHAP_KT_CT where TENSANPHAM_MA = '{0}'",ma);
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        internal static DataTable _getSlTong(string ma, string vitri)
        {

            String query = String.Format("select sum( SOLUONG ) as TONG_SL from SANPHAM_CH where MASP_CH = '{0}' AND VITRI = '{1}'"
                , ma,vitri);
            DataTable dt = clsData.TableRead(query);
            return dt;
        }    

        internal static DataTable _getSlTong(string ma)
        {

            String query = String.Format("select sum( SOLUONG ) as TONG_SL from SANPHAM_CH where MASP_CH = '{0}'", ma);
            DataTable dt = clsData.TableRead(query);
            return dt;

        }

        public static DataTable _getGroupStores()
        {
            String query = String.Format("SELECT * FROM CHINHNHANH_CH");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        public static bool _delProduct(string ma, string vitri)
        {
            try
            {
                string query = string.Format("DELETE FROM SANPHAM_CH WHERE MASP_CH = '{0}' AND VITRI = '{1}'", ma, vitri);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public static string _CreateMaSP()
        {
            /*
             * Mã tự động tăng HD001-> HD999
             * Nếu bảng có mã HD001 và HD003 thì HD002 sẽ được thêm vào
            */
            DataTable dt = new DataTable();
            //hàm get cột MaHD
            dt = _getMaSP();
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
                return "SP00" + temp;
            }
            if (temp < 100)
            {
                return "SP0" + temp;
            }
            return "SP" + temp;
        }

        public static DataTable _getMaSP()
        {
            string query = string.Format("SELECT MASP_CH FROM SANPHAM_CH");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        public static bool _insertProduct(string ma, string ten, string sl, string dvt, string kh, string giaban
            ,string hinh, string theloai, string vitri)
        {
            try
            {
                string query = String.Format("INSERT INTO SANPHAM_CH VALUES ('{0}',N'{1}',{2},N'{3}',{4},{5},'{6}','{7}','{8}')"
                    ,ma,ten,sl,dvt,kh,giaban,hinh,theloai,vitri);
                clsData.AED(query);
                return true;
            }
            catch (Exception)
            {
                //MessageBox.Show("lỗi insert into số lượng");
                return false;
            }
        }
        public static bool _updateProduct(string ma, string ten, string soluong, string donvitinh
            , string khuyenmai, string giaban, string hinh, string theloai, string vitri)
        {
            try
            {
                string query = String.Format("UPDATE SANPHAM_CH SET " +
                    "TENSP_CH = N'{1}'," +
                    "SOLUONG = {2}," +
                    "DONVITINH = N'{3}'," +
                    "KHUYENMAI = {4}," +
                    "GIABAN = {5}," +
                    "HINH = '{6}'," +
                    "THELOAI = '{7}'," +
                    "VITRI = '{8}'" +
                    "WHERE MASP_CH = '{0}'" 
                   , ma, ten, soluong, donvitinh, khuyenmai, giaban, hinh, theloai, vitri);
                clsData.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool _updateProductSL(string ma, string soluong, string vitri)
        {
            try
            {
                string query = String.Format("UPDATE SANPHAM_CH SET SOLUONG = {1} WHERE MASP_CH = '{0}' AND VITRI = '{2}'"
                   , ma, soluong, vitri);
                clsData.AED(query);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi update số lượng");
                return false;
            }
        }
    }
}
