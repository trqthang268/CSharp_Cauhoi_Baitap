using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong07
{
    internal class Baitap12
    {
        /*
         * 12) ðọan mã nguồn sau đây có lỗi hãy sửa lỗi và hãy cho biết tại 
         * sao có lỗi này. Sau khi sửa lỗi hãy viết một lớp Circle thực thi 
         * giao diện này? 
         */
        public interface IDimensions
        {
            //Có lỗi biên dịch vì interface không thể chứa các trường
            //long width;
            //long height;

            //Sửa lại:
            long width { get; set; }
            long height { get; set; }   

            double Area();
            double Circumference();
            int Side();
        }

        public class Circle : IDimensions
        {
            public long width { get; set; }
            public long height { get; set; }
            public double Radius { get; set; }
            public Circle(double radius)
            {
                this.Radius = radius;
            }
            public double Area()
            {
                return Math.PI * Radius * Radius;
            }

            public double Circumference()
            {
                return Math.PI * Radius * 2;
            }

            public int Side()
            {
                return 0;
            }
        }
    }
}
