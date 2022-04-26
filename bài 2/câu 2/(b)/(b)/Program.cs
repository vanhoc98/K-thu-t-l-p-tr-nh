using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _b_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lấy số dòng từ bàn phím
            Console.Write("Nhap vao chieu cao h:");
            int rows = Convert.ToInt32(Console.ReadLine());
            //sử dụng vòng for thứ nhất để lặp qua các dòng
            for (int i = 1; i <= rows; i++)
            {
                //sử dụng vòng for thứ hai để in ra các khoảng trắng
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }
                //sử dụng vòng for thứ hai để in ra các ký tự *
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                //xuống dòng
                Console.Write("\n");
            }
            Console.WriteLine("\nHa Van Hoc - 20180264\n");
            Console.ReadLine();
        }
    }
}