public class Entry
{
    public string _userPrompt;
    public string _userResponse;
    public DateTime _entryTime;
    PromptGenerator _promptRandomizer = new PromptGenerator();
    public void Write()
        {
            _entryTime = DateTime.Now;
            _userPrompt = _promptRandomizer.ChoosePrompt();
            Console.WriteLine($"{_userPrompt}");
            _userResponse = Console.ReadLine();
        }
    public void Display()
    {
        Console.WriteLine(_entryTime);
        Console.WriteLine(_userPrompt);
        Console.WriteLine(_userResponse);

    }



}