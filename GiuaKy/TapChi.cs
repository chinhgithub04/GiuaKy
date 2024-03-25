using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    public class TapChi : TaiLieu
    {
        public int SoPhatHanh { get; set; }
        public string TrangPhatHanh { get; set; }

        public TapChi()
        {
            SoPhatHanh = 0;
            TrangPhatHanh = "";
        }
        public TapChi(string maXB, string tenTL, string nhaPH, string idDanhMuc, int soPhatHanh, string trangPhatHanh) : base (maXB, tenTL, nhaPH, idDanhMuc)
        {
            SoPhatHanh = soPhatHanh;
            TrangPhatHanh = trangPhatHanh;
        }
    }
}
