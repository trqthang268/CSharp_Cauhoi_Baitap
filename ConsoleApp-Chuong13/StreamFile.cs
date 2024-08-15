using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamFile
{
    internal class StreamFile
    {
        /*
         1. Namespace System.IO:
        - Namespace System.IO là namespace chứa các lớp sử dụng cho việc 
        thao tác với các file và thư mục, một số class thông dụng trong
        namespace này :
       |    Tên lớp     ||        Mô tả
       |File, Directory || Hai lớp tĩnh mà trong đó chứa tất cả những 
       |                || phương thức dùng để thao tác với file,thư mục
       |FileInfo,       || Hai lớp này cũng chứa các phương thức để thao
       |DirectoryInfo   || tác trên tập tin và thư mục, tuy nhiên, chúng
       |                || chỉ thực hiện thao tác trên 1 đối tượng cụ thể
       |FileStream      || Lớp cơ bản dùng cho việc truy xuất dữ liệu từ 
       |                || file. Dữ liệu được trình bày dưới dạng 1 chuỗi
       |                || các byte
       |MemoryStream    || Tương tự với FileStream, nhưng dữ liệu này sẽ
       |                || được lưu trong bộ nhớ RAM.
       |StreamWriter,   || Hai lớp được dùng cho việc truy xuất file theo
       |StreamReader    || dạng văn bản
       |BinaryReader,   || Các lớp được sử dụng cho việc truy xuất file 
       |BinaryWriter    || theo dạng nhị phân
       |DriveInfo       || Lớp chuyên dùng để truy xuất thông tin về các
       |                || ổ đĩa có trong hệ thống

        2. Sử dụng File và Directory để thao tác với file và thư mục:
        1.1. Các phương thức tĩnh của lớp File:
       |Tên phương thức        | Mô tả
       |Create(string path)    | Tạo mới 1 file theo đường dẫn nằm trong 
       |                       | đối số. Phương thức này sẽ trả về một 
       |                       | FileStream sử dụng cho việc truy xuất 
       |                       | file mới
       |CreateText(string      | Tạo mới 1 file, nhưng khác Create ở chỗ
       | path)                 | CreateText trả về một StreamWriter sử dụng
       |                       | cho việc ghi dữ liệu vào file theo dạng
       |                       | văn bản
       |Copy(string srcFilename| Các phương thức thực hiện thao tác cơ bản
       |,string destFileName   | với file như copy, xóa, di chuyển
       |Delete(string path)    | 
       |Move(string srcFileName|
       |,string destFileName)  |
       |Exists(string path)    | Kiểm tra xem một file có tồn tại trên đĩa
       |                       | cứng hay không
       |Open(string FileName,  | Dùng mở file ra thao tác với nó.
       |FileMode mode,         | Đối số thứ 2 sẽ xác định các thao tác của 
       |FileAccess access)     | máy tính khi tiến hành mở file:
       |                       | FileMode.Append – Mở file để ghi thêm dữ 
       |                       | liệu. Sau khi mở, người dùng sẽ bắt đầu ghi
       |                       | vào cuối file
       |                       | FileMode.Create – Tạo file mới (sẽ ghi đè 
       |                       | lên file cũ nếu có)
       |                       | FileMode.CreateNew - Tạo file mới nhưng sẽ
       |                       | báo lỗi nếu file đã tồn tại
       |                       | FileMode.Open – Chương trình sẽ mở một file
       |                       | có sẵn nhưng sẽ báo lỗi nếu file không
       |                       | tồn tại
       |                       | FileMode.OpenOrCreate –Chương trình sẽ mở
       |                       | file cũ, hoặc tạo file nếu nó chưa có 
       |                       | trong đĩa
       |                       | đối số thứ 3 xác định mục đích mở file:
       |                       | FileAccess.Read, FileAccess.Write,
       |                       | FileAccess.ReadWrite 
       |OpenRead(string path)  | Phương thức sẽ mở file ra để đọc.Trong đó
       |OpenText(string path)  | OpenRead mở file theo kiểu nhị phân,
       |                       | OpenText mở theo kiểu văn bản
       |File.OpenWrite         | Mở file để ghi.
       |(string path)          |
       |Encrypt(string path)   | Mã hóa file sao cho chỉ account mã hóa 
       |                       | mới có thể giải mã
       |Decrypt(string path)   | Giải mã file
       |GetAttributes(string   | Hàm sử dụng cho việc truy xuất các thuộc 
       |path)                  | tính của file như : hidden, readonly
       |SetAttributes(string   |
       |path)                  |

        1.2 Các phương tĩnh của lớp Directory:
       |Tên phương thức       ||Mô tả
       |CreateDirectory       ||Tạo mới 1 thư mục như đường dẫn
       |(string path)         ||
       |Delete(string path)   ||Xóa thư mục
       |Move(string           ||Di chuyển thư mục và toàn bộ nội dung 
       |srcFileName,string    ||trong đó đến một vị trí mới
       |destFileName)         ||
       |GetCurrentDirectory   ||Trả về thư mục hiện hành của ứng dụng
       |GetDirectories(string ||Trả về tên các thư mục con của thư mục nêu
       |path)                 ||trong đường dẫn 
       |GetFiles(string path) ||Trả về danh sách các file của thư mục nêu
       |                      ||trong đường dẫn
       |GetParent(string path)||Trả về tên thư mục cha của thư mục trong
       |                      ||đường dẫn
       |GetLogicalDrives()    ||Lấy ra tên các ổ đĩa có trong máy tính

        3. Sử dụng FileInfo và DirectoryInfo:
        3.1. Lớp FileInfo:
        - Tương tự như File, FileInfo cũng được sử dụng để thao tác với 
        file. Tuy nhiên, để sử dụng được FileInfo, ta phải khởi tạo đối
        tượng thì mới có thể truy xuất đến các thuộc tính và phương thức
        của nó. Các phương thức của 2 lớp về cơ bản là giống nhau.

        3.2. Phương thức khởi tạo:
                FileInfo <tên biến> = new FileInfo(string <Đường dẫn>);

        3.3. Các thuộc tính thông dụng:
        |Tên thuộc tính    || Mô tả
        |Attributes        || Các thuộc tính của file
        |CreationTime      || Thời điểm tạo File
        |Directory         || Thư mục cha của file hiện thời
        |Exists            || Kiểm tra xem file có tồn tại hay không
        |Extension         || Trả về phần mở rộng của file
        |FullName          || Trả về đường dẫn đầy đủ của file
        |IsReadOnly        || Kiểm tra xem file có là readonly hay không
        |Length            || độ dài file, tính bằng Bytes
        |Name              || Tên file 

        3.4. Các phương thức thông dụng
        |Tên phương thức    ||Mô tả
        |Create             ||
        |CreateText         ||Tạo file trên đĩa cứng
        |CopyTo             ||Copy file đến vị trí khác
        |Delete             ||Thư mục cha của file hiện thời
        |Encrypt            ||
        |Decrypt            ||Mã hóa file hiện tại
        |MoveTo             ||Di chuyển file đến vị trí khác
        |Open               ||Mở file để ghi hoặc đọc(hoàn toàn giống với
        |OpenRead           ||phương thức của lớp File)
        |OpenText           ||
        |OpenWrite          ||

        3.5. Lớp DirectoryInfo:
        - Về cơ bản, DirectoryInfo cũng giống với Directory, Tuy nhiên để
        sử dụng DirectoryInfo ta cũng phải khởi tạo đối tượng như FileInfo.

        3.5.1. Phương thức khởi tạo:
          DirectoryInfo <Tên biến> = new DirectoryInfo(string <Đường dẫn>);

        3.5.2. Các thuộc tính thông dụng
        |Tên thuộc tính    ||Mô tả
        |Attributes        ||Các thuộc tính của thư mục
        |CreationTime      ||Thời điểm tạo thư mục
        |Directory         ||Thư mục cha của thư mục hiện thời
        |Exists            ||Kiểm tra xem thư mục có tồn tại hay không
        |FullName          ||Trả về đường dẫn đầy đủ của thư mục
        |Name              ||Tên thư mục
        |Root              ||Thư mục gốc của thư mục hiện thời 

        3.5.3. Các phương thức thông dụng:
        |Tên phương thức   | Mô tả
        |Create            |Tạo thư mục
        |CreateSubdirectory|Tạo thư mục con
        |Delete            |Xóa , di chuyển thư mục
        |MoveTo            |
        |GetFiles          |Trả về 1 mảng các file nằm trong thư mục này
        |GetDirectories    |Trả về 1 mảng các thư mục con của thư mục này
        
        4. Truy xuất file sử dụng FileStream:
        - Lớp FileStream là lớp cơ bản cho phép truy xuất dữ liệu từ file
        theo kiểu nhị phân. FileStream có hạn chế là chỉ cho phép lập 
        trình viên đọc dữ liệu theo từng byte một, cách đọc này gây khá
        nhiều bất tiện khi ta muốn đọc và ghi các kiểu dữ liệu khác. Bởi 
        vậy, FileStream thường được biến đổi thành các Stream khác để tiện
        sử dụng hơn như StreamReader, StreamWriter, ...
        - Để khởi tạo một Stream, ta có thể dùng các cách sau:
        + Sử dụng phương thức khởi tạo của FileStream
        FileStream fs = new FileStream("test.dat", FileMode.Create);
        + Sử dụng hàm File.Open(), File.OpenRead(), hoặc File.OpenWrite()
        FileStream fs = File.Open("test.dat", FileMode.Create);s
        + Sử dụng hàm Open(), OpenRead() hoặc OpenWrite() của lớp FileInfo
         
        - Các thuộc tính cơ bản của FileStream:
        |Tên thuộc tính ||Mô tả
        |CanRead        ||Kiểm tra xem ta có thể đọc dữ liệu từ stream 
        |               ||được hay không
        |CanWrite       ||Kiểm tra xem ta có thể ghi dữ liệu vào stream 
        |               ||được hay không
        |Length         ||độ dài của stream
        |Position       ||Vị trí của con trỏ trong stream

        - Các phương thức cơ bản của FileStream:
        |Tên phương thức ||    Mô tả
        |Read            ||đọc một khối byte từ file
        |ReadByte        ||đọc 1 byte từ file và dich con trỏ lên 1 vị trí
        |Write           ||Ghi một khối byte lên file
        |WriteByte       ||Ghi một byte lên file
        |Flush           ||Ghi toàn bộ dữ liệu từ bộ đệm lên file
        |Seek            ||Di chuyển con trỏ đến vị trí yêu cầu
        |Close           ||đóng file

        5. Sử dụng StreamReader và StreamWriter:
        - StreamReader và StreamWriter là 2 lớp chuyên dùng để xử lý file
        văn bản của namespace System.IO. Ta có thể sử dụng 2 lớp này bằng
        cách mở trực tiếp file, hoặc biến FileStream hành StreamReader,
        StreamWriter.
        
        5.1 Phương thức khởi tạo:
            5.1.1 Sử dụng tên file làm đối số khởi tạo:
            StreamReader sr = new StreamReader("test.txt");
            StreamWriter sw = new StreamWriter("test.txt");

            + Sử dụng 1 stream khác làm đối số
            FileStream fs = new FileStream("test.dat", FileMode.Create,
            FileAccess.Write);
            StreamReader sr = new StreamReader(fs);

        5.2 Các phương thức, thuộc tính thông dụng:
            5.2.1 StreamReader :
        |Tên phương thức  ||Mô tả
        |ReadLine         ||đọc một dòng từ file
        |ReadToEnd        ||đọc cả file rổi trả về bằng 1 string

        |Tên thuộc tính   ||Mô tả
        |BaseStream       ||Trả về stream gốc ( thường là stream nằm trong
        |                 ||đối số lúc khởi tạo)
        |Encoding         ||Bảng mã của các ký tự trong stream hiện thời
        |EndOfStream      ||Xác định xem đã kết thúc stream chưa

            5.2.2 StreamWriter :
        |Tên phương thức   ||Mô tả
        |Write             ||Ghi một object ra file dưới dạng văn bản 
        |                  ||( hoạt động giống Console.Write)
        |WriteLine         ||Viết dữ liệu ra file rồi xuống dòng
        |Flush             ||Ghi toàn bộ văn bản trong bộ nhớ đệm ra file

        |Tên thuộc tính    ||Mô tả
        |BaseStream        ||Trả về stream gốc ( thường là stream nằm 
        |                  ||trong đối số lúc khởi tạo)
        |Encoding          ||Bảng mã của các ký tự trong stream hiện thời
        |AutoFlush         ||Xác định xem stream có tự động ghi tất cả dữ '
        |                  ||liệu từ bộ đệm vào văn bản hay không 

        6. Sử dụng BinaryReader và BinaryWriter:
        - Hai lớp BinaryReader và BinaryWriter được sử dụng để ghi và đọc 
        dữ liệu dưới dạng nhị phân. Hai lớp trên hiệu quả hơn ở chỗ, nó 
        cho phép lập trình viên ghi và đọc dữ liệu cơ bản từ file.
        
        6.1 Phương thức khởi tạo:
        - Khác với StreamWriter và StreamReader. BinaryReader và 
        BinaryWriter chỉ có 1 phương thức khởi tạo duy nhất, có đối số
        là một Stream khác:
            FileStream fs = new FileStream("vidu.dat",FileMode.Create,
            FileAccess.Read);
            BinaryReader br = new BinaryReader(fs); 

        6.2 Các phương thức thông dụng:
        - BinaryReader: BinaryReader có rất nhiều phương thức để đọc có 
        tên dưới dạng: ReadXXXX().
        - Trong đó XXXX là các kiểu dữ liệu thông dụng như int,float,
        double, …… Ví dụ như:
                br.ReadBoolean();
                br.ReadByte();
                br.ReadString();
                br.ReadInt32();
        BinaryWriter: có một phương thức quan trọng nhất là Write(). Bất 
        kì kiểu dữ liệu cơ bản nào cũng có thể được ghi ra file bằng
        phương thức này. 



         */

    }

    class FileStreamTest
    {
        public static void Test()
        {
            Console.WriteLine("Danh sach cac o dia trong may tinh: ");
            foreach (string iS in Directory.GetLogicalDrives())
            {
                Console.WriteLine("\t" + iS);
            }
            Console.WriteLine(@"Su ton tai cua thu muc C:\Temp: " + Directory.Exists(@"C:\Temp"));
            Console.WriteLine("Danh sach thu muc con cua Temp:");
            foreach (string iS in Directory.GetDirectories(@"C:\Temp"))
            {
                Console.WriteLine("\t" + iS);
            }
            Console.WriteLine("Danh sach cac File trong thu muc Temp:");
            foreach (string iS in Directory.GetFiles(@"C:\Temp"))
            {
                Console.WriteLine("\t" + iS);
                Console.WriteLine("\tThuoc tinh: " + File.GetAttributes(iS));
                Console.WriteLine("\tThoi diem tao: " + File.GetCreationTime(iS));
                Console.WriteLine("\tTThoi diem truy xuat lan cuoi: " + File.GetLastAccessTime(iS));
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    /*Sử dụng lớp FileIfno và FileSystemInfo để duyệt toàn bộ thư mục
     * con và file của thư mục c:\Temp*/
    class DirectoryInfoTest
    {
        public static void TestDirectoryInfo()
        {
            DirectoryInfo Temp = new DirectoryInfo(@"C:\Temp");
            Duyet(Temp, 0);
            Console.ReadLine();
        }
        //Hàm đệ quy lo việc duyệt thư mục con
        public static void Duyet(DirectoryInfo ThuMuc, int depth)
        {
            // Căn lề lại cho dễ nhìn
            for (int i = 0; i < depth - 1; i++)
            {
                Console.Write("| ");
            }
            if (depth > 0)
            {
                Console.Write("+-");
            }
            Console.WriteLine(ThuMuc.Name);
            //Duyệt tất cả thư mục con
            foreach (DirectoryInfo iDI in ThuMuc.GetDirectories())
            {
                Duyet(iDI, depth + 1);
            }
            //In ra thông tin về file
            foreach (FileInfo iFI in ThuMuc.GetFiles())
            {
                for (int i = 0; i < depth; i++)
                {
                    Console.Write("| ");
                }
                Console.Write("+-");
                Console.WriteLine(iFI.Name + " : " + iFI.Length / 1024 + "KB");
            }
        }
    }

    class StreamTest
    {
        public static void TestStream()
        {
            //Mở stream bằng cách thứ 1
            StreamWriter sw = new StreamWriter("vidu.txt");
            sw.WriteLine(123);
            sw.WriteLine("Hello world");
            sw.WriteLine(DateTime.Now);
            sw.Close();
            //Mở stream bằng cách thứ 2
            FileStream fs = new FileStream("vidu.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string NoiDung = sr.ReadToEnd();
            Console.WriteLine(NoiDung);
            sr.Close();
            Console.ReadLine();
        }
    }

    /*đọc & ghi dữ liệu bằng BinaryWriter và BinaryReader*/

    class BinaryTest
    {
        public static void TestBinary()
        {
            FileStream fs = new FileStream("vidu.dat", FileMode.Create,
                FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(187234);
            bw.Write(0.3568);
            bw.Write("Hello world!");
            bw.Close();
            Console.WriteLine("Noi dung cua file vidu.dat khi doc bang " +
                "FileStream:");
            fs = new FileStream("vidu.dat", FileMode.Open,
                FileAccess.Read);
            while (fs.Position < fs.Length)
            {
                Console.Write(fs.ReadByte());
            }
            //Trở về vị trí đầu tiên
            Console.WriteLine();
            fs.Position = 0;
            Console.WriteLine("Noi dung cua file vidu.dat khi doc bang" +
                " BinaryReader:");
            BinaryReader br = new BinaryReader(fs);
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            Console.WriteLine(br.ReadString());
            br.Close();
            Console.ReadLine();
        }
    }

}
