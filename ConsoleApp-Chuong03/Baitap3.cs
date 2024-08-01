using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong03
{
    internal class Baitap3
    {
    /*
       3) Nhập một số tự nhiên n. Hãy liệt kê các số nguyên tố không lớn hơn n. 
     */
    /// <summary>
    /// Đọc và kiểm tra người dùng có nhập vào 1 số tự nhiên không.
    /// </summary>
    /// <returns> trả về một số tự nhiên vừa nhập </returns>
    public static int Nhap()
        {
            bool check = false;
            int n = 0;
            while (!check)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        throw new Exception("Số phải là số tự nhiên");
                    }
                    check = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Bạn phải nhập số tự nhiên");
                }
            }
            return n;
        }

        /// <summary>
        /// Hàm liệt kê những số nguyên tố nhỏ hơn n
        /// </summary>
        /// <param name="n"> số nguyên tố cần tìm phải nhỏ hơn số này </param>
        public static void LietKeSNT(int n)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (n < 2)
            {
                Console.WriteLine("Không tồn tại số nguyên tố nhỏ hơn hoặc bằng " + n);
                return;
            }
            // sử dụng mảng boolean để đánh dấu các số nguyên tố
            bool[] isPrime = new bool[n + 1];
            //khởi tạo các phần tử từ 2 đến n là true
            for (int i = 2; i <= n ; i++)
            {
                isPrime[i] = true;                
            }
            // dùng thuật toán Sàng Eratosthenes để đánh dấu các số không phải là số nguyên tố
            for (int j = 0; j*j < n; j++)
            {
                if (isPrime[j])
                {
                    for(int i = j*j; i <= n; i += j)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            Console.WriteLine("Các số nguyên tố không lớn hơn " + n + " là:");
            for (int i = 2; i < n; i++)
            {
                if (isPrime[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        public static void TimSoNT()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập một số tự nhiên n: ");
            int n = Nhap();
            LietKeSNT (n);
        }
    }
}
