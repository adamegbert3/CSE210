public class Journal
{
public List<Entry> _allEntries = [];
public void AddEntry(Entry newJournalEntry)
{
    _allEntries.Add(newJournalEntry);
}


public void ShowEntries()
{
    foreach (Entry oneEntry in _allEntries)
    {
        oneEntry.Display();
    }
}

public void Save()
{
    Console.WriteLine("Where would you like your journal saved? Don't forget to add .txt at the end of the file name.");

    string newFileName = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(newFileName))
    {

        foreach (Entry oneEntry in _allEntries)
        {
            outputFile.WriteLine($"{oneEntry._entryTime} | {oneEntry._userPrompt} | {oneEntry._userResponse}");
        }
    }
}

public void Load()
    {
        Console.WriteLine("Where would you like your journal loaded from? Don't forget to add .txt at the end of the file name.");

        string newImportFileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(newImportFileName);
        
        _allEntries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split(" | ");
            Entry newEntry = new Entry();
            newEntry._entryTime = DateTime.Parse(parts[0]);
            newEntry._userPrompt = parts[1];
            newEntry._userResponse = parts[2];
            AddEntry(newEntry);
            
        }
        
    }

}



// READING TEXT FILES IN C#
// string newFileName = "myFile.txt";
// string[] lines = System.IO.File.ReadAllLines(newFileName);

// foreach (string line in lines)
// {
//     string[] parts = line.Split(",");

//     string firstName = parts[0];
//     string lastName = parts[1];
// }




// WRITING TEXT FILES IN C#
// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
// using System.IO; 

// ...

// string newFileName = "myFile.txt";

// using (StreamWriter outputFile = new StreamWriter(newFileName))
// {
//     // You can add text to the file with the WriteLine method
//     outputFile.WriteLine("This will be the first line in the file.");
    
//     // You can use the $ and include variables just like with Console.WriteLine
//     string color = "Blue";
//     outputFile.WriteLine($"My favorite color is {color}");
// }