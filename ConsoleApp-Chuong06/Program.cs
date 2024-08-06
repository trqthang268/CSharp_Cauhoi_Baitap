namespace ConsoleApp_Chuong06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 1) Xây dựng các lớp đối tượng hình học như: điểm, đoạn thẳng,
             * đường tròn, hình chữ nhật, hình vuông, tam giác, hình bình hành,
             * hình thoi. Mỗi lớp có các thuộc tính riêng để xác định được
             * hình vẽ biểu diễn của nó như đoạn thẳng thì có điểm đầu, điểm
             * cuối.... 
             */
            Baitap01.Test();

            /**
             * 2) Mỗi lớp thực thi một phương thức Draw() ghi đè(overriding) 
             * phương thức Draw() của lớp cơ sở gốc của các hình mà nó dẫn xuất.
             * Hãy xây dựng lớp cơ sở của các lớp trên và thực thi đa hình với
             * phương thức Draw(), sau đó tạo lớp Tester cùng với hàm Main() 
             * để thử nghiệm.
             */
            Baitap02.Tester();
        }
    }
}
