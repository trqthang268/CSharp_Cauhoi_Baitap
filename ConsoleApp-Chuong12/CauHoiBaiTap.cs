using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong12
{
    internal class CauHoiBaiTap
    {
        /*
        1) Tóm tắt những nét cơ bản về delegate?
            - Delegate là một kiểu dữ liệu dùng để lưu trữ tham chiếu đến một
        phương thức có một danh sách tham số và kiểu trả về tương ứng.
            - Delegate có thể được sử dụng để gọi phương thức mà nó tham chiếu
        đến, như thể đang gọi phương thức trực tiếp.
            - Một delegate có thể tham chiếu đến nhiều phương thức cùng lúc. 
        khi delegate được gọi,tất cả các phương thức đã đăng kí sẽ được gọi
        theo thứ tự
            - Delegate thường được sử dụng để triển khai các phương thức gọi lại
            - Delegate là nền tảng để triển khai các sự kiện trong C#. Sự kiện
        bản chất là một delegate đặc biệt được sử dụng để thông báo hoặc xử lí 
        các sự kiện

        2) Có thể sử dụng delegate như một thuộc tính hay không? Nếu có thể
        thì sử dụng như thế nào?
        Cho biết ý nghĩa?
            - Có thể sử dụng delegate như một thuộc tính trong C#. Khi sử dụng 
        delegate như một thuộc tính, ta có thể gán hoặc truy cập delegate đó 
        giống như bất kỳ thuộc tính nào khác. Điều này rất hữu ích khi bạn muốn
        cung cấp khả năng tùy chỉnh hành vi của một lớp hoặc một đối tượng từ
        bên ngoài thông qua các phương thức được gán cho delegate.
            - Ý nghĩa:
            + Tính linh hoạt và khả năng tùy biến cho phép người dùng hoặc các
            lớp khác gán các phương thức tùy chỉnh vào delegate thuộc tính.
            GIúp thay đổi hành vi của đối tượng mà không cần sửa đổi lớp đó.
            + Tách biệt logic xử lí : Logic cụ thể có thể được tách biệt ra 
            ngoài lớp, giúp mã dễ bảo trì hơn. Đặc biệt hữu ích khi bạn muốn
            thay đổi cách xử lý mà không cần thay đổi lớp chứa logic chính.
            + Khả năng mở rộng : Sử dụng delegate như thuộc tính cho phép lớp 
            có thể dễ dàng mở rộng các chức năng mà không cần kế thừa hay thay
            đổi mã gốc
            + Delegate thuộc tính có thể được tái sử dụng trong nhiểu lớp hoặc
            đối tượng khác nhau, giúp giảm thiểu sự trùng lặp trong mã.

        3) Nếu có một số hoạt động cần được thực hiện theo một thứ tự nhất
        định thì ta phải làm thế nào để khi cần thực hiện thì gọi lần
        lượt thực hiện các hoạt động đó?
            - Sử dụng Delegate hoặc Delegate Multicast : 
            + Delegate có thể được sử dụng để tạo ra một chuỗi các phương 
        thức cần gọi theo thứ tự nhất định. 
            + Delegate multicast cho phép gán nhiều phương thức vào cùng một
        delegate và chúng sẽ được gọi lần lượt.


        4) Công dụng của việc khai báo delegate tĩnh? Khi nào thì nên khai
        báo ủy quyền tĩnh khi nào thì không nên?
        - Công dụng của việc khai báo delegate tĩnh:
            + Không cần tạo đối tượng (Instance): Delegate tĩnh được gọi trực
        tiếp thông qua lớp chứa nó mà không cần tạo một đối tượng của lớp đó.
        Điều này hữu ích khi bạn muốn sử dụng delegate một cách toàn cục mà 
        không cần quản lý đối tượng.
            + Chia sẻ toàn cục: Delegate tĩnh có thể được chia sẻ bởi tất cả
        các phiên bản của lớp chứa nó. Nếu có nhiều đối tượng cần sử dụng cùng
        một delegate, thì delegate tĩnh giúp tiết kiệm bộ nhớ và dễ quản lí hơn
            + Tính năng sử dụng toàn cụcL: Có thể được sử dụng cho các sự kiện 
        hoặc hành động mà bản chất là toàn cục và không liên quan đến bất kỳ
        trạng thái cụ thể nào của đối tượng.

        - Nên khai báo ủy quyền tĩnh khi:
            + khi delegate không cần truy cập vào trạng thái của một đối tượng
            + Khi delegate mang tính toàn cục
            + Khi cần hiệu năng cao
        - không nên khai báo ủy quyền tĩnh khi:
            + Khi delegate cần truy cập hoặc thao tác với các thành viên không
            tĩnh của lớp
            + Khi cần sử dụng nhiều phiên bản khác nhau của delegate, cần sự 
            linh hoạt trong việc xử lý trạng thái của đối tượng

        5) Một delegate có thể gọi được nhiều hơn một phương thức hay không?
        Chức năng nào trong C# hỗ trợ ủy quyền này?
        - Có, một delegate trong C# có thể gọi nhiều phương thức. Khi một 
        delegate được gán nhiều phương thức, nó sẽ gọi tất cả các phương thức
        theo thứ tự mà chúng được thêm vào.
        - Chức năng hỗ trợ việc gán nhiều phương thức vào một delegate được
        gọi là multicast. Trong C#, các delegate có khả năng tự nhiên để
        multicast, có nghĩa là bạn có thể gán nhiều phương thức vào 1 delegate

        6) Có phải tất cả các delegate đều là delegate Multicast hay không?
        điều kiện để trở thành delegate Multicast?
        - Không phải tất cả các delegate đều là delegate Multicast. Tuy nhiên,
        đa số các delegate trong C# là multicast. Ta có thể gán nhiều phương
        thức cho một delegate và các phương thức này sẽ được gọi tuần tự
        - Điều kiện để trở thành Delegate Multicast:
            + Delegate có thể gán nhiều phương thức. một delegate có thể được 
        gán nhiều phương thức thông qua toán tử "+=" và loại bỏ thông qua "-=" 
            + Delegate không có kiểu trả về hoặc kiểu trả về là void:
            + Điều kiện chính để trở thành multicast là delegate có thể gán
            nhiều phương thức và thực thi các phương thức này theo thứ tự đã 
            được thêm vào.
        
        7) Các toán tử nào có thể dùng để thực hiện việc Multicast các 
        delegate?
        - Toán tử "+=" để thêm phương thức và "-=" để loại bỏ phương thức

        8) Sự kiện là gì? Trong hệ thống ứng dụng nào thì sự kiện được sử 
        dụng nhiều?
        - Sự kiện là cơ chế giúp đối tượng thông báo về các thay đổi hoặc 
        hành động của nó cho các đối tượng khác.
        - Những hệ thống sử dụng sự kiện nhiều nhất là các ứng dụng 
        GUI(Graphical User Interface) và các hệ thống tương tác với người dùng.

        9) Những sự kiện trong C# được thực hiện thông qua cái gì?
        -  Những sự kiện trong C# được thực hiện thông qua Delegate. Delegate 
        đóng vai trò như là trung gian giữa các sự kiện và các phương thức 

        10) Hãy tóm lược quá trình tạo một sự kiện và giải quyết sự kiện 
        thông qua cơ chế ủy quyền trong C#?
        - Quá trình bao gồm các bước sau:
         1. Khai báo một delegate. Sự kiện sẽ sử dụng delegate này để gọi các
        phương thức xử lý sự kiện
         2. Khai báo sự kiện dựa trên delegate. Khi sự kiện được kích hoạt ,
        delegate sẽ được gọi để xử lý sự kiện
         3. Đăng ký phương thức xử lý sự kiện. Để 1 phương thức được gọi khi 
        sự kiện xảy ra, nó phải được đăng ký với sự kiện. Được thực hiện bằng
        cách sử dụng toán tử "+=".
         4. Kích hoạt sự kiện. Khi một hành động xảy ra, kích hoạt sự kiện.
        Sẽ khiến delegate gọi tất cả các phương thức đã đăng ký.
         5 Xử lý sự kiện trong các phương thức đăng ký
         6. Gỡ hoặc hủy đăng ký sự kiện (nếu cần). Nếu muốn ngừng việc xử lý 
        sự kiện trong một phương thức cụ thể, sử dụng "-=" để gỡ bỏ đăng ký 
        phương thức.

        */
    }
}
