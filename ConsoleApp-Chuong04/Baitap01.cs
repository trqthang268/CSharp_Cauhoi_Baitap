using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong04
{
    internal class Baitap01
    {
        public static void ChangeForBinary()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập một số nguyên ở hệ thập phân: ");
            int decimalNum = int.Parse(Console.ReadLine());
            string binaryNumber = "";
            while(decimalNum > 0)
            {
                int result = decimalNum % 2;
                binaryNumber += result.ToString();
                decimalNum /= 2;
            }

            if(binaryNumber == "")
                binaryNumber = "0";
            Console.WriteLine("Dãy nhị phân là :"+binaryNumber);
        }
    }
}
