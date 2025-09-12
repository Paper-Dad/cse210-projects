public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    private Random _random = new Random();

    public PromptGenerator()
    {
        _prompts.Add("What was your biggest success today?");
        _prompts.Add("What was an obstacle you needed to overcome today?");
        _prompts.Add("What is something that you are grateful for today?");
        _prompts.Add("What is something you learned today?");
        _prompts.Add("What is something that happened today that didn't happen yesterday?");
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}