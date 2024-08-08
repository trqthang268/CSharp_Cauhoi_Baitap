using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong08
{
    internal class Baitap02
    {
        /*2) Hãy tìm và sửa lỗi đoạn code sau:
         * - Lỗi trong getter của property "BalanceAmount". getter đang trả về
         * "value" giá trị không hợp lệ, sửa bằng cách trả về "_balanceAmount"
         */
    }
    class Balance
    {
        private double _balanceAmount;
        public double BalanceAmount
        {
            get
            {
                //return value;
                return _balanceAmount;
            }
            set
            {
                _balanceAmount = value;
            }
        }
        public static void Test()
        {
            Balance objBal = new Balance();
            objBal.BalanceAmount = 1005.50;
            Console.WriteLine(objBal.BalanceAmount);
        }
    }
}
