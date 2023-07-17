using System;

class Program
{
    static void Main(string[] args)
    {
         // Create videos
        Video video1 = new Video("How to create a file in vs code", "Lauren Crosbie", 120);
        Video video2 = new Video("Chocolate cake recipe", "Diane Bakes", 180);
        Video video3 = new Video("Lofi music", "Lofi fruits music", 150);

        // Add comments to videos
        video1.AddComment(new Comment("User1", "Comment 1"));
        video1.AddComment(new Comment("User2", "Comment 2"));
        video1.AddComment(new Comment("User3", "Comment 3"));

        video2.AddComment(new Comment("User4", "Comment 4"));
        video2.AddComment(new Comment("User5", "Comment 5"));

        video3.AddComment(new Comment("User6", "Comment 6"));
        video3.AddComment(new Comment("User7", "Comment 7"));
        video3.AddComment(new Comment("User8", "Comment 8"));
        video3.AddComment(new Comment("User9", "Comment 9"));

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

         // Display video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumComments());
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine(comment.CommenterName + ": " + comment.CommentText);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}