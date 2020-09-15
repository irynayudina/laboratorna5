using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorna5
{
    class TeamsJournalEntry
    {
        public string nameOfTheChangedCollection { get; set; }
        public string whatHappenedToTheCollection { get; set; }
        public int numberOfNewElement { get; set; }
        public TeamsJournalEntry(string name, string type, int number)
        {
            nameOfTheChangedCollection = name;
            whatHappenedToTheCollection = type;
            numberOfNewElement = number;
        }
        override public string ToString()
        {
            return ($"\n Name of the collection: {nameOfTheChangedCollection}\n Type of changes: {whatHappenedToTheCollection}\n" +
                $" Number of the element that was changed or added: {numberOfNewElement}\n");
        }
    }
}
