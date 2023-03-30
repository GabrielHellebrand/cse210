using System;
class Comment
{
    public string Name {get; set;}
    public string Text {get; set;}

    public Comment(string name, string text)
    // This retrieves the name of the person writing the comment along with the comment itself.
    {
        Name = name;
        Text = text;
    }
}