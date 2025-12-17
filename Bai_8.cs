using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_LAN2
{
    internal class Bai_8
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập chuỗi ký tự");
            string chuoi = Console.ReadLine();
            int chucai = 0;
            int chuso = 0;
            int kytudacbiet = 0;

            foreach (char i in chuoi)
            {
                if (char.IsLetter(i))
                {
                    chucai++;
                }
                else if (char.IsDigit(i))
                {
                    chuso++;
                }
                else
                    kytudacbiet++;
            }
            Console.WriteLine($"Số chữ cái {chucai}");
            Console.WriteLine($"Số chữ số {chuso}");
            Console.WriteLine($"Số chữ ký tự {kytudacbiet}");
            Console.ReadKey();
        }
    }
}
