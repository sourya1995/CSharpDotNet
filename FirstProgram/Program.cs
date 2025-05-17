using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Where are you from?");
            string? location = Console.ReadLine();
            if (location != null)
            {
                Console.WriteLine($"You are from {location}.");
            }
            else
            {
                Console.WriteLine("Location is not provided.");
            }
            program.Print();
        }
    }

    public class program
    {
        public static void Print()
        {
            Console.WriteLine("just some OOP shizz");
        }
    }
}

