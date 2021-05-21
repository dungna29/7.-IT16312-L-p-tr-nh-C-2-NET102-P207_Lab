using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._1_CLASS_GENERIC
{
    class PolyGeneric<T>
    {
        private T[] arrs;//Mảng chưa xác định kiểu

        public PolyGeneric(int size)
        {
            //Contructor truyền kích thước mảng và khởi tạo
            arrs = new T[size];
        }

        public T[] Arrs
        {
            get => arrs;
            set => arrs = value;
        }

        //Phương thức trả về lấy 1 giá trị trong mảng ra
        public T GetValueByIndex(int index)
        {
            if (index<0 || index >= arrs.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return arrs[index];
        }

        //Gán giá trị vào mảng
        public void setValueByIndex(int index, T value)
        {
            if (index < 0 || index >= arrs.Length)
            {
                throw new IndexOutOfRangeException();
            }
            arrs[index] = value;
        }
    }
}
