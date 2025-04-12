using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("Introduction to C#", "John Doe", 600);
        Video video2 = new Video("Object-Oriented Programming", "Jane Smith", 1200);
        Video video3 = new Video("C# LINQ Basics", "Michael Brown", 900);
        Video video4 = new Video("Design Patterns in C#", "Emily White", 1500);

        Comment comment1 = new Comment("Alice", "Very helpful, thanks!");
        Comment comment2 = new Comment("Charlie", "I love this tutorial!");
        Comment comment3 = new Comment("Tony", "Impressive");
        Comment comment4 = new Comment("Ben", "Way to go");

        video1.AddComment(comment1);
        video2.AddComment(comment2);
        video3.AddComment(comment3);
        video4.AddComment(comment4);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video v in videos)
        {
            Console.WriteLine($"{v._title}-{v._author}-{v._length}");
            Console.WriteLine($"Title: {v._title}");
            Console.WriteLine($"Author: {v._author}");
            Console.WriteLine($"Length: {v._length} seconds");
            Console.WriteLine($"Number of Comments: {v.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment c in v.Comments)
            {
                Console.WriteLine($"- {c._name}: {c._text}");
            }
        }
    }
}