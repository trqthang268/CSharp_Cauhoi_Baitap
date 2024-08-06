using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong04
{
    internal class Baitap03
    {
        public static void SapxepKethopHaiMang()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số lượng phần tử của dãy a: ");
            int soptA = int.Parse(Console.ReadLine());
            double[] a = new double[soptA];
            Console.WriteLine("Nhập các phần tử của dãy a (giá trị tăng dần)");
            for (int i = 0; i < soptA; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nhập số lượng phần tử của dãy b: ");
            int soptB = int.Parse(Console.ReadLine());
            double[] b = new double[soptB];
            Console.WriteLine("Nhập các phần tử của dãy b (giá trị tăng dần)");
            for (int i = 0; i < soptB; i++)
            {
                b[i] = double.Parse(Console.ReadLine());
            }

            double[] c = new double[soptA + soptB];
            int indexA = 0,indexB = 0,indexC = 0;
            while (indexA < soptA && indexB < soptB) 
            {
                if (a[indexA] < b[indexB])
                {
                    c[indexC++] = a[indexA++];
                }
                else
                {
                    c[indexC++] = b[indexB++];

                }
            }

            while (indexA < soptA)
            {
                c[indexC++] = a[indexA++];
            }
            while (indexA < soptB)
            {
                c[indexC++] = b[indexB++];
            }

            Console.WriteLine("Dãy kết hợp của a và b là :");
            foreach(var i in c)
            {
                Console.WriteLine(i+" ");
            }
        }
    }
}
