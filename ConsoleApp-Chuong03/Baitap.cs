using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong03
{
    internal class Baitap
    {
        
        /*
         2) Viết chương trình nhập các hệ số thực ai, i = 0, 1, 2,..., n và số thực x rồi tính giá trị của ña thức
            P(x)=anx^n + an-1x^^n-1 + ... + a1x+ a0
            Theo cách tính của Horner ñể ñạt ñược tốc ñộ tính nhanh:
            i. P(x)=((((anx+ an-1)x+ an-2... + a1)x+ a0
         */
        /// <summary>
        /// đảm bảo rằng người dùng nhập vào một số nguyên hợp lệ
        /// </summary>
        /// <returns>
        /// trả về một số nguyên.
        /// </returns>
        public static int Nhap()
        {
            bool check = false;
            int n = 0;
            while (!check)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    check = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Bạn phải nhập số! Hãy nhập lại");
                }
            }
            return n;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        public static void Horner(int[] arr, int n)
        {
            // khởi tạo 2 biến nguyên T và x
            int T = 0,x;
            Console.WriteLine("Nhập x = ");
            // yêu cầu ng dùng nhập giá trị của x và đọc bằng pt Nhap()
            x = Nhap();
            //khởi tạo T bằng hệ số bậc cao nhất của đa thức
            T = arr[n];
            //sử dụng vòng lặp để tính giá trị của đa thức theo phương pháp Horner
            for (int i = n; i > 0 ; i--)
            {
                T = T * x + arr[i - 1];
            }
            Console.WriteLine("Giá trị của đa thức tính theo công thức Horner là : "+T);
        }

        public static void Baitap2()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //ng dùng nhập bậc của đa thức
            Console.WriteLine("Nhập bậc của đa thức n = ");
            int n = Nhap();
            //khởi tạo mảng chứa các hệ số của đa thức,với kích thước n+1
            int[] array = new int[n + 1];
            //dùng vòng lặp từ n đến 0 để đọc các hệ số của đa thức từ ng dùng
            for (int i = n; i >= 0; i--)
            {
                Console.Write("Nhập hệ số của x^" + i + " = ");
                array[i] = Nhap();
            }
            //gọi phương thức Horner tính giá trị của đa thức với các hệ số đã nhập.
            Horner(array, n);
        }
    }
}
