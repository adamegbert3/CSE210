public class Menu
{
public void StartMenu(Journal journalToStartMenu)
{
    while (true)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("");
        Console.WriteLine($"Please select one fo the following choices: \n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.WriteLine($"What would you like to do?\n  >>>  ");

        int task = int.Parse(Console.ReadLine());

        if (task == 1)
        {
            // WRITE
            Entry newEntry = new Entry();
            newEntry.Write();
            journalToStartMenu.AddEntry(newEntry);
        }
        else if (task == 2)
        {
            // DISPLAY
            journalToStartMenu.ShowEntries();
        }
        else if (task == 3)
        {
            // LOAD
            journalToStartMenu.Load();
        }
        else if (task == 4)
        {
            // SAVE
            journalToStartMenu.Save();
        }
        else if (task == 5)
        {
            // QUIT
            break;
        }
        else
        {
            Console.WriteLine("You gave an incorrect number.");
        }
}
}

}