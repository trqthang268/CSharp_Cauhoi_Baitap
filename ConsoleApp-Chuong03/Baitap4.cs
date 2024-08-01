using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong03
{
    internal class Baitap4
    {
        /// <summary>
        /// Đọc và kiểm tra người dùng có nhập vào 1 số tự nhiên không.
        /// </summary>
        /// <returns> trả về một số tự nhiên vừa nhập </returns>
        public static double Nhap()
        {
            bool check = false;
            double d = 0;
            while (!check)
            {
                try
                {
                    // Sử dụng CultureInfo.InvariantCulture để chắc chắn rằng dấu chấm
                    // được hiểu là dấu thập phân
                    string input = Console.ReadLine();
                    d = double.Parse(input, CultureInfo.InvariantCulture);
                    if (d <= 0)
                    {
                        throw new Exception("Số phải lớn hơn 0!");
                    }
                    check = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Bạn phải nhập số lớn hơn 0! Hãy nhập lại...");
                }
            }
            return d;
        }

        public static void CaculatePi()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số c>0  gần với số 0  (ví dụ c = 0.0001): ");
            double c = Nhap();
            double pi = 0.0;
            double term = 1.0;
            int n = 0;
            while (Math.Abs(term) > c )
            {
                // Tính số hạng hiện tại của chuỗi
                term = 1.0/(2 * n + 1) * Math.Pow(-1, n);
                // Cộng số hạng vào tổng giá trị của pi
                pi += term;
                // Tăng giá trị của n để chuyển đến số hạng tiếp theo
                n++;
            }
            // Nhân tổng giá trị của pi với 4 để có giá trị cuối cùng
            pi *= 4;
            Console.WriteLine("Giá trị số π tính được là : " + pi);
        }

        public static void CaculatePiByFor()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số c > 0 (Ví dụ c = 0.0001) :");
            double c = Nhap();
            double pi = 0.0;
            double term = 1.0;

            for (int n = 0; Math.Abs(term) > c; n++)
            {
                // Tính số hạng hiện tại của chuỗi
                term = 1.0 / (2 * n + 1) * Math.Pow(-1, n);
                // Cộng số hạng vào tổng giá trị của pi
                pi += term;
            }
            // Nhân tổng giá trị của pi với 4 để có giá trị cuối cùng
            pi *= 4;
            Console.WriteLine("Giá trị của số π tính được là: " + pi);
        }
    }
}
