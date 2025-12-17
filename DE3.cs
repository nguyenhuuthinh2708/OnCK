using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Test_Lan4_Dethithu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bai_7();
        }
        static void Bai_2()
        {
            Console. OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập tên khách hàng");
            string ten = Console.ReadLine();
            Console.WriteLine("Nhập chỉ số cũ");
            double old = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chỉ số mới");
            double news = int.Parse(Console.ReadLine());
            
            double tieuthu = news - old;
            double tiendien = tieuthu * 452.45;
            double phuthu = tiendien * 0.1;
            double thue = 12426;
            double tong = tiendien + phuthu + thue;

            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("Hóa đơn tiền điện");
            Console.WriteLine($"Khách hàng: {ten}");
            Console.WriteLine($"Chỉ số cũ: {old}");
            Console.WriteLine($"Chỉ số mới: {news}");
            Console.WriteLine($"Tiêu thụ: {tieuthu}");
            Console.WriteLine($"Tiền thuê điện kế {thue} đ/ tháng");
            Console.WriteLine($"Tiền phụ thu 10% tiền điện");
            Console.WriteLine($"Tổng tiền phải trả: {tong}");
            Console.WriteLine("Yêu cầu tiết kiệm điện");
            Console.WriteLine();
            Console.WriteLine("------------------------");
           

        }
        static void Bai_3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số b:");
            double b = double .Parse(Console.ReadLine());

            double x = -b / a ;
            Console.WriteLine($"Kết quả là {x.ToString("F5")}");

        
        }
        static void Bai_5()
        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("Nhập chiều dài");
            int dai = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều rộng");
            int rong = int.Parse(Console.ReadLine());
            for (int i = 0; i < dai; i++)
            {
                for (int j = 0; j < rong; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();

        }
        static void Bai_6()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("CHÀO MỪNG BẠN ĐẾN VỚI TRÒ CHƠI ĐOÁN SỐ");
            Console.WriteLine("Bạn sẽ đoán từ 0 đến 100. Bạn có 7 lần đoán");
           
           
            Random rd = new Random();
            int maychon = rd.Next(0,101);
            do
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.Write($"{i+1}. Mời bạn nhập số muốn đoán: ");
                    int nguoichon = 0;
                    string s = Console.ReadLine();
                    while (!int.TryParse(s, out nguoichon))
                    {
                        Console.WriteLine("Nhập lại");
                        s = Console.ReadLine();
                    }
                    if (maychon == nguoichon)
                    {
                        Console.WriteLine($"Bạn đã đoán đúng. Máy chọn: {maychon}");
                        break;
                    }
                    else if(maychon > nguoichon)
                    {
                        Console.WriteLine("Số bạn chọn bé hơn số máy chọn");

                    }
                    else
                    {
                        Console.WriteLine("Số bạn chọn lớn hơn số máy chọn");
                    }
                }
                Console.WriteLine($"Bạn đã đoán sai hết 7 lần. Số máy chọn là {maychon}");
                break ;

            }
            while (true);
        }
        static void Bai_7()
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Nhập chiều dài mảng");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int am = 0;
            int duong = 0;
            int tongam = 0;
            int tongduong = 0;
            for (int i = 0; i< arr.Length; i++)
            {
                Console.Write($"Nhập phần tử thứ {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("Dãy số: ");
            for (int i = 0; i< arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
            for (int i = 0; i< arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    am++;
                    tongam += arr[i];
                }
                else
                {
                    duong++;
                    tongduong += arr[i];
                }
            }
            Console.WriteLine($"Có {am} số âm");
            Console.WriteLine($"Có {duong} số dương");
            Console.WriteLine($"Tổng số âm = {tongam}");
            Console.WriteLine($"Tổng số duong = {tongduong}");
            Console.ReadKey();



        }
    }
}
