using System;
using System.Text;

namespace BAI_1._0_ONTAP_CSHARP1_CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.InputEncoding = Encoding.UTF8;
            ServiceStudent serviceStudent = new ServiceStudent();
            while (true)
            {
                serviceStudent.removeStudentById();
                serviceStudent.getLstStudents();
            }

        }
    }
}
