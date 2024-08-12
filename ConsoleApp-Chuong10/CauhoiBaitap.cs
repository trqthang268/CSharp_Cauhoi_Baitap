using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Chuong10
{
    internal class CauhoiBaitap
    {
        /*
         * 1) Việc sử dụng catch không có tham số có vẻ như có nhiều sức mạnh
         * do chúng bắt giữ tất cả các ngoại lệ. Tại sao chúng ta không luôn
         * luôn sử dụng câu lệnh catch không có tham số để bắt các lỗi?
         * 
         * - Khó xác định và xử lý lỗi cụ thể: Khi sử dụng catch không có tham 
         * số, ta không biết chính xác loại ngoại lệ nào đã được ném ra. Điều 
         * này làm cho việc xử lý lỗi trở nên khó khăn, vì mỗi loại ngoại lệ có
         * thể yêu cầu một cách xử lí khác nhau.
         * 
         * - Bắt các ngoại lệ không mong muốn: catch không tham số có thể bắt các
         * ngoại lệ không mong muốn hoặc không dự đoán được, bao gồm các ngoại lệ
         * hệ thống nghiêm trọng. những ngoại lệ này là dấu hiệu của các vấn đề
         * nghiêm trọng trong ứng dụng và có thể không nên bị bắt và xử lí theo 
         * cách thông thường
         * 
         * - Phá vỡ luồng kiểm soát : Chương trình có thể bỏ qua những đoạn mã
         * quan trọng mà lẽ ra phải được thực thi nếu lỗi không xảy ra
         * 
         * - Khó khăn trong việc bảo trì và gỡ lỗi: sử dụng catch không tham số
         * làm cho mã nguồn trở nên khó bảo trì hơn vì nó làm cho việc tìm kiếm
         * nguồn gốc và nguyên nhân của lỗi trở nên khó khăn. Có thể không biết 
         * lỗi xuất phát từ đâu và tại sao nó lại xảy ra.
         * 
         * - Không cung cấp thông tin về lỗi: catch không tham số không cung cấp 
         * thông tin về ngoại lệ bị bắt, vì vậy bạn không thể ghi log thông tin 
         * chi tiết về lỗi hoặc thực hiện các hành động xử lí cụ thể dựa trên 
         * ngoại lệ đó
         *
         *
         * 2) Như câu trả lời bên trên tại sao tôi phải tìm hiểu nhiều về các
         * ngoại lệ và cách thức xử lý các ngoại lệ khi chúng được phát sinh?
         * - Lí do cần phải tìm hiểu :
         * > Cải thiện độ tin cậy của ứng : Hiểu biết về các ngoại lệ giúp dự đoán
         * và xử lí các tình huống lỗi một cách có chủ ý. Điều này làm giảm khả 
         * năng ứng dụng của mình bị sập hoặc rơi vào tình trạng không mong muốn
         * khi gặp lỗi, từ đó nâng cao độ tin cậy của ứng dụng.
         * 
         * > Bảo trì và phát triển dễ dàng hơn: khi hiểu rõ các ngoại lệ có thể xảy 
         * ra , ta có thể viết mã dễ bảo trì hơn. Có thể phân biệt các loại ngoại lệ
         * khác nhau và xử lí chúng một cách cụ thể, điều này giúp mã nguồn trở nên 
         * rõ ràng, dễ hiểu, và dễ gỡ lỗi hơn khi có vấn đề xảy ra.
         * 
         * > Tăng cường khả năng gỡ lỗi: Nắm vững cách thức ngoại lệ hoạt động, ta có 
         * thể nhanh chóng xác định nguyên nhân của các vấn đề trong mã nguồn. Thay vì
         * chỉ bắt mọi ngoại lệ và không hiểu tại sao chúng xảy ra, ta có thể ghi log 
         * thông tin chi tiết về lỗi và từ đó tìm ra giải pháp khắc phục
         * 
         * > Bảo vệ dữ liệu và tài nguyên: Việc xử lí ngoại lệ đúng cách giúp 
         * đảm bảo rằng tài nguyên được giải phóng đúng cách, ngay cả khi có
         * lỗi xảy ra. Ngăn ngừa rò rit tài nguyên và bảo vệ dữ liệu khỏi bị
         * hỏng hoặc mất mát.
         * 
         * > Tối ưu hóa trải nghiệm người dùng: Khi ngoại lệ xảy ra, thay vì
         * để ứng dụng bị sập đột ngột, ta có thể cung cấp cho người dùng thông
         * tin hữu ích về vấn đề và cách khắc phục. điều này làm tăng trải 
         * nghiệm người dùng và còn giúp họ không bị gián đoạn trong công việc
         * 
         * > An toàn bảo mật: Không hiểu rõ và xử lí các ngoại lệ liên quan đến
         * bảo mật đúng cách có thể vô tình để lộ các lỗ hổng bảo mật trong ứng
         * dụng của mình
         * 
         * > Phát hiện và ngăn chặn lỗi sớm.
         * 
         * > Tuân thủ các nguyên tắc thiết kế phần mềm.
         * 
         * 
         * 3) Hãy cho biết các từ khóa được sử dụng để xử lý ngoại lệ?
         *  - try : viết trước khối lệnh có thể xảy ra lỗi
         *  - catch : viết trước khối các câu lệnh xử lí lỗi
         *  - throw : dùng để ném ra một ngoại lệ, đối số là 1 đối tượng thuộc 
         *  lớp để bắt ngoại lệ
         *  - finally : viết trước khối mã lệnh luôn muốn thực thi, dù có ngoại
         *  lệ hay không
         * 
         * 
         * 4) Phân biệt giữa lỗi và ngoại lệ?
         * - Lỗi là các vấn đề nghiêm trọng, thường xuất phát từ hệ thống hoặc
         * môi trường, và không thể xử lí được bởi chương trình.
         * - Ngoại lệ là các vấn đề ít nghiêm trọng hơn, có thể được dự đoán
         * trước và xử lí trong mã nguồn để đảm bảo chương trình hoạt động ổn
         * định và có thể tiếp tục hoặc kết thúc một cách an toàn.
         * 
         * 
         * 5) Khi thực hiện việc bắt giữ các ngoại lệ nếu có nhiều mức bắt giữ
         * ngoại lệ thì chúng ta sẽ thực hiện mức nào: từ chi tiết đến tổng
         * quát, hay từ tổng quát đến chi tiết?
         * - Từ chi tiết đến tổng quát.
         * - Để đảm bảo rằng các ngoại lệ cụ thể được xử lí đúng cách trước
         * khi xử lí các ngoại lệ tổng quát hơn
         * 
         * 
         * 6) Câu lệnh nào được dùng để phát sinh ngoại lệ?
         * - Câu lệnh throw
         * 
         * 
         * 7) Loại nào sau đây nên được xử lý theo ngoại lệ và loại nào thì 
         * nên được xử lý bởi các mã lệnh thông thường?
         *
         * a. Giá trị nhập vào của người dùng không nằm trong mức cho phép.
         * b. Tập tin không được viết mà thực hiện viết.
         * c. đối số truyền vào cho phương thức chứa giá trị không hợp lệ.
         * d. đối số truyền vào cho phương thức chứa kiểu không hợp lệ.
         * 
         * - Tình huống nên xử lí bằng mã lệnh thông thường : a,c
         * - Tình huống nên xử lí bằng ngoại lệ : b,d
         * 
         * 
         * 8) Nguyên nhân nào dẫn đến phát sinh ngoại lệ?
         * - Lỗi logic trong mã lệnh
         * - Lỗi dữ liệu nhập vào không hợp lệ
         * - Lỗi liên quan đến tài nguyên hệ thống
         * - Lỗi liên quan đến kết nối mạng hoặc cơ sở dữ liệu
         * - Lỗi xử lí không đúng ngoại lệ trước đó
         * - Lỗi liên quan đến luồng
         * - Lỗi liên quan đến các vấn đề bảo mật
         * 
         * 
         * 9) Khi nào thì ngoại lệ xuất hiện?
         * a. Trong khi tạo mã nguồn
         * b. Trong khi biên dịch 
         * c. Trong khi thực thi chương trình
         * d. Khi yêu cầu đựơc đưa ta bởi người dùng cuối.
         * 
         * Trả lời : c. Trong khi thực thi chương trình
         * 
         * 
         * 10) Khi nào thì khối lệnh trong finally được thực hiện?
         * - Khối finally luôn được thự thi sau khối try và khối catch 
         * bất kỳ nào, bất kể không có ngoại lệ xảy ra.
         * 
         * 
         * 11)Trong namespace nào chứa các lớp liên quan đến việc xử lý các
         * ngoại lệ? Hãy cho biết một số lớp xử lý ngoại lệ quan trọng 
         * trong namespace này?
         * - Namespace chứa các lớp liên quan đến việc xử lý các ngoại lệ là
         * System
         * - Các lớp xử lý ngoại lệ trong System là :
         *      > Exception
         *      > SystemException
         *      > ApplicationException
         *      > ArgumentException
         *      > IO.IOException
         *      > NotSupportedException
         *      > InvalidOperationException
         * 
         */
    }
}
