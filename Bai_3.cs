using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_LAN2
{
    internal class Bai_3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên dương");
            int so = int.Parse(Console.ReadLine());
            if (so % 9 == 0 && so % 7 == 0)
            {
                Console.WriteLine($"{so} là bội của 9 và 7");
            }
            else
            {
                Console.WriteLine($"{so} không phải bội của 9 và 7");
            }
            Console.ReadKey();
        }
    }
}
