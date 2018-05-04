using System;
using System.Runtime.InteropServices.ComTypes;

namespace Isen.Cs.Library.Lessons
{
    public class D_MyCollection
    {
        public static void Run()
        {
            var myCollection = new MyCollection();
            myCollection.Add("hey");
            myCollection.Add("coucou");
            myCollection.Add("hello");
            myCollection.Add("bonne nuit ");


            foreach (var str in myCollection.Values)
                Console.WriteLine(str);
            myCollection.InsertAt(2,"pfoublblbl");

            foreach (var str in myCollection.Values)
                Console.WriteLine(str);
        }
    }
}