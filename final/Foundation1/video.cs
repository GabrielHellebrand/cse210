using System;
using System.Collections.Generic;
class Video
{
   public string Title {get; set;}
   public string Author {get; set;} 
   public int LengthInSeconds {get; set;}
   public List<Comment> Comments {get; set;}
   
   public Video(string title, string author, int lengthInSeconds) 
// This gets the title of the video, the author of the video, how long the video is and the list of comments.
   {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
   } 
   public int GetCommentCount()
// This counts the comments in each video.
   {
        return Comments.Count;
   }
}
