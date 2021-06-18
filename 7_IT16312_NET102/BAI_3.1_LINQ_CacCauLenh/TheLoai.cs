using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3._1_LINQ_CacCauLenh
{
    class TheLoai:IEqualityComparer<TheLoai>
    {
        public int Id { get; set; }
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public bool TrangThai { get; set; }
        public bool statuEdit { get; set; }

        public void InRaManHinh()
        {
            Console.WriteLine($"{Id} | {MaTheLoai} | {TenTheLoai} | {TrangThai}");
        }

        public bool Equals(TheLoai x, TheLoai y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.Id == y.Id && x.MaTheLoai == y.MaTheLoai && x.TenTheLoai == y.TenTheLoai && x.TrangThai == y.TrangThai;
        }

        public int GetHashCode(TheLoai obj)
        {
            return HashCode.Combine(obj.Id, obj.MaTheLoai, obj.TenTheLoai, obj.TrangThai);
        }
    }
}
