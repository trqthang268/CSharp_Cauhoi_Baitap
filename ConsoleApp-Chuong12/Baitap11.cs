using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*11) Viết chương trình minh họa sử dụng ủy quyền để thực hiện việc sắp
        xếp các số nguyên trong một mảng?
 */
namespace Baitap11
{
    //Khai báo một delegate để so sánh 2 số nguyên
    public delegate bool Compare(int x, int y);

    //Tạo các phương thức để sắp xếp tăng dần và giảm dần
    public class Sorter
    {
        public static bool Ascending(int x, int y)
        {
            return x > y; //Đổi chỗ nếu x lớn hơn y(tăng dần)
        }
        public static bool Descending(int x, int y)
        {
            return x < y; // Đổi chỗ nếu x nhỏ hơn y(giảm dần)
        }
    }

    //Viết phương thức thực hiện sắp xếp dựa trên delegate
    public class ArraySorter
    {
        public void Sort(int[] array, Compare compare)
        {
            for (int i = 0; i < array.Length -1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (compare(array[i], array[j]))
                    {
                        //Hoán đổi vị trí nếu điều kiện so sánh là đúng
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }

    public class Program
    {
        static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void Test()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] numbers = { 1, 2, 9, 4, 8, 4, 6, 82, 12, 4 };

            ArraySorter arraySorter = new ArraySorter();

            Console.WriteLine("Mảng ban đầu");
            PrintArray(numbers);

            //Sắp xếp tăng dần
            arraySorter.Sort(numbers, Sorter.Ascending);
            Console.WriteLine("\nMảng sắp xếp tăng dần: ");
            PrintArray(numbers);

            //Sắp xếp giảm dần
            arraySorter.Sort(numbers, Sorter.Descending);
            Console.WriteLine("\nMảng sắp xếp giảm dần: ");
            PrintArray(numbers);


        }
    }
}
