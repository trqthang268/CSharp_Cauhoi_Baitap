using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong12
{
    public delegate void ThongBao(string message);
    public class HocSinh
    {
        // Khai báo delegate như một thuộc tính
        public ThongBao BaoCaoKetQua { get; set; }

        public void DiemSo(int diem)
        {
            if (BaoCaoKetQua != null)
            {
                BaoCaoKetQua("Điểm số của bạn là: " + diem);
            }
            else
            {
                Console.WriteLine("Không có điểm số nào được đăng ký.");
            }
        }
    }
    internal class Baitap02
    {
        public static void InLoiNhan(string message)
        {
            Console.WriteLine(message);
        }

        public static void Test()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            HocSinh hs = new HocSinh();
            //Gán phương thức cho delegate thuộc tính
            hs.BaoCaoKetQua = InLoiNhan;
            //Gọi phương thức và sử dụng delegate thuộc tính
            hs.DiemSo(1);
            //Có thể thay đổi hành vi bằng cách gán delegate khác
            hs.BaoCaoKetQua = message => Console.WriteLine("Thông báo: " + message);
            hs.DiemSo(2);
        }
    }
}
