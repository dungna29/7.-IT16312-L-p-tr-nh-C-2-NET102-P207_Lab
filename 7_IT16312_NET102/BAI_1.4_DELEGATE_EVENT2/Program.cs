using System;
using System.Text;

namespace BAI_1._4_DELEGATE_EVENT2
{
    class Program
    {
        public delegate void SuKienNhapSo(int x,int y);

        class UserInput
        {
            public event SuKienNhapSo suKienNhapSo;

            public void getInputValue()
            {
                do
                {
                    Console.WriteLine("Mời bạn nhập số nguyên 1");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mời bạn nhập số nguyên 2");
                    int b = Convert.ToInt32(Console.ReadLine());
                    //Hành động phát đi sự kiện
                    suKienNhapSo?.Invoke(a,b);//Nếu sự kiện nhập số != null

                } while (true);
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

            public void tinhTong(int a,int b)
            {
                Console.WriteLine("Tổng 2 số: {0} + {1} = {2}",a,b,a+b);
            }
        }
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
