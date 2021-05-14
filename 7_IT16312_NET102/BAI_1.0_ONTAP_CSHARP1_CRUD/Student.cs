using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._0_ONTAP_CSHARP1_CRUD
{
    class Student
    {
        //Phần 1: Liệt kê tất cả các thuộc tính mà đối tượng phải có
        private int id;
        private string name;
        private string phone;
        private int sex;

        //Phần 2: Khởi tạo 2 contructor tại thời điểm học
        //1. Contructor không tham số: ctor + tab
        public Student()
        {
            //Console.WriteLine("Đây là text của contructor");
        }
        //2. Contructor có tham số sẽ giúp đối tượng có giá trị ngay khi khởi tạo
        /*
         Nếu bạn nào dùng resharper ctorf + tab
         Đối với các bạn không cài resharper muốn gọi contructor có tham số:
            1. Chuột phải vào Class đối tượng chọn Quick Actions....
            2. Generate Contructor
         */
        public Student(int id1, string name, string phone, int sex)
        {
            id = id1;
            this.name = name;
            this.phone = phone;
            this.sex = sex;
        }

        //Phần 3:Triển khai property của thuộc tính
        /*
         * Bôi đen vào các thuộc tính đang có hiện tại của lớp sau đó chuột phải --> Quick Actions....
         * Chọn Encapsulate fields
         *
         * Đối với các bạn resharper alt + insert --> properties
         */
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        public int Sex
        {
            get => sex;
            set => sex = value;
        }

        //Phần 4: Các phương thức của đối tượng
        public void inRaManHinh()
        {
            Console.WriteLine("Mã: {0} Tên: {1} Điện thoai: {2} Giới Tính: {3}",id,Name,phone,sex == 1?"Nam":"Nữ");
        }
    }
}
