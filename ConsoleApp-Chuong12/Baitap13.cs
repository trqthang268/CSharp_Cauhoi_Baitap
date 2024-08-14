using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap13
{
    //Khai báo delegate và event
    public delegate void ClockHandle(object sender, EventArgs e);
    public class DigitalClock
    {
        public event ClockHandle Handle;
        public void Start()
        {
            while (true)
            {
                //Phát sinh sự kiện mỗi giây
                OnTick();
                Thread.Sleep(1000); //Dừng 1 giây
            }
        }

        public virtual void OnTick()
        {
            if (Handle != null)
            {
                Handle(this, EventArgs.Empty);
            }
        }
    }

    //Tạo lớp hiển thị thời gian
    public class DisplayClock
    {
        public void Subscribe(DigitalClock clock)
        {
            clock.Handle += ShowTime;
        }

        private void ShowTime(object sender, EventArgs e)
        {
            Console.Clear();
            Console.WriteLine("Thời gian hiện tại : "+ DateTime.Now.ToString("HH:mm:ss"));
        }
    }

    // chương trình chính để khởi động đồng hồ
    class Program
    {
        public static void Test()
        {
            DigitalClock clock = new DigitalClock();
            DisplayClock displayClock = new DisplayClock();
            
            //Đăng ký sự kiện
            displayClock.Subscribe(clock);

            //Bắt đầu đồng hồ
            clock.Start();
        }
    }
}
