using System;

class Scripture
{
    private string _scriptureReference;
// This is a constructer that goes through each word and adds the word to the verse.
    private List<Verse> _verses = new List<Verse>();
    private bool _hidden = false;
    public Scripture(string scriptureReference, List<string> verses)
    {
        _scriptureReference = scriptureReference;
        foreach(string verseStr in verses)
        {
            Verse verse = new Verse(verseStr);
            _verses.Add(verse);
        }
        _hidden = false;
    }

// This displays the scripture on the screen.
    public void Display()
    {
        System.Console.WriteLine(_scriptureReference);
        foreach (Verse verse in _verses)
        {
            verse.Display();
        }
    }
// This hides the words using a randomizer.
    public bool HideWords (int number)
    {
        int count  = 0;
        int failed = 0;
        while (count < number)
        {
            Random random = new Random();
            int verseIndex = random.Next(_verses.Count());
            Verse verse = new Verse("");
            verse = _verses[verseIndex];
            if (verse.Cleared() == true)
            {
                count = count + 1;
            }
            failed = failed + 1;
            if (failed > 100)
            {
                _hidden = true;
                return false;
            }
        }

        return true;
    }

// This is when the words are all hidden and the program exits.
    public bool IsAllHidden()
    {
        foreach (Verse verse in _verses)
        {
            if (verse.Cleared() == false)
            {
                return false;
            }
        }
        return true;
    }
    public bool Clear()
    {
        foreach(Verse verse in _verses)
        {
            verse.Clear();
            _hidden = true;
        }
        return true;
    }
}
