using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong03
{
    internal class Baitap6
    {
        /// <summary>
        /// Hàm nhập số thực
        /// </summary>
        /// <returns> trả về số thực </returns>
        public static double NhapSoThuc()
        {
            bool check = false;
            double value = 0;
            while (!check)
            {
                try
                {
                    string input = Console.ReadLine();
                    value = double.Parse(input, CultureInfo.InvariantCulture);
                    check = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Hãy nhập một số thực.");
                }
            }
            return value;
        }

        /// <summary>
        /// phương thức đảm bảo nhập vào một số thực lớn hơn 0, nếu k đc yêu cầu nhập lại
        /// </summary>
        /// <returns>
        /// trả về số thực lớn hơn 0
        /// </returns>
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

        /// <summary>
        /// hàm để tính giá trị mũ của e^x dựa trên c và x 
        /// </summary>
        /// <param name="x"> số mũ x </param>
        /// <param name="c"> số thực c </param>
        /// <returns> trả về kết quả e^x sau khi tính </returns>
        public static double TinhGiaTriMu(double x, double c)
        {
            double eX = 1.0; //Giá trị e^x ban đầu, bắt đầu từ 1 
            double term = 1.0; // Giá trị của số hạng đầu tiên (x^0/0!)
            int n = 1; //Bắt đầu từ số hạng thứ nhất
            
            for (;Math.Abs(term) > c; n++)
            {
                //Cập nhật giá trị của số hạng hiện tại
                term *= x / n;
                //Cộng số hạng vào tổng giá trị của e^x
                eX += term;
            }
            return eX;
        }

        public static void CalculateExponential()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số c (Ví dụ c = 0.0001): ");
            double c = Nhap();
            Console.WriteLine("Nhập giá trị x:");
            double x = NhapSoThuc();
            double result = TinhGiaTriMu(x, c);
            Console.WriteLine("Giá trị của e^x tính được là : " + result);
        }

    }
}
