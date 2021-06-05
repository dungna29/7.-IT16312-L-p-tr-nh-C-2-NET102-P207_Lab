using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._8_DocGhiDoiTuong
{
    class StudentServiceGhiFileDocFile
    {
        private List<Student> _lstStudents;
        private FileStream _fs;
        private BinaryFormatter _bf;
        public StudentServiceGhiFileDocFile()
        {
            _lstStudents = new List<Student>();
        }
        public List<Student> GetFakeStudents()
        {
            return new List<Student>()
            {
                new Student(1,"PH001111","A"),
                new Student(2,"PH001112","B"),
                new Student(3,"PH001113","C"),
                new Student(4,"PH001114","D"),
               
            };
        }

        public string GhiFile(List<Student> lstStudents, string path)//Ghi vào file dữ liệu gì và lưu ở đâu
        {
            try
            {
                _fs = new FileStream(path, FileMode.Create);
                _bf = new BinaryFormatter();
                _bf.Serialize(_fs, lstStudents);//Serialize Tuần tự hóa hoặc tuần tự hóa là quá trình dịch cấu trúc dữ liệu hoặc trạng thái đối tượng sang định dạng có thể được lưu trữ hoặc truyền và tái tạo lại sau này.
                _fs.Close();
                return "Ghi file thành công";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return "Ghi file thất bại rồi";
        }
        public List<Student> DocFile(string path)//Đọc file nào ở đâu
        {
            try
            {
                _lstStudents = new List<Student>();
                _fs = new FileStream(path, FileMode.Open);
                _bf = new BinaryFormatter();
                var data = _bf.Deserialize(_fs);//Đọc đối tượng lên
                _lstStudents = (List<Student>)data;//Gán lại List object cho List Student
                _fs.Close();
                return _lstStudents;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return null;
        }
    }
}
