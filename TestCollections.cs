using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace laboratorna5
{
    class TestCollections
    {
        List<Person> PersonList = new List<Person>();
        List<string> stringList = new List<string>();
        Dictionary<Person, GraduateStudet> typedKVDictionary = new Dictionary<Person, GraduateStudet>();
        Dictionary<string, GraduateStudet> typedStringVDictionary = new Dictionary<string, GraduateStudet>();
        public static GraduateStudet GenerateElement(int i)
        {
            GraduateStudet gr = new GraduateStudet();
            gr.PersonProperty = new Person(gr.Name, gr.LastName + i, gr.Date);
            return gr;
        }
        public TestCollections(int elem)
        {
            for (int i = 0; i < elem; i++)
            {
                GraduateStudet g = GenerateElement(i);
                PersonList.Add(g.PersonProperty);
                stringList.Add(g.PersonProperty.ToString());
                typedKVDictionary.Add(g.PersonProperty, g);
                typedStringVDictionary.Add(g.PersonProperty.ToString(), g);
            }
        }
        public void CalculateTime(GraduateStudet g)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            if (PersonList.Contains(g.PersonProperty))
            {
                Console.WriteLine("contains");
            }
            stopWatch.Stop();
            TimeSpan ts1d = stopWatch.Elapsed;
            Console.WriteLine($"Time to find the element in list of persons: {ts1d}");
            stopWatch.Start();
            if (stringList.Contains(g.PersonProperty.ToString()))
            {
                Console.WriteLine("contains");
            }
            stopWatch.Stop();
            TimeSpan ts2d = stopWatch.Elapsed;
            Console.WriteLine($"Time to find the element in list of strings: {ts2d}");
            stopWatch.Start();
            if (typedKVDictionary.ContainsKey(g.PersonProperty))
            {
                Console.WriteLine("contains");
            }
            stopWatch.Stop();
            TimeSpan ts3d = stopWatch.Elapsed;
            Console.WriteLine($"Time to find the element by key in Dictionary<Person, GraduateStudet>: {ts3d}");
            stopWatch.Start();
            if (typedKVDictionary.ContainsValue(g))
            {
                Console.WriteLine("contains");
            }
            stopWatch.Stop();
            TimeSpan ts4d = stopWatch.Elapsed;
            Console.WriteLine($"Time to find the element by value in Dictionary<Person, GraduateStudet>: {ts4d}");
            stopWatch.Start();
            if (typedStringVDictionary.ContainsKey(g.PersonProperty.ToString()))
            {
                Console.WriteLine("contains");
            }
            stopWatch.Stop();
            TimeSpan ts5d = stopWatch.Elapsed;
            Console.WriteLine($"Time to find the element by key in Dictionary<string, GraduateStudet>: {ts5d}");
            stopWatch.Start();
            if (typedStringVDictionary.ContainsValue(g))
            {
                Console.WriteLine("contains");
            }
            stopWatch.Stop();
            TimeSpan ts6d = stopWatch.Elapsed;
            Console.WriteLine($"Time to find the element by value in Dictionary<string, GraduateStudet>: {ts6d}");
        }
    }
}
