public class PromptGenerator
{
    public List<string> _journalPrompts = [];

    public PromptGenerator()
    {
       _journalPrompts.Add("How have you seen the Lord's hand in your life today?");
       _journalPrompts.Add("What did you learn in your scripture study today?");
       _journalPrompts.Add("Who did you minister to today?");
       _journalPrompts.Add("Who needed your help when they weren't looking?");
       _journalPrompts.Add("How has the Lord brought you joy today?");
    }

    public string ChoosePrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompts.Count);
        return _journalPrompts[index];
    }


}