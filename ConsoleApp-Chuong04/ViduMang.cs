using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong04
{
    internal class ViduMang
    {
        /*
         1.Mảng
        - Mảng là 1 kiểu dữ liệu, dùng để chứa các phần tử có cùng kiểu dữ liệu
        - Mảng là kiểu dữ liệu thuộc nhóm kiểu dữ liệu tham chiếu (reference type). 
        - Mảng được phân loại thành mảng một chiều và mảng nhiều chiều.

        2. Mảng một chiều
        syntax :  <Kiểu dữ liệu> []<tên mảng> = new <kiểu dữ liệu>[Kích thước];
        giá trị mặc định của các kiểu dữ liệu sau khi khai báo trong bảng:
        - int : 0
        - float : 0.0
        - double : 0.0
        - char : "\0"
        - string : Null
        Các phần tử trong mảng được đánh chỉ số từ 0 và được truy xuất thông qua chỉ 
        số mảng . Thuộc tính length trả về kích thước của mảng(phần tử đối đa có thể
        chứa)

        3.Mảng nhiều chiều
        Có 2 loại :
            + Rectangular Array
            + Jagged Array
        Rectangular Array: là mảng nhiều chiều có kích thước của mỗi chiều phải
        là hằng số
        Jagged Array: là mảng nhiều chiều trong đó kích thước của một chiều có 
        thể thay đổi(mảng của các mảng)

        Khai báo mảng nhièu chiều:
            Kiểu Rectangular : DataType[,] arrayName = new DataType[size1,size2];
                            vd: int[] marks = new int [4,5];
            Kiểu jagged : DataType[][] arrayName = new DataType[size][];
                        vd: string[][] a = new string[3][];

        4.Câu lệnh foreach
        -câu lệnh foreach dùng để duyệt các phần tử bên trong một tập hợp. cụ 
        thể câu lệnh foreach thường được dùng để duyệt các phần tử bên trong một
        mảng, các đối tượng bên trong 1 tập hợp.
        
        -Cú pháp : foreach(<kiểu dữ liệu> <tên biến> in <tập hợp>) { câu lệnh };

        5. Lớp Random
        - Lớp Random dùng để sinh ra một số ngẫu nhiên
        - Cú pháp để tạo ra một đối tượng thuộc lớp Random là : 
                Random rdObj1 = new Random();
        - Các phương thức và chức năng của Random:
            + Next : Dùng để sinh ra số ngẫu nhiên lớn hơn không
            + Next(int n) : Sinh ra số ngẫu nhiên lớn hơn 0 và nhỏ hơn n
            + NextBytes : Sinh ra một mảng, một phần tử trong mảng là số kiểu 
            byte ngẫu nhiên
            +NextDouble : Sinh ra một số ngẫu nhiên lớn hơn 0 và nhỏ hơn 1
            +Next(min, max) : Sinh ra một số ngẫu nhiên trong khoảng min và max

        6. Kí tự và chuỗi kí tự
            6.1 . Kí tự
            - Kiểu dữ liệu char dùng để biểu diễn một kí tự dưới dạng mã Unicode
            -- Ví du:
                + char char1 = 'Z'; // gán hằng kí tự cho biến kiểu char
                + char char2 = '\x0058'; // gán giá trị hệ hexa
                + char char3 = (char)88; // ép về kiểu char từ kiểu integer
                + char char4 = '\u0058'; // gán mã Unicode

            - Cấu trúc (struct) Char gồm các phương thức để thao tao với biến kiểu char
            || Phương thức   ||  Chức năng
            || IsDigit()     ||  Kiểm tra xem kí tự có phải là kí số hay không
            || IsLetter()    ||  Kiểm tra xem kí tự có phải là kí tự aphabetic
            || ToLower()     ||  Chuyển thành kí tự thường
            || ToUpper()     ||  Chuyển thành kí tự hoa
            || IsWhiteSpace  ||  Kiểm tra xem có phải là kí tự cách không
         
            6.2. Chuỗi kí tự
            - Chuỗi kí tự dùng để biểu diễn một chuỗi  các kí tự unicode. Cú pháp
            để khai báo một biến kiểu string : string s1;
            - Các kí tự trong chuỗi được đánh chỉ số từ 0 và đc truy xuất thông qua 
            chỉ số. Cấu trúc(struct) String có các thuộc tính và phương thức để thao 
            tác với chuỗi kí tự. Thuộc tính Length: trả về chiều dài một chuỗi.

| Phương thức                 || Chức năng
| ToLower()                   || Chuyển về chuỗi kí tự thường
| ToUpper()                   || Chuyển về chuỗi kí tự hoa
| Substring()                 || Cắt 1 chuỗi con từ chuỗi mẹ
| CompareTo()                 || So sánh 2 chuỗi.
|                             || - s1.CompareTo(s2)
|                             || + Trả về 0 nếu chuỗi s1 bằng chuỗi s2
|                             || + Trả về số nguyên >0 nếu s1 lớn hơn s2
|                             || + Trả về số nguyên <0 nếu s1 nhỏ hơn s2
| Remove(int i)               || Xóa các kí tự từ chỉ số i ñến cuối chuỗi
| Remove(int i, int j)        || Xóa các kí tự từ chí số i ñến chỉ số j
| Contains()                  || S1.Contains(S2) kiểm tra xem chuỗi S2
|                             || có nằm trong chuỗi S1 không
| Replace(oldString,newString)|| Thay thế một chuỗi bằng một chuỗi khác.
| IndexOf(Char ch)            || Trả về chỉ số của một kí tự trong chuỗi
| LastIndexOf(Char ch)        || Trả về chỉ số của kí tự ch cuối cùng trong chuỗi
         

        7. Lớp Array
        - Array là lớp cung cấp các phương thức để thao tác với mảng.
        - Thuộc tính Length : trả về số phần tử tối đa mà mảng có thể chứa
        - Rank : trả về số chiều của mảng

    | Phương thức    || Chức năng
    | CreateInstance || Tạo ra một mảng
    | Sort           || Sắp xếp các phần tử trongmảng theo thứ tự tăng dần
    | Find           || Tìm một phần tử trong mảng thỏa mãn ñiều kiện
    | FindAll        || Tìm tất cả các phần tử trong mảng thỏa mãn ñiều kiện
    | BinarySearch   || Tìm kiếm nhị phân trên mảng 1 chiều ñã sắp xếp
    | Copy           || Dùng ñể copy các phần tử từ mảng này sang mảng khác


         */


        //Ví dụ tìm số lớn nhất và nhỏ nhất trong mảng
        /*
         * Nhap vao mot mang gom N so nguyen
         * Tim so lon nhat va nho nhat trong day so do
         *
         * */
        public static void timMinMax()
        {
            int n, min, max;
            // Nhập số phần tử trong mảng
            Console.Write("-So phan tu trong mang n =");
            n = Convert.ToInt32(Console.ReadLine());
            //khai bao va khoi tao mang
            int[] a = new int[n];
            //nhap cac phan tu vao trong mang
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("-Nhap phan tu thu {0:D}:", i + 1);
                a[i]= Convert.ToInt32(Console.ReadLine());
            }
            //in ra cac phan tu trong mang
            Console.WriteLine("+Cac phan tu trong mang la:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0,3:D}", a[i]);
            }
            //tim max, min
            max = a[0];
            min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]>max)
                {
                    max = a[i];
                }
                if(a[i]<min)
                    min = a[i];
            }
            Console.WriteLine("\n + Phan tu lon nhat la: " + max);
            Console.WriteLine("\n + Phan tu nho nhat la: " + min);

        }

        //sap xep cac phan tu trong mang
        public static void sortArray()
        {
            int n;
            // nhap so phan tu trong mang
            Console.Write("- So phan tu trong mang n=");
            n= Convert.ToInt32(Console.ReadLine());
            //khai bao va khoi tao mang
            int[] a = new int[n];
            //nhap cac phan tu vao trong mang
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" - Nhap phan tu thu {0:D}:", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            //in ra cac phan tu trong mang
            Console.WriteLine(" Mang truoc khi sap xep");
            for (int i = 0; i < n; i++)
                Console.Write("{0,3:D}", a[i]);
            //sap xep mang
            for (int i = 0; i < a.Length - 1; i++)
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            //in ra cac phan tu trong mang
            Console.WriteLine("\n Mang sau khi sap xep");
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0,3:D}", a[i]);
            Console.WriteLine();
        }

        //Ví dụ 1: Nhập mảng 2 chiều và tìm phần tử lớn nhất, nhỏ nhất trên mỗi dòng
        public static void timMinMaxMang2chieu()
        {
            int n, m;
            int i, j, k, max, min;
            //nhap so dong
            Console.Write("Nhap vao so dong n=");
            n = Convert.ToInt32(Console.ReadLine());
            //nhap vao so cot
            Console.Write("Nhap vao so dong m=");
            m = Convert.ToInt32(Console.ReadLine());
            //khai bao va khoi tao mang
            int[,] a = new int[n, m];
            //nhap vao mang 2 chieu
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                {
                    Console.Write("Nhap vao phan tu a[{0}][{1}]=", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            // in ra mang 2 chieu
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write("{0,3:D}", a[i, j]);
                Console.WriteLine();
            }
            for (i = 0; i < n; i++)
            {
                //gan max va min
                max = a[i, 0];
                min = a[i, 0];
                //tim phan tu lon nhat, nho nhat tren moi dong
                for (j = 1; j < m; j++)
                {
                    if (a[i, j] > max)
                        max = a[i, j];
                    if (a[i, j] < min)
                        min = a[i, j];
                }
                //in ra gia tri lon nhat, nho nhat tren moi dong
                Console.WriteLine("+ Dong thu {0},gia tri lon nhat:{1}", i + 1, max);
                Console.WriteLine("+ Dong thu {0},gia tri nho nhat:{1}", i + 1, min);
            }
        }

        //Ví dụ : Dùng foreach để duyệt các phần tử trong một mảng 
        public static void foreachDemo()
        {
            int[] fibarray = new int[] { 0, 1, 2, 3, 5, 8, 13 };
            foreach (int i in fibarray)
            {
                System.Console.Write("{0,3:D}", i);
            }
            Console.WriteLine();
        }

        //Ví dụ : Duyệt mảng các chuỗi
        public static void foreachChuoi()
        {
            string[] info = { "Name: Barak Obama", "Title: Mr.", "Age: 47", "Cu tru: NewYork", "Gioi tinh: F"};
            Console.WriteLine("Thong tin chi tiet:");
            Console.WriteLine("----------------");
            foreach (string s in info)
                Console.WriteLine(s);
        }

        //Ví dụ : Sinh ra số ngẫu nhiên
        public static void RandomDemo()
        {
            const int MAX = 10;
            int[] a = new int[MAX];
            Random rd = new Random();
            //sinh ra mot mang cac so ngau nhien tu 0 den 100
            for (int i = 0; i < MAX; i++)
                a[i] = rd.Next(0, 100);
            //in ra mang
            for (int i = 0; i < MAX; i++)
                Console.WriteLine("{0,3:D}", a[i]);
        }

        //Ví dụ : Sinh ra một chuỗi gồm 10 kí tự ngẫn nhiên
        public static void RandomDemo2()
        {
            Random rd = new Random();
            string s = null;
            //sinh ra mot chuoi gom 10 ki tu ngau nhien
            for (int i = 0; i < 10; i++)
                s = s + (char)(97 + (122 - 97) * rd.NextDouble());
            //in chuoi ki tu ngau nhien
            Console.Write("\n Chuoi 10 ki tu ngau nhien:" + s);
            Console.WriteLine();
        }

        //Ví dụ :Sinh ra chuỗi kí tự ngẫu nhiên (kí tự thường hoặc hoa)với chiều dài tùy ý
        public static void RandomDemo3()
        {
            ViduMang obj = new ViduMang();
            String str = obj.RandomString(7, false);
            Console.Write("Chuoi ki tu ngau nhien:" + str);
            Console.ReadLine();
        }
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        //Ví dụ : Sinh ra kí tự ngẫu nhiên gồm cả kí tự số và kí số
        public static void RandomDemo4()
        {
            ViduMang obj = new ViduMang();
            //Sinh ra chuoi ki tu password ngau nhien
            String str = obj.GetPassword();
            Console.Write("Chuoi ki tu mat khau:" + str);
            Console.ReadLine();
        }
        //sinh ra so ngau nhien trong khoang
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }        
        //sinh ra chuoi co ca ki tu va ki so
        public string GetPassword()
        {
            StringBuilder builder = new StringBuilder();
            //sinh ra 4 ki tu ngau nhien
            builder.Append(RandomString(4, true));
            //sinh ra so ngau nhien trong khoang
            builder.Append(RandomNumber(1000, 9999));
            //sinh ra 2 ki tu hoa ngau nhien
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }

        //Ví dụ : Kiểm tra kí số
        public static void IsDigitSample()
        {
            char ch = '8';
            Console.WriteLine(Char.IsDigit(ch));
            Console.WriteLine(Char.IsDigit("sample string", 7));
        }

        //Ví du : Cắt lấy tên file trong ñường dẫn
        public static void CutFileName()
        {
            string s = @"D:\AI\C#\Slides\Bai10.ppt";
            //cat lay ten file trong duong dan tren
            string fileName = s.Substring(s.LastIndexOf('\\') + 1);
            Console.Write("Ten file:" + fileName);
            Console.ReadLine();
        }

        //Ví dụ  : Xóa kí tự trong chuỗi
        public static void CharDelete()
        {
            string s = "abc---def";
            Console.WriteLine("Index: 012345678");
            Console.WriteLine("1) {0}", s);
            Console.WriteLine("2) {0}", s.Remove(3));
            Console.WriteLine("3) {0}", s.Remove(3, 3));
        }

        //Ví du : Tách họ và tên
        public static void RemoveTest()
        {
            string name = "Pham Huu Tung";
            Console.WriteLine("Ho ten day du: '{0}'", name);
            string ho = name.Substring(0, name.LastIndexOf(' '));
            string ten = name.Substring(name.LastIndexOf(' '));
            Console.WriteLine("Ho:" + ho);
            Console.WriteLine("Ten:" + ten);
        }

        //Ví dụ : Sắp xếp các chuỗi
        public static void SortString()
        {
            int n, i, j;
            Console.Write("Nhap vao so chuoi n=");
            n = Convert.ToInt32(Console.ReadLine());
            string[] ds = new string[n];
            //nhap ten sinh vien
            for (i = 0; i < n; i++)
            {
                Console.Write("Nhap ten sv thu {0}:", i + 1);
                ds[i] = Console.ReadLine();
            }
            //truoc khi sap xep
            Console.WriteLine("\n Danh sach truoc khi sap xep:");
            foreach (string s in ds)
                Console.WriteLine(s);
            //sap xep cac ten theo thu tu abc
            for (i = 0; i < ds.Length - 1; i++)
            {
                for (j = i + 1; j < ds.Length; j++)
                    if (ds[i].CompareTo(ds[j]) > 0)
                    {
                        string temp = ds[i];
                        ds[i] = ds[j];
                        ds[j] = temp;
                    }
            }
            Console.WriteLine("\n Danh sach sau khi sap xep:");
            foreach (string s in ds)
                Console.WriteLine(s);
        }

       // Ví dụ : Sắp xếp mảng tăng dần và giảm dần
       public static void ArraySort()
        {
            int n, i;
            //nhap so phan tu mang
            Console.WriteLine("Nhap so phan tu trong mang n=");
            n = Convert.ToInt32(Console.ReadLine());
            //khai bao va khoi tao mang
            int[] a = new int[n];
            //nhap cac phan tu vao mang
            for (i = 0; i < n; i++)
            {
                Console.Write("+ Nhap phan tu thu a[{0}]=", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n Mang truoc khi sap xep:");
            foreach (int x in a)
                Console.Write("{0,3:D}", x);
            //sap xep mang tang dan
            Array.Sort(a);
            Console.WriteLine("\n Mang sau khi sap xep tang dan:");
            foreach (int x in a)
                Console.Write("{0,3:D}", x);
            //dao nguoc de duoc mang giam dan
            Array.Reverse(a);
            Console.WriteLine("\n Mang sau khi sap xep giam dan:");
            foreach (int x in a)
                Console.Write("{0,3:D}", x);
            Console.ReadLine();

        }
    }
}
