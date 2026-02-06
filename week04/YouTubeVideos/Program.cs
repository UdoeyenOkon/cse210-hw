using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        
            Video video1 = new Video("beautiful", "Kiss Daniel", 180);
            // Console.WriteLine("Video Information");
            // video1.GetTitle();
            // video1.GetAuthor();
            // video1.GetLength();
            
            Comment comment1 = new Comment();
            comment1. _name = "Etim";
            comment1._commentText = "This video is wonderful";

            Comment comment2 = new Comment();
            comment2. _name = "Akpan";
            comment2. _commentText = "I like the video";

            Comment comment3 = new Comment();
            comment3. _name = "Comfort";
            comment3. _commentText = "I would have love the video to be a bit longer";
            
            // Console.WriteLine("Comments on the Video:");
            video1.AddComments(comment1);
            video1.AddComments(comment2);
            video1.AddComments(comment3);

            // video1.DisplayAll();

            // video1.NumberOfComments();
        

        Console.WriteLine();
        
            Video video2 = new Video("Love in the Air", "Davido", 240);
            // Console.WriteLine("Video Information");
            // video2.GetTitle();
            // video2.GetAuthor();
            // video2.GetLength();
            
            Comment comment4 = new Comment();
            comment4. _name = "Udoeyen";
            comment4._commentText = "Excellent video";

            Comment comment5 = new Comment();
            comment5. _name = "Aniefiok";
            comment5. _commentText = "This video is made in heaven";

            Comment comment6 = new Comment();
            comment6. _name = "Okon";
            comment6. _commentText = "I love the video";
            
            Comment comment6a = new Comment();
            comment6a. _name = "Victor";
            comment6a. _commentText = "Watching the video is renewing";
            // Console.WriteLine("Comments on the Video:");
            video2.AddComments(comment4);
            video2.AddComments(comment5);
            video2.AddComments(comment6);
            video2.AddComments(comment6a);

            // video2.DisplayAll();

            // video2.NumberOfComments();
        

        Console.WriteLine();
        
            Video video3 = new Video("Send Down the Rain", "Majek Fashe", 360);
            // Console.WriteLine("Video Information");
            // video3.GetTitle();
            // video3.GetAuthor();
            // video3.GetLength();
            
            Comment comment7 = new Comment();
            comment7. _name = "Ekaette";
            comment7._commentText = "This is a rekea music video";

            Comment comment8 = new Comment();
            comment8. _name = "Sam";
            comment8. _commentText = "This video was a hit";

            Comment comment9 = new Comment();
            comment9. _name = "Edet";
            comment9. _commentText = "I think this video will win a grammy";
            
            Comment comment9a = new Comment();
            comment9a. _name = "Abas";
            comment9a. _commentText = "The video production is supperb";

            // Console.WriteLine("Comments on the Video:");
            video3.AddComments(comment7);
            video3.AddComments(comment8);
            video3.AddComments(comment9);
            video3.AddComments(comment9a);
            // video3.DisplayAll();

            // video3.NumberOfComments();
        

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Video Information");
            video.GetTitle();
            video.GetAuthor();
            video.GetLength();
            Console.WriteLine("Comments on the Video:");
            video.DisplayAll();
            video.NumberOfComments();
            Console.WriteLine();
        }

    }
}