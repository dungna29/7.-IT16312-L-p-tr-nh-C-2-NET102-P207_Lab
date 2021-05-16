using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._1_ONTAP_CSHARP1_CRUD_NANGCAO
{
    interface IService1
    {
        void method1();
    }
    interface IService2
    {
        void method2();
    }
    interface IService3
    {
        void method3();
    }
    //Implement nhiều Interface
    //Cho phép đa kế thừa với interface
    class Service:Person, IService1, IService2, IService3
    {
        public void method1()
        {
            throw new NotImplementedException();
        }

        public void method2()
        {
            throw new NotImplementedException();
        }

        public void method3()
        {
            throw new NotImplementedException();
        }

        public override void inRaManHinh1()
        {
            throw new NotImplementedException();
        }

        public override void inRaManHinh2()
        {
            throw new NotImplementedException();
        }
    }
}
