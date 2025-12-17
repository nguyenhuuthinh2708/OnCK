using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_LAN2
{
    internal class Bai_2
    {
        static void Main(string[] args)
        {
          Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập tên của bạn: ");
            string ten = Console.ReadLine();
            double diemgk = 0;
            double diemck = 0;
            Console.Write("Nhập điểm giữa kỳ: ");
            string s = Console.ReadLine();
            while (!double.TryParse(s, out diemgk) || diemgk < 0 || diemgk < 10)
            {
                Console.Write("Điểm không hợp lệ. Nhập lại: ");
                s = Console.ReadLine();
            }
            Console.Write("Nhập điểm cuối kỳ: ");
            string a = Console.ReadLine();
            while (!double.TryParse(a, out diemck) || diemck < 0 || diemck < 10)
            {
                Console.Write("Điểm không hợp lệ. Nhập lại: ");
                a = Console.ReadLine();
            }
            Console.WriteLine($"Tên của bạn là {ten}");
            Console.WriteLine($"Điểm giữa kỳ là {diemgk}");
            Console.WriteLine($"Điểm cuối kỳ là {diemck}");
            double tong = diemgk * 0.4 + diemck * 0.6;
            if(tong >= 5)
            {
                Console.WriteLine("Đậu");
            }
            else
            {
                Console.WriteLine("Rớt");
            }
            Console.ReadKey();
        }
    }
}
