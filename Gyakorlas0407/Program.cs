using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas0407
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"fájlbeolvasás, tárolás");
            Console.WriteLine($"adatok száma");
            Console.WriteLine($"legnagyobb elem helye");
            Console.WriteLine($"van budapesti lakos");
            Console.WriteLine($"mindenki 18 feletti");
            Console.WriteLine($"ki lakik a XIII. kerületben");
            Console.WriteLine($"milyen kerületekben laknak");
            Console.WriteLine($"melyik kerületben hányan laknak");

            string[] sorok = File.ReadAllLines("adat3.txt");
            List<Adat> adatok = new List<Adat>();
            foreach (string sor in sorok.Skip(1))
            {
                adatok.Add(new Adat(sor));
            }

          

            Console.ReadLine();
        }
    }
}
