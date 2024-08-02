using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong04
{
    internal class Baitap05
    {
        public static void MaTranNghichDao()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Nhap kich thuoc cua ma tran vuong
            Console.Write("Nhập kích thước của ma trận vuông n: ");
            int n = int.Parse(Console.ReadLine());

            //Nhap ma tran vuong cap n
            double[,] matrix = new double[n, n];
            Console.WriteLine("Nhập các phần tử trong ma trận: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0;  j < n;  j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i,j] = double.Parse(Console.ReadLine());
                }
            }

            //Khoi tao ma tran don vi cap n
            double[,] identity = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                identity[i, i] = 1.0;
            }

            //ap dung phuong phap khu Gauss-Jordan
            for (int i = 0; i < n; i++)
            {
                //tim phan tu chinh pivot
                double pivot = matrix[i,i];
                if (pivot == 0)
                {
                    Console.WriteLine("Ma trận không khả nghịch");
                    return;
                }

                //Chia hang hien tai cho pivot de phan tu chinh tro thanh 1
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] /= pivot;
                    identity[i, j] /= pivot;
                }

                //khu cac phan tu khac trong cot hien tai
                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        double factor = matrix[k, i];
                        for (int j = 0; j < n; j++)
                        {
                            matrix[k, j] -= factor * matrix[i, j];
                            identity[k,j] -= factor * matrix[i, j];
                        }
                    }
                }
            }

            //in ma tran nghich dao
            Console.WriteLine("Ma trận nghịch đảo là: ");
            for(int i = 0;i<n; i++)
            {
                for(int j = 0;j<n; j++)
                {
                    Console.Write(identity[i, j] + " ");
                }
                Console.WriteLine();
            } 
        }
    }
}
