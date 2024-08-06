using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong04
{
    internal class Baitap02
    {
        public static void TinhTienDien()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập tổng số tiền điện tiêu thụ (KW): ");
            int tongSoDien = int.Parse(Console.ReadLine());

            int tongTien = 0;
            //tinh theo từng mức đã cho 
            if (tongSoDien < 0)
            {
                Console.WriteLine("Số điện không được là số âm!");
                return;
            }
            //Các giới hạn của từng mức tiêu thụ điện
            int[] gioihan = { 100, 50, 50 };
            //Các giá trị tương ứng tiêu thụ điện
            int[] giatri = { 500, 550, 600, 650 };

            for (int i = 0; i < gioihan.Length && tongSoDien >0; i++)
            {
                int dientieuthu = Math.Min(tongSoDien, gioihan[i]);
                tongTien += dientieuthu * giatri[i];
                tongSoDien -= dientieuthu;
            }

            //Tính chi phí cho phần điện tiêu thụ còn lại nếu vượt quá các giới hạn đã cho
            if (tongSoDien > 0)
            {
                tongTien += tongSoDien * giatri[gioihan.Length];
            }

            Console.WriteLine("Tông số tiền điện phải trả là : " + tongTien + " đồng");
        }


    }
}
