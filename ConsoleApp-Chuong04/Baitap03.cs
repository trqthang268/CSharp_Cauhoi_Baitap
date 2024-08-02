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
            Console.WriteLine("Nhap so luong phan tu cua day a: ");
            int soptA = int.Parse(Console.ReadLine());
            double[] a = new double[soptA];
            Console.WriteLine("Nhap cac phan tu cua day a (tang dan)");
            for (int i = 0; i < soptA; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nhap so luong phan tu cua day b: ");
            int soptB = int.Parse(Console.ReadLine());
            double[] b = new double[soptB];
            Console.WriteLine("Nhap cac phan tu cua day b (tang dan)");
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
