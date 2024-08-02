using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong04
{
    internal class Baitap02
    {
        public static void TinhTienDien()
        {
            Console.Write("Nhập tổng số tiền điện tiêu thụ (KW): ");
            int totalKW = int.Parse(Console.ReadLine());

            int totalCost = 0;
            //tinh theo từng mức đã cho 
            if (totalKW < 0)
            {
                Console.WriteLine("Số điện không được là số âm!");
            }
            else if (totalKW <= 100)
            {
                totalCost = totalKW * 500;
            }
            else if (totalKW <= 150)
            {
                totalCost = (100 * 500) + ((totalKW - 100) * 550);
            }
            else if (totalKW <= 200)
            {
                totalCost = (100 * 500) + (50 * 550) + ((totalKW - 150) * 600);
            }
            else
            {
                totalCost = (100 * 500) + (50 * 550) + (50 * 600) + ((totalKW - 200) * 650);
            }
            Console.WriteLine("Tong tien dien phai dong la : " + totalCost + " đồng");
        }
    }
}
