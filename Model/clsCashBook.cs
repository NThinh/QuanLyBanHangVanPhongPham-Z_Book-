using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Z_Book.Model
{
    class clsCashBook
    {

        public static string id = "";
        public static DataTable _getCashBook(string vitri)
        {
            String query = String.Format("SELECT * FROM SOQUY WHERE CHINHANH = '{0}'", vitri);
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static DataTable _getMaCash()
        {
            string query = string.Format("SELECT ID FROM SOQUY WHERE CHINHANH = '{0}'", clsCommon.CHINHANH);
            DataTable dt = clsData.TableRead(query);
            return dt;
        }
        public static string _CreateMaCash()
        {
            /*
             * Mã tự động tăng HD001-> HD999
             * Nếu bảng có mã HD001 và HD003 thì HD002 sẽ được thêm vào
            */
            DataTable dt = new DataTable();
            //hàm get cột MaHD
            dt = _getMaCash();
            // tạo temp để lưu số thứ tự của mã hd
            int temp = 0;
            //nếu danh sánh hd rỗng
            if (dt.Rows.Count == 0)
            {
                temp = 1;
            }
            // nếu ds có 1 hóa đơn và mahd = HD001
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(1, 3)) == 1)
            {
                temp = 2;
            }
            //nếu ds có 1 hóa đơn và mahd # HD001
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(1, 3)) > 1)
            {
                temp = 1;
            }
            //nếu ds có > 1 hd
            else
            {
                for (int i = 0; i < dt.Rows.Count - 1; i++)
                {
                    if (int.Parse(dt.Rows[i + 1][0].ToString().Substring(1, 3)) - int.Parse(dt.Rows[i][0].ToString().Substring(1, 3)) > 1)
                    {
                        temp = int.Parse(dt.Rows[i][0].ToString().Substring(1, 3)) + 1;
                        break;
                    }
                }

                if (temp == 0)
                {
                    temp = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(1, 3)) + 1;
                }
            }

            if (temp < 10)
            {
                return "Q00" + temp + "_" + clsCommon.CHINHANH.Substring(2, 3);
            }
            if (temp < 100)
            {
                return "Q0" + temp + "_" + clsCommon.CHINHANH.Substring(2, 3);
            }
            return "Q" + temp + "_" + clsCommon.CHINHANH.Substring(2, 3);
        }

        public static DataTable _getCashBook_detail(string id)
        {
            String query = String.Format("SELECT * FROM SOQUY_CT WHERE MA_SOQUY = '{0}'", id);
            DataTable dt = clsData.TableRead(query);
            return dt;
        }

        internal static bool _addNewCashBook(string id, string ngay, string tiendau, string tiencuoi, string vitri)
        {
            try
            {
              
                string query = String.Format("INSERT INTO SOQUY VALUES ('{0}','{1}',{2},{3},'{4}')"
                   ,id ,ngay, tiendau, tiencuoi, vitri);
                clsData.AED(query);
                return true;
            }
            catch (Exception e )
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        internal static bool _insertStartCash(string id, int stt, int t500, int t200, 
            int t100, int t50, int t20, int t10, int t5, int t2, int t1, int t0_5)
        {
            try
            {

                string query = String.Format("INSERT INTO SOQUY_CT VALUES ('{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})"
                   ,id, stt, t500, t200, t100, t50, t20, t10, t5, t2, t1,t0_5);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static bool _updateMoneyStart(string id,int tongtien)
        {
            try
            {
                string query = String.Format("UPDATE SOQUY SET " +
                    "TIENDAUNGAY = {1}" +
                    "WHERE ID = '{0}'"
                   , id, tongtien);
                clsData.AED(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public static bool _updateMoneyEnd(string id, int tongtien)
        {
            try
            {
                string query = String.Format("UPDATE SOQUY SET " +
                    "TIENCUOINGAY = {1}" +
                    "WHERE ID = '{0}'"
                   , id, tongtien);
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
