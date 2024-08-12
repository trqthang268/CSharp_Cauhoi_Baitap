using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp_Chuong10
{
    internal class Baitap13
    {
        /*
         * 13) Chương trình sau ñây có thể dẫn đến ngoại lệ hay không? Nếu có
         * thì hãy cho biết ngoại lệ có thể được phát sinh. Hãy viết lại
         * chương trình hoàn chỉnh có xử lý các ngoại lệ bằng cách đưa ra
         * thông điệp về ngoại lệ được phát sinh. 
         * - Chương trình được cung cấp có thể dẫn đến một số ngoại lệ, tùy 
         * thuộc vào trạng thái của file 'text3.txt' và môi trường chạy chương
         * trình. Các ngoại lệ có thể xảy ra :
         *      > 'FileNotFoundException' : Nếu file không tồn tại ở vị trí
         *      được chỉ định. 
         *      > 'IOException' : Có thể xảy ra khi có sự cố với file, ví dụ 
         *      như quyền truy cập bị từ chối hoặc lỗi hệ thống liên quan đến 
         *      file.
         *      > 'UnauthorizedAccessException' : Nếu chương trình không có
         *      quyền truy cập để mở file
         *      > 'ObjectDisposedException' : Nếu cố gắng đọc từ StreamReader
         *      sau khi nó đã bị đóng.
         */
        // using System;
        // using System.IO;
        public class Tester
        {
            public static void MainBT13()
            {
                string fname = "test3.txt";
                string buffer;
                StreamReader sReader = null;
                try
                {
                    sReader = File.OpenText(fname);
                    while ((buffer = sReader.ReadLine()) != null)
                    {
                        Console.WriteLine(buffer);
                    }

                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Lỗi: File không tồn tại.");
                }
                catch (IOException ex) 
                {
                    Console.WriteLine("Lỗi: Vấn đề với file.");
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine("Lỗi: Không có quyền truy cập file.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi không xác định.");
                }
                finally
                {
                    if (sReader != null)
                    {
                        sReader.Close();
                    }
                }
            }
        }
    }
}
