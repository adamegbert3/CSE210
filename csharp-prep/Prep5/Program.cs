using System;

class Program
{

        static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }


    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("What is your birth year? ");
        birthYear = int.Parse(Console.ReadLine());
    }



    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }



    static void DisplayResult(string name, int squaredNumber, int birthYear)
    {
        int ageThisYear = 2026 - birthYear;

        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        Console.WriteLine($"{name}, you will turn {ageThisYear} this year.");
    }




    static void Main(string[] args)
    {
       DisplayWelcome();
       string name = PromptUserName();
       int number = PromptUserNumber();
       int birthYear;
       PromptUserBirthYear(out birthYear);
       int squaredNumber = SquareNumber(number);
       DisplayResult(name,squaredNumber,birthYear);
    }


}