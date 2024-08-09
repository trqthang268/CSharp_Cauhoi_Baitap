using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Play = Sony.Player.DvdPlayer;
//using Play = Sony.Players.DvdPlayer;

namespace ConsoleApp_Chuong09
{
    internal class Baitap02
    {
        /**
         * 2) Tìm và sửa lỗi đoạn code sau :
         * - Lỗi DvdPlayer được khai báo với dấu ngoặc tròn () trong tên lớp
         * - Namespace Player trong Samsung không có lớp DvdPlayer
         * - Alias Play không khớp với namespace Sony.Players.DvdPlayer . Do 
         * DvdPlayer nằm trong namespace Sony.Player
         */
    }
}
namespace Sony
{
    namespace Player
    {
        class CdPlayer
        {
            public CdPlayer()
            {
                Console.WriteLine("CD-R as well as CD-RW are available");
            }
        }
        //class DvdPlayer()
        class DvdPlayer
        {
            public DvdPlayer()
            {
                Console.WriteLine("DVD-R as well as DVD-RW are available");
            }
        }
    }
}
namespace Samsung
{
    class Player
    {
        public static void Test()
        {
            //Play.DvdPlayer objPlayer = new Player.DvdPlayer();
            Play objPlayer = new Play();
        }
    }
}