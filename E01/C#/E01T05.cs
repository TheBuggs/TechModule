using System;

namespace E01T05
{
    public class CharacterStats
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            string pipesHealth = new string('|', currentHealth);
            string dotsHealth  = new string('.', maximumHealth - currentHealth);
            string pipesEnergy = new string('|', currentEnergy);
            string dotsEnergy  = new string('.', maximumEnergy - currentEnergy);

            Console.WriteLine($"Name: {name}\nHealth: |{pipesHealth}{dotsHealth}|\nEnergy: |{pipesEnergy}{dotsEnergy}|\n");
        }
    }
}
