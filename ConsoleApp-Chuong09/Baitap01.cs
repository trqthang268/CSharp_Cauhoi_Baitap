using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong09
{
    internal class Baitap01
    {
        /**
         * 1) Sửa lỗi đoạn code sau:
         * - Đoạn mã trên có một lỗi liên quan đến việc truy cập lớp lồng nhau
         * Trong namespace Sony , lớp Player là một lớp lồng bên trong lớp 
         * Laptops. 
         * - Đoạn code hiện tại không tạo ra bất kỳ đối tượng nào từ lớp Player.
         * - Sửa bằng cách tạo 1 đối tượng của lớp 
         */
    }
}

namespace Sony
{
    class Laptops
    {
        public Laptops()
        {
            Console.WriteLine("Manufactures Laptops of different configurations");
        }

        // Lớp Player lồng bên trong lớp Laptops
        public class Player
        {
            public Player()
            {
                Console.WriteLine("CD as well as DVD players are manufactured");
            }
        }
    }
}
namespace Dell
{
    class Laptops
    {
        //static void Main(string[] args)
        public static void Test()
        {
            // Tạo đối tượng từ lớp Laptops trong không gian tên Sony
            Sony.Laptops objSonyLaptop = new Sony.Laptops();

            // Tạo đối tượng từ lớp Player lồng bên trong lớp Laptops của Sony 
            Sony.Laptops.Player objSonyPlayer = new Sony.Laptops.Player();
        }
    }
}
