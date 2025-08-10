using System;
using System.Collections.Generic;

public class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetCommentText()
    {
        return _commentText;
    }
}

public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment c in _comments)
        {
            Console.WriteLine($" - {c.GetCommenterName()}: {c.GetCommentText()}");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("C# Tutorial", "Alice", 600);
        video1.AddComment(new Comment("Bob", "Great tutorial, thanks!"));
        video1.AddComment(new Comment("Charlie", "Very helpful."));
        video1.AddComment(new Comment("Diana", "I learned a lot."));

        Video video2 = new Video("Funny Cats Compilation", "CatLover99", 180);
        video2.AddComment(new Comment("Eve", "So funny!"));
        video2.AddComment(new Comment("Frank", "Cats rule!"));
        video2.AddComment(new Comment("Grace", "Love this video!"));

        Video video3 = new Video("Travel Vlog: Japan", "Traveler", 900);
        video3.AddComment(new Comment("Hank", "Amazing scenery."));
        video3.AddComment(new Comment("Ivy", "I want to visit!"));
        video3.AddComment(new Comment("Jack", "Thanks for sharing."));

        // Put videos in a list
        List<Video> videos = new List<Video>() { video1, video2, video3 };

        // Display all videos info
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
