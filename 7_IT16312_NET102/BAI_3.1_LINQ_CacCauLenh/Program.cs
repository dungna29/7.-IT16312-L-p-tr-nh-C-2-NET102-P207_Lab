using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BAI_3._1_LINQ_CacCauLenh
{
    class Program
    {
        private static ServiceAll sa = new ServiceAll();
        private static List<NhanVien> _lstNhanViens;
        private static List<SanPham> _lstSanPhams;
        private static List<TheLoai> _lsttTheLoais;
        public Program()
        {
            _lstNhanViens = sa.GetListNhanViens();
            _lstSanPhams = sa.GetListSanPhams();
            _lsttTheLoais = sa.GetListTheLoais();
        }
        static void Main(string[] args)
        {
            //Gọi các ví dụ về lý thuyết lên để chạy
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Program program = new Program();
            ViduWhere();
        }

        #region 1. Toán tử Where để lọc theo điều kiện trả về 1 danh sách hoặc 1 giá trị sau khi thỏa mãn điều kiện

        public static void ViduWhere()
        {
            //Lọc ra 1 danh sách nhân viên sống tại HN và Quê cũng phải HN
            var lst = from a in _lstNhanViens
                      where a.ThanhPho == "HN" && a.QueQuan == "HN"
                      select a;
            var lst1 = _lstNhanViens.Where(c => c.QueQuan == "HN" && c.ThanhPho == "HN").Select(c => c).ToList();
            foreach (var x in lst)
            {
                x.InRaManHinh();
            }
        }
        #endregion

        #region 2. Toán tử OfType để lọc theo điều kiện lọc một phần tử trong tập hợp thành một kiểu được chỉ định

        public static void ViduOfType()
        {
            ArrayList arrTemp = new ArrayList();
            arrTemp.Add(1);
            arrTemp.Add("Mot");
            arrTemp.Add("Hai");
            arrTemp.Add(2);

            var lstTemp1 = from a in arrTemp.OfType<string>()
                select a;
            var lstTemp2 = from a in arrTemp.OfType<int>()
                select a;
            Console.WriteLine("arrTemp.OfType<string>()");
            foreach (var x in lstTemp1)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
            Console.WriteLine("arrTemp.OfType<int>()");
            foreach (var x in lstTemp2)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
        }

        #endregion
    }
}
