using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._1_ONTAP_CSHARP1_CRUD_NANGCAO
{
    class ServiceStudent:IServiceStudent
    {
        private List<Student> _lstStudents;
        private string _input;
        private Student _student;
        public ServiceStudent()
        {
            _lstStudents = new List<Student>();
            // Student st1 = new Student(1, "Trang", "0123", 0);
            // Student st2 = new Student(2, "Kiều", "0123", 0);
            // Student st3 = new Student(3, "Long", "0123", 0);
            // Student st4 = new Student(4, "Phương", "0123", 0);
            // Student st5 = new Student(5, "Hoàng", "0123", 0);
            // _lstStudents.Add(st1);
            // _lstStudents.Add(st2);
            // _lstStudents.Add(st3);
            // _lstStudents.Add(st4);
            // _lstStudents.Add(st5);
        }

        public void addStudent()
        {
            do
            {
                Console.WriteLine("Bạn muốn thêm bao nhiêu SV: ");
                _input = Console.ReadLine();
                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    _student = new Student();//Khởi tạo đối tượng thì mới sử dụng được
                    _student.Id = i;
                    Console.WriteLine("Mời bạn nhập tên: ");
                    _student.Name = Console.ReadLine();
                    Console.WriteLine("Mời bạn nhập sdt: ");
                    _student.Phone = Console.ReadLine();
                    Console.WriteLine("Mời bạn nhập giới tính 1 = Nam || 0 Nữ: ");
                    _student.Sex = Convert.ToInt32(Console.ReadLine());
                    _lstStudents.Add(_student);//Thêm đối tượng vào danh sách
                }
                Console.WriteLine("Bạn có muốn nhập tiếp hay không? y/n: ");
                _input = Console.ReadLine();
            } while (!(_input == "n"));
        }

        public void removeStudentById()
        {
            #region Cách 1 phổ thông
            // Console.WriteLine("Mời bạn nhập vào mã SV: ");
            // _input = Console.ReadLine();
            // for (int i = 0; i < _lstStudents.Count; i++)
            // {
            //     if (_lstStudents[i].Id == Convert.ToInt32(_input))
            //     {
            //         _lstStudents[i].inRaManHinh();
            //         _lstStudents.RemoveAt(i);
            //         Console.WriteLine("Chúc mừng xóa thành công");
            //         return;
            //     }
            // }
            // Console.WriteLine("Mã sinh viên bạn tìm không tồn tại");
            #endregion

            //Cách 2:
            _lstStudents.RemoveAt(getIndexStudentByID(getInputValue("mã sinh viên: ")));

        }
        public void findStudentById()
        {
            #region Cách 1 phổ thông
            // Console.WriteLine("Mời bạn nhập vào mã SV: ");
            // _input = Console.ReadLine();
            // for (int i = 0; i < _lstStudents.Count; i++)
            // {
            //     if (_lstStudents[i].Id == Convert.ToInt32(_input))
            //     {
            //         _lstStudents[i].inRaManHinh();
            //         Console.WriteLine("Đã tìm thấy");
            //         return;
            //     }
            // }
            // Console.WriteLine("Mã sinh viên bạn tìm không tồn tại");
            #endregion
            //Cách 2:
            _lstStudents[(getIndexStudentByID(getInputValue("mã sinh viên: ")))].inRaManHinh1();
        }

        public void getLstStudents()
        {
            foreach (var x in _lstStudents)
            {
                x.inRaManHinh1();
            }
        }

        private string getInputValue(string mess)
        {
            Console.WriteLine("Mời bạn nhập " + mess);
            return Console.ReadLine();
        }

        //Phương thức trả về dạng số nguyên và trả về vị trí của đối tượng trong danh sách
        private int getIndexStudentByID(string idStudent)
        {
            for (int i = 0; i < _lstStudents.Count; i++)
            {
                if (_lstStudents[i].Id == Convert.ToInt32(idStudent))
                {
                    return i;
                }
            }
            return -1;
        }

        public List<Student> getListStudent(string nganh)
        {
            return null;
        }
    }
}
