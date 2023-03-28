using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos= new List<Video>();
        {
          Video video1 = new Video("I ate donuts and coffee for 30 days straight, here's what happened", "Tim Horton", 500);
          video1.Comments.Add(new Comment("Da Real Patrick Bateman", "First."));
          video1.Comments.Add(new Comment("Simpfever", "Follow my insta and you'll get a giftcard."));
          video1.Comments.Add(new Comment("JoeRogan420", "Have you tried DMT wth the donuts and coffee, it makes you see the elves."));  
          videos.Add(video1);

          Video video2 = new Video("The time I drove drunk into a ditch and got away with it", "Jack Daniels", 380);
          video2.Comments.Add(new Comment("Tyler Durden Is My Sensei", "You broke the third rule of Fight Club."));
          video2.Comments.Add(new Comment("Shrek is my one and only", "Get out of my swamp."));
          video2.Comments.Add(new Comment("Gandhi Approves This Message", "Boo your video sucks."));
          videos.Add(video2);

          Video video3 = new Video("Elmo apologizes for doing all of the drugs", "Big Bird be pimpin yo", 400);
          video3.Comments.Add(new Comment("My Name Is Heisenburg", "Shame on you Elmo."));
          video3.Comments.Add(new Comment("Xavier", "#LifeGoals."));
          video3.Comments.Add(new Comment("Tony Soprano", "Not again"));
          videos.Add(video3);
        }
          // Iterate through the list of videos and display information about each one
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: {0}", video.Title);
            Console.WriteLine("Author: {0}", video.Author);
            Console.WriteLine("Length: {0} seconds", video.LengthInSeconds);
            Console.WriteLine("Number of comments: {0}", video.GetCommentCount());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("{0}: {1}", comment.Name, comment.Text);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
