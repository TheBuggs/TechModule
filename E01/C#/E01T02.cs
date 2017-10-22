using System;

namespace E01T02{
    public class RectangleArea {
        public static void Main() {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
          
            Console.WriteLine("{0:F2}", width * height);
        }
    }
}
