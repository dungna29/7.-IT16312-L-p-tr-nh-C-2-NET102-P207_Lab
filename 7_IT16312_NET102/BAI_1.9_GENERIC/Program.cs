using System;
using System.Collections.Generic;
using System.Text;

namespace BAI_1._9_GENERIC
{
    class Program
    {
        #region Tham trị và Tham chiếu
        /*
         * Có hai hình thức truyền tham số cho phương thức khi nó được gọi là tham trị và tham chiếu:    
            + Tham trị là cách thức mặc định khi tham số đó là kiểu giá trị. Có nghĩa là gán tham số bằng một biến, thì giá trị của biến được copy và sử dụng trong phương thức như biến cục bộ, còn bản thân biến bên ngoài không hề ảnh hưởng.

            + Tham chiếu là cách thức mặc định khi tham số đó là kiểu tham chiếu, thì bản thân biến ở tham số sẽ được hàm sử dụng trực tiếp (tham chiếu) chứ không tạo ra một biến cục bộ trong hàm, nên nó có tác động trực tiếp đến biến này bên ngoài.
                - Trong phần này mở rộng thêm, nếu muốn biến kiểu giá trị nhưng được truyền vào phương thức dạng tham chiếu (giống cách thức biến tham chiếu) thì khai báo tham số ở phương thức, cũng như khi gọi cần cho thêm từ khóa ref
         */

        #endregion

        #region GENERIC
        /*
        * ❑ Generic trong C# cho phép định nghĩa một hàm,một lớp mà không cần chỉ ra đối số kiểu dữ liệu là gì.
          ❑ Generic cũng là một kiểu dữ liệu trong C# như int, string, bool,… nhưng nó là một kiểu dữ liệu “tự do”, tùy vào mục đích sử dụng mà nó có thể đại diện cho tất cả các kiểu dữ liệu còn lại.
          ❑ Có thể định nghĩa lớp, interface, phương thức, delegate như là kiểu generic
        */


        #endregion

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            int x = 5, y = 7;
            Console.WriteLine("Giá trị x = {0} và y = {1}", x, y);
            // hoanViThamTri(x,y);
            // Console.WriteLine("Giá trị sau khi sử dụng hoán vị thám trị x = {0} và y = {1}", x, y);
            // hoanViThamChieu(ref x,ref y);
            // Console.WriteLine("Giá trị ở phương hoán vị tham chiếu x = {0} và y = {1}", x, y);
            //Sử dụng Generic
            Console.WriteLine("====Phương thức Generic====");
            //hoanViThamChieuGeneric(ref x,ref y);
            hoanViThamChieuGeneric<int>(ref x, ref y);//Dùng kiểu tường minh
            Console.WriteLine("Giá trị ở phương hoán vị tham chiếu x = {0} và y = {1}", x, y);

            double a = 5.9, b = 4.9;
            //hoanViThamChieuGeneric(ref a, ref b);
            hoanViThamChieuGeneric<double>(ref a, ref b);
            Console.WriteLine("Giá trị ở phương hoán vị tham chiếu a = {0} và b = {1}", a, b);
        }
        public static void hoanViThamTri(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Giá trị ở phương hoán vị tham trị x = {0} và y = {1}", a, b);
        }
        public static void hoanViThamChieu(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        //Khai báo phương thức kiểu Generic
        public static void hoanViThamChieuGeneric<B>(ref B a, ref B b)
        {
            B temp = a;
            a = b;
            b = temp;
        }
    }
}

