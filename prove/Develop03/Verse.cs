using System;
class Verse
{
    private List<Word> _words = new List<Word>();
    private bool _check;

// This displays the verse itself character by character. 
    public Verse(String verse)
    {
        string Verse = verse;
        _words = new List<Word>();
        char[] delimeterChars ={' ', ',', '.', ':', '\t'};
        string[] words = verse.Split(delimeterChars);
        foreach(string wordStr in words)
        {
            Word word = new Word(wordStr);
            _words.Add(word);
        }
        _check = false;
    }
// This displays the words in the verse. 
    public void Display()

    {
        foreach (Word word in _words)
        {
            word.Display();
            System.Console.Write(" ");
        }
        System.Console.WriteLine();
    }

// This is an index for the verses that randomly selects three words at a time to delete from the verse.
    private int randomIndex()
    {
        Random random = new Random();
        int verseIndex = random.Next(_words.Count());
        return verseIndex;
    }
// This checks if the words are hidden and when it runs out of words, it exits out the program.
    public bool HideWords()
    {
        int count = 0;
        _check = false;
        while (_check == false)
        {
            Word word = new Word("_");
            int verseIndex = randomIndex();
            word = _words [verseIndex];
            count = count + 1;
            if (word.Cleared() == false)
            {
                word.Clear();
                return true;
            }
            if (count > _words.Count() * 3)
            {
                return false;
            }
        } return false;
    }
// This stores the word if it's one of the words cleared. 
        
    public bool Cleared()
    {
        if (_check == true)
            {
                return true;
            }
            else
            {
                foreach (Word Word in _words)
                {
                    if (Word.Cleared() == false)
                    {
                        return false;
                    }
                }
                _check = true;
                return true;
            }

        }
        public void Clear()
        {
         foreach(Word word in _words)
        {
            word.Clear();
            _check = true;
            
        }
    }
}

