using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    public class Bao : TaiLieu
    {
        public DateOnly NgayPhatHanh { get; set; }

        public Bao()
        {
            NgayPhatHanh = DateOnly.MinValue;
        }

        public Bao(string maXB, string tenTL, string nhaPH, string idDanhMuc, DateOnly ngayPhatHanh) : base (maXB, tenTL, nhaPH, idDanhMuc)
        {
            NgayPhatHanh = ngayPhatHanh;
        }
    }
}
