public class PromptGenerator
{
    private List<string> _promts;
    private Random _random;

    public PromptGenerator(List<string> prompts)
    {
        _promts = prompts;
        _random = new Random();
    }


    public string GetRandomPrompt()
    {
        int index = _random.Next(0, _promts.Count);
        return _promts[index];
    }

}