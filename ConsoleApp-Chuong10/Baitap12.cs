using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong10
{
    internal class Baitap12
    {
        /* 12) Hãy viết đoạn lệnh để thực hiện việc bắt giữa ngoại lệ liên
         * quan đến câu lệnh sau đây:
         * Ketqua = Sothu1 / Sothu2
         */
        public static void TinhThuong()
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                // Nhập giá trị từ người dùng
                Console.Write("Nhập số thứ nhất (Sothu1): ");
                int Sothu1 = int.Parse(Console.ReadLine());

                Console.Write("Nhập số thứ hai (Sothu2): ");
                int Sothu2 = int.Parse(Console.ReadLine());

                // Thực hiện phép chia
                int Ketqua = Sothu1 / Sothu2;
                Console.WriteLine("Kết quả: " + Ketqua);
            }
            catch (DivideByZeroException ex)
            {
                // ngoại lệ chia cho 0
                Console.WriteLine("Lỗi: Không thể chia cho 0. " + ex.Message);
            }
            catch (FormatException ex)
            {
                // nhập sai định dạng
                Console.WriteLine("Lỗi: Định dạng nhập không hợp lệ. " + ex.Message);
            }
            catch (Exception ex)
            {
                // các ngoại lệ khác 
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
    }
}
