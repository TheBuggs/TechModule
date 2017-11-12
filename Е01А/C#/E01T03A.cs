/////////////////////////////////////////////////////////////
// Problem 3.	Poke Mon
/////////////////////////////////////////////////////////////

using System;
using System.Numerics;

namespace E01T02 {
    public class Program
    {
        public static void Main()
        {
            int  n  = int.Parse(Console.ReadLine());
            int  m  = int.Parse(Console.ReadLine());
            short y = short.Parse(Console.ReadLine());

            long percent = n;
            int count = 0;

            while (n >= m){
                n -= m;
                count++;

                if (n * 2 == percent) {
                    if (y > 0) {

                        n /= y;
                    }
                }
            }
            Console.WriteLine(n + "\n" + count);
        }
    }
}
