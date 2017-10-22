using System;

namespace E01T03
{
    public class Miles2Kilometers
    {
        const float MILE = 1.60934f;
		
        public static void Main()
        {
            float miles = float.Parse(Console.ReadLine());
            Console.WriteLine($"{MILE * miles:F2}");
        }
    }
}
