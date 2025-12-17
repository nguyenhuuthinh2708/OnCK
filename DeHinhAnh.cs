using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double[] a = new double[5] { 3.6, 3.4, 5.7,8.8,9 };
            Console.WriteLine("Mảng trước khi đảo");
            for (int i = 0; i< a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Mảng sau khi đảo: ");
            Bai_9DaoHaiSoTrongMang(a, 3, 2);
            Console.ReadKey();
        }
        static void Bai_2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập vào tên hàng: ");
            string tenhang = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập vào số lượng");
            int soluong = 0;
            string s = Console.ReadLine();
            while (!int.TryParse(s, out soluong))
            {
                Console.WriteLine("Nhập lại");
                s = Console.ReadLine();
            }
            Console.WriteLine("Mời bạn nhập vào đơn giá: ");
            int dongia = 0;
            string g = Console.ReadLine();
            while (!int.TryParse(g, out dongia))
            {
                Console.WriteLine("Nhập lại");
                g = Console.ReadLine();
            }
            double thanhtien = dongia * soluong;
            double tongtien = thanhtien * 1.08;
            Console.WriteLine("HÓA ĐƠN BÁN HÀNG");
            Console.WriteLine($"Tên hàng: {tenhang}");
            Console.WriteLine($"Số lượng: {soluong}");
            Console.WriteLine($"Thành tiền: {thanhtien}");
            Console.WriteLine($"Thuế VAT (8%): {thanhtien * 0.08}");
            Console.WriteLine($"Tiền phải trả: {tongtien}");
            Console.ReadLine();
        }
        static void Bai_3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên: ");
            int songuyen = 0;
            string s = Console.ReadLine();
            while (!int.TryParse(s, out songuyen))
            {
                Console.WriteLine("Nhập lại: ");
                s = Console.ReadLine();
            }
            if (songuyen % 3 == 0 && songuyen % 5 == 0)
            {
                Console.WriteLine($"{songuyen} chia hết cho 3 và 5");
            }
            else if (songuyen % 3 == 0 && songuyen % 5 != 0)
            {
                Console.WriteLine($"{songuyen} chia hết cho 3 nhưng không cho 5");
            }
            else if (songuyen % 3 != 0 && songuyen % 5 == 0)
            {
                Console.WriteLine($"{songuyen} chia hết cho 5 nhưng không cho 3");
            }
            else
            {
                Console.WriteLine($"{songuyen} không chia hết cho 3 và 5");
            }
            Console.ReadLine();

        }
        static void Bai_5()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên n: ");
            int songuyen = 0;
            string s = Console.ReadLine();
            while (!int.TryParse(s, out songuyen))
            {
                Console.WriteLine("Nhập lại");
                s = Console.ReadLine();
            }
            Console.WriteLine($"Bảng cửu chương {songuyen}");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($" {i} * {songuyen} = {i * songuyen}");
            }
            Console.ReadLine();
        }
        static void Bai_4()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số gói mì");
            int sogoimi = int.Parse(Console.ReadLine());
            int keo = 0;
            int nuoc = 0;

            if (sogoimi == 5)
            {
                nuoc = 1;
            }
            else if (sogoimi > 5)
            {
                nuoc = 1;
                keo = sogoimi - 5;
            }
            int tongtien = 6000 * sogoimi;
            Console.WriteLine($"Tiền phải trả: {tongtien}");
            Console.WriteLine($"Số bịch kẹo được tặng: {keo}");
            Console.WriteLine($"Số chai nước :{nuoc}");
        }
        static void Bai_6()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("CHÀO MỪNG ĐẾN VỚI TRÒ CHƠI ĐOÁN MẬT KHẨU");
            string may = "12345";
            Console.WriteLine("MỜI BẠN NHẬP MẬT KHẨU");
            string nguoi = Console.ReadLine();
            int solanthu = 4;
            for (int i = 0; i < 4; i++)
            {
                if (may == nguoi)
                {
                    Console.WriteLine("Đăng nhập thành công");
                    break;
                }
                else
                {
                    Console.WriteLine($"Sai mật khẩu. Còn {solanthu -1} lần thử");
                    Console.WriteLine("Nhập lại");
                    nguoi = Console.ReadLine();
                    solanthu--;
                }
            }


            if (solanthu == 0)
            {
                Console.WriteLine("Khóa tài khoản");

            }
            Console.ReadLine();
        }
        static void Bai_7()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập độ dài mảng");
            int n = int.Parse( Console.ReadLine() );
            int[] mang = new int[n];
            for (int i = 0;i < n;i++)
            {
                Console.Write($"Nhập phần tử thứ {i}\n");
                mang[i] = int.Parse( Console.ReadLine() ) ;
            }
            int max = mang[0];
            int min = mang[0];
            for (int i = 0;i < mang.Length;i++)
            {
                if ( mang[i] > max)
                {
                    max = mang[i];  
                }
                if (mang[i] < min)
                {
                    min = mang[i];
                }
            }
            Console.WriteLine($"Số nhỏ nhất {min}");
            Console.WriteLine($"Số lớn nhất {max}");
        }
        static void Bai_8()
        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("Nhập chuỗi");
            string chuoi = Console.ReadLine();
            int chu = 0;
            int space = 0;
            int dacbiet = 0;
            foreach (char i in chuoi)
            {
                if (char.IsLetter(i))
                {
                    chu++;
                }
                else if (char.IsWhiteSpace(i))
                {
                    space++;
                }
                else if (!char.IsLetter(i) && !char.IsWhiteSpace(i) && !char.IsDigit(i))
                {
                    dacbiet++;
                }
            }
            Console.WriteLine($"Số ký tự chữ: {chu}");
            Console.WriteLine($"Số ký tự đặc biệt: {dacbiet}");
            Console.WriteLine($"Số ký tự khoảng trắng: {space}");

        }
        static void Bai_9DaoHaiSoTrongMang(double[]arr, int index1, int index2)
        {
           if ( arr == null)
            {
                Console.WriteLine("Mảng không được rỗng");
                return;
            }
           if (index1 >= arr.Length || index2>= arr.Length || index1 == index2 || index1 < 0 || index2<0)
            {
                Console.WriteLine("Index không hợp lệ");
                return;
            }
            else
            {
                for (int i = 0;  i < arr.Length; i++)
                {
                    double temp = arr[index1];
                    arr[index1] = arr[index2];
                    arr[index2] = temp;
                }
            }
           for (int i = 0;i < arr.Length;i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
