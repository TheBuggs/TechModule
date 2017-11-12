/////////////////////////////////////////////////////////////
// Problem 2.	Hornet Wings
/////////////////////////////////////////////////////////////

using System;

namespace E01T02{
	
    public class HornetWings {
		
        public static void Main() {

            int n       = int.Parse(Console.ReadLine());
            double m    = double.Parse(Console.ReadLine());
            int p       = int.Parse(Console.ReadLine());

            var totalDistance = n / 1000 * m;
            var totalTime = (n / p * 5) + (n / 100);

            Console.WriteLine("{0:F2} m.\n{1} s.", totalDistance, totalTime);
        }
    }
}
