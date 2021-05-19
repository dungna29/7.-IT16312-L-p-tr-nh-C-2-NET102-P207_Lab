using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._7_DINH_NGHIA_CLASS_EXCEPTION
{
    class NameException:Exception
    {
        public NameException(string? message) : base(message)
        {
        }
    }
}
