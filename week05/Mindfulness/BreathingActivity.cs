public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description) { }

    public void Run()
    {
        int duration = DisplayStartingMessage();
        Console.Clear();
        Console.Write("Get Ready");
        ShowSpinner(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.WriteLine("");
            Console.Write($"Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("");
            Console.Write($"Now Breathe Out...");
            ShowCountDown(4);
            Console.WriteLine("");
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();
    }
}