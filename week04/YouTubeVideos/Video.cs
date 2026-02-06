using System.Net;
using System.Numerics;
using System.Reflection;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
  
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
       }

    public void GetTitle()
    {
        Console.WriteLine($"Title: {_title}");
    }

    public void GetAuthor()
    {
        Console.WriteLine ($"Author: {_author}");
    }

    public void GetLength()
    {
        Console.WriteLine($"Duration: {_length} seconds");
    }

    private List<Comment>_comments = new List<Comment>();

    public void AddComments(Comment newComment)
    {
        _comments.Add(newComment);
    }

    public void NumberOfComments()
    {
        Console.Write("Total Number of comments:");
        Console.WriteLine (_comments.Count());
    }

    public void DisplayAll()
    {
        foreach (var comemnt in _comments)
        {
            comemnt.Display();
        }
    }

}