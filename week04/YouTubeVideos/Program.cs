using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Coding for Beginners", "Ben Roberts", 600);
        Video v2 = new Video("Try not to laugh video", "Laugh Attack", 720);
        Video v3 = new Video("Lets Play Mario Party", "Gamer365", 300);

        v1.AddComment(new Comment("Alice", "Very helpful, thanks!"));
        v1.AddComment(new Comment("John", "I finally understand classes now."));
        v1.AddComment(new Comment("Sophia", "Those are some funky functions!"));

        v2.AddComment(new Comment("Mike", "Hahahahahahahahah!"));
        v2.AddComment(new Comment("Sarah", "Oh no! I failed the challenge."));
        v2.AddComment(new Comment("David", "This made my day."));

        v3.AddComment(new Comment("Emma", "Itsa ME! MARIO!"));
        v3.AddComment(new Comment("Oliver", "I am way better at this game."));
        v3.AddComment(new Comment("Liam", "I used to play this game when I was a kid!"));

        List<Video> videos = new List<Video> { v1, v2, v3 };

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}