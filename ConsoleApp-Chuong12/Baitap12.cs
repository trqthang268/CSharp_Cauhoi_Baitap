using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 12) Viết chương trình minh họa sử dụng ủy quyền để thực hiện việc 
        chuyển các ký tự thường thành ký tự hoa trong một chuỗi?
 */
namespace Baitap12
{
    //Khai báo delegate
    public delegate string StringProcessor(string input);
    //Tạo phương thức chuyển ký tự thường thành in hoa
    public class StringConverter
    {
        public static string ConvertToUpper(string input)
        {
            //Chuyển chuỗi thành in hoa
            return input.ToUpper();
        }
    }
    public class Program
    {
        public static void Test()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Khai báo và gán delegate với phương thức chuyển đổi
            StringProcessor stringProcessor = new StringProcessor(StringConverter.ConvertToUpper);

            Console.WriteLine("Nhập chuỗi : ");
            string input = Console.ReadLine();

            //Sử dụng delegate để chuyển đổi chuỗi
            string ketqua = stringProcessor(input);
            
            //Hiển thị kết quả
            Console.WriteLine("Chuỗi sau khi chuyển đổi : "+ketqua);
        }
    }
}
