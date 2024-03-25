using System;
namespace GiuaKy
{
    public class Program
    {
        static void Main(string[] agrs)
        {
            //Them moi danh sach cac sach, bao, tap chi
            List<TaiLieu> DsTL203 = new List<TaiLieu>();

            Console.Write("Nhap loai tai lieu can them (SACH, BAO, TAPCHI): ");
            string tailieu203 = Console.ReadLine();
            tailieu203 = tailieu203.ToUpper().Replace(" ", "");
            Console.Write("Nhap bao nhieu cuon: ");
            int socuon203 = int.Parse(Console.ReadLine());
            for(int i = 0; i < socuon203; i++)
            {
                Console.Write("Nhap ma xuat ban: ");
                string maXB203 = Console.ReadLine();
                Console.Write("Nhap ten tai lieu: ");
                string tenTL203 = Console.ReadLine();
                Console.Write("Nhap nha phat hanh: ");
                string tenNPH203 = Console.ReadLine();
                Console.Write("Nhap ID danh muc: ");
                string idDM203 = Console.ReadLine();
                switch (tailieu203)
                {
                    case "SACH":
                        Console.Write("Nhap ten tac gia: ");
                        string tenTG203 = Console.ReadLine();
                        Console.Write("Nhap so trang");
                        int soTrang203 = int.Parse(Console.ReadLine());
                        DsTL203.Add(new Sach(maXB203, tenTL203, tenNPH203, idDM203, tenTG203, soTrang203));
                        Console.WriteLine("Da them sach vao danh sach");
                        break;
                    case "BAO":
                        Console.Write("Nhap ngay phat hanh(dd-MM-yyyy): ");
                        string ngayPH203 = Console.ReadLine();
                        DateOnly datePH203;
                        if (DateOnly.TryParseExact(ngayPH203, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out datePH203))
                        {
                            DsTL203.Add(new Bao(maXB203, tenTL203, tenNPH203, idDM203, datePH203));
                            Console.WriteLine("Da them bao vao danh sach");
                        }
                        else
                        {
                            Console.WriteLine("Dinh dang ngay khong hop le, khong them vao bao!");
                        }
                        break;
                    case "TAPCHI":
                        Console.Write("Nhap so phat hanh: ");
                        int soPH203 = int.Parse(Console.ReadLine());
                        Console.Write("Nhap trang phat hanh: ");
                        string trangPH203 = Console.ReadLine();
                        DsTL203.Add(new TapChi(maXB203, tenTL203, tenNPH203, idDM203,soPH203,trangPH203));
                        Console.WriteLine("Da them tap chi vao danh sach");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }

            //Tim theo loai (Sach, Bao, Tap Chi)
            Console.Write("Nhap tai lieu can truy van (BAO, SACH, TAPCHI): ");
            string tailieutruyvan203 = Console.ReadLine().ToUpper().Replace(" ", "");

            var dsTheoLoai203 = DsTL203.Where(tl =>
            {
                switch (tailieutruyvan203)
                {
                    case "SACH":
                        return tl is Sach;
                    case "BAO":
                        return tl is Bao;
                    case "TAPCHI":
                        return tl is TapChi;
                    default:
                        return false;
                }
            });

            if (dsTheoLoai203.Any())
            {
                Console.WriteLine("Danh sach " + tailieutruyvan203);
                foreach (var taiLieu in dsTheoLoai203)
                {
                    Console.WriteLine("Ma xuat ban: " + taiLieu.MaXB + ", ten tai lieu: " + taiLieu.TenTL);
                }
            }
            else
            {
                Console.WriteLine("Khong co " + tailieutruyvan203 + " trong danh sach");
            }

            //Tim bao co ngay phat hanh trong thang 3/2024
            var baoCanTim203 = DsTL203.Where(tl =>
            {
                if (tl is Bao bao)
                {
                    return bao.NgayPhatHanh.Year == 2024 && bao.NgayPhatHanh.Month == 3;
                }
                return false;
            });

            if (baoCanTim203.Any())
            {
                Console.WriteLine("Cac bao co ngay phat hanh trong thang 3-2024:");
                foreach (Bao bao in baoCanTim203)
                {
                    Console.WriteLine(bao.TenTL + " , ngay phat hanh: " + bao.NgayPhatHanh);
                }
            }
            else
            {
                Console.WriteLine("Khong co bao nao co ngay phat hanh trong thang 3-2024.");
            }
        }
    }
}