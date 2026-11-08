public class Activity {

    private string _name;
    private string _description;
    private int _duration;


        public void Countdown(int seconds)
        {

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
    

    public int GetTimeDuration()
    {
        return _duration;
    }

    public Activity (string name, string description)
    {
        _name = name;
        _description = description;

        

    }
    public void SpinSpinner() 
        {
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b");
        }

    public void ActivityStart()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.WriteLine("How many seconds would you like this activity to last? \n");
        _duration = int.Parse(Console.ReadLine());
        SpinSpinner();


    }
    public void ActivityEnd()
    {
        Console.WriteLine("\nYou finished!");
        SpinSpinner();
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}");
        SpinSpinner();

    }




}