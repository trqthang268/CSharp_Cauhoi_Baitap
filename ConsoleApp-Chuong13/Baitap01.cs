using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong13
{
    /*
     1) Viết chương trình sao chép một tệp tin từ tệp này sang tệp khác.
    Tên của tệp được nhập từ bàn phím nguồn và đích được nhập từ tham số
    dòng lệnh. Ví dụ: cp d:/temp.txt c:/abc.txt
     */
    internal class Baitap01
    {
        //Phương thức thực hiện sao chép tệp
        public static void CopyFile(string sourcePath, string destinationPath)
        {
            try
            {
                //Sao chép tệp từ nguồn sang sang 
                File.Copy(sourcePath, destinationPath, true);
                Console.WriteLine("Sao chép tệp thành công.");
            }
            catch (Exception ex)
            {
                //Hiển thị lỗi nếu có
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        public static void Test()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Nhập đường dẫn tệp nguồn từ bàn phím
            Console.Write("Nhập đường dẫn tệp nguồn: ");
            string sourcePath = Console.ReadLine();

            // Nhập đường dẫn tệp đích từ bàn phím
            Console.Write("Nhập đường dẫn tệp đích: ");
            string destinationPath = Console.ReadLine();

            //Gọi phương thức sao chép tệp
            CopyFile(sourcePath, destinationPath);
        }
    }
}
