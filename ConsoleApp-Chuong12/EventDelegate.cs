using EventAndDelegateDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong12
{
    internal class EventDelegate
    {
        /*
        1. Delegate :
        - Delegate là cầu nối trung gian giữa sự kiện và phương thức xử lí sự
        kiện(method handling).
        - Delegate sẽ chứa một danh sách các phương thức sẽ được gọi khi sự 
        kiện xảy ra. Nó đóng vai trò như là hàm callback(gọi xong hàm này, 
        quay lại gọi hàm tiếp theo).
        - Một delegate có thể tham chiếu đến nhiều phương thức và các phương 
        thức lần lượt được gọi để thực thi, tức là các phương thức được thực
        hiện một cách tuần tự.
        - Nếu có 1 phương thức nào đó chạy và bị treo hoặc chiếm nhiều thời 
        gian của tiến trình khi đó các phương thức khác sẽ không đc thực thi
        - .NET đã có cơ chế để cho các phương thức được thực thi một cách bất
        tuần tự (asynchronous), phương thức gọi và phương thức được gọi chạy
        trên các luồng độc lập nhau.

        1.1. Khai báo và sử dụng một delegate
        - Cú pháp: 
        [modifiers]delegate<kiểu dữ liệu trả về>tên biến([các tham số nếu có]);
        vd: public delegate int Pheptoan(int so1, int so2);
        - Sử dụng:
         + Để thực hiện gắn một delegate với một phương thức cụ thể, ta phải
        sử dụng từ khóa new để khởi tạo 1 đối tượng thuộc lớp đã khai báo ở
        trên với tham số là tên phương thức được tham chiếu đến.
         + Phương thức được tham chiếu đến phải có khai báo kiểu dữ liệu trả 
        về và tham số tương thích với khai báo delegate.
        - Thực thi một delegate:
         + Để thực thi một delegate, ta chỉ cần gọi tên object cùng với các 
        tham số thực tế giống như cách gọi một hàm thông thường.

        1.2. Multicasting :
        - Một delegate có thể tham chiếu đến nhiều phương thức bằng cách sử 
        dụng toán tử cộng như các phép toán bình thường.
        - Điều này chỉ có thể được thực hiện với các delegate có kiểu trả về 
        là void 
        - Một hàm cũng có thể được loại bớt ra khỏi multicast delegate bằng 
        cách sử dụng toán tử trừ.

        1.3. Anonymous method :
        - Ta không chỉ có thể gắn delegate với một hàm cụ thể được khai báo
        từ trước mà còn có thể gắn chúng với các phương thức được khai báo tại
        thời điểm khởi tạo delegate. Cú pháp cho cách sử dụng này là:
                <tên biến delegate> = delegate([tên các tham số tương ứng])
                {
                    <Các dòng lệnh trong hàm>;
                };

        2. Event:
        - Mỗi event tương ứng với mỗi hành động được gây nên bởi người dùng
        hoặc các đối tượng khác trong chương trình. Khi đó, mỗi event khi 
        được tạo ra sẽ là sự kết hợp giữa : Mô tả hành động gây ra event và 
        Hành động phản ứng tương ứng của chương trình.
        - Mỗi tình huống - Event sẽ được ủy thác - delegate cho các phương 
        thức trong chương trình lo việc đáp ứng lại sự kiện đó.

        2.1. Khai báo một event:
        - Để khai báo một sự kiện có thể xảy ra trong chương trình, ta sử 
        dụng cú pháp :
            [Modifier] event <Tên delegate> <Tên sự kiện>
        - trong đó : + <Tên delegate> là tên của delegate lo việc xử lý sự 
        kiện, delegate này buộc phải có kiểu trả về là void
        - Ví dụ:
        public delegate void BamPhimAoHandler(BanPhimAo sender, char Phim);
        public event BamPhimAoHandler GoPhim;

        2.2. Đăng kí xử lí sự kiện bằng delegate :
        - Để đăng kí 1 hàm xử lí một sự kiện, ta thực hiện giống như khai
        báo và gắn một delegate. Sử dụng từ khóa new và gán một delegate vào 
        event khi muốn đăng kí xử lý sự kiện, dùng toán tử '+' khi muốn để 
        nhiều delegate cùng xử lí một sự kiện.
        - Ví dụ:
            obj.GoPhim += new BamPhimAoHandler(HienThi);

        2.3. Phát sinh một sự kiện :
        - Để phát sinh một sự kiện mới cho chương trình xử lý, ta sử dụng cú
        pháp :
            <Tên sự kiện>([các tham số thực tế])
        - Ví dụ:
            GoPhim(this,(char)temp);

        2.4. Gỡ bỏ việc đăng kí:
        - Để gỡ bỏ việc đăng kí xử lý sự kiện, ta chỉ việc sử dụng toán tử 
        trừ, như việc gỡ bỏ multicast của delegate.
        - Ví dụ:
            GoPhim -= new BanPhimAoHandler(HienThi);


         */


    }
    public class ViduDelegate
    {
        public delegate int PhepToan(int so1, int so2);
        //khai bao phương thức
        public static int PhepCong(int so1, int so2)
        {
            return so1 + so2;
        }
        public void Thuchienpheptinh()
        {
            //gắn delegate với phương thức
            PhepToan pheptinh = new PhepToan(PhepCong);
            int ketqua = pheptinh(4, 5);
            Console.WriteLine("ket qua = " + ketqua);
        }

    }
}

namespace EventAndDelegateDemo
{
    public delegate void HanhDong(Nguoi DoiTuong);
    public delegate void BieuDien();
    public class Nguoi
    {
        public string Ten;
        public Nguoi(string pTen)
        {
            Ten = pTen;
        }
        public void Chao(Nguoi DoiTuong)
        {
            Console.WriteLine(Ten + " noi: Xin chao " + DoiTuong.Ten);
        }
        public void Hat()
        {
            Console.WriteLine(Ten + " hat: La la la");
        }
    }
    class DelegateTest
    {
        public static void Test()
        {
            Nguoi SinhVienA = new Nguoi("Hai");
            Nguoi SinhVienB = new Nguoi("Dung");
            Nguoi SinhVienC = new Nguoi("Duong");
            HanhDong AChao = new HanhDong(SinhVienA.Chao);
            HanhDong BChao = new HanhDong(SinhVienB.Chao);
            Console.WriteLine("Su dung delegate de goi ham:");
            AChao(SinhVienC);
            Console.WriteLine();
            Console.WriteLine("Su dung multicast de goi nhieu ham mot luc:");
            HanhDong AVaBChao = AChao + BChao;
            AVaBChao(SinhVienC);
            Console.WriteLine();
            Console.WriteLine("Su dung toan tu tru voi delegate:");
            AVaBChao -= AChao;
            AVaBChao(SinhVienC);
            Console.WriteLine();
            Console.WriteLine("Su dung multicast de goi nhieu lan mot ham");
            BieuDien DongCa = new BieuDien(SinhVienA.Hat);
            DongCa += new BieuDien(SinhVienB.Hat);
            DongCa += new BieuDien(SinhVienC.Hat);
            // Ta hoàn toàn có thể gọi một hàm nhiều lần với multicasting
            DongCa += new BieuDien(SinhVienA.Hat);
            DongCa();
            Console.ReadLine();

            //Ví dụ Anonymous method :
            HanhDong HanhDongMoi = delegate (Nguoi DoiTuong)
            {
                Console.WriteLine("Ai do lay cap vi cua " + DoiTuong.Ten);
            };
            HanhDongMoi(SinhVienA);
        }
    }
}

namespace EventAndDelegateDemo
{
    // Khai báo delegate xử lý sự kiện gõ phím
    // Delegate này có 2 tham số, sender là đối tượng đã phát sinh event,
    // Phim là kí tự đã được BanPhimAo thay đổi
    public delegate void BamPhimAoHandler(BanPhimAo sender, char Phim);
    // BanPhimAo sẽ lọc và thay đổi các phím mà người dùng nhập vào
    public class BanPhimAo
    {
        //Khai báo event
        public event BamPhimAoHandler GoPhim;
        //Lưu trữ chuỗi các kí tự gốc, chưa bị lọc, thay đổi bởi bàn phím ảo
        public string ChuoiGoc = "";
        public void Run()
        {
            //Liên tục kiểm tra phím nhập vào
            while (true)
            {
                char ch = Console.ReadKey().KeyChar;
                ChuoiGoc += ch;
                Console.WriteLine();
                Console.WriteLine("Ban go: " + ch);
                //Chỉ cho phép các kí tự chữ qua BanPhimAo
                if (char.IsLetter(ch))
                {
                    //Kiểm tra xem đã có ai đăng kí xử lý sự kiện chưa
                    if (GoPhim != null)
                    {
                        //Biến đổi phím được gõ
                        int temp = ch + 1;
                        //Phát sinh sự kiên gõ phím với một phím mới
                        GoPhim(this, (char)temp);
                    }
                }
            }
        }
    }
    class Program2
    {
        //Biến đếm kiểm tra số lượng kí tự đã nhập
        public static int count = 0;
        //Chuỗi kết quả sau khi qua sự biến đổi của bàn phím ảo
        public static string ChuoiKetQua = "";
        //Hàm lo xử lý việc gõ phím của người dùng
        public static void HienThi(BanPhimAo sender, char ch)
        {
            //Hiển thị phím ấy lên màn hình
            Console.WriteLine("Hien len man hinh: " + ch);
            ChuoiKetQua += ch;
            count++;
            //Kiểm tra xem người dùng đã nhập được 5 phím (trên bàn phím ảo) chưa
            //Nếu đủ 5 phím, chương trình sẽ dừng việc nhận xử lý sự kiện GoPhim
            if (count > 5)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Chuoi goc:" + sender.ChuoiGoc);
                Console.WriteLine("Sau khi ma hoa:" + ChuoiKetQua);
                Console.WriteLine("-----------------");
                //Gõ bỏ việc đăng kí xử lý sự kiện GoPhim của bàn phím ảo
                Console.WriteLine("Go bo viec dang ki xu ly su kien GoPhim");
                sender.GoPhim -= new BamPhimAoHandler(HienThi);
            }
        }
        //Chương trình chính
        public static void MainTest()
        {
            //Tạo một bàn phím ảo mới
            BanPhimAo obj = new BanPhimAo();
            Console.WriteLine("Da dang ki xu li su kien GoPhim bang ham HienThi:");
            //ðăng kí xử lý sự kiện hiển thị
            obj.GoPhim += new BamPhimAoHandler(HienThi);
            //Bắt đầu việc lọc và thay đổi phím
            obj.Run();
        }
    }
}