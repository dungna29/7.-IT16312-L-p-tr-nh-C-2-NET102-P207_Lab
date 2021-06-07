using System;
using System.Collections.Generic;

namespace BAI_2._5_NULLABLE_TYPED
{
    class Program
    {
        /*
         * 1. Từ khóa null
         *    + null là một giá trị cố định nó biểu thị không có đối tượng nào cả, có nghĩa là biến có giá trị null không có tham chiếu (trỏ) đến đối tượng nào (không có gì).
           
              + null chỉ có thể gán được cho các biến kiểu tham chiếu (biến có kiểu dữ liệu là các lớp), không thể gán null cho những biến có kiểu dữ liệu dạng tham trị như int, float, bool ...
           
         */

        /*
         *2. Sử dụng nullable
         *    + Nếu bạn muốn sử dụng các kiểu dữ liệu nguyên tố như int, float, double ... như là một kiểu dữ liệu dạng tham chiếu, có thể gán giá trị null cho nó, có thể sử dụng như đối tượng ... thì khai báo nó có khả năng nullable, khi biến nullable có giá trị thì đọc giá trị bằng truy cập thành viên .Value, cách làm như sau:
         *    + Khi khai báo biến có khả năng nullable thì thêm vào ? sau kiểu dữ liệu      
         */
        class ClassA
        {
            public void method1()
            {
                Console.WriteLine("Method 1 Class A");
            }
        }
        static void Main(string[] args)
        {
            #region Phần 1 Null
            // ClassA classA1, classA2;
            // classA1 = new ClassA();    // classA1 tham chiếu (gán) bằng một đối tượng
            // classA2 = classA1;          // classA1, classA2 cùng tham chiếu một đối tượng
            //
            // classA1 = null;             // classA1 gán bằng null =>  không trỏ đến đối tượng nào
            // classA2.method1();         // classA2 có trỏ đến đến tượng, nên có thể truy cập các thành viên của đối tượng
            // classA1.method1();         // classA1 không trỏ đến đối tượng nào, nên truy cập thành viên sẽ lỗi
            //
            // int temp1 = 10;             //  int là kiểu tham trị, nó có thể gán giá trị cho biến temp1 (10)
            //                             //int temp2 = null;           //  lỗi - kiểu tham  trị  không được gán null hay bằng tham chiếu đến đến tượng


            #endregion
            #region Phần 2 nullable  Khi khai báo biến có khả năng nullable thì thêm vào ? sau kiểu dữ liệu
            //1. Không thể gán giá trị null cho biến kiểu int theo đúng định nghĩa
            // int temp;
            // temp 1 = null;
            int? temp2;                 //Hoặc Nullable<int> temp2;

            temp2 = null;               //Có thể gán null 
            temp2 = 10;                 //Gán giá trị như biến bình thường
            if (temp2 != null)
            {
                int value = temp2.Value; //Lấy giá trị trong biến nullable
            }
            #endregion

            /*2.  NULLABLE TYPED
                  + Cú pháp: 
                      - Nullable<T> tên biến;
                      - T? tên biến;
                  + Cần gán gia trị cho biến khi khai báo nếu không sẽ bị lỗi và nên kiểm tra giá tị trước khi dùng bằng HasValue
                  + Dùng phương thức GetValueOrDefault() để lấy giá mặc định của kiểu dữ liệu
                  + Dùng toán tử ?? thực hiện gán Nullable Type cho Non-Nullable Type

           */
            Nullable<int> temp3 = null;
            Nullable<int> temp4 = 11;
            int? temp5 = 100;
            int?[] arr = new int?[5];

            if (temp4.HasValue) //Kiểm tra giá trị trước dùng
            {
                Console.WriteLine(temp3.Value);
            }
            else
            {
                Console.WriteLine("Giá trị là empty");
            }
            //GetValueOrDefault() phương thức lấy giá trị mặc định của kiểu dữ liệu
            Console.WriteLine(temp3.GetValueOrDefault());//Giá trị mặc định = 0

            //Toán tử ?? thực hiện gán Nullable Type cho Non-Nullable type
            int? temp6 = null;
            int temp7 = temp6 ?? 0;//Temp7 = temp6 nếu temp6 khác null, temp7 = 0 nếu temp6 = null
        }


    }
}
