using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._8_DocGhiDoiTuong
{
    class GenericService<T>
    {
        private List<T> lstTemp;
        public GenericService()
        {
            lstTemp = new List<T>();
        }

        public List<T> GetListObjects()
        {
            return lstTemp;
        }

        public string AddObjectDungna(T objectDungna)
        {
            if (objectDungna != null)
            {
                lstTemp.Add(objectDungna);
                return "Thêm thành công";
            }
            return "Không thành công";
        }

        public string RemoveObjectDungna(T objectDungna)
        {
            if (objectDungna != null)
            {
                lstTemp.Remove(objectDungna);
                return "Thêm thành công";
            }
            return "Không thành công";
        }
        // public T FindObjectDungna(string id)
        // {
        //     if (String.IsNullOrEmpty(id))
        //     {
        //         //Trả ra 1 object T
        //     }
        //     //Trả ra 1 object T
        //     //return ;
        // }

        // public int GetIndexObjectDungna(dynamic id)
        // {
        //     for (int i = 0; i < lstTemp.Count; i++)
        //     {
        //         if (lstTemp[i].)
        //         {
        //             //Nghĩ thêm về cái này
        //         }
        //     }
        // }
    }
}
