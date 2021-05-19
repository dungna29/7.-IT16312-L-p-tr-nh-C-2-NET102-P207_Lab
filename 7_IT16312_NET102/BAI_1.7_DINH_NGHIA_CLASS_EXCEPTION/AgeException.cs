using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._7_DINH_NGHIA_CLASS_EXCEPTION
{
    class AgeException:Exception
    {
        public int age { get; set; }

        public AgeException(string? message, int age) : base(message)
        {
            this.age = age;
        }

        public void Detail()
        {
            Console.WriteLine("Tuổi của bạn chưa đủ tuổi vào CLUB C# nhé đợi đến 18 tuổi");
        }
    }
}
