using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong07
{
    internal class Baitap13
    {
       /* 13) }
        Chương trình sau ñây có lỗi hãy sử lỗi, biên dịch và chạy lại chương
        trình? Giải thích tại sao chương trình có lỗi.
       */
        interface IPoint
        {
            // Property signatures:
            int x { get; set; }
            int y { get; set; }
        }
        class MyPoint : IPoint
        {
            // Fields:
            private int myX;
            private int myY;
            // Constructor:
            public MyPoint(int x, int y)
            {
                myX = x;
                myY = y;
            }
            // Property implementation:
            public int x
            {
                get
                {
                    return myX;
                }
                set
                {
                    myX = value;
                }
            }
            public int y
            {
                get
                {
                    return myY;
                }
                set
                {
                    myY = value;
                }
            }
        }

        private static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y={1}", p.x, p.y);
        }
        public static void Tester()
        {
            MyPoint p = new MyPoint(2, 3);
            Console.Write("My Point: ");
            PrintPoint(p);
            // lỗi khi cố gắng khởi tạo interface IPoint bằng cách sử dụng từ khóa new. 
            //IPoint p2 = new IPoint();

            IPoint p2 = new MyPoint(4, 5);
            PrintPoint(p2);
        }
    }
}
