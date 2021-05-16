using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._1_ONTAP_CSHARP1_CRUD_NANGCAO
{
    //Đã sử dụng abstract thì phải có phương thức abstract
    abstract class Person //Lớp cha abstract
    {
        private int id;
        private string name;
        private string phone;
        private int sex;

        public Person()
        {
            
        }

        protected Person(int id, string name, string phone, int sex)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.sex = sex;
        }

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

        //Phương thức abstract không có body code
        abstract public void inRaManHinh1();
        abstract public void inRaManHinh2();
    }
}
