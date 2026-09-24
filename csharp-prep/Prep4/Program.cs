using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Please enter numbers. Type 0 when done. ");

            string userintegers = Console.ReadLine();
            userNumber = int.Parse(userintegers);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.Write($"The sum is {sum}");
    }
}