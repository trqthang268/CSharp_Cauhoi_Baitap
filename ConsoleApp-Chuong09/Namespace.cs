using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math;
using test.Car;
using test.Vehice;
using IO = System.Console;
using Emp = Bank.Accounts.EmployeeDetails;

namespace ConsoleApp_Chuong09
{
    internal class Namespace
    {
        /*
         * 1. Namespace : 
         * - Trong một project lớn, có nhiều người cùng tham gia phát triển, có
         * trường hợp ngẫu nhiên 2 lập trình đặt tên 2 lớp trùng tên nhau, khi 
         * ghép nối module vào trình biên dịch sẽ báo lỗi 2 lớp trùng tên nhau.
         * Để giải quyết tình huống như thế này chúng ta đặt mỗi lớp vào trong một
         * namespace. Mặt khác, khi nhóm các lớp liên quan vào trong một namespace
         * sẽ giúp cho việc quản lý thư viện các lớp dễ dàng hơn.
         * - Để gọi các lớp trong một namespace, ta sử dụng cú pháp:
         *      using < Tên của namespace >
         *
         * 2. System namespace :
         * - System namespace là các namespace hệ thống mà ngôn ngữ lập trình C#
         * cung cấp sẵn cho người dùng. Ví dụ System là một namespace hệ thống,
         * trong namespace này có các lớp như Console, Math...
         * 
         * 3. Custom namespace :
         * - Custom namespace là những namespace do người tự xây dựng. Cú pháp để
         * tạo ra một namespace
         *      namespace <Tên Name space>
         *      {
         *          //Khai báo các lớp
         *      }
         * - Bên trong một namespace có thể chứa: lớp, interface, delegate, 
         * enumeration. Phạm vi truy xuất của namespace luôn là public, vì vậy khi
         * khai báo không được đặt bất kỳ từ khóa chỉ phạm vi truy xuất nào trước 
         * tên namespace.
         * - Một namespace có thể khai báo bên trong một namespace khác gọi là 
         * nested namespace 
         *      namespace <NamespaceName>
         *      {
         *          namespace <NamespaceName>
         *          {
         *          }
         *          namespace <NamespaceName>
         *          {
         *          }
         *      }
         * 4. Namespace alias
         * - Nếu một namespace có tên dài, chúng ta nên đặt bí danh cho nó để
         * việc viết code ngắn gọn hơn
         * - Syntax: using <aliasName> = <NamespaceName>
         * 
         * 
         */
    }
}
namespace Math
{
    class Circle
    {
        public static double Area(double radius)
        {
            return (3.14 * radius * radius);
        }
    }
}
//lop rectangle
namespace Math
{
    class Rectangle
    {
        public static double Area(double a, double b)
        {
            return (a * b);
        }
    }
}
//lop square
namespace Math
{
    class Square
    {
        public static double Area(double a)
        {
            return (a * a);
        }
    }
}

namespace test
{
    namespace Car
    {
        class Car
        {
            string name;
            public Car(string name)
            {
                this.name = name;
            }
            public void print()
            {
                Console.WriteLine(this.name);
            }
        }
    }
    namespace Vehice
    {
        class Vehice
        {
            string name;
            int age;
            public Vehice(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public void print()
            {
                Console.WriteLine(this.name + ":" + this.age);
            }
        }
    }
}

namespace Main
{
    class main
    {
        public static void test()
        {
            Car acar = new Car("Toyota");
            Vehice avi = new Vehice("Thong nhat", 10);
            acar.print();
            avi.print();
        }
    }
}

namespace Math
{
    class TestNamespace
    {
        static void Test()
        {
            //khai bao ban kinh
            double r = 10;
            //canh hinh vuong
            double a = 11;
            //chieu dai & rong hinh chu nhat
            double c = 2, d = 3;
            Console.WriteLine("Dien tich hinh tron:{0}", Circle.Area(r));
            Console.WriteLine("Dien tich hinh vuong:{0}", Square.Area(a));
            Console.WriteLine("Dien tich hinh chu nhat:{0}", Rectangle.Area(c, d));
        }
    }
}

namespace Bank.Accounts.EmployeeDetails
{
     public class Employee
    {
        public string EmpName;
    }
}
class AliasExample
{
    static void Test()
    {
        Emp.Employee objEmp = new Emp.Employee();
        objEmp.EmpName = "TungPH";
        IO.WriteLine("Employee Name:" + objEmp.EmpName);
    }
}