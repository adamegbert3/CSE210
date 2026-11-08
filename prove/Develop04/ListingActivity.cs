public class ListingActivity : Activity {

    private int _number;
    private List<string> _prompts;


    public ListingActivity () : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
         _prompts = new List<string>()
         {
             "What are some of your favorite dishes?",
             "Who are some people you look up to?",
             "What are you most looking forward to?"
         };

    }

    public string SelectPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count);
        Console.WriteLine(_prompts[randomNumber]);
        return _prompts[randomNumber];

    }
    public void PerformList()
    {
        ActivityStart();
        _number = 0;
        SelectPrompt();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetTimeDuration());
        SpinSpinner();
        Console.WriteLine("List: ");
        while (currentTime < futureTime)
        {
            
            Console.ReadLine();
            _number += 1;
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {_number} items!");

        ActivityEnd();

    }

 

}