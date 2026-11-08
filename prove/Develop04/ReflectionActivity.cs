public class ReflectionActivity : Activity {

    private List<string> _startingPrompts;
    private List<string> _followingUpReflectionPrompts;


    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _startingPrompts = new List<string>()
        {
            "Think of a time when you helped someone else in need.",
            "Think of a time when you did the right thing even when it was hard.",
            "Think of a time when you served someone."
        };

        _followingUpReflectionPrompts = new List<string>()
        {
            "How did you feel when you did it?",
            "What would you do different next time?",
            "When do you think you will do this again?"
        };

    }

    public void PerformReflection()
    {
        ActivityStart();
        Random random = new Random();
        int randomNumber = random.Next(0, _startingPrompts.Count);
        Console.WriteLine(_startingPrompts[randomNumber]);
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetTimeDuration());
        while (currentTime < futureTime)
        {
            randomNumber = random.Next(0, _followingUpReflectionPrompts.Count);
            Console.WriteLine(_followingUpReflectionPrompts[randomNumber]);
            SpinSpinner();
            currentTime = DateTime.Now;
        }


        ActivityEnd();
        

    }







}