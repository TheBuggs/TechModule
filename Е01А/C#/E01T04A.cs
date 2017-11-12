///////////////////////////////////////////////////////////////
// Problem 4.	Resurrection
///////////////////////////////////////////////////////////////

using System;

namespace E01BT04 {
    public class Resurrection {
        public static void Main() {

            short quantity = short.Parse(Console.ReadLine());

            for (short i = 0; i < quantity; i++) {

                long length     = long.Parse(Console.ReadLine());
                decimal width   = decimal.Parse(Console.ReadLine());
                long wing       = long.Parse(Console.ReadLine());
                decimal years   = length * length * ((2 * wing) + width);
                Console.WriteLine(years);
            }
        }
    }
}
