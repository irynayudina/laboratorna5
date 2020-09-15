using System;
using System.Collections.Generic;

namespace laboratorna5
{
    class GraduateStudentCollection
    {
        private List<GraduateStudet> ListOfStudents = new List<GraduateStudet>();
        public string nameOfTheCollection { get; set; }
        public delegate void GraduateStudentListHandler(object source, GraduateStudentListHandlerEventArgs args);
        public event GraduateStudentListHandler GraduateStudentAdded;
        public event GraduateStudentListHandler GraduateStudentInserted;
        public void AddDefaults()
        {
            /*c допомогою якого можна додати деяке число елементів
              * типу GraduateStudent для ініціалізації колекції за замовчуванням; */
            int sizedef = 7;
            GraduateStudet[] p = new GraduateStudet[sizedef];
            for (int i = 0; i < sizedef; i++)
            {
                GraduateStudet grd = new GraduateStudet();
                grd.LastName = grd.LastName + i;
                p[i] = grd;
            }
            ListOfStudents.AddRange(p);
            GraduateStudentAdded?.Invoke(this, new GraduateStudentListHandlerEventArgs("ListOfStudents",
                    "element was added to the end of the list", ListOfStudents.Count));

        }
        public void InsertAt(int j, GraduateStudet gs)
        {
            if (ListOfStudents[j] != null)
            {
                ListOfStudents.Insert(j - 1, gs);
                GraduateStudentInserted?.Invoke(this, new GraduateStudentListHandlerEventArgs("ListOfStudents",
                    $"element was inserted to the {j - 1} posittion of the list", j - 1));


            }
            else
            {
                ListOfStudents.Add(gs);
                GraduateStudentAdded?.Invoke(this, new GraduateStudentListHandlerEventArgs("ListOfStudents",
                    "element was added to the end of the list", ListOfStudents.Count));
            }
        }
        public GraduateStudet this[int index]
        {
            get
            {
                return ListOfStudents[index];
            }
            set
            {
                ListOfStudents[index] = value;
            }
        }
        

        public void AddGraduateStudents(params GraduateStudet[] p)
        {
            ListOfStudents.AddRange(p);
            GraduateStudentAdded?.Invoke(this, new GraduateStudentListHandlerEventArgs("ListOfStudents",
                    "element was added to the end of the list", ListOfStudents.Count));
        }
        public override string ToString()
        {
            string res = "";
            foreach (GraduateStudet g in ListOfStudents)
            {
                res += g.ToString();
            }
            return res;
        }
        public string ToShortString()
        {
            string res = "";
            foreach (GraduateStudet g in ListOfStudents)
            {
                res += g.ToShortString();
            }
            return res;
        }
        public void SortByLastName()
        {
            ListOfStudents.Sort();
        }
        public void SortByBirthday()
        {
            ListOfStudents.Sort(new Person());
        }
        public void SortByLearningYear()
        {
            ListOfStudents.Sort(new GraduateStudet.YearComparer());
        }
    }
}
