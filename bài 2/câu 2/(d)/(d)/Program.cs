using System;
using System.Collections;
namespace VietTutsCsharp
{
    class USCLN__BSCNN
    {
        /**
         * Tim uoc so chung lon nhat
         */
        static int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }

        /**
         * Tim boi so chung nho nhat
         */
        static int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong a = ");
            String valA = Console.ReadLine();
            int a = Convert.ToInt32(valA);
            Console.Write("Nhap so nguyen duong b = ");
            String valB = Console.ReadLine();
            int b = Convert.ToInt32(valB);

            Console.Write("USCLN cua {0} va {1} la: {2} \n", a, b, USCLN(a, b));            // tinh uoc so chung cua a và b
          
            Console.Write("USCLN cua cua {0} va {1} la: {2}", a, b, BSCNN(a, b));          // tinh boi so chung cua a và b
            Console.Write("\n----------------------------------");
            Console.Write("\nHa Van Hoc - 20180264\n");
            Console.ReadLine();
        }
    }
}