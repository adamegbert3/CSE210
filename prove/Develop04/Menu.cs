public class Menu {

    private string _options;

    public Menu()
    {
        



    }

    public void DisplayAndRun()
    {
        while (true) {
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("> ");

        _options = Console.ReadLine();

        if (_options == "1")
        {
            // breathing activity
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.StartBreathing();
        }
        else if (_options == "2")
        {
            // reflection activity
            ReflectionActivity reflectionActivity = new ReflectionActivity();
            reflectionActivity.PerformReflection();
        }

        else if (_options == "3")
        {
            // listing activity
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.PerformList();
        }

        else if (_options == "4")
        {
            // quit
            break;
        }

        else
        {
            Console.WriteLine("Incorrect. Please choose a number between 1 - 4.");
        }
    }
    }

}