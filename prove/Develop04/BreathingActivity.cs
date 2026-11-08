public class BreathingActivity : Activity {


    private int _customInhale;
    private int _customExhale;




    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        _customInhale = 5;
        _customExhale = 5;


    }
    public void StartBreathing()
    {
        ActivityStart();
        BreathingMessages();
        ActivityEnd();

    }
    public void BreathingMessages()
    {
        Console.WriteLine("How long do you want to inhale, in seconds?");
        _customInhale = int.Parse(Console.ReadLine());
        Console.WriteLine("How long do you want to exhale, in seconds?");
        _customExhale = int.Parse(Console.ReadLine());
        Console.WriteLine("Ready to breathe?");
        Countdown(3);
        // work with time
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetTimeDuration());

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.WriteLine("Breathe in...");
        Countdown(_customInhale);
        Console.WriteLine("Now breathe out...");
        Countdown(_customExhale);
        
        currentTime = DateTime.Now;
        }
    }



}