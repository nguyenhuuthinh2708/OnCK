using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_LAN2
{
    internal class Bai_7
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số cột ma trận");
            int col = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số hàng ma trận ");
            int row = int.Parse(Console.ReadLine());
            int[,]matran = new int[row,col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine($"Nhập phần tử {i},{j}");
                    matran[i,j] = int.Parse(Console.ReadLine());    
                }
            }
            Console.WriteLine("Ma trận là");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{matran[i,j]}\t");
                       
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
