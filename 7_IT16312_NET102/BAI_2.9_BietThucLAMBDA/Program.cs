using System;
using System.Linq;
using System.Threading.Channels;

namespace BAI_2._9_BietThucLAMBDA
{
    class Program
    {
        #region Lamda định nghĩa

        /*
         * Biểu thức lambda còn gọi là biểu thức (Anonymous), một biểu thức khai báo giống phương thức nhưng thiếu tên. Cú pháp để khai báo biểu thức lambda là sử dụng toán dử => như sau:
         
            Công thức 1:
                (tham_số) => biểu_thức;

            Công thức 2:
            (tham_số) =>
                {
                   các câu lệnh
                   Sử dụng return nếu có giá trị trả về
                }            

         */
        //Ví dụ 1: sử dụng Delegate với lambda khai báo phương thức nặc danh
        delegate int TinhTong(int a, int b);

        public static void ViDu1()
        {
            int a = 9, b = 10;
            TinhTong tinhTong = (int x, int y) =>
            {
                return x + y * 1000;
            };
            TinhTong tinhTong2 = (int x, int y) => x + y * 1000;
            Console.WriteLine(tinhTong2(a, b));
        }

        //Ví dụ 2: Khai báo 1 phương thức kiểu lambda
        static int PhepNhan(int x, int y) => x * y;

        //Ví dụ 3:
        public static void ViDu3()
        {
            // Array.ForEeach<T>(T[] array, Action<T> action)
            int[] arrNumbers = {1, 2, 3, 4, 5, 6};
            //Cách 1:
            Array.ForEach(arrNumbers, delegate(int x) {Console.WriteLine(x + " ");});

            //Cách 2:
            Array.ForEach(arrNumbers,x=>Console.WriteLine(x + " "));

            //Cách 3:
            foreach (var x in arrNumbers) Console.WriteLine(x + " ");
        }
        #endregion
        #region Một số quy tắc khi sử dụng lambda

        delegate void ChaoBan1(string name);
        delegate void ChaoBan2();
        delegate void ChaoBan3(string name1, string name2, string name3);
        delegate int TinhToan(int a, int b);
        delegate bool Check1(int a, int b);
        static void ViDu4()
        {
            //1. Không quan tâm đến kiểu dữ liệu đầu vào
            ChaoBan1 chao1 = (string temp) => { Console.WriteLine("Chào bạn " + temp); };
            ChaoBan1 chao2 = (temp) => { Console.WriteLine("Chào bạn " + temp); };

            //2. Để trống nếu không có tham số ()
            ChaoBan2 chao3 = () => { Console.WriteLine("Chào bạn"); };

            //3. Nếu chỉ có một tham số bỏ luôn dấu ()
            ChaoBan1 chao4 = temp => { Console.WriteLine("Chào bạn " + temp); };

            //4. Nếu có nhiều tham số ngăn cách bằng dấu ,
            ChaoBan3 chao5 = (x, y, z) => { Console.WriteLine("Chào bạn " + x + y + z); };

            //5. Nếu phương thức chỉ có 1 câu lệnh thực thi bỏ dấu {}
            ChaoBan3 chao6 = (x, y, z) => Console.WriteLine("Chào bạn " + x + y + z);

            //6. Đối với phương thức return
            TinhToan tinhToan1 = (x, y) => { return x + y * 100; };
            Check1 check1 = (x, y) => { return x > 4 && y > 4; };

        }
        //Ngoài ra các bạn có thê tìm hiểu và áp dụng thêm

        #endregion
        static void Main(string[] args)
        {
           
        }
    }
}
