using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong06
{
    internal class ViduKethua
    {
        /**
         * 1.Khái niệm kế thừa:
         * - Kế thừa là khả năng cho phép sử dụng lại những đối tượng đã có sẵn 
         * để tạo ra các đối tượng mới. Lớp A kế thừa lớp B thì lớp A gọi là lớp 
         * dẫn xuất(lớp con), lớp B là lớp cơ sở(lớp cha)
         * - Có 2 loại kế thừa :
         *      + Đơn kế thừa : vd kế thừa lớp với lớp
         *      + Đa kế thừa : vs kế thừa Interface
         * 
         * 2. Cài đặt kế thừa:
         * class <classA> : <classB>
         * - classA kế thừa từ classB. trong đó classA có thể truy xuất đến các 
         * thành phần trong lớp classB nếu thành phần đó có phạm vi truy xuất là
         * protected hoặc public. Hàm khởi tạo không được kế thừa
         * 
         * 3. Từ khóa protected:
         * - Trong lớp cơ sở(lớp cha), thành phần nào có phạm vi truy xuất là 
         * protected thì nó sẽ đc truy xuất trong lớp dẫn xuất(lớp con)
         * 
         * 4. Từ khóa sealed:
         * - Một lớp có từ khóa sealed có nghĩa là lớp đó không cho phép các lớp 
         * khác kế thừa
         * VD: sealed class classA{//Class Implemetation}
         * 
         * 5. Từ khóa base:
         * - Dùng để truy cập đến các thành phần (thuộc tính, phương thức ...)
         * bên trong lớp cơ sở từ lớp dẫn xuất(lớp kế thừa). Dùng để gọi hàm tạo 
         * của lớp cơ sở khi tạo đối tượng của lớp dẫn xuất, không đc sử dụng từ 
         * khóa base trong phương thức tĩnh.
         * 
         * 6. Từ khóa new:
         * - Từ khóa new ngoài chức năng là một toán tử để tạo đối tượng của một lớp
         * nó còn đc dùng để che dấu đi các thuộc tính và phương thức của lớp cơ sở
         * - Do đó trong lớp dẫn xuất, muốn gọi các thuộc tính và phương thức ở
         * lớp cơ sở, sử dụng từ khóa base.
         * 
         * 7. Ghi đè phương thức(Method override)
         * - Là lkhả năng cho phép lớp dẫn xuất định nghĩa lại(override/ redefine)
         * các phương thức của lớp cơ sở. phương thức ở lớp cơ sở và lớp dẫn xuất
         * có cùng một prototype(signature) nhưng thực hiện các công việc khác nhau.
         * Để ghi đè (override) một phương thức ở lớp cơ sở, thực hiện như sau:
         *      + Đặt từ khóa virtual trước phương thức trong lớp cơ sở
         *      + Đặt từ khóa override trc phương thức muốn override trong lớp dẫn xuất
         * VD:
         *  [access modifier] virtual [return-type] name( [parameters-list] )
            {
             //virtual method implementation
            } 
         *
            [access modifier] override [return-type] name( [parameters-list] )
            {
             //virtual method implementation
            } 
         *   
         * 8. Đa hình:
         * - Nói ở ngữ cảnh chung chung, đa hình là khả năng biến hóa thành nhiều 
         * hình dạng khác nhau.
         * - Đa hình thể hiện ở 3 dạng:
         *      + Method overriding : Phương thức của lớp dẫn xuất(con) ghi đè
         *      phương thức của lớp cơ sở(cha).
         *      + Viết chồng phương thức trừu tượng: Phương thức của lớp dẫn xuất
         *      cài đặt phương thức trừu tượng của lớp tượng.
         *      + Viết chồng các phương thức của interface : Các phương thức của
         *      một lớp cài đặt các phương thức trong một interface
         * - Đa hình là khả năng một biến tham chiếu thay vì hành vi tùy theo
         * đối tượng mà nó đang tham chiếu đến. Cho phép nhiều đối tượng của các 
         * lớp dẫn xuất(lớp con) được coi như là các đối tượng của super class và
         * tự động lựa chọn đúng phương thức dựa trên đối tượng mà phương thức đó
         * được triệu gọi.
         * - Ưu điểm: + Dễ mở rộng    + Đơn giản hóa code(dễ viết và dễ hiểu)
         */
    }
    /*Vi du minh hoa tu khoa new*/
    public class BaseC
       
    {
            public int x = 55;

    }
    public class DerivedC : BaseC
    {       
    new public int x = 100;// tu khoa new de an di 'x' trong lop BaseC
        void show()
        {
            Console.WriteLine(x);
            //hien thi gia tri trong lop BaseC
            Console.WriteLine(base.x);
        }
        //static void Main()
        //{
        //   DerivedC obj = new DerivedC();
        //    obj.show();
        //}
    }

    //public class DrawingObject
    //{
    //    public virtual void Draw()
    //    {
    //        Console.WriteLine("I'm just a generic drawing object.");
    //    }
    //}
    //public class Line : DrawingObject
    //{
    //    public override void Draw()
    //    {
    //        Console.WriteLine("I'm a Line.");
    //    }
    //}
    //public class Circle : DrawingObject
    //{
    //    public override void Draw()
    //    {
    //        Console.WriteLine("I'm a Circle.");
    //    }
    //}
    //public class Square : DrawingObject
    //{
    //    public override void Draw()
    //    {
    //        Console.WriteLine("I'm a Square.");
    //    }
    //}
    //public class DrawDemo
    //{
    //    //public static int Main()
    //    //{
    //    //    DrawingObject[] dObj = new DrawingObject[4];
    //    //    dObj[0] = new Line();
    //    //    dObj[1] = new Circle();
    //    //    dObj[2] = new Square();
    //    //    dObj[3] = new DrawingObject();
    //    //    foreach (DrawingObject drawObj in dObj)
    //    //    {
    //    //        drawObj.Draw();
    //    //    }
    //    //    return 0;
    //    //}
    //}

    class Car
    {
        public virtual void DescribeCar()
        {
            System.Console.WriteLine("Four wheels and an engine.");
        }
    }
    // Define the derived classes
    class ToyotaCar : Car
    {
        public virtual void DescribeCar()
        {
            System.Console.WriteLine("This is Toyota car.Made in Japan");
        }
    }
    class FordCar : Car
    {
        public override void DescribeCar()
        {
            System.Console.WriteLine("This is Ford car.Made in American");
        }
    }
    public class TestCars1
    {
        //public static void Main()
        //{
        //    Car car1 = new Car();
        //    car1.DescribeCar();
        //    System.Console.WriteLine("----------");
        //    ToyotaCar car2 = new ToyotaCar();
        //    car2.DescribeCar();
        //    System.Console.WriteLine("----------");
        //    FordCar car3 = new FordCar();
        //    car3.DescribeCar();
        //    System.Console.WriteLine("----------");
        //}
    }


    namespace TestOverride
    {
        public class Employee
        {
            public string name;
            // Tien luong duoc khai bao co pham vi truy xuat la protected
            // de no chi duoc truy xuat ben trong lop
            //va nhung lop ke thua lop Employee
            protected decimal salary;
            // Constructor de khoi tao gia tri cho name va salary.
            public Employee(string name, decimal salary)
            {
                this.name = name;
                this.salary = salary;
            }
            // Khai bao la phuong thuc ao de no co the overriding.
            public virtual decimal CalculatePay()
            {
                return salary;
            }
        }
        // Khai bao mot lop ke thua lop Employee.
        public class SalesEmployee : Employee
        {
            // khai bao mot field moi cua lop SalesEmployee.
            private decimal bonus; //bonus: tien thuong
                                   // Constructor de khoi tao
            public SalesEmployee(string name, decimal salary, decimal bonus)
            : base(name, salary)
            {
                this.bonus = bonus;
            }
            // Override phuong thuc CalculatePay
            // phuong thuc CalculatePay cua lop SalesEmployee tra ve luong + thuong.
            public override decimal CalculatePay()
            {
                return salary + bonus;
            }
            //static void Main()
            //{
            //    // Tao 1 doi tuong thuoc lop employees.
            //    Employee emp1 = new Employee("Bob", 1200);
            //    //Tao 1 doi tuong thuoc lop SaleEmployees
            //    SalesEmployee emp2 = new SalesEmployee("Alice", 1000, 500);
            //    //in ket qua
            //    Console.WriteLine("Nhan vien: " + emp1.name + " kiem duoc: " + emp1.CalculatePay());
            //    Console.WriteLine("Nhan vien " + emp2.name + " kiem duoc: " + emp2.CalculatePay());
            //}
        }
    }
}
