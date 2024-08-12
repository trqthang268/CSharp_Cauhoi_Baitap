using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp_Chuong10
{
    internal class ExceptionDinhnghia
    {
        /*
         * 1. Exception là:
         * - Lỗi mà khi chương trình chạy mới xảy ra
         * - Các lỗi ngoại lệ thường gặp :
         *      - Lỗi chia cho số không
         *      - Lỗi nhập sai định dạng dữ liệu
         *      - Lỗi truy xuất vượt quá phạm vi của mảng
         *      - Lỗi tràn bộ nhớ
         *      - Lỗi thiếu bộ nhớ
         *      - ...
         * - Exception có thể do người dùng chương trình gây ra, hoặc có thể 
         * do hệ thống gây ra như lỗi kết nối database server, lỗi kết nối 
         * mạng.
         * 
         * 2. Các lớp xử lý ngoại lệ:
         * - Exception là lớp nằm trong namespace System, dùng để xử lý các 
         * ngoại lệ.
         * - Do có nhiều loại ngoại lệ khác nhau nên C# cung cấp các lớp khác
         * nhau để xử lý các ngoại lệ.
         * - Tất cả các lớp xử lý ngoại lệ đều kế thừa từ lớp Exception. Lớp
         * Exception có các thuộc tính để chứa thông tin về ngoại lệ
         * - Các thuộc tính của lớp Exception:
         * |Thuộc tính  || Mô tả                                             |
         * |Message     || Chứa thông điệp chỉ ra nguyên nhân gây ra lỗi     |
         * |Source      || Cung cấp tên ứng dụng hoặc đối tượng gây ra lỗi   |
         * |StarckTrace || Cung cấp thông tin chi tiết của ngoại lệ trên vùng|
         * |            || nhớ khi xảy ra ngoại lệ                           |
         * 
         * 3. Bắt và xử lý lỗi ngoại lệ:
         * - Bắt và xử lý ngoại lệ bằng cách sử dụng cấu trúc try-catch
         * - Syntax :   
         *      try
         *      {
         *          // các câu lệnh có thể xảy ra lỗi
         *      }
         *      catch(<ExceptionClass>)
         *      {
         *          //Các câu lệnh xử lí lỗi
         *      }
         * - 
         * 
         * 4. Câu lệnh throw
         * - Câu lệnh throw dùng để ném ra một ngoại lệ
         * - Đối số của câu lệnh throw là một đối tượng thuộc lớp để bắt ngoại
         * lệ
         * - Cú pháp : throw exceptionObject
         * 
         * 5. Câu lệnh finally:
         * - Finally là khối lệnh không bắt buốc phải có sau try, nó không có 
         * đối số.
         */
    }

    public class ThrowTest
    {
        static void Test()
        {
            string s = null;
            if (s == null)
            {
                Console.WriteLine("Test cau lenh throw");
                throw new ArgumentNullException();
            }
            Console.Write("The string s is null"); // not executed
        }
    }
}

namespace ExHandle
{
    class ExceptionDemo1
    {
        public static void Test()
        {
            byte[] a = new byte[5];
            //nhap mang
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("a[{0}]=", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch (FormatException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Khong duoc nhap ki tu cho mang so");
            }
            catch (OverflowException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Khong duoc nhap gia tri nam ngoai mien 0-255");
            }
            catch (IndexOutOfRangeException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Loi vuot qua pham vi cua mang");
            }
            //in mang
            for (int i = 0; i < 5; i++)
                Console.Write(" {0}", a[i]);

        }
    }
}

/*Vi du ve cau lenh throw*/
class MainClass
{
    static void ProcessString(string s)
    {
        if (s == null)
        {
            throw new ArgumentNullException();
        }
    }
    public static void Test()
    {
        try
        {
            string s = null;
            ProcessString(s);
        }
        catch (Exception e)
        {
            Console.WriteLine("Doi so khong duoc de null");
            //Console.WriteLine("{0} Exception caught.", e);
        }
    }
}

/*Vi du ve tu khoa finally*/
class FinallyDemo
{
    public static void Test()
    {
        FileStream outStream = null;
        FileStream inStream = null;
        try
        {
            //mo file de ghi du lieu
            outStream = File.OpenWrite("DestinationFile.txt");
            //mo file de doc du lieu
            inStream = File.OpenRead("BogusInputFile.txt");
            //cac cau lenh ghi du lieu len file
            //cac cau lenh doc du lieu tu file
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            if (outStream != null)
            {
                outStream.Close();
                Console.WriteLine("outStream closed.");
            }
            if (inStream != null)
            {
                inStream.Close();
                Console.WriteLine("inStream closed.");
            }
        }
    }
}
