///////////////////////////////////////////
// Task 1.	Type Boundaries
///////////////////////////////////////////

using System;

namespace E04T01b {
    public class TypeBoundaries {
        public static void Main() {
            string msg = Console.ReadLine();
            switch (msg) {
                case "int":
                    Console.WriteLine($"{ int.MaxValue   }\n{int.MinValue    }");
                    break;
                case "short":
                    Console.WriteLine($"{ short.MaxValue }\n{ short.MinValue }");
                    break;
                case "ushort":
                    Console.WriteLine($"{ ushort.MaxValue}\n{ ushort.MinValue }");
                    break;
                case "uint":
                    Console.WriteLine($"{ uint.MaxValue  }\n{ uint.MinValue  }");
                    break;
                case "long":
                    Console.WriteLine($"{ long.MaxValue  }\n{ long.MinValue  }");
                    break;
                case "byte":
                    Console.WriteLine($"{ byte.MaxValue  }\n{ byte.MinValue  }");
                    break;
                case "sbyte":
                    Console.WriteLine($"{ sbyte.MaxValue }\n{ sbyte.MinValue }");
                    break;
            }
        }
    }
}
