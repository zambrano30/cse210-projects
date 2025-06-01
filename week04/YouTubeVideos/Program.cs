using System;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C#", "John Smith", 2400);
        video1.AddComment("Anna", "Great explanation!");
        video1.AddComment("Luis", "Very clear and concise.");
        video1.AddComment("Sophia", "This helped me a lot, thanks.");

        Video video2 = new Video("Introduction to HTML", "Mary Johnson", 1800);
        video2.AddComment("Charles", "Just what I needed.");
        video2.AddComment("Helen", "Very useful for beginners.");
        video2.AddComment("Peter", "Awesome video!");

        Video video3 = new Video("OOP in Java", "Robert Brown", 3600);
        video3.AddComment("Valerie", "Now I understand encapsulation.");
        video3.AddComment("Michael", "Please make more videos like this.");
        video3.AddComment("Andrea", "Super well explained!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.Display();
        }
    }
}