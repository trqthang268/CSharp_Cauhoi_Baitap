using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong03
{
    internal class vidu
    {
        public static void Vidu()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n1, n2;
            int x1, x2;
            n1 = n2 = 1;
            //phep toan tang dat ben phai n1
            x1 = 10 * n1++;
            Console.WriteLine("x1 = {0},n1 = {1}", x1, n1);
            //phep taon tang dat ben trai bien n2
            x2 = 10 * ++n2;
            Console.WriteLine("x2 = {0},n2 = {1}", x2, n2);

            int x, y, z, max;
            //nhap x
            Console.WriteLine("Nhập x = ");
            x = Convert.ToInt32(Console.ReadLine());
            //nhap y
            Console.WriteLine("Nhập y = ");
            y = Convert.ToInt32(Console.ReadLine());
            //nhap z
            Console.WriteLine("Nhập z = ");
            z = Convert.ToInt32(Console.ReadLine());
            max = (x > y) ? x : y;
            max = (max > z) ? max : z;
            Console.WriteLine("Max of x,y,z is:{0}", max);
        }

        public static void ViduClIf()
        {
            int a1;
            //nhap a
            Console.WriteLine("a = ");
            a1 = Convert.ToInt32(Console.ReadLine());
            if (a1 % 2 == 0)
                Console.WriteLine("a la so chan");
            else
                Console.WriteLine("a la so le");

            double a, b, c, delta, x1, x2;
            //nhap cac he so a,b,c
            Console.WriteLine("a,b,c=");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta < 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem kep");
                Console.WriteLine("x1=x2={0}", -b / (2 * a));
            }
            else
            {
                Console.WriteLine("Phuong trinh co 2 nghiem");
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1={0}", x1);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x2={0}", x2);
            }

        }

        public static void ViduClSwitch()
        {
            int n;
            Console.WriteLine("n=");
            n = Convert.ToInt16(Console.ReadLine());
            switch (n)
            {
                case 2:
                    Console.WriteLine(" Hom nay la thu 2");
                    break;
                case 3:
                    Console.WriteLine(" Hom nay la thu 3");
                    break;
                case 4:
                    Console.WriteLine(" Hom nay la thu 4");
                    break;
                case 5:
                    Console.WriteLine(" Hom nay la thu 5");
                    break;
                case 6:
                    Console.WriteLine(" Hom nay la thu 6");
                    break;
                case 7:
                    Console.WriteLine(" Hom nay la thu 7");
                    break;
                default:
                    Console.WriteLine(" Hom nay la chu nhat");
                    break;
            }
        }

        public static void ViduClSwitch2()
        {
            char ch;
            //nhap vao 1 ki tu
            Console.WriteLine("Nhap vao 1 ki tu:");
            ch = (char)Console.Read();
            switch (ch)
            {
                case 'a':
                case 'o':
                case 'e':
                case 'u':
                case 'i':
                    Console.WriteLine("{0} la nguyen am.", ch);
                    break;
                default:
                    Console.WriteLine("{0} la phu am.", ch);
                    break;
            }
        }

        public static void ViduFor()
        {
            int i;
            for (i = 1; i <= 10; i++)
                Console.Write("{0,3:d}", i);
            //xuong dong
            Console.WriteLine();
            for (i = 10; i >= 1; i--)
                Console.Write("{0,3:d}", i);
            //dung man hinh
            Console.ReadLine();
        }

        public static void ViduFor2()
        {
            const int count = 5;
            for (int i = 0, j = 10; i < count; i++, j += 10)
            {
                Console.WriteLine("{0}, {1}", i, j);
            }
        }

        public static void ViduFor3()
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine();
                for (j = 1; j <= i; j++)
                    Console.Write("{0,5:D}", j);
            }
            Console.ReadLine();
        }

        public static void ViduFor4()
        {
            int i, j, k;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine();
                //in ki tu cach
                for (k = 1; k <= 5 - i; k++)
                    Console.Write(" ");
                for (j = 1; j <= i; j++)
                    Console.Write("{0,1:D}", j);
            }
            Console.ReadLine();
        }

        public static void ViduFor5() 
        {
            int i, j, k;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine();
                //in dau cach
                for (k = 1; k <= 10 - i; k++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
            }
            Console.ReadLine();
        }

        public static void ViduWhile() 
        {
            int n = 1;
            while (n < 6)
            {
                Console.WriteLine("Current value of n is {0}", n);
                n++;
            }

        }

        public static void ViduDOWhile()
        {
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x < 5);
        }

        public static void ViduBreak()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i == 50)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }

        public static void ViduContinue()
        {
            int i;
            for (i = 1; i <= 50; i++)
            {
                if (i % 5 != 0)
                    continue;
                Console.Write("{0,5}", i);
            }
            Console.WriteLine();
        }

        public static void ViduGoto()
        {
            int n;
            Console.WriteLine("Hello World1");
            goto err;
            Console.WriteLine("Hello World2");
            Console.WriteLine("Hello World3");
            err:
            Console.WriteLine("Hello World4");
        }
    }
}
