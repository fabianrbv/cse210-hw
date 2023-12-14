using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        // Crear 3-4 videos
        var videos = new List<Video>
        {
            new Video("Video 1", "Author 1", 120),
            new Video("Video 2", "Author 2", 180),
            new Video("Video 3", "Author 3", 150)
        };

        // Agregar comentarios a los videos
        videos[0].AddComment("UserA", "Great video!");
        videos[0].AddComment("UserB", "Interesting content.");

        videos[1].AddComment("UserC", "Liked it!");
        videos[1].AddComment("UserD", "Awesome!");

        videos[2].AddComment("UserE", "Informative.");
        videos[2].AddComment("UserF", "Well explained.");

        // Mostrar detalles de los videos y sus comentarios
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.UserName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}

class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    public List<Comment> Comments { get; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string userName, string text)
    {
        Comments.Add(new Comment(userName, text));
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

class Comment
{
    public string UserName { get; }
    public string Text { get; }

    public Comment(string userName, string text)
    {
        UserName = userName;
        Text = text;
    }
}
