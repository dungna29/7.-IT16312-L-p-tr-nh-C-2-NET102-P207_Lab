using System;
using System.Text;

namespace BAI_1._4_DELEGATE_EVENT
{
    class Program
    {
        #region DELEGATE EVENT
        /*
         * ❑Sự kiện (Event) là các hành động, ví dụ như nhấn phím, click, di chuyển chuột...
           ❑Trong C#, Event là một đối tượng đặc biệt của  Delegate, nó là nơi chứa các phương thức, các phương thức này sẽ được thực thi khi sự kiện xảy ra
           ❑Đặc điểm của event:
               ❖Được khai báo trong các lớp hoặc interface
               ❖Được khai báo là abstract hoặc sealed, virtual
               ❖Được thực thi thông qua delegate
           ❑Tạo và sử dụng event
               ❖Đinh nghĩa delegate cho event
               ❖Tạo event thông qua delegate
               ❖Đăng ký để lắng nghe và xử lý event
               ❖Kích hoạt event
         */
        //Bước 1: Tạo 1 delegate
        delegate void UpdateNameHandler(string studentID);

        //Bước 2: Tạo 1 Class Student
        class Student
        {
            public event UpdateNameHandler StudentIDchanged;
            private string studentID;
            public string StudentID
            {
                get => studentID;
                set
                {
                    studentID = value;
                    //Kiểm tra để gọi ra sự kiện mỗi khi tác động vào thuộc tính
                    if (StudentIDchanged != null)
                    {
                        StudentIDchanged(studentID);
                    }
                }
            }
        }

        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Student st = new Student();
            st.StudentIDchanged += St_StudentIDchanged;//Khi gõ += nó sẽ zen cho 1 phương thức của sự kiện 
            st.StudentID = "PH00555";
            Console.WriteLine("Mã sinh viên mới: " + st.StudentID);
            st.StudentID = "PH00999";
            Console.WriteLine("Mã sinh viên mới: " + st.StudentID);
        }

        private static void St_StudentIDchanged(string studentID)
        {
            Console.WriteLine("Mã bị thay đổi thành: " + studentID);
        }
    }
}
