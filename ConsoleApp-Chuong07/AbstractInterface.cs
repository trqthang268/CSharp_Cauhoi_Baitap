using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong07
{
    internal class AbstractInterface
    {
        /*
         * 1. Phương thức trừu tượng:
         * - Là phương thức mà không có phần cài đặt(chỉ có phần khai báo nguyên mẫu mà 
         * không có phần thân).
         * - Cú pháp : đặt từ khóa abstract truớc phần khai báo phương thức
         * 
         * 2. Lớp trừu tượng:
         * - Lớp trừu tượng (abstract class) là lớp gồm 1 hoặc nhiều phương thức trừu tượng
         * - Không thể khởi tạo đối tượng cho lớp trừu tượng.
         * - Một lớp khác sẽ cài đặt các phương thức trong lớp trừu tượng
         * - Khi nào thì dùng phương thức trừu tượng và lớp trừu tượng:
         * -> Khi hai hoặc nh lớp muốn cài đặt các phương thức cùng tên nhưng mỗi phương 
         * thức trong 1 lớp lại thực hiện các công việc khác nhau(tính đa hình).
         * -> Các lớp này sẽ kế thừa và cài đặt các phương thức trong lớp cơ sở
         * -> Trong lập trình hướng đối tượng, lớp trừu tượng thường đc đặt ở mức đỉnh 
         * trong sơ đồ cây phân cấp các lớp kế thừa
         * 
         * 3. Interface:
         * - Là lớp trừu tượng hoàn toàn, có nghĩa là trong interface chỉ chứa các phương 
         * thức trừu tượng(abtract method), nó không chứa các phương thức thường. Cũng giống 
         * như lớp trừu tượng, không thể khởi tạo đối tượng của interface. Một interface có 
         * thể nằm trong một namespace, nằm trong 1 lớp(trong class thì phải đặt public)
         * - Trong interface chỉ gồm các thành phần:
         *      > Abstract method
         *      > Properties
         *      > Indexers
         *      > Event
         * - Cu phap:
         *      interface IFile
         *      {
         *          int delFile();
         *          void disFile();
         *      }
         *      
         * - Nếu đặt interface trong 1 lớp thì phải đặt từ khóa public trc interface
         * - Ưu điểm:
         *      > Có được các lớp không có quan hệ với nhau cùng cài đặt các phương thức
         *      giống nhau.
         *      > Sử dụng đa kế thừa, tức 1 interface có thể kế thừa từ nhiều interface khác
         *      > Che dấu thông tin (encapsulation)
         *      
         * 4. Cài đặt interface
         * - Interface được cài đặt bởi các lớp. Một lớp cài đặt interface thì phải cài đặt
         * tất cả các phương thức khai báo trong interface. Các phưong thức cài đặt trong lớp 
         * phải có nguyên mẫu giống như trong interface.
         * 
         * 5. Kế thừa Interface
         * - Ngôn ngữ C# cho phép một lớp cài đặt nhiều Interface, điều đó gọi là Multiple 
         * Interface và một interface có thể kế thừa nhiều Interface.
         * 
         * 6. So sánh lớp trừu tượng và Interface
         * - Giống nhau: 
         *      > Cả hai đều không thể khởi tạo đối tượng.
         *      > Cả hai đều chứa phương thức trừu tượng.
         *      > Cả lớp trừu tượng và interface đều được cài đặt bới lớp kế thừa.
         * - Khác nhau:
         *      > Lớp trừu tượng có thể kế thừa một lớp và nhiều interface, còn interface chỉ 
         *      kế thừa được nhiều interface.
         *      > Lớp trừu tượng có thể có phương thức thông thường(có thân) nhưng interface chỉ
         *      gồm các phương thức trừu tượng
         *      > Phương thức của lớp trừu tượng được cài đặt bằng từ khóa override, phương thức
         *      của interface đc đặt mà không dùng từ khóa override.
         *      > Sử dụng lớp trừu tượng khi muốn trong lớp vừa có phương thức trừu tượng và có
         *      phương thức bình thường. Sử dụng interface khi chỉ khai báo các phương thức trừu
         *      tượng
         *      > Lớp trừu tượng có thể khai báo phương thức khởi tạo, hàm hủy bên trong lớp, còn 
         *      interface thì không
         *      
         */
    }

    abstract class BaseClass
    {
        protected int x = 100;
        protected int y = 150;
        public abstract void AbstractMethod(); // Abstract method
    }
    class DerivedClass : BaseClass
    {
        public override void AbstractMethod()
        {
            x++; y++;
        }
    }

    interface ISampleInterface
    {
        void SampleMethod();
    }
    //khai bao lop cai dat interface
    class ImplementationClass : ISampleInterface
    {
        /*cai dat phuong thuc SampleMethod cua interface*/
        void ISampleInterface.SampleMethod()
        {
            Console.WriteLine("This is sample method");
        }
    }
}
