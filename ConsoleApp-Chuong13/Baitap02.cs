using ConsoleApp_Chuong13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap02
{
    /*
     2) . Tạo một lớp Sinhviên gồm: TenSV, TuoiSV và DiemSV và các phương
    thức cần thiết khác. Viêt ứng dụng có dạng menu như sau
    Menu
    --------------------------
    11. Save to File
    12. Read File
    13. Exit
    Your choice: _
    Save to File:
    Nhập vào thông tin của một sinh viên và ghi toàn bộ thông tin đó 
    xuống file sv.txt – mỗi sinh viên ghi trên 1 dòng và khoảng cách 
    giữa các trường của cấu trúc đúng 1 dấu tab
    Read File:
    đọc và hiển thị thông tin của file sv.txt ra màn hình, mỗi dòng là
    thông tin một sinh viên
    Exit: Thoat khỏi chương trình
     */

    public class SinhVien
    {
        public string TenSV { get; set; }
        public int TuoiSV { get; set; }
        public double DiemSV { get; set; }
        public SinhVien(string tenSV, int tuoiSV, double diemSv)
        {
            TenSV = tenSV;
            TuoiSV = tuoiSV;
            DiemSV = diemSv;
        }
        public override string ToString()
        {
            return $"Tên sinh viên: {TenSV}\tTuổi sinh viên: {TuoiSV}\tĐiểm sinh viên: {DiemSV}";
        }
    }

    public class Menu
    {
        public static void MenuStream()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            List<SinhVien> danhsachSinhVien = new List<SinhVien>();
            string filePath = "sv.txt";
            int choice;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("11. Save to File");
                Console.WriteLine("12. Read File");
                Console.WriteLine("13. Exit");
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 11:
                        SaveToFile(filePath);
                        break;
                    case 12:
                        ReadFile(filePath);
                        break;
                    case 13:
                        Console.WriteLine("Thoat khỏi chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
            } while (choice != 13);
        }

        static void SaveToFile(string filePath)
        {
            Console.Write("Nhập tên sinh viên: ");
            string tenSV = Console.ReadLine();
            Console.Write("Nhập tuổi sinh viên: ");
            int tuoiSV = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập điểm sinh viên: ");
            double diemSV = Convert.ToDouble(Console.ReadLine());

            SinhVien sv = new SinhVien(tenSV, tuoiSV, diemSV);

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(filePath, true);
                writer.WriteLine(sv.ToString());
            }
            finally
            {
                if (writer != null)
                {
                    //Đảm bảo StreamWriter được đóng lại sau khi sử dụng
                    writer.Close();
                }
            }

            Console.WriteLine("Đã ghi thông tin sinh viên vào file.");
        }

        static void ReadFile(string filePath)
        {
            StreamReader reader = null;
            try
            {
                if (File.Exists(filePath))
                {
                    reader = new StreamReader(filePath);
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("File không tồn tại.");
                }
            }
            finally
            {
                if(reader != null)
                {
                    //Đảm bảo StreamReader được đóng lại sau khi sử dụng
                    reader.Close();
                }
            }
        }
    }
}
