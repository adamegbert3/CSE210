using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");



        Console.Write("What is your grade? \n >>> ");
            int numgrade = int.Parse(Console.ReadLine());

            if (numgrade >= 90)
                Console.Write("Congratulations! You got an A!");
            else if (numgrade >= 80)
                Console.Write("Congradulations! You got a B!");
            else if (numgrade >= 70)
                Console.Write("Congradulations! You got a C!");
            else if (numgrade >= 60)
                Console.Write("Better luck next time. You got a D.");
            else
                Console.Write("You should have tried harder. You didn't pass.");

            // Console.WriteLine(grade);
    }
}