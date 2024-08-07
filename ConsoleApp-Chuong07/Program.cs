using Chuong07;

namespace ConsoleApp_Chuong07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1) So sánh giữa lớp và giao diện?
                -Lớp: 
                    > Hỗ trợ đơn kế thừa. một lớp chỉ có thể kế thừa từ một lớp cha.
                    > Có thể kế thừa từ nhiều giao diện
                    > Có thế chứa cả triển khai của phương thức và thuộc tính.
                    > Có các mức truy cập khác nhau: public, private, protected, internal,v.v
                    > Có thể khởi tạo để tạo ra các đối tượng
            
                -Giao diện:
                    > Không hỗ trợ kế thừa từ lớp. Nhưng giao diện có thể kế thừa từ nhiều
                    giao diện khác
                    > Chỉ chứa các khai báo phương thức và thuộc tính mà không có phần thực thi
                    > Mức truy cập mặc định là public
                    > Không thể được khởi tạo trực tiếp. Chỉ có thể sử dụng các lớp triển khai
                    giao diện để khởi tạo đối tượng 

             2) Sự khác nhau giữa giao diện và lớp trừu tượng?
                - Lớp trừu tượng:
                    > Có thể kế thừa một lớp và nhiều interface
                    > Có thể có phương thức thông thường có phần thân
                    > Phương thức của lớp trừu tượng được cài đặt bằng từ khóa override
                    > Sử dụng khi muốn trong lớp vừa có phương thức trừu tượng và có pt bình thường
                    > Có thể khai báo phương thức khởi tạo, hàm hủy bên trong lớp

                - Giao diện:
                    > chỉ kế thừa được nhiều giao diện
                    > Chỉ gồm các phương thức trừu tượng, không có phần thân
                    > phương thức của giao diện được đặt mà không dùng override
                    > Sử dụng khi chỉ khai báo các phương thức trừu tượng
                    > Không thể khai báo phương thức khởi tạo, hàm hủy bên trong

             3) Các lớp thực thi giao diện sẽ phải làm gì?
                - Triển khai tất cả các phương thức và các thuộc tính của giao 
                diện, cung cấp phần thực thi cụ thể cho mọi phương thức trong
                giao diện

             4) Có bao nhiêu cách gọi một phương thức được khai báo trong giao diện?
                1. Gọi trực tiếp qua đối tượng của lớp thực thi
                2. Gọi thông qua một biến kiểu giao diện
                3. Gọi thông qua triển khai rõ ràng(Explicit Interface Implementation)
                4. Gọi thông qua một phương thức hoặc thuộc tính khác trả về giao diện.

             5) Các thành viên của giao diện có thể có những thuộc tính truy cập nào?
                - các thành viên của giao diện chỉ có thuộc tính truy cập là public

             6) Chúng ta có thể tạo thể hiện của giao diện một cách trực tiếp được không?
                - Không được

             7) Giao diện là kiểu dữ liệu tham chiếu hay kiểu giá trị?
                - Là kiểu dữ liệu tham chiếu. Các biến của giao diện lưu trữ tham chiếu đến
                đối tượng thực hiện giao diện đó.

             8) Khi thực thi giao diện với cấu trúc thì truy cập các thành viên của
             giao diện thông qua đối tượng hay thông qua tham chiếu giao diện là tốt nhất?
                - Truy cập thông qua tham chiếu giao diện là tốt nhất. 

             9) Số giao diện có thể được kế thừa cho một lớp?
                - 1 lớp có thể kế thừa từ nhiều giao diện.

             10) Việc thực thi giao diện tường minh là thực thi như thế nào? Trong
             trường hợp nào thì cần thực hiện tường minh?
                -Khi triển khai một giao diện một cách tường minh, các thành
                viên của giao diện không thể được truy cập trực tiếp qua đối
                tượng của lớp thực thi. Thay vào đó, phải sử dụng một biến 
                kiểu giao diện để truy cập chúng:
                    VD :
                    public interface IAnimal
                    {
                        void Speak();
                    }

                    public class Dog : IAnimal
                    {
                        void IAnimal.Speak()
                        {
                            Console.WriteLine("Woof!");
                        }
                    }

                    class Program
                    {
                        static void Main(string[] args)
                        {
                            Dog dog = new Dog();
        
                            // Không thể gọi phương thức Speak trực tiếp qua đối tượng dog:
                            // dog.Speak(); // Lỗi biên dịch
        
                            // Phải gọi thông qua biến kiểu giao diện
                            IAnimal animal = dog;
                            animal.Speak(); // Output: Woof!
                        }
                    }
                - Thực thi giao diện tường minh thường được sử dụng trong các trường hợp sau:
                    > Tránh xung đột tên: khi một lớp thực thi nhiều giao diện có các phương
                    thức hoặc thuộc tính bị trùng tên, thực thi tường minh giúp tránh xung đột
                    > Ẩn triển khai: để ẩn đi các thành viên của giao diện khỏi đối tượng
                    của lớp thực thi, chỉ cho phép truy cập thông qua biến kiểu giao diện.
                    Hạn chế khả năng truy cập các thành viên giao diện từ bên ngoài.
                    > Phân biệt rõ ràng một phương thức là 1 phần của giao diện
                    và không phải là 1 phần của lớp thực thi trực tiếp
             */
            
            Baitap13.Tester();
            Baitap14.Test();
        }
    }
}
