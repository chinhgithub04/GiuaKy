using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    public class DanhMuc
    {
        public string IdDanhMuc {  get; set; }
        public string TenDanhMuc { get; set; }

        public DanhMuc() 
        {
            IdDanhMuc = "";
            TenDanhMuc = "";
        }

        public DanhMuc(string idDanhMuc, string tenDanhMuc)
        {
            IdDanhMuc = idDanhMuc;
            TenDanhMuc = tenDanhMuc;
        }
    }
}
