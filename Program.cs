using System;

namespace laboratorna5
{
    public enum FormOfStudy
    {
        FullTime,
        PartTime,
        Distance
    }
    class Program
    {
        static void Main()//string[] args
        {
            //int size = Positive();
            //GraduateStudentCollection gst = new GraduateStudentCollection();
            //gst.AddDefaults();
            ////##########################//Add elements to GraduateStudetCollection//############################
            //AddRandEllements(gst);
            ////################################################################################
            //Console.WriteLine(gst.ToString());
            //Console.WriteLine("Elements of GraduateStudentCollection sorted by name:########################################");
            //gst.SortByLastName();
            //Console.WriteLine(gst.ToString());
            //Console.WriteLine("Elements of GraduateStudentCollection sorted by birthday:####################################");
            //gst.SortByBirthday();
            //Console.WriteLine(gst.ToString());
            //Console.WriteLine("Elements of GraduateStudentCollection sorted by learning year:###############################");
            //gst.SortByLearningYear();
            //Console.WriteLine(gst.ToString());
            //TestCollections testColl = new TestCollections(size);
            //GraduateStudet first = TestCollections.GenerateElement(0);
            //GraduateStudet middle = TestCollections.GenerateElement(size / 2);
            //GraduateStudet last = TestCollections.GenerateElement(size - 1);
            //GraduateStudet notexisting = TestCollections.GenerateElement(size + 1);
            //Console.WriteLine("Searching time for the first element:################################################");
            //testColl.CalculateTime(first);
            //Console.WriteLine("Searching time for the middle element:###############################################");
            //testColl.CalculateTime(middle);
            //Console.WriteLine("Searching time for the last element:#################################################");
            //testColl.CalculateTime(last);
            //Console.WriteLine("Searching time for not existing element:#############################################");
            //testColl.CalculateTime(notexisting);

            //static int Positive()
            //{
            //    int size;
            //    Console.WriteLine("Enter the size of collections:");
            //    String temp = Console.ReadLine();
            //    while (!(int.TryParse(temp, out size)) || size < 0)
            //    {
            //        Console.Write("Enter the size of collections:");
            //        temp = Console.ReadLine();
            //    }
            //    return size;
            //}

            //static void AddRandEllements(GraduateStudentCollection gst)
            //{
            //    int amount = 10;
            //    GraduateStudet[] gradArr = new GraduateStudet[amount];
            //    for (int i = 0; i < amount; i++)
            //    {
            //        gradArr[i] = new GraduateStudet();
            //    }
            //    Random rand = new Random();
            //    int lastNameInt = 0;
            //    int learnigYearInt = 0;
            //    int y = 0;
            //    for (int i = 0; i < amount; i++)
            //    {
            //        lastNameInt = rand.Next(1, 400);
            //        learnigYearInt = rand.Next(1, 4);
            //        gradArr[i].LearningYear = learnigYearInt;
            //        y = rand.Next(DateTime.Today.Year - learnigYearInt - 30, DateTime.Today.Year - learnigYearInt - 18);
            //        gradArr[i].ChangeBirthday = y;
            //        gradArr[i].PersonProperty = new Person(gradArr[i].Name, gradArr[i].LastName + lastNameInt, gradArr[i].Date);
            //    }
            //    gst.AddGraduateStudents(gradArr);
            //}
            GraduateStudentCollection gst1 = new GraduateStudentCollection();
            GraduateStudentCollection gst2 = new GraduateStudentCollection();
            TeamsJournal tj1 = new TeamsJournal();
            TeamsJournal tj2 = new TeamsJournal();
            gst1.GraduateStudentAdded += tj1.makeTeamsJournalEntry;
            gst1.GraduateStudentInserted += tj1.makeTeamsJournalEntry;
            gst1.GraduateStudentInserted += tj2.makeTeamsJournalEntry;
            gst2.GraduateStudentInserted += tj2.makeTeamsJournalEntry;
            gst1.AddDefaults();
            gst2.AddDefaults();
            gst1.InsertAt(2, new GraduateStudet());
            gst2.InsertAt(200, new GraduateStudet());
            Console.WriteLine(tj1);
            Console.WriteLine("#####################################");
            Console.WriteLine(tj2);
        }
    }
}
