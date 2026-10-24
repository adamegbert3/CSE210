using System;

// I showed creativity by only choosing words that haven't been hidden yet.


class Program
{
    static void Main(string[] args)
    {

        Reference info = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(info, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        

        while (!scripture.CheckIsHidden())
        {
            Console.WriteLine(info.GetReferenceTitle());
            Console.WriteLine(scripture.DisplayWords());
            Console.WriteLine("Press enter to hide 3 more words. Quit to end.");
            



            string input = Console.ReadLine();


            if (input == "quit")
                return;
            scripture.HideRandomWords();
            Console.Clear();
        }

        // to show all blanks
        Console.WriteLine(info.GetReferenceTitle());
        Console.WriteLine(scripture.DisplayWords());

        
    }
}

