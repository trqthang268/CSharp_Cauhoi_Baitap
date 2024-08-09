using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Chuong08
{
    internal class PropertiesIndexers
    {
        /*
         * 1. Khái niệm properties
         * - Các trường trong một lớp được truy xuất thông qua tên lớp hoặc
         * đối tượng của lớp. Ngoài cách viết trực tiếp tên trường , Properties
         * cung cấp cho ta cách thức khác để đọc và ghi giá trị của các trường 
         * bên trong một đối tượng
         * Properties dùng get accessor ñể ñọc giá trị của trường(field) và sử
         * dụng set accessor ñể gán giá trị cho một trường
         * 
         * 2. Cú pháp : <access modifer> <return type> <PropertyName>
         * {
         *      get
         *      {
         *      //return value
         *      }
         *      set
         *      {
         *      //return value
         *      }
         * }
         * - Có thể viết properties cho bất kì trường nào trong một lớp
         * 
         * 3. Phân loại properties
         * - Properties có 3 loại:
         *      > Read Only Properties
         *          + Dùng để đọc giá trị của một trường trong lớp
         *          + get{ // return value }
         *      > Write only properties
         *          + Dùng để giá trị cho một trường trong lớp
         *          + set { // assign value }
         *      > Read and Write properties
         *          + Cho phép đọc và ghi giá trị của một trường trong lớp
         *          + get { // return value } set { // assign value}
         * - sử dụng đẻ che giấu thông tin trong lớp.
         * - sử dụng properties linh hoạt hơn 
         * - Properties có thể tính toán để trả về môt giá trị, trường k làm đc.
         * Các trường có thể sử dụng như là tham số của phương thức còn pro thì ko
         * 
         * 4. Khái niệm Indexers:
         * - Indexers là thành phần của lớp, nó cho phép duyệt các đối tượng của một
         * lớp giống như chúng ta duyệt các phần tử bên trong một mảng
         * - Indexers thường được gọi là các property có tham số
         * 
         * 5. Cú pháp Indexers:
         * - <access modifier> <return type> this [<parameter>]
         *  {
         *       get 
         *       {
         *           // return value
         *       }
         *       set 
         *       {
         *           // assign value
         *       }
         *  }
         * - Cũng giống như properties, indexers cũng được khai báo bên trong một lớp
         * , thân của indexers cũng gồm có get/set accessor. Tuy nhiên indexers khác 
         * properties ở chỗ nó có một hoặc nhiều đối số và tên của indexers là this.
         * - Indexers phải có ít nhẩt một đối số
         * - Tham số sẽ là chỉ số để truy cập đến dữ liệu bên trong đối tượng
         * - Trong một lớp có thể viết nhiều indexers(các đối số khác nhau), gọi là 
         * overloaded indexers
         * - Indexers có thể có nhiều tham số, ví dụ khi thành phần của lớp là mảng 2
         * chiều, khi đó indexers cần phải có 2 tham số để truy cập như mảng kiểu mảng
         * 2 chiều
         * 
         */
    }

    class IndexerClass
    {
        private int[] arr = new int[100];
        public int this[int index] // Khai bao Indexer
        {
            get
            {
                // kiem tra mien gia tri cua chi so index.
                if (index < 0 || index >= 100)
                {
                    return 0;
                }
                else
                {
                    return arr[index];
                }
            }
            set
            {
                if (!(index < 0 || index >= 100))
                {
                    arr[index] = value;
                }
            }
        }
    }

    class Indexers
    {
        static void Test()
        {
            IndexerClass test = new IndexerClass();
            // Goi indexer de khoi tao cac phan tu thu #3 va #5.
            test[3] = 256; //test.arr[3] = 256
            test[5] = 1024; //test.arr[5] = 1024;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Element #{0} = {1}", i, test[i]);
            }
        }

        static void Test1()
        {
            DayCollection week = new DayCollection();
            Console.WriteLine(week["Wed"]);//tra ve chi so 3
            Console.WriteLine(week["End"]);//= -1 vi khong co ngay Made-up Day
        }
    }

    class DayCollection
    {
        string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
        // tra ve chi so cua ngay trong mang
        public int this[string inputDay]
        {
            get
            {
                int i = 0;
                foreach (string day in days)
                {
                    if (day == inputDay)
                    {
                        return i;
                    }
                    i++;
                }
                return -1;
            }
        }
    }
    /*Vi du minh hoa overloaded indexers*/
    class OvrIndexer
    {
        //khai bao cac field
        private string[] myData;
        private int arrSize;
        //khai bao constructor
        public OvrIndexer(int size)
        {
            arrSize = size;
            myData = new string[size];
            for (int i = 0; i < size; i++)
            {
                myData[i] = "empty";
            }
        }
        //khai bao indexers
        public string this[int pos]
        {
            get
            {
                return myData[pos];
            }
            set
            {
                myData[pos] = value;
            }
        }
        //overloaded indexer
        public string this[string data]
        { //dem so chuoi trong mang bang chuoi truyen vao
            get
            {
                int count = 0;
                for (int i = 0; i < arrSize; i++)
                {
                    if (myData[i] == data)
                    { count++; }
                }
                return count.ToString();
            }
            /*update gia tri cho cac phan tu trong mang co gia tri bang chuoi nhap vao */
            set
            {
                for (int i = 0; i < arrSize; i++)
                {
                    if (myData[i] == data)
                    {
                        myData[i] = value;
                    }
                }
            }
        }
        static void Tester()
        {
            int size = 10;
            OvrIndexer myInd = new OvrIndexer(size);
            myInd[9] = "Some Value";
            myInd[3] = "Another Value";
            myInd[5] = "Any Value";
            myInd["empty"] = "no value";
            Console.WriteLine("\nIndexer Output\n");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("myInd[{0}]: {1}", i, myInd[i]);
            }
            Console.WriteLine("\nNumber of \"no value\" entries: {0}", myInd["value"]);
        }
    }

    public class Upholstery
    {
        // Lop de bieu dien upholstery fabric
        private double yardPrice;
        private int deliveryWeeks;
        private string fabName;
        // Ham tạo
        public Upholstery(double price, int delivery, string fabric)
        {
            this.yardPrice = price;
            this.deliveryWeeks = delivery;
            this.fabName = fabric;
        }
        // Khai bao cac property
        public int DeliveryTime
        { get { return deliveryWeeks; } }
        public double PricePerYard
        { get { return yardPrice; } }
        public string FabricName
        { get { return fabName; } }
    }
    public class Fabrics
    {
        // khoi tao Collection
        private ArrayList fabricArray = new ArrayList();
        // Indexer de add và return doi tuong tu mang
        public Upholstery this[int ndx]
        {
            get
            {
                if (!(ndx < 0 || ndx > fabricArray.Count - 1))
                    return (Upholstery)fabricArray[ndx];
                // tra ve doi tuong rong
                else return (new Upholstery(0, 0, ""));
            }
            set { fabricArray.Insert(ndx, value); }
        }
    }
    public class IndexerApp
    {
        public static void TestApp()
        {
            Fabrics sofaFabric = new Fabrics();
            // su dung Indexer de tao doi tuong
            sofaFabric[0] = new Upholstery(15.00, 8, "Silk");
            sofaFabric[1] = new Upholstery(12.00, 6, "Wool");
            sofaFabric[2] = new Upholstery(9.00, 6, "Cotton");
            // In ket qua "Fabric: Silk"
            Console.WriteLine("Fabric: {0} ", sofaFabric[0].FabricName);
        }
    }
}

