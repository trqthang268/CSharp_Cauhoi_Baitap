using Hospital;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Chuong11
{
    internal class Collection
    {
        /*
         * 1. Tập hợp :
         * - Tập các dữ liệu gọi là tập hợp.
         * - So sánh mảng và tập hợp:
         * |Mảng                        || Tập hợp                            |  
         * |Ko thể thay đổi kích thước  || Có thể thay đổi kích thước lúc thực|
         * |lúc thực thi                || thi                                |
         * |Tất cả các phần tử trong    || Các phần tử trong tập hợp có thể   |
         * |mảng phải có cùng kiểu      || thuộc các kiểu khác nhau           |
         * |Không chứa bất kỳ phương    || Chứa các phương thức giúp cho việc |
         * |thức nào để thao tác với các|| thao tác với các phần tử trong tập |
         * |phần tử trong tập hợp       || hợp rất dễ dàng                    |
         * 
         * 2. Namespace System.Collection :
         * - Là namespace chứa các lớp để thao tác với tập các đối tượng (tập
         * hợp). Các lớp và interface có trong namespace này :
         * + Lớp: 
         *  > ArrayList: Lớp này có phép lưu trữ và truy cập các phần tử giống
         *  nhau như mảng, ngoài ra thêm các phần tử lúc thực thi, các phần tử
         *  có thể khác kiểu nhau
         *  > Stack: Lưu trữ và thao tác tập hợp theo cấu trúc LIFO
         *  > Queue: Lưu trữ và thao tác tập hợp theo cấu trúc FIFO
         *  > Hashtable: Lưu trữ một tập các cặp key và value,  các cặp key 
         *  và value được sắp xếp dựa trên mã băm(hash key) của khóa chính
         *  > SortedList : Lưu trữ một tập các cặp key và value, các cặp này
         *  được sắp xếp dựa trên các key.
         * + Interface:
         *  > Icollection : Dùng để xác định kích thước và các phương thức đồng
         *  bộ cho tất cả các tập hợp
         *  > Ienumerator : Cung cấp các phương thức cho phép duyệt các phần tử
         *  trong tập hợp.
         *  > IList : Cung cấp các phương thức cho phép truy cập các phần tử 
         *  trong collection như truy cập các phần tử trong mảng
         * 
         * 3. Namespace System.Collection.Generic :
         * - Generic là một kỹ thuật co phép tạo ra các lớp, các phương thức 
         * có thể thao tác với kiểu dữ liệu bất kỳ. 
         * - Các lớp trong System.Collection.Generic là các lớp generic. Do
         * khi lưu các tập các đối tượng trong các generic class, khi lấy một
         * đối tượng ra khỏi các tập hợp ta không phải ép kiểu. 
         * - Generic collection còn gọi là kiểu an toàn.
         * - Namespace này gồm các lớp và interface sau:
         * + Lớp:
         *  > List<T> : Thao tác với tập hợp kiểu generic(generic collection)
         *  có thể thay đổi kích thước của tập hợp khi thực thi.
         *  > Stack<T> : Lưu trữ và thao tác với generic collection theo kiểu
         *  LIFO.
         *  > Queue<T> : Lưu trữ và thao tác với generic collection theo kiểu
         *  FIFO.
         *  > Dictionary<K,V> : Tạo ra một tập hợp các cặp kiểu generic gồm có
         *  key và value.
         *  > SortedDictionary<K,V> : Tạo ra một tập hợp các cặp gồm key và 
         *  value, trong đó tập hợp được sắp xếp theo key
         *  > LinkedList<T> : Cung cấp cấu trúc liên kết đôi
         * + Intergace:
         *  > IDictionary : Cung cấp các phương thức để lưu trữ tập các phần
         *  tử generic gồm có key và value.
         *  > IEnumerator : Cung cấp các phương thức duyệt các phần tử trong 
         *  tập hợp.
         *  > ICollection : Định nghĩa các phương thức để thao tác với các
         *  generic collection khác nhau.
         *  > IList : Cung cấp các phương thức duyệt các phần tử trong tập 
         *  hợp theo chỉ số giống như mảng.
         * 
         * 4. Lớp ArrayList:
         * - Là lớp lưu trữ tập các đối tượng theo kiểu mảng, tức là truy 
         * xuất các đối tượng trong tập hợp theo chỉ số. Kích thước của 
         * ArrayList có thể thay đổi lúc thực thi. 
         * - ArrayList có thể lưu trữ các phần tử thuộc các kiểu dữ liệu khác
         * nhau. 
         * - Kích thước mặc định  của ArrayList là 0. Nếu các phần tử được 
         * lấp đầy, kích thước của ArrayList sẽ tự động tăng gấp đôi. 
         * - ArrayList cho phép lưu giá trị null cũng như giá trị trùng lặp
         * - Phương thức và thuộc tính thông dụng của lớp ArrayList:
         *  + Phương thức:
         *      > Add: Thêm 1 phần tử vào tập hợp.
         *      > Remove: Xóa 1 phần tử khỏi tập hợp
         *      > RemoveAt : Xóa 1 phần tử khỏi tập hợp tại chỉ số i, chỉ số 
         *      các phần tử được đánh từ 0.
         *      > Insert : Chèn phần tử vào trong tập hợp tại 1 chỉ số nào đó
         *      > Contains : Tìm 1 phần tử trong tập hợp
         *      > IndexOf : Trả về chỉ số của một phần tử trong tập hợp
         *      > CopyTo :Copy các phần tử trong tập hợp ra 1 mảng kiểu object
         *  + Thuộc tính:
         *      > Capacity: Trả về số phần tử mà ArrayList có thể chứa
         *      > Count: Đếm số phần tử hiện có trong ArrayList
         *      
         * 5. Lớp Hashtable:
         * - Cho phép tạo ra một tập hợp các đối tượng dưới dạng key và value
         * - Key sẽ được dùng để sinh ra Hash code tương ứng và Hash code sẽ
         * dùng để xác định key và value tương ứng.
         *  + Phương thức: 
         *      > Add: Thêm một phần tử gồm có key và value vào hashtable
         *      > Remove : Xóa 1 phần tử.
         *      > CopyTo : Copy các phần tử trong hashtable ra 1 mảng tương ứng
         *      > ContainsKey: Tìm kiếm 1 key trong hashtable
         *      > ContainsValue: Tìm kiếm 1 value trong hashtable
         *  + Thuộc tính:
         *      > Count : Đếm số cặp key và value có trong tập hợp
         *      > Keys : Trả về một tập các key có trong hashtable
         *      > Values : Trả về một tập các value có trong hashtable
         * 
         * 6. Lớp SortedList:
         * - SortedList là lớp kết hợp của Hashtable và ArrayList, có nghĩa là
         * các phần tử trong tập hợp bao gồm key và value, các phần tử được 
         * truy xuất theo chỉ số. 
         * - Sự khác nhau giữa Hashtable và SortedList là các phần tử trong 
         * SortedList được sắp xếp theo key của nó. Việc thực thi chương trình
         * sử dụng SortedList chậm hơn chương trình sử dụng Hashtable do có
         * quá trình sắp xếp các phần tử.
         * - Các phương thức và thuộc tính thông dụng của lớp SortedList:
         *  + Phương thức:
         *      > Add : Thêm phần tử
         *      > Remove : Xóa phần tử
         *      > GetKey : Trả về key của phần tử tại chỉ số thứ i
         *      > IndexOfKey : Trả về index của một key
         *      > IndexOfValue : Trả về index của value đầu tiên trong danh sách
         *      > ContainsKey : Tìm kiếm key trong danh sách
         *  + Thuộc tính:
         *      > Capacity : Trả về số phần tử mà SortedList có thể chứa
         *      > Count : Trả về số phần tử có trong SortedList
         *      > Keys : Trả về tập các key có trong SortedList
         *      > Values : Trả về tập các values có trong SortedList
         *      
         * 7. Lớp Dictionary:
         * - Là lớp tạo ra tập hợp các phần tử kiểu generic gồm có key và value
         * , có nghĩa là nó chỉ cho phép lưu một tập các phần tử có cặp key và
         * value có cùng kiểu dữ liệu.
         * - Dictionary không có cho phép lưu trữ giá trị null.
         * - Cú pháp: Dictionary<Tkey,Tvalue>;
         * - Các phương thức và thuộc tính thông dụng của lớp Dictionary:
         *  + Phương thức:
         *      > Add : thêm phần tử
         *      > Remove : Xóa phần tử
         *      > Clear : Xóa tất cả key/value trong Dictionary
         *      > ContainsKey: Tìm kiếm Key trong Dictionary
         *      > ContainsValue : Tìm kiếm value trong Dictionary
         *  + Thuộc tính:
         *      > Count : Đếm số phần tử trong Dictionary
         *      > Keys : Trả về tập các key có trong Dictionary
         *      > Values : Trả về tập các values có trong Dictionary
         */

    }

    public class ViDuArrayList 
    {
        public static void VD01()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Adding 6 elements");
            // Them cac phan tu vao array list
            al.Add('C');
            al.Add('A');
            al.Add('E');
            al.Add('B');
            al.Add('D');
            al.Add('F');
            Console.WriteLine("Removing 2 elements");
            // Xoa cac phan tu khoi array list
            al.Remove('F');
            al.Remove('A');
            Console.WriteLine("Number of elements: " + al.Count);
        }

        public static void VD02()
        {
            // Tao array list
            ArrayList al = new ArrayList();
            // them cac phan tu vao array list
            al.Add(155);
            al.Add(413);
            al.Add(-41);
            al.Add(818);
            Console.Write("Original contents: ");
            foreach (int i in al)
                Console.Write(i + " ");
            Console.WriteLine("\n");
            // sap xep
            al.Sort();
            // su dung vong lap de in cac phan tu trong array list
            Console.Write("Contents after sorting: ");
            foreach (int i in al)
                Console.Write(i + " ");
            Console.WriteLine("\n");
            Console.WriteLine("Index of 413 is " + al.BinarySearch(413));
        }

        public static void VD03()
        {
            ArrayList inv = new ArrayList();
            // Add cac phan tu vao danh sach
            inv.Add(new Product("A", 5.9, 3));
            inv.Add(new Product("B", 8.2, 2));
            inv.Add(new Product("C", 3.5, 4));
            inv.Add(new Product("D", 1.8, 8));
            Console.WriteLine("Product list:");
            foreach (Product i in inv)
            { Console.WriteLine(" " + i); }
        }

        public static void VD04()
        {
            ArrayList myArrayList = new ArrayList();
            // add bon doi tuong Employee vao myArrayList su dung phuong thuc add
            Console.WriteLine("Adding four Employee objects to myArrayList");
            Employee myM = new Employee("M", 2001);
            Employee myB = new Employee("B", 2001);
            Employee myC = new Employee("C", 1999);
            Employee myT = new Employee("T", 1979);
            myArrayList.Add(myM);
            myArrayList.Add(myB);
            myArrayList.Add(myC);
            myArrayList.Add(myT);
            //in truoc khi sap xep mang
            DisplayArrayList("myArrayList", myArrayList);
            myArrayList.Sort();
            //ket qua sau khi sap xep
            DisplayArrayList("myArrayList", myArrayList);
        }

        public static void VD05()
        {
            Hospital.PatientListTest.Test();
        }
        public static void DisplayArrayList(string arrayListName, ArrayList myArrayList)
        {
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(arrayListName + "[" + i + "] = " + myArrayList[i]);
            }
        }
    }

    class Product
    {
        string name;
        double cost;
        int onhand;
        public Product(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }
        public override string ToString()
        {
            return
            String.Format("{0,-10}Cost: {1,6:C} On hand: {2}", name, cost, onhand);
        }
    }

    //lop nay se cai dat lai phuong thuc compareTo
    class Employee : IComparable
    {
        public string Name;
        public int Number;
        public Employee(string Name, int Number)
        {
            this.Name = Name;
            this.Number = Number;
        }
        public override string ToString()
        {
            return "Name is " + Name + ", Number is " + Number;
        }
        public int Compare(object lhs, object rhs)
        {
            Employee lhsEmployee = (Employee)lhs;
            Employee rhsEmployee = (Employee)rhs;
            if (lhsEmployee.Number < rhsEmployee.Number)
            {
                return -1;
            }
            else if (lhsEmployee.Number > rhsEmployee.Number)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int CompareTo(object rhs)
        {
            return Compare(this, rhs);
        }
    }

    public class ViduHashtable
    {
        public static void VD01()
        {
            Hashtable ht = new Hashtable();
            ht.Add("a", "A");
            ht.Add("b", "B");
            ht.Add("c", "C");
            ht.Add("e", "E");
            // Lay tap keys trong Hashtable.
            ICollection c = ht.Keys;
            foreach (string str in c)
                Console.WriteLine(str + ": " + ht[str]);
        }

        public static void VD02()
        {
            Hashtable myHashtable = new Hashtable();
            myHashtable.Add("AL", "Alabama");
            myHashtable.Add("CA", "California");
            myHashtable.Add("FL", "Florida");
            myHashtable.Add("NY", "New York");
            myHashtable.Add("WY", "Wyoming");
            foreach (string myKey in myHashtable.Keys)
            {
                Console.WriteLine("myKey = " + myKey);
            }
            foreach (string myValue in myHashtable.Values)
            {
                Console.WriteLine("myValue = " + myValue);
            }
            if (myHashtable.ContainsKey("FL"))
            {
                Console.WriteLine("myHashtable contains the key FL");
            }
        }

        public static void VD03()
        {
            DoctorTableTest.Test();
        }
    }

    public class ViduSortedList
    {
        public static void VD01()
        {
            SortedList sl = new SortedList();
            sl.Add("a", "A");
            sl.Add("b", "B");
            sl.Add("c", "C");
            sl.Add("d", "D");
            // Lay cac key co trong collection.
            ICollection c = sl.Keys;
            // Hien thi danh sach su dung indexer.
            Console.WriteLine("Contents by integer indexes.");
            for (int i = 0; i < sl.Count; i++)
                Console.WriteLine(sl.GetByIndex(i));
        }

        public static void VD02()
        {
            //tao doi tuong lop SortedList
            SortedList mySortedList = new SortedList();
            //add cac doi tuong vao SortedList
            mySortedList.Add("NY", "New York");
            mySortedList.Add("FL", "Florida");
            mySortedList.Add("AL", "Alabama");
            mySortedList.Add("WY", "Wyoming");
            mySortedList.Add("CA", "California");
            //duyet va in cac key co trong SortedList
            foreach (string myKey in mySortedList.Keys)
            {
                Console.WriteLine("myKey = " + myKey);
            }
            //duyet va in cac value co trong SortedList
            foreach (string myValue in mySortedList.Values)
            {
                Console.WriteLine("myValue = " + myValue);
            }
            Console.WriteLine("Getting the value list");
            IList myValueList = mySortedList.GetValueList();
            foreach (string myValue in myValueList)
            {
                Console.WriteLine("myValue = " + myValue);
            }
        }

        public static void VD03()
        {
            MedicineListTest.Test();
        }
    }

    public class ViduDictionary
    {
        public static void VD01()
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            // Them cac phan tu vao collection.
            dict.Add("A", 7);
            dict.Add("B", 5);
            dict.Add("C", 4);
            dict.Add("D", 9);
            // Lay mot tap cac keys (names).
            ICollection<string> c = dict.Keys;
            foreach (string str in c)
                Console.WriteLine("{0}, Salary: {1:C}", str, dict[str]);
        }

        public static void VD02()
        {
            SuppliersTest.TestMain();
        }
    }
}

namespace Hospital
{
    class PatientList
    {
        public ArrayList objPatientNames = new ArrayList();
        public void AcceptDetails()
        {
            char choice = 'Y';
            try
            {
                do
                {
                    Console.Write("Enter patient's name : ");
                    // Phuong thuc Add() cua lop ArrayList de add ten benh nhan vao danh sach list
                    objPatientNames.Add(Console.ReadLine());
                    Console.Write("Do you want to add more names? [Y/N] : ");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'Y' || choice == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("\nList of patients :");
            for (int i = 0; i < objPatientNames.Count; i++)
            {
                Console.WriteLine(objPatientNames[i]);
            }
            //Thuoc tinh Count cua lop ArrayList de hien thi tong so benh nhan
            Console.WriteLine("Total number of patients : " + objPatientNames.Count);
        }
        public bool Remove()
        {
            string choice;
            Console.Write("Enter the name of the patient : ");
            choice = Console.ReadLine();
            // Phuong thuc Contains() cua ArrayList duoc su dung de tim kiem ten benh nhan trong danh sach
            if (objPatientNames.Contains(choice))
            {
                //phuong thuc Remove() cua lop ArrayList de xoa ten moi benh nhan khoi danh sach
                objPatientNames.Remove(choice);
                return true;
            }
            else
                return false;
        }
        public void Search()
        {
            string choice;
            Console.Write("Enter the name of the patient : ");
            choice = Console.ReadLine();
            if (choice != "")
            {
                if (objPatientNames.Contains(choice))
                {
                    Console.WriteLine("Record Found!");
                    Console.WriteLine(objPatientNames[objPatientNames.IndexOf(choice)]);
                }
                else
                    Console.WriteLine("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }

    class PatientListTest
    {
        public static void Test()
        {
            try
            {
                // Tao 1 doi tuong cua lop PatientList
                PatientList objPatientList = new PatientList();
                // Goi phuong thuc AcceptDetails cua lop PatientList de nhap ten ben nhan
                objPatientList.AcceptDetails();
                //goi phuong thuc DisplayDetails cua lop PatientList de hien thi ten benh nhan
                objPatientList.DisplayDetails();
                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of the following options:");
                    Console.WriteLine(" 1. Sort\n 2. Remove\n 3. Reverse\n 4. Search\n 5. Exit");
                    Console.Write("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            // Sap tep benh nhan theo thu tu tang dan bang cach su dung phuong thuc Sort
                            objPatientList.objPatientNames.Sort();
                            Console.Write("\n-----After Sorting-----");
                            objPatientList.DisplayDetails();
                            break;
                        case 2:
                            // Xoa ten benh nhan
                            if (objPatientList.Remove())
                            {
                                Console.Write("\n-----After Removing-----");
                                objPatientList.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Patient with this name does not exist");
                            break;
                        case 3:
                            // Dao nguoi danh sach ten ben nhan bang phuong thuc Reverse
                            objPatientList.objPatientNames.Reverse();
                            Console.Write("\n-----After Reversing-----");
                            objPatientList.DisplayDetails();
                            break;
                        case 4:
                            // Tim kiem ten benh nhan
                            objPatientList.Search();
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Invalid Data Entry!");
                            break;
                    }
                } while (input == 'Y' || input == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }
    }

    class DoctorTable
    {
        public Hashtable objDoctorDetails = new Hashtable();
        public void AcceptDetails()
        {
            // field de luu ten cua doctor
            string name;
            // field de luu dia chi
            string address;
            // bien de luu lua chon cua nguoi dung
            char choice = 'Y';
            try
            {
                do
                {
                    Console.Write("Enter the doctor's name : ");
                    name = Console.ReadLine();
                    Console.Write("Enter the address : ");
                    address = Console.ReadLine();
                    // Phuong thuc Add() cua lop Hashtable de add thong tin cua bac si vao danh sach
                    objDoctorDetails.Add(name, address);
                    Console.Write("Do you want to add more records? [Y/N] : ");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'Y' || choice == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }
        // Phuong thuc de hien thi thong tin chi tiet cua bac si.
        public void DisplayDetails()
        {
            // Luu cac keys vao trong doi tuong cua Icollection
            //bang cach su dung thuoc tinh Keys cua Hashtable
            ICollection objCollection = objDoctorDetails.Keys;
            Console.WriteLine("\nDetails of doctors :"); Console.WriteLine("Doctor's Name \t Address");
            Console.WriteLine("------------- \t -------");
            // Duyet cac phan tu trong tap hop bang vong lap
            foreach (string details in objCollection)
            {
                Console.WriteLine(details + "\t\t " + objDoctorDetails[details]);
            }
            // Thuoc tinh Count cua lop Hashtable de dem so bac si
            Console.WriteLine("Total number of doctors : " + objDoctorDetails.Count);
        }
        //phuong thuc xoa mot bach si
        public bool Remove()
        {
            string choice;
            Console.Write("Enter the name of the doctor : ");
            choice = Console.ReadLine();
            // Phuong thuc ContainsKey() tim mot key co trong Hastable khong
            if (objDoctorDetails.ContainsKey(choice))
            {
                // Phuong thuc Remove() de xoa thong tin chi tiet mot bac si khoi danh sach
                objDoctorDetails.Remove(choice);
                return true;
            }
            else
                return false;
        }
        // Phuong thuc de tim mot bac si.
        public void Search()
        {
            string choice;
            Console.Write("Enter the name of the doctor : ");
            choice = Console.ReadLine();
            if (choice != "")
            {
                // Phuong thuc ContainsKey() tim ten mot bac si trong danh sach
                if (objDoctorDetails.ContainsKey(choice))
                {
                    Console.WriteLine("Record Found!");
                    Console.WriteLine("Doctor's Name : {0}", choice);
                    // Hien thi dia chi cua bac si su dung thuoc tinh Item
                    Console.WriteLine("Address : {0}", objDoctorDetails[choice]);
                }
                else
                    Console.WriteLine("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }

    class DoctorTableTest
    {
        public static void Test()
        {
            try
            {
                // Tao mot doi tuong cua lop DoctorTable
                DoctorTable objDoctorsTable = new DoctorTable();
                // Goi phuong thuc AcceptDetails cua lop DoctorTable
                // Nhap thong tin chi tiet mot bac si
                objDoctorsTable.AcceptDetails();
                // Goi phuong thuc DisplayDetails cua lop DoctorTable
                // de hien thi thong tin chi tiet mot bac si
                objDoctorsTable.DisplayDetails();
                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of the following options:");
                    Console.WriteLine(" 1. Remove\n 2. Remove All\n 3. Search\n 4. Exit");
                    Console.Write("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            // Xoa mot bac si
                            if (objDoctorsTable.Remove())
                            {
                                Console.WriteLine("\n-----After Removing-----");
                                objDoctorsTable.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Doctor with this name does not exist");
                            break;
                        case 2:
                            // Xoa ten tat ca cac bac si su dung phuong Clear
                            objDoctorsTable.objDoctorDetails.Clear();
                            Console.WriteLine("\n-----After removing all the doctors-----");
                            Console.WriteLine("Total number of doctors : " +
                           objDoctorsTable.objDoctorDetails.Count);
                            return;
                        case 3:
                            // Tim thong tin chi tiet mot bac si
                            objDoctorsTable.Search();
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Invalid Data Entry!");
                            break;
                    }
                } while (input == 'Y' || input == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }
    }

    class MedicineList
    {
        public SortedList objMedicineDetails = new SortedList();
        public void AcceptDetails()
        {
            // field de luu ten thuoc
            string name;
            // bien Double de luu gia thuoc
            double price;
            // bien luu lua chon y/n cua nguoi dung
            char choice = 'Y';
            try
            {
                do
                {
                    Console.Write("Enter the medicine name : ");
                    name = Console.ReadLine();
                    Console.Write("Enter the price : ");
                    price = Convert.ToDouble(Console.ReadLine());
                    // Phuong thuc Add() cua lop SortedList de add thong tin thuoc
                    objMedicineDetails.Add(name, price);
                    Console.Write("Do you want to add more names? [Y/N] : ");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'Y' || choice == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }
        // Phuong thuc hien thi thong tin chi tiet ve thuoc
        public void DisplayDetails()
        {
            Console.WriteLine("Details of Medicines :");
            Console.WriteLine("Medicine Name \t Price");
            for (int i = 0; i < objMedicineDetails.Count; i++)
            {
                // Hien thi chi tiet ve thuoc su dung phuong thuc GetKey() va GetByIndex()
                Console.WriteLine("{0}\t\t {1:C2}", objMedicineDetails.GetKey(i),
               objMedicineDetails.GetByIndex(i));
            }
            //Thuoc tinh Count cua lop SortedList de dem tong so loai thuoc
            Console.WriteLine("Total number of medicines : " + objMedicineDetails.Count);
        }
        public bool Modify()
        {
            string name;
            double price;
            Console.Write("Enter the name of the medicine to change its price : ");
            name = Console.ReadLine();
            // Phuong thuc Contains() cua lop SortedList tim xem mot loai thuoc co trong danh sach chua
            if (objMedicineDetails.Contains(name))
            {
                Console.Write("Enter new price : ");
                price = Convert.ToDouble(Console.ReadLine());
                // Phuong thuc IndexOfKey() tra ve index cua mot loai thuoc tu list
                int index = objMedicineDetails.IndexOfKey(name);
                // Phuong thuc SetByIndex() duoc su dung de sua gia Medicine tai chi so nao do
                objMedicineDetails.SetByIndex(index, price);
                return true;
            }
            else
                return false;
        }
        // Phuong thuc xoa mot loai khoi danh sach
        public bool Remove()
        {
            string choice;
            Console.Write("Enter the name of the medicine : ");
            choice = Console.ReadLine();
            // Phuong Contains() tim kiem mot loai thuoc
            if (objMedicineDetails.Contains(choice))
            {
                // Phuong thuc Remove() de xoa mot loai thuoc khoi danh sach
                objMedicineDetails.Remove(choice);
                return true;
            }
            else
                return false;
        }
        // Phuong thuc de tim ten thuoc.
        public void Search()
        {
            string choice;
            Console.Write("Enter the name of the medicine : ");
            choice = Console.ReadLine();
            if (choice != "")
            {
                // Phuong thuc ContainsKey() de kiem tra ten thuoc trong
                if (objMedicineDetails.ContainsKey(choice))
                {
                    Console.WriteLine("Record Found!");
                    Console.WriteLine("Medicine Name : {0}", choice);
                    // Hien thi thong tin chi tiet cua thuoc su dung thuoc tinh Item
                    Console.WriteLine("Price : {0:C2}", objMedicineDetails[choice]);
                }
                else
                    Console.WriteLine("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }

    /// Lop MedicineListTest de test lop MedicineList.
    class MedicineListTest
    {
        public static void Test()
        {
            try
            {
                // Tao mot doi tuong cua lop MedicineList
                MedicineList objMedicines = new MedicineList();
                // Goi phuong thuc AcceptDetails cua lop MedicineList
                // de nhap thong tin chi tiet ve thuoc
                objMedicines.AcceptDetails();
                // Goi phuong thuc DisplayDetails cua lop MedicineList
                // de hien thi thong tin chi tiet ve thuoc
                objMedicines.DisplayDetails();
                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of the following options :");
                    Console.WriteLine(" 1. Modify\n 2. Remove\n 3. Remove All\n 4. Search\n 5. Exit");
                    Console.Write("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            // Sua gia thuoc
                            if (objMedicines.Modify())
                            {
                                Console.WriteLine("\n-----After Modifying-----");
                                objMedicines.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Medicine with this name does not exist");
                            break;
                        case 2:
                            // Xoa mot loai thuoc khoi danh muc thuoc
                            if (objMedicines.Remove())
                            {
                                Console.WriteLine("\n-----After Removing-----");
                                objMedicines.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Medicine with this name does not exist");
                            break;
                        case 3:
                            // Xoa ta ca cac loai thuoc bang phuong thuc clear
                            objMedicines.objMedicineDetails.Clear();
                            Console.WriteLine("\n-----After removing all the medicines-----");
                            Console.WriteLine("Total number of medicines : " +
                           objMedicines.objMedicineDetails.Count);
                            return;
                        case 4:
                            // Tim thong tin chi tiet ve thuoc
                            objMedicines.Search();
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Invalid Data Entry!");
                            break;
                    }
                } while (input == 'Y' || input == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }
    }

    class Suppliers
    {
        public Dictionary<int, string> objSupplierDetails = new Dictionary<int, string>();
        public void AcceptDetails()
        {
            // bien kieu nguyen de luu ma nha cung cap
            int id;
            // bien luu ten nhan cung cap
            string name;
            // bien luu lua cho nguoi dung y/n
            char choice = 'Y';
            try
            {
                do
                {
                    Console.Write("Enter the supplier ID : ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the name : ");
                    name = Console.ReadLine();
                    // Phuong thuc Add() de nhap thong tin chi tiet nha cung cap
                    objSupplierDetails.Add(id, name);
                    Console.Write("Do you want to add more records? [Y/N] : ");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'Y' || choice == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }
        //Phuongthuc hien thi chi tiet nha cung cap.
        public void DisplayDetails()
        {
            // Luu cac keys vao trong mot doi tuong cua ICollection interface
            ICollection objCollection = objSupplierDetails.Keys;
            Console.WriteLine("Details of Suppliers :");
            Console.WriteLine("Supplier ID \t Name");
            foreach (int details in objCollection)
            {
                Console.WriteLine(details + "\t\t " + objSupplierDetails[details]);
            }
            Console.WriteLine("Total number of suppliers : " + objSupplierDetails.Count);
        }
        // Sua ten nha cung cap
        public bool Modify()
        {
            int id;
            string name;
            Console.Write("Enter the supplier ID to change the name : ");
            id = Convert.ToInt32(Console.ReadLine());
            if (id > 0 && objSupplierDetails.ContainsKey(id))
            {
                Console.Write("Enter new name of the supplier : ");
                name = Console.ReadLine();
                objSupplierDetails[id] = name;
                return true;
            }
            else
                return false;
        }// Xoa mot nha cung cap
        public bool Remove()
        {
            int input;
            Console.Write("Enter the supplier ID : ");
            input = Convert.ToInt32(Console.ReadLine());
            // Phuong thuc ContainsKey() duoc su dung de kiem tra xe ma nha cung cap da co trong list chua
            if (input > 0 && objSupplierDetails.ContainsKey(input))
            {
                // Phuong thuc Remove() xoa 1 nha cung cap khoi danh sach
                objSupplierDetails.Remove(input);
                return true;
            }
            else
                return false;
        }
        // Phuong thuc tim kiem mot nha cung cap.
        public void Search()
        {
            int choice;
            Console.Write("Enter the supplier ID : ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice > 0)
            {
                // Phuong thuc ContainsKey() de kiem tra xem nha cung cap co trong list chua
                if (objSupplierDetails.ContainsKey(choice))
                {
                    Console.WriteLine("Record Found!");
                    Console.WriteLine("Supplier ID : {0}", choice);
                    // Hien thi ten nha cung cap su dung thuoc tin Item
                    Console.WriteLine("Name : {0}", objSupplierDetails[choice]);
                }
                else
                    Console.WriteLine("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
    class SuppliersTest
    {
        public static void TestMain()
        {
            try
            {
                // Tao doi tuong cua lop Suppliers
                Suppliers objSuppliers = new Suppliers();
                // Goi phuong thuc AcceptDetails cua lop Suppliers
                // de nhap thong tin chi tiet
                objSuppliers.AcceptDetails();
                // Goi phuong thuc DisplayDetails cua lop Suppliers
                // de hien thi thong ti chi tiet nha cung cap
                objSuppliers.DisplayDetails();
                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of the following options:");
                    Console.WriteLine(" 1. Modify\n 2. Remove\n 3. Remove All\n 4. Search\n 5. Exit"); 
                    Console.Write("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            // Sua ten nha cung cap
                            if (objSuppliers.Modify())
                            {
                                Console.WriteLine("\n-----After Modifying-----");
                                objSuppliers.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Supplier with this name does not exist");
                            break;
                        case 2:
                            // Xao nha cung cap
                            if (objSuppliers.Remove())
                            {
                                Console.WriteLine("\n-----After Removing-----");
                                objSuppliers.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Supplier with this name does not exist");
                            break;
                        case 3:
                            // Removing the records of all suppliers using the built-in method Clear
                            objSuppliers.objSupplierDetails.Clear();
                            Console.WriteLine("\n-----After removing all the suppliers-----");
                            Console.WriteLine("Total number of suppliers : " +
                           objSuppliers.objSupplierDetails.Count);
                            return;
                        case 4:
                            // Tim mot nha cung cap
                            objSuppliers.Search();
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Invalid Data Entry!");
                            break;
                    }
                } while (input == 'Y' || input == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }
    }
}

