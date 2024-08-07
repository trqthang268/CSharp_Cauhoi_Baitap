using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong07
{
    internal class Baitap11
    {
        /*
        11) Hãy viết một giao diện khai báo một thuộc tính ID chứa chuỗi giá
        trị.Viết một lớp Employee thực thi giao diện ñó.
        */
        public interface IEmployee
        {
            string ID { get; set; }
        }
        public class Employee : IEmployee
        {
            public string ID { get; set; }
            public Employee(string id)
            {
                this.ID = id;
            }
        }
    }
}
