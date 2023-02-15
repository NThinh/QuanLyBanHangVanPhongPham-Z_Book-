using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_Book.Model
{
    class cls_Import
    {
        public static bool checkThemPhieuNhap = false;
        public static string ma = "";
        public static string ngaynhap = "";
        public static string nhanvien = "";
        public static string nhacungcap = "";
        public static string tongtien = "";
        public static string no = "";
        public static string vitri = "";
        public static string trangthai = "";

        public static string mapnk_new = "";
        public static string soluong_pnk = "";
        public static string gianhap_pnk = "";
        public static string tensp_pnk = "";

        public static ArrayList array_PN = new ArrayList();

      
        public static string _CreateMaPNK()
        {
            /*
             * Mã tự động tăng HD001-> HD999
             * Nếu bảng có mã HD001 và HD003 thì HD002 sẽ được thêm vào
            */
            DataTable dt = new DataTable();
            //hàm get cột MaHD
            dt = _getMaPNK();
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
                return "PNK00" + temp;
            }
            if (temp < 100)
            {
                return "PNK0" + temp;
            }
            return "PNK" + temp;
        }

        public static DataTable _getMaPNK()
        {
            string query = string.Format("SELECT MA_PNK FROM PHIEUNHAP_KT");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        public static DataTable _getImport()
        {
            String query = String.Format("SELECT * FROM PHIEUNHAP_KT");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        
        public static bool _updateStatus(bool status, string ma, string vitri)
        {
            try
            {
                String query = String.Format("UPDATE PHIEUNHAP_KT SET TRANGTHAI = N'{0}' " +
                    "WHERE MA_PNK = '{1}' AND VITRI_NHAP = '{2}'", status, ma, vitri);
                clsData.AED(query);
                return true;
            }
            catch (Exception)
            {
               
               return false;             
            }         
            
        }

        public static DataTable _getImportDetail(string mapn)
        {
            String query = String.Format("SELECT * FROM PHIEUNHAP_KT_CT WHERE PNK_MA = '{0}'", mapn);
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        internal static bool _addNewPnk(string ma, string ngaynhap, string nhanvien
            , string nhacungcap, int tongtien, string conno, string trangthai, string vitri)
        {
            try
            {              
                string query = string.Format("INSERT INTO PHIEUNHAP_KT " +
                    "(MA_PNK, NGAYNHAP, NHANVIEN_MA, NHACUNGCAP_MA, TONGTIEN, CONNO, VITRI_NHAP, TRANGTHAI) " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', {4}, {5}, '{6}','{7}')"
                    , ma, ngaynhap, nhanvien, nhacungcap, tongtien, conno, vitri,trangthai);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi thêm phiếu nhập !\n" + e.Message);
                return false;
            }
        }

        internal static void _insertDetailPnk(string ma, string ten, int soluong, int gianhap)
        {
            try
            {
                string query = string.Format("INSERT INTO PHIEUNHAP_KT_CT " +
                    "(PNK_MA, TENSANPHAM_MA, SOLUONG, GIANHAP) " +
                    "VALUES ('{0}', '{1}', {2}, {3})"
                    , ma, ten, soluong, gianhap);
                clsData.AED(query);
            }
            catch (Exception e)
            {

                MessageBox.Show("Lỗi thêm chi tiết pn !" + e.Message);
            }
        }

        public static void _updateConNo(string mapn, string conno)
        {
            try
            {
                string query = string.Format("UPDATE PHIEUNHAP_KT SET CONNO = {0} " +
                    "WHERE MA_PNK = '{1}'", conno, mapn);
                clsData.AED(query);               
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi ! \n" + e.Message.ToString());              
            }
        }
    }
}
