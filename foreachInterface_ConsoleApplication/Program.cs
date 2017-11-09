using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace foreachInterface_ConsoleApplication
{
    class A : IEnumerable
    {
        public int[] zahlen = new int[10];      // new, weil auch int ist eine Klasse, genau wie string oder char usw...


        public A()
        {
            WriteLine("Ich bin ein A");
            for (int zaehl = 0; zaehl < 10; zaehl++)
            {
                WriteLine("Im Array zahlen wird {0} eingefügt", zaehl);
                zahlen[zaehl] = zaehl;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();        // hier muss Enumerable codiert werden
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<A> meineAs = new List<A>();
            for (int zaehl = 0; zaehl < 10; zaehl++)
            {
                meineAs.Add(new A());
            }

            WriteLine("Es sind {0} Elemente in meineAs", meineAs.Count);

            ReadLine();

            foreach (var element in meineAs)
            {
                WriteLine("Wieder ein A Element");
            }

            ReadLine();

            foreach (var element in meineAs)
            {
                foreach (var zahl in element.zahlen) // Enumerable hinzufügen          // foreach ( var zahl in element) element weiß nicht, wie oft das denn passieren soll
                {
                    WriteLine(zahl);
                }
            }

            ReadLine();

            // WriteLine(meineAs[0].zahlen[3]);       // einzelnes Element der Liste, dort ist ein Feld von Zahlen!
        }
    }
}
