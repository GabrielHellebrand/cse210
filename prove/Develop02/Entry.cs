using System;
class Entry
{
    // This sets the date and time as well as gets a prompt from the user.
    public DateTime Time { get; set; }
    public string Prompt {get; set; }
    public Entry (DateTime time, string prompt)
    {
        Time = time;
        Prompt = prompt;
    }

    public override string ToString()
    {
        return Time + "" + Prompt;
    }

}