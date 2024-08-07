using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp_Chuong07
{
    internal class Baitap14
    {
        /*
         * 14) Xây dựng một giao diện IDisplay có khai báo thuộc tính Name
         * kiểu chuỗi. Hãy viết hai lớp Dog và Cat thực thi giao diện IDisplay,
         * cho biết thuộc tính Name là tên của đối tượng.
         */
        public static void Test()
        {
            //Tạo đối tượng Dog và Cat
            IDisplay dog = new Dog("Tom");
            IDisplay cat = new Cat("Jerry");
            //Hiển thị tên của dog và cat
            WriteLine("Dog name: " + dog.Name);
            WriteLine("Cat name: " + cat.Name);
        }
    }

    interface IDisplay
    {
        string Name { get; set; }
    }

    class Dog : IDisplay
    {
        public string Name { get; set; }
        public Dog(string name)
        {
            Name = name;
        }
    }

    class Cat : IDisplay
    {
        public string Name { get; set; }
        public Cat(string name)
        {
            Name = name;
        }
    }
}
