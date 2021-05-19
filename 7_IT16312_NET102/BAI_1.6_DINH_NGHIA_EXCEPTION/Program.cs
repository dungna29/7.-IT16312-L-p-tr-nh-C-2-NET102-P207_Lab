using System;
using System.Net.Http.Headers;
using System.Text;

namespace BAI_1._6_DINH_NGHIA_EXCEPTION
{
    class Program
    {
        #region Phần 1: Định nghĩa ra 1 EXCEPTION bên trong 1 phương thức

        static void dangKy(string name, int age)
        {
            if (string.IsNullOrEmpty(name))
            {
                Exception exception = new Exception("Phương không được để null tên");
                throw exception;//Ném ra Exception
            }

            if (age < 18)
            {
                throw new Exception("Chưa đủ tuổi vào club");
            }

            Console.WriteLine("Chào mừng bạn đến với Club C#: " + name + " " + age);
        }
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            try
            {
                dangKy("Kiều",17);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
    }
}
