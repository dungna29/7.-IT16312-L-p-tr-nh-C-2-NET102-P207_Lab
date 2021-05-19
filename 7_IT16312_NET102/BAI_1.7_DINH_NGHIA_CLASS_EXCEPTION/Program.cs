using System;
using System.Text;

namespace BAI_1._7_DINH_NGHIA_CLASS_EXCEPTION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            try
            {
                dangKy("Phương", 17);
            }
            catch (NameException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (AgeException e)
            {
                Console.WriteLine(e.Message);
                e.Detail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void dangKy(string name,int age)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NameException("Tên không được phép rỗng");
            }

            if (age<18)
            {
                throw new AgeException("Tuổi bạn chưa đủ vào club C#", age);
            }

            Console.WriteLine("Chúc mừng đến với câu club C#");
        }
    }
}
