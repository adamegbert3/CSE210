using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number of your choice? ");
        // int userMagicNumber = int.Parse(Console.ReadLine());


        Random randomNumberGenerator = new Random();
        int computerMagicNumber = randomNumberGenerator.Next(1, 100);


        int userGuess = 0;

        // while (userGuess != userMagicNumber)
        // {
        //     Console.Write("What is your guess for the Magic Number? ");
        //     userGuess = int.Parse(Console.ReadLine());

        //     if (userMagicNumber > userGuess)
        //     {
        //         Console.Write("Higher");
        //     }
        //     else if (userMagicNumber < userGuess)
        //     {
        //         Console.Write("Lower");
        //     }
        //     else
        //     {
        //         Console.Write("CORRECT! YOU GUESSED IT :)");
        //     }
        // }

        while (userGuess != computerMagicNumber)
        {
            Console.Write("What is your guess for the Magic Number? ");
            userGuess = int.Parse(Console.ReadLine());

            if (computerMagicNumber > userGuess)
            {
                Console.Write("Higher");
            }
            else if (computerMagicNumber < userGuess)
            {
                Console.Write("Lower");
            }
            else
            {
                Console.Write("CORRECT! YOU GUESSED IT :)");
            }
        }
    }
}