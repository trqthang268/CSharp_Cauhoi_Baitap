using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong04
{
    internal class Baitap04
    {
        public static void XoaDauCach()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập chuỗi : ");
            string input = Console.ReadLine();

            //khởi tạo một StringBuilder để xây dựng chuỗi kết quả
            StringBuilder result = new StringBuilder();

            //Biến cờ để kiểm tra trạng thái đang trong một từ
            bool inWord = false;
            //duyệt qua từng ký tự của chuỗi đầu vào
            foreach(char c in input)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (inWord)
                    {
                        //thêm một dấu cách nếu đang trong một từ và có dấu cách
                        result.Append(' ');
                        inWord = false;
                    }
                }
                else
                {
                    //Thêm ký tự vào kết quả nếu không phải dấu cách
                    result.Append(c);
                    inWord = true;
                }
            }

            //Loại bỏ dấu cách ở cuối chuỗi kết quả nếu có
            if (result.Length > 0 && result[result.Length - 1] == ' ') 
            {
                result.Length--;
            }

            Console.WriteLine("Chuỗi sau khi loại bỏ dấu cách thừa: "+result.ToString());

        }
    }
}
