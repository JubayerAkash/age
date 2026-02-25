using System;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
                Console.WriteLine("Minor.");
            else if (age <= 36)
                Console.WriteLine("Adult.");
            else
                Console.WriteLine("Senior.");
        }
    }
}