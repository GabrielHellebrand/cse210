using System;

class Program
{
    static void Main(string[] args)
    {
        Journal Journal = new Journal();
         
// This calls the functions that are going to be used in main.
        Journal.Menu();
        Journal.CreateFile();
        Journal.DisplayJournal();
        Journal.ClearJournal();
        Journal.DisplayJournal();
        Journal.AddEntry();
    }
}