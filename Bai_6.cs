using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_LAN2
{
    internal class Bai_6
    {
        static void Main (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("CHÀO MỪNG BẠN ĐÉN VỚI TRÒ CHƠI ĐOÁN SỐ");
            Random random = new Random();
            int maychon = random.Next(1,101);
            int nguoichon;
            Console.WriteLine("Mời bạn nhập số đã đoán");
            nguoichon = int.Parse(Console.ReadLine());
            do
            {
               for (int i = 0; i< 7; i++)
                {
                    if(nguoichon == maychon)
                    {
                        Console.WriteLine("Bạn đã chọn đúng");
                        break;
                    }
                    else if (nguoichon > maychon)
                    {
                        Console.WriteLine("Số bạn chọn lớn hơn số máy chọn. Nhập lại");
                        nguoichon = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Số bạn chọn bé hơn số máy chọn. Nhập lại");
                        nguoichon = int.Parse(Console.ReadLine());
                    }    
                }
                Console.WriteLine($"Số máy chọn là {maychon}");
                Console.WriteLine("Bạn có muốn chơi tiếp không <c/k>");
                string trl = Console.ReadLine();
                if (trl.ToLower().Equals('c'))
                {
                    Console.WriteLine("Tạm biệt");
                    break;
                }
            }
            while (true);
        }
    }
}
