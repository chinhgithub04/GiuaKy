using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    public class Sach : TaiLieu
    {
        public string TenTG {  get; set; }
        public int SoTrang {  get; set; }

        public Sach()
        {
            TenTG = "";
            SoTrang = 0;
        }

        public Sach(string maXB, string tenTL, string nhaPH, string idDanhMuc, string tenTG, int soTrang)
                    : base(maXB, tenTL, nhaPH, idDanhMuc)
        {
            TenTG = tenTG;
            SoTrang = soTrang;
        }
    }
}
