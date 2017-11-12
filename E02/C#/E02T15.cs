/////////////////////////////////////////////////////////////
// Problem 15.   *Neighbour Wars
/////////////////////////////////////////////////////////////

using System;

namespace E02T15 {
    public class Program {
        public static void Main() {
            int[] damage = new int[2];
            int[] health = new int[2];

            for (int i = 0; i < 2; i++) {
                damage[i] = int.Parse(Console.ReadLine());
                health[i] = 100;
            }

            string result = String.Empty;
            string[] name = { "Pecho", "Gosho" };
            string[] atack = { "Roundhouse kick", "Thunderous fist" };

            int counter = 1;

            while (true) {
                
                if (counter % 2 != 0) {
                    health[1] -= damage[0];
                    if (health[1] <= 0) {
                        result += name[0] + " won in " + counter + "th round.\n";
                        break;
                    } else {
                        result += name[0] + " used " + atack[0] + " and " +
                        "reduced " + name[1] + " to " + health[1] + " health.\n";
                    }
                }
                else {
                    health[0] -= damage[1];
                    if (health[0] <= 0) {
                        result += name[1] + " won in " + counter + "th round.\n";
                        break;
                    } else {  
                        result += name[1] + " used " + atack[1] + " and " +
                        "reduced " + name[0] + " to " + health[0] + " health.\n";
                    }
                }
                if (counter % 3 == 0) {
                    health[0] += 10;
                    health[1] += 10;
                }
                counter++;
            }
            Console.WriteLine(result.Remove(result.Length - 1));
        }
    }
}
