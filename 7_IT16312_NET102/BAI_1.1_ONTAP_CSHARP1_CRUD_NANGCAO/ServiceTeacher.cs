using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._1_ONTAP_CSHARP1_CRUD_NANGCAO
{
    class ServiceTeacher:IServiceTeacher
    {
        private IServiceStudent _iServiceStudent = new ServiceStudent();
        //Code các chức năng của Teacher ở đây
        public ServiceTeacher()
        {
            
        }

        public void method1()
        {
            _iServiceStudent.getListStudent("UDPM");
        }
    } 
}
