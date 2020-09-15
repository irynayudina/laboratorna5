using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorna5
{
    class TeamsJournal
    {
        public List<TeamsJournalEntry> ListOfChanges = new List<TeamsJournalEntry>();
        public void makeTeamsJournalEntry(object source, GraduateStudentListHandlerEventArgs args)
        {
            TeamsJournalEntry ts = new TeamsJournalEntry(args.nameOfCollectionOfOccuredEvent, args.typeOfChangesInTheCollection, args.numberOfElementThatWasChangedOrAdded);
            ListOfChanges.Add(ts);
        }
        //GraduateStudentAdded += makeTeamsJournalEntry();
        public override string ToString()
        {
            string res = "";
            foreach (TeamsJournalEntry g in ListOfChanges)
            {
                res += g.ToString();
            }
            return res;
        }
        //TeamsJournalEntry = GraduateStudentListHandlerEventArgs

    }
}
