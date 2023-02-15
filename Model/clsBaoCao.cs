using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_Book.Model
{
    class clsBaoCao
    {

        public static DataTable _getDoanhThu_GiaGiam()
        {
            String query = String.Format("SELECT SUM(TONGTIEN) as N'TONGTIEN', SUM(GIAGIAM) as N'GIAGIAM' FROM HOADON");
            DataTable dt = clsData.TableRead(query);

            return dt;
        }

        public static DataTable _getCongNo_TongTien()
        {
            String query = String.Format("select sum(TONGTIEN) as N'TONGTIEN', SUM(CONNO) AS N'TONGCONGNO' from PHIEUNHAP_KT ");
            DataTable dt = clsData.TableRead(query);

            return dt;
        }

        public static DataTable _getTongTienPhieuChi()
        {
            String query = String.Format("select sum(TONGTIEN) as N'TONGTIEN' from PHIEUCHI");
            DataTable dt = clsData.TableRead(query);

            return dt;
        }
        public static DataTable _getPhieuchi_baocao()
        {
            String query = String.Format("select MA_PHIEUCHI, NGAYLAP, TONGTIEN from PHIEUCHI");
            DataTable dt = clsData.TableRead(query);

            return dt;
        }
        public static DataTable _getPhieuchi_baocao(string vitri)
        {
            String query = String.Format("select MA_PHIEUCHI, NGAYLAP, TONGTIEN from PHIEUCHI where CHINHANH = '{0}'",vitri);
            DataTable dt = clsData.TableRead(query);

            return dt;
        }
        public static DataTable _getPhieunhapkho_baocao()
        {
            String query = String.Format("select MA_PNK, NGAYNHAP as N'NGAYLAP',CONNO, TONGTIEN from PHIEUNHAP_KT ");
            DataTable dt = clsData.TableRead(query);

            return dt;
        }
        public static DataTable _getPhieunhapkho_baocao(string vitri)
        {
            String query = String.Format("select MA_PNK, NGAYNHAP as N'NGAYLAP',CONNO, TONGTIEN from PHIEUNHAP_KT " +
                "where VITRI_NHAP = '{0}'",vitri);
            DataTable dt = clsData.TableRead(query);

            return dt;
        }

        public static DataTable _getdgvDoanhThu()
        {
            String query = String.Format("select hdct.SANPHAM_MA as N'MASP' , sum (hdct.SOLUONG) as N'SOLUONGBAN', " +
                "sum(hdct.DONGIA ) as N'TONGTIENBAN', sum(hd.GIAGIAM) as N'TONGKHUYENMAI' " +
                "from HOADON_CT hdct , HOADON hd " +
                "where hd.MAHD = hdct.HOADON_MA " +
                "group by hdct.SANPHAM_MA");

            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        public static DataTable _getdgvDoanhThu(string vitri)
        {
            String query = String.Format("select hdct.SANPHAM_MA as N'MASP' , sum (hdct.SOLUONG) as N'SOLUONGBAN', " +
                "sum(hdct.DONGIA ) as N'TONGTIENBAN', sum(hd.GIAGIAM) as N'TONGKHUYENMAI' " +
                "from HOADON_CT hdct , HOADON hd " +
                "where hd.MAHD = hdct.HOADON_MA and hd.VITRI = '{0}'" +
                "group by hdct.SANPHAM_MA", vitri);

            DataTable dt = clsData.TableRead(query);
            return dt;
        }
    }
}
