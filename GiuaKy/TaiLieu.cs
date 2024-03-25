using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    public class TaiLieu
    {
        public string MaXB {  get; set; }
        public string TenTL { get; set; }
        public string NhaPH { get; set; }
        public string IdDanhMuc { get; set; }

        public TaiLieu()
        {
            MaXB = "";
            TenTL = "";
            NhaPH = "";
            IdDanhMuc = "";
        }

        public TaiLieu(string maXB, string tenTL, string nhaPH, string idDanhMuc)
        {
            MaXB = maXB;
            TenTL = tenTL;
            NhaPH = nhaPH;
            IdDanhMuc = idDanhMuc;
        }
    }
}
