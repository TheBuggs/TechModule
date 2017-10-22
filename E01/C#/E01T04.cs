using System;

namespace E01T04{
    public class BeverageLabels
    {
        const float MILE = 1.60934f;
        public static void Main() {
            string name = Console.ReadLine();
            int volume  = int.Parse(Console.ReadLine());
            int energy  = int.Parse(Console.ReadLine());
            int sugar   = int.Parse(Console.ReadLine());
          
            Console.WriteLine("{1}ml {0}:\n{2}kcal, {3}g sugars", name, volume, energy * volume/100f, sugar * volume /100f);
        }
    }
}
