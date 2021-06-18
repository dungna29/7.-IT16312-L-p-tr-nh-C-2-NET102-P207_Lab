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
            ViduAllAny();
        }

        #region 1. Toán tử Where để lọc theo điều kiện trả về 1 danh sách hoặc 1 giá trị sau khi thỏa mãn điều kiện

        public static void ViduWhere()
        {
            //Lọc ra 1 danh sách nhân viên sống tại HN và Quê cũng phải HN
            var lst = (from a in _lstNhanViens
                       where a.ThanhPho == "HN" && a.QueQuan == "HN"
                       select a).ToList();
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

        #region 3. OrderBy sử dụng để sắp xếp danh sách theo một điều kiện cụ thể

        public static void ViDuOrderBy()
        {
            var temp = from a in _lstNhanViens
                       orderby a.TenNV  //ascending || descending
                       select a;
            var temp2 = _lstNhanViens.OrderBy(c => c.TenNV);//Cách viết lambda
            //In ra màn hình để kiểm tra
            foreach (var x in temp)
            {
                x.InRaManHinh();
            }
        }
        //ThenBy và ThenByDescending đi với Orderby và nó là mở rộng để sắp xếp thêm nhiều trường hơn
        public static void ViDuThenBy()
        {
            var temp2 = _lstNhanViens.OrderBy(c => c.TenNV).ThenBy(c => c.ThanhPho);
            var temp3 = _lstNhanViens.OrderBy(c => c.TenNV).ThenByDescending(c => c.ThanhPho);
            foreach (var x in temp2)
            {
                x.InRaManHinh();
            }
        }


        #endregion

        #region 4. GroupBy nhóm các thành phần giống nhau
        public static void ViduGroupBy()
        {
            List<string> lstName = new List<string> { "Trang", "Trang", "Kiều", "Kiều", "A", "B", "C" };
            var tempGroup = from a in lstName
                            group a by a into g
                            select g.Key;//Nhóm các String giống nhau lại

            var lstTemp = from a in _lstSanPhams
                          group a by a.IdTheLoai
                into g
                          select g.Key;

            var lstTemp1 = from a in _lstSanPhams
                           group a by new
                           {
                               a.IdTheLoai,
                               a.GiaNhap
                           }
                into g
                           select new SanPham()
                           {
                               IdTheLoai = g.Key.IdTheLoai,
                               GiaNhap = g.Key.GiaNhap,
                               TenSP = Convert.ToString(g.Sum(c => c.GiaNhap))

                           };
            var lstTemp2 = _lstSanPhams.GroupBy(a => new { a.IdTheLoai, a.GiaNhap })
                .Select(g => new SanPham()
                {
                    IdTheLoai = g.Key.IdTheLoai,
                    GiaNhap = g.Key.GiaNhap,
                    TenSP = Convert.ToString(g.Sum(c => c.GiaNhap))
                });//Sử dụng lambda với câu trên

            //Khi sử dụng Groupby khi cần nhóm các cột dữ liệu giống nhau tạo thành các bản ghi mới và thường đi với các hàm tổng hợp

            //Buổi sau code lại câu đếm số lượng nhân viên sống tại HN sử dụng Groupby
            //Tính tổng giá bán của các sản phẩm có cùng thể loại
        }
        #endregion

        #region 5. Join

        public static void ViduJoin()
        {
            //Hiển thị thông tin sản phẩm bao gồm (Mã, Tên, Mầu sắc, Tên Nhân Viên, Mã Nhân Viên)
            var temp =
                       from a in _lstSanPhams //Truy vấn vào bảng....
                       join b in _lstNhanViens //Inner Join với bảng ...
                       on a.IdNhanVien equals b.Id //Key khóa phụ so sánh với khóa chính
                       join c in _lsttTheLoais
                       on a.IdTheLoai equals c.Id
                       where a.TrangThai == true //Đưa thêm điều kiện vào nếu cần
                       select new
                       {

                           //Select ra kết quả là các cột mới không phải là các cột có sẵn
                           MaSP = a.MaSP,//a là của bảng sản phẩm
                           TenTheLoai = c.TenTheLoai, //c là của bảng thể loại
                           TenSP = a.TenSP,
                           Color = a.MauSac,
                           TenNVTao = b.TenNV,//b là của bảng nhân viên
                           MaNVTao = b.MaNV,
                           TrangThai = a.TrangThai
                       };

            //Cách 2 tự Viết lambada với join
            var temp2 = _lstSanPhams.Join(_lstNhanViens, c => c.IdNhanVien, d => d.Id, (c, d) => new
            {
                //Select ra kết quả là các cột mới không phải là các cột có sẵn
                MaSP = c.MaSP, //a là của bảng sản phẩm
                TenSP = c.TenSP,
                Color = c.MauSac,
                TenNVTao = d.TenNV, //b là của bảng nhân viên
                MaNVTao = d.MaNV,
                TrangThai = c.TrangThai
            });//Tự viết Lambda nếu muốn

            foreach (var x in temp)
            {
                Console.WriteLine($"{x.MaSP} + {x.TenSP} + {x.TenNVTao} + {x.TenTheLoai}");
            }


            //NGoài ra có thể kết hợp Join với GroupBy và các toán tử khác.
        }
        #endregion

        #region 6. Select giúp trả về 1 tập hợp giá trị từ 1 Collection (Ngoài ra tham khảo SelectMany = Tách String về Char)

        public static void ViduSelect()
        {
            var temp1 = from a in _lstNhanViens
                select a; //Trả về 1 lập đối tượng Nhân Viên
            //In thử temp1
            var temp2 = from a in _lstNhanViens
                select a.TenNV;//Trả về 1 Tập giá trị Tên có kiểu String
            //In thử temp2
            foreach (var x in temp2)
            {
                Console.WriteLine(x);//Cách in 1 tập giá trị đơn
            }

            var temp3 = from a in _lstSanPhams
                group a.MauSac by a.MauSac 
                into g
                select g.Key;//Trả về 1 tập giá trị mầu sắc có kiểu String
            foreach (var x in temp3)
            {
                Console.Write(x + " ");//Cách in 1 tập giá trị đơn
            }

            var temp4 = from a in _lstNhanViens
                select new
                {
                    Name = a.TenNV,
                    Addr = a.DiaChi
                };
            foreach (var x in temp4)
            {
                Console.WriteLine(x.Name);
            }
            foreach (var x in temp4.SelectMany(c=>c.Name))
            {
                Console.WriteLine(x);
            }

        }


        #endregion

        #region ALL/ANY
       
        public static void ViduAllAny()
        {
            //All: Kiểm tra xem tất cả các phần tử trong dãy có thỏa mãn thì trả ra true
            //Any: Kiểm tra xem tất cả các phần tử trong dãy chỉ cần có thỏa mãn thì trả ra true
            var temp1 = _lsttTheLoais.All(c => c.TrangThai == true);
            var temp2 = _lsttTheLoais.Any(c => c.TrangThai == true);
            Console.WriteLine("All = " + temp1);
            Console.WriteLine("Any = " + temp2);

            TheLoai theLoaiNew = new TheLoai {Id = 1, MaTheLoai = "TL1", TenTheLoai = "Small", TrangThai = true};
            //Để Contain 1 đối tượng với 1 tập đối tượng yêu cầu lớp Thể loại Implement Interface IEqualityComparer<TheLoai>
            var temp3 = _lsttTheLoais.Contains(theLoaiNew,new TheLoai());
            Console.WriteLine("Contains = " + temp3);
        }
        #endregion

        #region Arrgreation - SUM - MIN - MAX - COUNT - AVERAGE

        public static void ViduArregate()
        {
            //Tính tổng số lượng máy mầu đen mà của hàng đang có
            var soLuongMayMauDen = _lstSanPhams.Count(c=>c.MauSac == "Đen");
            
            //Tính trung bình số tiền trên 1 máy bán ra ở của hàng
            var soTienTrungBinh = _lstSanPhams.Average(c => c.GiaBan);
        }
        

        #endregion
    }
}
