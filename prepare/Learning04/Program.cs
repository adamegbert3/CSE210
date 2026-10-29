using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        
        Assignment namentopic = new Assignment("Bob Barker", "Game Show Host");
        Console.WriteLine(namentopic.GetSummary());


        MathAssignment addmath = new MathAssignment("Bob Barker", "Mathematician", "9.1", "1-4");
        Console.WriteLine(addmath.GetSummary());
        Console.WriteLine(addmath.GetHomeworkList());





        WritingAssignment addwriting = new WritingAssignment("The Causes of World War II", "Mary Waters", "European History");
        Console.WriteLine(addwriting.GetSummary());
        Console.WriteLine(addwriting.GetWritingInformation());

    }
}