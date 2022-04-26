using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chao ban, minh den voi the gioi lap trinh");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào tên của bạn:");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            
            Console.ReadKey();
        }
    }
}
