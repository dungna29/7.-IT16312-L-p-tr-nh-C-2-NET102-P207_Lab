using System;
using System.Text;

namespace BAI_1._4_DELEGATE_EVENT3
{
    class Program
    {
        /*
      * Ngoài ra trong C# có sẵn chuẩn tạo ra sẵn sự kiện Delegate
      */

        #region EventHandler bổ sung kiến thức có sẵn trong C#
        class UserInput
        {
            public event EventHandler suKienNhapSo;// Tương đương delegate void ten(object sender, EventArgs args)

            public void getInputValue()
            {
                do
                {
                    Console.WriteLine("Mời bạn nhập số nguyên 1");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mời bạn nhập số nguyên 2");
                    int b = Convert.ToInt32(Console.ReadLine());
                    //Hành động phát đi sự kiện
                    suKienNhapSo?.Invoke(this,new UserInput1(a,b));//Nếu sự kiện nhập số != null
                } while (true);
            }
        }

        class UserInput1: EventArgs
        {
            //prop + tab
            public int a { get; set; }
            public int b { get; set; }

            public UserInput1(int a,int b)
            {
                this.a = a;
                this.b = b;
            }
        }
        //Lớp nhận sự kiện
        class TinhTong
        {
            public void thiHanh(UserInput userInput)
            {
                //Không được thực hiện phép gán mà phải thực phép += hoặc -=
                userInput.suKienNhapSo += tinhTong;//Khi sự kiện nhập số xảy ra thì thi thành tính tổng
            }

            public void tinhTong(object sender, EventArgs e)
            {
                UserInput1 userInput1 = (UserInput1)e;//Chuyển e về đối tượng để đọc được giá trị truyền vào
                var a = userInput1.a;
                var b = userInput1.b;

                Console.WriteLine("Tổng 2 số: {0} + {1} = {2}", a, b, a + b);
            }
        }

        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //PHát đi sự kiện
            UserInput userInput = new UserInput();

            //Nhận sự kiện
            TinhTong tinhTong = new TinhTong();
            tinhTong.thiHanh(userInput);

            //Thực thi tác động vào sự kiện
            userInput.getInputValue();
        }
    }
}
