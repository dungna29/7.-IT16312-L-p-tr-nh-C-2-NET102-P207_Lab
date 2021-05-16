using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._1_ONTAP_CSHARP1_CRUD_NANGCAO
{
    class Student: Person//Khi kế thừa abstract thì sẽ phải kế thừa tất cả các phương thức abstract mà lớp cha có
    {
        private string msv;

        public Student()
        {
            
        }

        public Student(string msv)
        {
            this.msv = msv;
        }
        public string Msv
        {
            get => msv;
            set => msv = value;
        }


        //Khi kế thừa các phương abstract sẽ có body code phía bên của lớp con
        public override void inRaManHinh1()
        {
            Console.WriteLine("Mã: {0} Tên: {1} Điện thoai: {2} Giới Tính: {3}", Id, Name, Phone, Sex == 1 ? "Nam" : "Nữ");
        }

        public override void inRaManHinh2()
        {
            
        }
    }
}
