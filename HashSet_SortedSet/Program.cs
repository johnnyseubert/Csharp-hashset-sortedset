using System;
using System.Collections.Generic;
using System.Linq;

namespace HashSet_SortedSet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0,2,4,5,6,8,10 };
            SortedSet<int> b = new SortedSet<int>() { 5,6,7,8,9,10 };

            SortedSet<int> c = new SortedSet<int>(a);
            
            //union
            c.UnionWith(b);
            Console.Write("Union: ");
            PrintColletion(c);
            
            //intersection

            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            Console.Write("Intersection: ");
            PrintColletion(d);

            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Console.Write("ExceptWith: ");
            PrintColletion(e);
            
        }

        static void PrintColletion<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }

            Console.WriteLine();
        }
        
    }
}