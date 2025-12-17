using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_LAN2
{
    internal class Bai_9
    {
        static void ThongKe(int[] arr)
        {
           int min = arr[0];
            int max = arr[0];
            int sum = 0;
            for (int i= 0; i< arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                sum = sum + arr[i];
            }
            double avg = sum / arr.Length;
            Console.WriteLine($"Số lớn nhất: {max}");
            Console.WriteLine($"Số bé nhất: {min}");
            Console.WriteLine($"Trung bình: {avg}");
        }
        static void Main(string[] agrs)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[]so = new int[7] {1,2,3,4,5,6,7};
            ThongKe(so);
            Console.ReadLine();
        }
    }
}
