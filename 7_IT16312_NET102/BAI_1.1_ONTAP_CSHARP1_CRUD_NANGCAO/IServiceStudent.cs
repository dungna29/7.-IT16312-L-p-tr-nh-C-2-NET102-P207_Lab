using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._1_ONTAP_CSHARP1_CRUD_NANGCAO
{
    interface IServiceStudent
    {
        //Không thể sử dụng từ khóa private
        //Cần comment diễn giải các chức năng của đối tượng khi đưa lên interface
        public void addStudent();//Đây là chức năng thêm sinh viên
        public void removeStudentById();
        public void findStudentById();
        public void getLstStudents();

        public List<Student> getListStudent(string nganh);//Phương thức này hiện tại không nằm ở đâu
    }
}
