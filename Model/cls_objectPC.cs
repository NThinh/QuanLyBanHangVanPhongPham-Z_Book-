using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_Book.Model
{
    class cls_objectPC
    {
        private string ma = "";
        private int stt = 0;
        private string noidung = "";
        private string soluong = "";
        private string gia = "";

        public cls_objectPC(string ma, int stt, string noidung, string soluong, string gia)
        {
            this.ma = ma;
            this.stt = stt;
            this.noidung = noidung;
            this.soluong = soluong;
            this.gia = gia;
        }

        public cls_objectPC()
        {
        }

        public string Ma { get => ma; set => ma = value; }
        public int Stt { get => stt; set => stt = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Gia { get => gia; set => gia = value; }
    }
}
