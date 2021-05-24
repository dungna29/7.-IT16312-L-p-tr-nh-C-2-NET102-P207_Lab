using System;

namespace BAI_2._3_PARTIAL_CLASS_METHOD
{
    class Program
    {
        #region Phần 1: Partial định nghĩa
        /*
     * 1 - Partial là kỹ thuật phân chia code lưu ở nhiều file mã nguồn khác nhau, khi biên dịch thì nó tổng hợp lại thành một. Kỹ thuật này dùng với từ khóa partial khi định nghĩa lớp.
     *
     * 2 - Kỹ thuật phân chia code ra thành nhiều file bạn có thể gặp khi:       
        - Dự án lớn, những lớp mà mã nguồn dài cần chia tách ra thành nhiều file có thể đơn giản là gộp các chức năng giống nhau thành một file, hoặc làm việc nhóm mỗi lập trình viên làm việc trên một file - sau đó khi biên dịch nó tự tổng hợp thành một class hoàn chỉnh
        - Khi làm việc với các IDE, nó có thể phát sinh code một cách tự động, code được thêm vào lớp được lưu ở một file mã nguồn khác mà không cần chỉnh sửa file code ban đầu (nếu lập trình C# WPF bạn nhận thấy IDE phát sinh nhiều thành phần giao diện ở dạng này)

      3 - Lưu ý khi dùng partial
        - Có một số quy tắc cần lưu ý khi bạn để code của một thành phần ở nhiều nơi với partial
        - Trong định nghĩa ở tất cả các phần phải có từ khóa partial

     */


        #endregion
        static void Main(string[] args)
        {
            /*
             * Phần 1: Sử dụng
             * Khi sử dụng đối tượng ClassA hoàn toàn bình thường như class khác chẳng qua nó được phân tách thành 2 file Class khác nhau
             */
            ClassA classA = new ClassA();
            classA.variableA = "";
            classA.variableB = 1;
            classA.variableC = " ";
            classA.variableD = 2;
            classA.method1();
            classA.method2();//Class B
            classA.method3();//Phương thức partial

            /*
             * Phần 2: Class lồng nhau kiểu Nested
             * Lớp Nested được khai báo, định nghĩa trong lớp Container, nếu phạm vị lớp public, thì bên ngoài sử dụng lớp con này bằng cách chỉ rõ Container.Nested
             */
            ClassNested.ClassD classD = new ClassNested.ClassD();
            classD.getYears();

        }
    }
}
