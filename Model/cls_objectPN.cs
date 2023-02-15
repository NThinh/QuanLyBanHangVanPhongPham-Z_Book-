using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_Book.Model
{
    class cls_objectPN
    {
        private string mapnk_new = "";
        private string soluong_pnk = "";
        private string gianhap_pnk = "";
        private string tensp_pnk = "";

        public string Mapnk_new { get => mapnk_new; set => mapnk_new = value; }
        public string Soluong_pnk { get => soluong_pnk; set => soluong_pnk = value; }
        public string Gianhap_pnk { get => gianhap_pnk; set => gianhap_pnk = value; }
        public string Tensp_pnk { get => tensp_pnk; set => tensp_pnk = value; }

        public cls_objectPN()
        {
        }

        public cls_objectPN(string mapnk_new, string soluong_pnk, string gianhap_pnk, string tensp_pnk)
        {
            this.mapnk_new = mapnk_new;
            this.soluong_pnk = soluong_pnk;
            this.gianhap_pnk = gianhap_pnk;
            this.tensp_pnk = tensp_pnk;
        }
    }
}
