using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TEST_LAN3_DE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bai_7();
        }
        static void Bai_2()
        {
            Console.OutputEncoding = Encoding.UTF8; 
            Console.WriteLine("Nhập vào tên khách hàng: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Nhập vào ngày đến: ");
            int den =int.Parse( Console.ReadLine());
            Console.WriteLine("Nhập ngày đi: ");
            int di = int.Parse(Console.ReadLine());
            double gia = 100000;
           
            while (di < den)
            {
                Console.WriteLine("Nhập lại ngày đến: ");
                den = int.Parse( Console.ReadLine());
                Console.WriteLine("Nhập lại ngày ");
                di = int.Parse( Console.ReadLine());    
                
            }
            
            if (di - den <= 3 && di - den >0)
            {
                gia = gia * ( di-den +1);
            }
            else if (di - den > 3)
            {
                gia = gia * (di - den + 1) *0.9;
            }
            else
            {
                gia = gia * 1;
            }
                Console.OutputEncoding = UTF32Encoding.UTF8;
            Console.WriteLine($"Họ và tên: {ten} ");
            Console.WriteLine($"Ngày đến: {den}");
            Console.WriteLine($"Ngày đi: {di}");
            Console.WriteLine($"Gía phòng: {gia}");


        }
        static void Bai_4()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập và số nguyên");
            int so = int.Parse( Console.ReadLine());    
            while (so < 0)
            {
                Console.WriteLine("Nhập lại");
                so = int.Parse( Console.ReadLine());
            }
            if (so % 2 == 0)
            {
                Console.WriteLine($"{so} là số chẵn");
            }
            else 
            {
                Console.WriteLine($"{so} là số lẻ");
            }
        }
        static void Bai_6()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("CHÀO MỪNG ĐẾN VỚI TRÒ CHƠI KÉO BÚA BAO");
            Random rd = new Random();
            string[] chon = {"kéo", "búa", "bao"};
            Console.WriteLine("Nhập lựa chọn của bạn: Kéo/Búa/Bao");
            Console.WriteLine("Mỗi ván thắng được 1 điểm. Ai thắng 5 ván trước sẽ thắng");
            int diemmay = 0;
            int diemnguoi = 0;
            
            do
            {
                if (diemnguoi == 5 || diemmay == 5)
                {
                    Console.WriteLine("Trò chơi kết thúc");
                    break;
                }
                Console.WriteLine("");
                string may = chon[rd.Next(0, chon.Length)];
                Console.WriteLine("Mời bạn nhập");
                string nguoi = Console.ReadLine().ToLower().Trim();
                if (!nguoi.Equals("kéo") && !nguoi.Equals("búa") && !nguoi.Equals("bao"))
                {
                    Console.WriteLine("Nhập lại");
                    nguoi = Console.ReadLine();
                }
                else if (nguoi == may)
                {
                    Console.WriteLine($"Máy chọn {may}");
                    Console.WriteLine("Hòa");
                }
                else if (nguoi == "búa" && may == "kéo"||nguoi == "kéo" && may == "bao"||nguoi == "bao" && may == "búa" )
                {
                    Console.WriteLine($"Máy chọn {may}");
                    Console.WriteLine("Bạn thắng");
                    diemnguoi++;
                }
                else
                {
                    Console.WriteLine($"Máy chọn: {may}");
                    Console.WriteLine("Bạn thua");
                    diemmay++;
                }
                Console.WriteLine($"Tỉ số giữa bạn và máy {diemnguoi} - {diemmay}");

            }
            while (true);
            if (diemmay == 5)
            {
                Console.WriteLine("MÁY THẮNG");
            }
            else
            {
                Console.WriteLine("BẠN THẮNG");
            }
                
        }
        static void Bai_7()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số dòng");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số cột");
            int cols = int.Parse(Console.ReadLine());   
            int[,] matran = new int[rows,cols];
            
            Console.WriteLine("Nhập ma trận");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Phần tử {i},{j}: ");
                    matran[i,j]= int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ma trận");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matran[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Nhập số nguyên");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Số chia hết cho {n}: ");
            int so = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matran[i,j] % n == 0 )
                    {
                      so++;
                    }

                            
                }
               
            }


        }
        static bool TrySoThuc(int n, out double so)
        {
            Console.WriteLine("Nhập số");
            so = 0;
            string s = Console.ReadLine();
            int solan = 0;
         while ( solan < n)
         {
                if (!double.TryParse(s, out so))
                {
                    solan++;
                    Console.WriteLine("Không phải số thực");
                    Console.WriteLine("Nhập lại");
                    if (solan == n)
                        break;
                    s = Console.ReadLine();
                   
                }
                else
                {
                    return true;
                }
         }
                return false;
        }

    }
}
