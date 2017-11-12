//////////////////////////////////////////////////
// Problem 5.	Wormtest
//////////////////////////////////////////////////

using System;

namespace E02BT05 {
    public class Wormtest {
        public static void Main() {
            long lenght = 100 * long.Parse(Console.ReadLine()); 
            double width  = double.Parse(Console.ReadLine()); 
  
            if (lenght % width == 0 || width == 0){  
                Console.WriteLine("{0:F2}", (lenght * width));
            }
            else{
                Console.WriteLine("{0:F2}%", ((lenght / width) * 100));
            }
        }
    }
}
