using System;

namespace tpzslaba4_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Hello World";
            string string2 = "Hello World";
            string string3 = "Hello World!";
            Console.Write("Cтрока 1:");
            Console.Write(string1);
            Console.Write("\nCтрока 2:");
            Console.Write(string2);
            Console.Write("\nCтрока 3:");
            Console.Write(string3);
            Console.WriteLine(" ");
            Console.WriteLine(string1 == string3);
            Console.WriteLine(string1.Equals("Hello World"));
            Console.WriteLine(Equals(string1, string2));
            Console.WriteLine(Equals(string1, string3));
            Console.ReadKey();

        }
    }
}
