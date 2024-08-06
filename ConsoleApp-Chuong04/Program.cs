namespace ConsoleApp_Chuong04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                1) Nhập vào một số nguyên ở hệ thập phân, chuyển sang hệ nhị phân và in ra màn hình dãy nhị phân
            */
            //Baitap01.ChangeForBinary();
            /*
                2) Lập chương trình tính tiền điện cho khách hàng giá điện tính theo KW như sau:
                |W =w1+w2+w3+w4 | điện tiệu thụ (KW)| Giá (đồng)
                |    w1         |   0-100           |    500 / KW
                |    w2         |   101-150         |    550/ KW
                |    w3         |   151 – 200       |    600 / KW
                |    w4         |   > 200           |    650/ KW
            */
            Baitap02.TinhTienDien();
            /*
                3) Nhập số liệu cho 2 dãy số thực a0 , a1 ,..., am-1 và b0 , b1 ,..., bn-1. Giả sử cả 2 dãy này đã được
                sắp theo thứ tự tăng dần. Hãy tận dụng tính sắp xếp của 2 dãy và tạo dãy c0 , c1 ,..., cm+n-1 là hợp
                của 2 dãy trên, sao cho dãy ci cũng có thứ tự tăng dần . (Gợi ý: So sánh và loại dần từng cặp phần
                tử của 2 dãy).
            */
            //Baitap03.SapxepKethopHaiMang();
            /*
                4) Khi ta soạn thảo văn bản, đôi khi thay vì một dấu cách ta lại gõ liền mấy dấu cách, hoặc gõ thêm
                dấu cách thừa ở hai đầu chuỗi. Giả sử chuỗi ST có chứa một số dấu cách thừa như vậy. Hãy viết
                chương trình để loại bỏ những dấu cách thừa ở trong và hai đầu văn bản. Nghĩa là sau khi chạy
                chương trình thì không còn trường hợp 2 hoặc nhiều dấu cách liền nhau bên trong chuỗi và ở hai
                đầu chuỗi không còn dấu cách nữa, ví dụ chuỗi “ Trần Hưng Đạo “ sẽ được chuyển thành
                “Trần Hưng Đạo“.
            */
            //Baitap04.XoaDauCach();
            /*
                5) Tìm ma trận nghịch đảo của ma trận vuông cấp n bằng phương pháp khử Gauss-Jordan.
            */
            //Baitap05.MaTranNghichDao();
        }
    }
}
