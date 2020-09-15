using System;
using System.Collections.Generic;

namespace laboratorna5
{
    class Person : IDateAndCopy, IComparable, IComparer<Person>
    {
        protected string name;
        protected string lastName;
        protected DateTime birthday;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime Date
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public int ChangeBirthday
        {
            get { return Date.Year; }
            set { Date = new DateTime(value, Date.Month, Date.Day); }
        }
        public Person(string name, string lastName, DateTime birthday)
        {
            Name = name;
            LastName = lastName;
            Date = birthday;
        }
        public Person()
        {
            Name = "Iryna";
            LastName = "Yudina";
            Date = new DateTime(2001, 01, 27);
        }
        override public string ToString()
        {
            return ($"\n Name: {Name}\n Last Name: {LastName}\n" +
                $" Date of birthday: {Date}\n");
        }
        public virtual string ToShortString()
        {
            return ($"{Name} {LastName}");
        }
        public override bool Equals(object obj)
        {
            if (obj != null && obj.ToString() == this.ToString())
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return !p1.Equals(p2);
        }
        public virtual object DeepCopy()
        {
            Person p = (Person)this.MemberwiseClone();
            p.Name = new string(Name);//String.Copy(Name);
            p.LastName = new string(LastName); //String.Copy(LastName);
            return p;
        }
        /*
         interfaces implementation
        */
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Person other = obj as Person;
            if (other != null)
                return this.LastName.CompareTo(other.LastName);
            else
                throw new ArgumentException("Object is not a Person");
        }
        public int Compare(Person x, Person y)
        {
            if (x.Date.CompareTo(y.Date) != 0)
            {
                return x.Date.CompareTo(y.Date);
            }
            else
            {
                return 0;
            }
        }

    }
}
