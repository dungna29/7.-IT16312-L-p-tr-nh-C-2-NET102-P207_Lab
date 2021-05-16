using System;
using System.Text;

namespace BAI_1._2_DELEGATE
{
    //Khai báo 1 delegate bên ngoài class hoặc bên trong class
    public delegate void ShowMessage(string message);
    class Program
    {
        #region Bài về Delegate
        static void Info1(string s)
        {
            string temp = "FPT ";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(temp + s);
            Console.ResetColor();
        }
        static void Info2(string s)
        {
            string temp = "FPT ";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(temp + s);
            Console.ResetColor();
        }
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            #region Phần 1: Khởi tạo null

            Console.WriteLine("======Phần 1: Khởi tạo null=======");
            ShowMessage showMessage = null;//Khởi tạo delegate = null
            showMessage = Info1;//trỏ đến phương thức
            //Sử dụng delegate
            //Info1("Xin chào các bạn đang học delegate C#2"); Ở C#1 gọi phương thức thẳng
            showMessage(" Xin chào các bạn đang học delegate C#2");
            showMessage?.Invoke(" Xin chào các bạn đang học delegate C#2");//? Kiểm tra xem delegate có null hay không thì mới tham chiếu.

            #endregion

            #region Phần 2: Khởi tạo
            Console.WriteLine("======Phần 2: Khởi tạo=======");
            ShowMessage showMessage2 = new ShowMessage(Info1);//Tham chiếu đến phương thức info1
            showMessage2("Chào các bạn .NET học Delegate");
            #endregion

            #region Phần 3: Multicast Delegate
            Console.WriteLine("======Phần 3: Multicast Delegate=======");
            ShowMessage showMessage3 = new ShowMessage(Info1);
            ShowMessage showMessage4 = new ShowMessage(Info2);
            ShowMessage Multicast = showMessage3 + showMessage4;
            Multicast += showMessage3;
            Multicast += showMessage4;
            Multicast("Chào mừng học được Multicast rồi");

            Console.WriteLine("=====Trừ trong Delegate=======");
            Multicast = Multicast - showMessage3;//Loại bỏ bớt 1 phương trong delegate dùng dấu trừ
            Multicast -= showMessage3;
            Multicast("Chào mừng học được Multicast rồi");
            #endregion

            #region Phần 4: Delegate Callback Method
            Console.WriteLine("======Phần 4: Delegate Callback Method=======");
            DelegateCallback delegateCallback = new DelegateCallback(showMes);
            CallBack(delegateCallback);//Gọi phương thức truyền vào 1 delegate đang trỏ đến 1 phương thức khác
            #endregion
        }

        #region Phần 4: Delegate Callback Method

        public delegate void DelegateCallback(string mes);

        public static void showMes(string mes)
        {
            Console.WriteLine("Thông báo: " + mes);
        }

        public static void CallBack(DelegateCallback delegateCallback)
        {
            Console.WriteLine("Mời bạn nhập thông báo: ");
            var mes = Console.ReadLine();
            delegateCallback(mes);
            //showMes(mes);//Gọi theo kiểu C#1
        }

        #endregion
    }
}
