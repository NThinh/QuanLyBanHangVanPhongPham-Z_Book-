using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Z_Book.Model
{
    class clsOrder
    {
        public static string mahd;
        public static string ngayban;
        public static string nhanvien;
        public static double tongtien;
        public static double giamgia;
        public static string khachhang;

       
        public static DataTable _getOrderDetail(string mahd)
        {
            String query = String.Format("SELECT * FROM HOADON_CT WHERE HOADON_MA = '{0}' ", mahd);
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static DataTable _getTongSp()
        {
            String query = String.Format("SELECT SUM(SOLUONG) FROM HOADON_CT");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static DataTable _getTongKH()
        {
            String query = String.Format("SELECT COUNT(MAKH) FROM KHACHHANG");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static DataTable _getTongSLMUA()
        {
            String query = String.Format("SELECT SUM(SOLUONG) FROM PHIEUNHAP_KT_CT");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        public static DataTable _getGroupNV()
        {
            String query = String.Format("SELECT MANV, TENNV FROM NHANVIEN");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static DataTable _getGroupKH()
        {
            String query = String.Format("SELECT MAKH, TEN_KH FROM KHACHHANG");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
      
        public static DataTable _getBill()
        {
            String query = String.Format("SELECT * FROM HOADON");
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static DataTable _getBill(string vitri)
        {
            String query = String.Format("SELECT * FROM HOADON WHERE VITRI = '{0}'", vitri);
            DataTable dt = clsData.TableRead(query);

            return dt;

        }
        public static DataTable _getDoanhThuNgay(string date, string vitri)
        {
            String query = String.Format("SELECT SUM(TONGTIEN) as DOANHTHUNGAY FROM HOADON WHERE VITRI = '{0}' AND NGAYBAN = '{1}'", vitri,date);
            DataTable dt = clsData.TableRead(query);

            return dt;

        }

        public static DataTable _getMaHD()
        {
            string query = string.Format("SELECT MAHD FROM HOADON WHERE VITRI = '{0}'", clsCommon.CHINHANH );
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        public static string _CreateMaHD()
        {
            /*
             * Mã tự động tăng HD001-> HD999
             * Nếu bảng có mã HD001 và HD003 thì HD002 sẽ được thêm vào
            */
            DataTable dt = new DataTable();
            //hàm get cột MaHD
            dt = _getMaHD();
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
                return "HD00" + temp +"_" +clsCommon.CHINHANH.Substring(2,3);
            }
            if (temp < 100)
            {
                return "HD0" + temp + "_" + clsCommon.CHINHANH.Substring(2, 3);
            }
            return "HD" + temp + "_" + clsCommon.CHINHANH.Substring(2, 3);
        }
        
        //thêm mới Hóa Đơn
        public static bool _addNewHD(string maHD, String nhanVienID, string tenKhach, int tongTien,int giamgia)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyy/MM/dd");
                string query = string.Format("INSERT INTO HOADON(MAHD, NGAYBAN, NHANVIEN_MA, TONGTIEN, GIAGIAM, KHACHHANG_MA, VITRI) " +
                    "VALUES ('{0}', '{1}', '{2}', {3}, {4}, N'{5}', '{6}')"
                    , maHD, date, nhanVienID, tongTien, giamgia, tenKhach, clsCommon.CHINHANH);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi thêm hóa đơn !\n" + e.Message);
                return false;
            }
        }

        public static void _updateCTHD(string mahd, string masp, int soluong, int dongia, int khuyenmai)
        {
            try
            {
                string query = string.Format("INSERT INTO HOADON_CT(HOADON_MA, SANPHAM_MA, SOLUONG, DONGIA , KHUYENMAI) VALUES" +
                    " ('{0}', '{1}', {2}, {3}, {4})", mahd, masp, soluong, dongia, khuyenmai);
                clsData.AED(query);
            }
            catch (Exception e)
            {             
                MessageBox.Show("Lỗi khi cập nhật chi tiết hóa đơn. Vui lòng kiểm tra lại \n"+ e.Message.ToString()
                    , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void _updateSP(string maSP, int soluong, string vitri)
        {
            try
            {
                int sl = 0;
                string query1 = string.Format("SELECT SOLUONG FROM SANPHAM_CH WHERE MASP_CH = '{0}' AND VITRI = '{1}'", maSP,vitri);
                DataTable dt = new DataTable();
                dt = clsData.TableRead(query1);
                sl = Convert.ToInt32(dt.Rows[0][0].ToString());
                int update = sl - soluong;
                string query = string.Format("UPDATE SANPHAM_CH SET SOLUONG = {0} WHERE MASP_CH = '{1}' AND VITRI = '{2}'", update, maSP, vitri);
                clsData.AED(query);
            }
            catch (Exception e)
            {              
                MessageBox.Show("Lỗi khi cập nhật số lượng sản phẩm. Vui lòng kiểm tra lại\n "+ e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
