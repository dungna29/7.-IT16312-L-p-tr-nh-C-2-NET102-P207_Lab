using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BAI_2._3_PARTIAL_CLASS_METHOD
{
    partial class ClassA//File class B đổi tên và thêm partial 
    {
        public string variableC { get; set; }
        public double variableD { get; set; }

        public void method2()
        {
            Console.WriteLine("Đây là method 2");
        }

        public partial void method3()
        {
            //Đây là nơi triển khai method3 ở file Class A
        }
    }
}
