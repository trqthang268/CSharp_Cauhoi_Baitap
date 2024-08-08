using ConsoleApp_Chuong08;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong08
{
    internal class Baitap01
    {
        /*
         * 1) đoạn code sau có lỗi, hãy tìm và sửa lỗi
         * - Cú pháp get và set sai : thừa dấu "()" dẫn đến sai cú pháp
         * - Biến _empId là private nên không thể truy cập trực tiếp từ bên 
         * ngoài
         */
    }
    class EmployeeDetails
    {
        private string _empName;
        private int _empId;
        public string EmpName
        {
            //get()
            get
            {
                return _empName;
            }
            //set()
            set
            {
                _empName = value;
            }
        }
        //Tạo một property EmpId để có thể truy cập giá trị của _empId từ bên ngoài lớp.
        public int EmpId
        {
            get
            {
                return _empId;
            }
        }
        public void SetId(int val)
        {
            _empId = val;
        }

        public static void Test()
        {
            EmployeeDetails objDetails = new EmployeeDetails();
            objDetails.EmpName = "Bill";
            objDetails.SetId(10);
            Console.WriteLine("Employee Name:" + objDetails.EmpName);
            Console.WriteLine("Employee Id:" + objDetails._empId);
        }
    }
}
