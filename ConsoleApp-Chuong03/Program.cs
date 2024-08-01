namespace ConsoleApp_Chuong03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 1) So sánh vòng lặp do và while
                + Vòng lặp while sẽ kiểm tra điều kiện trước khi thực hiện câu lệnh.
                Nếu sai điều kiện thực hiện ngay từ đầu thì câu lệnh sẽ không được thực 
                hiện 1 lần nào
                + Vòng lặp do while sẽ thực hiện câu lệnh (nhóm lệnh) trước rồi sau đó 
                kiểm tra điều kiện, nên là câu lệnh sẽ được thực hiện ít nhất 1 lần. 
             */
            /*
            2) Viết chương trình nhập các hệ số thực ai, i = 0, 1, 2,..., n và số thực x rồi tính giá trị của ña thức
               P(x)=anx^n + an-1x^^n-1 + ... + a1x+ a0
               Theo cách tính của Horner ñể ñạt ñược tốc ñộ tính nhanh:
               i. P(x)=((((anx+ an-1)x+ an-2... + a1)x+ a0
            */
            Baitap.Baitap2();

            /*
                3) Nhập một số tự nhiên n. Hãy liệt kê các số nguyên tố không lớn hơn n. 
             */
            Baitap3.TimSoNT();

            /*
             4) Nhập một số c>0 (ví dụ c = 0.0001) rồi dùng lệnh while để tính số π theo công thức:
                π = 4(1 - 1/3 + 1/5 - 1/7 +...+(-1)^n *1/(2n+1) )
            tổng ñược tính với n ñủ lớn sao cho bất ñẳng thức 1/(2n+1) ≤ c thỏa mãn.
             */
            Baitap4.CaculatePi();

            /*
             5) Nhập một số c>0 (ví dụ c = 0.0001) rồi dùng lệnh for để tính số π theo công thức:
                π = 4(1 - 1/3 + 1/5 - 1/7 +...+(-1)^n *1/(2n+1) )
            tổng ñược tính với n ñủ lớn sao cho bất ñẳng thức 1/(2n+1) ≤ c thỏa mãn.
             */
            Baitap4.CaculatePiByFor();

            /*
             6) Nhập một số c>0 (ví dụ c = 0.0001) và một số thực x rồi tính
            e^x = 1 + x/1! + x^2/2! + ... + x^n/n!
            
            tổng được tính với n đủ lớn sao cho bất đẳng thức |x^n/n!| <= c thỏa mãn
             */
            Baitap6.CalculateExponential();
        }
    }
}
