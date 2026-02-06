public class Comment
{
    public string _name;
    public string _commentText;

    public void Display()
    {
        Console.Write($"{_name}:");
        Console.WriteLine($"{_commentText}");
    }
}