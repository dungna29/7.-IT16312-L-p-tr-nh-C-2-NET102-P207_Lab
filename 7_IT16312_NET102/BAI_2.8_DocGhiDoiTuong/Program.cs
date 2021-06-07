using System;
using System.IO;
using System.Linq;
using System.Net.Mime;

namespace BAI_2._8_DocGhiDoiTuong
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\Google Driver Dungna29FPT\8. Demo\Demo C#2\SM21_Block1\7.-IT16312-L-p-tr-nh-C-2-NET102-P207_Lab\7_IT16312_NET102\BAI_2.8_DocGhiDoiTuong\DataDungna.bin";
            StudentServiceGhiFileDocFile ss = new StudentServiceGhiFileDocFile();
            Console.WriteLine(ss.GhiFile(ss.GetFakeStudents(),path));//Ghi file
            foreach (var x in ss.DocFile(path))
            {
                x.inRaManHinh();
            }
        }
    }
}
