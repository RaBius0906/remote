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
            int i; //válaszokhoz


            //Console.WriteLine($"fájlbeolvasás, tárolás");
            string[] sorok = File.ReadAllLines("adat3.txt");
            List<Adat> adatok = new List<Adat>();
            foreach (string sor in sorok.Skip(1))
            {
                adatok.Add(new Adat(sor));
            }

            int N = adatok.Count;
            //Console.WriteLine(N);
            Console.WriteLine($"Adatok száma:" + N);


            //van e, aki valamilyen: eldöntés I.
            Console.WriteLine($"Van budapesti lakos?");
            i = 0;
            while (i < N && !(adatok[i].getHely() == "Budapest")) { i++; }
            bool van = i < N;
            Console.WriteLine(van ? "van" : "nincs");

            //mindenki valamilyen: eldöntés II.
            Console.WriteLine($"Mindenki 18 feletti?");
            i = 0;
            while (i < N && adatok[i].getKor() > 18 ) { i++; }
            bool mind = i >= N;
            Console.WriteLine(mind ? "igen" : "nem");

            //min / max
            Console.WriteLine($"A legidősebb ember neve?");            
            int ind = 0;
            for (i = 1; i < N; i++)
            {
                if (adatok[i].getKor() > adatok[ind].getKor())
                {
                    ind = i;
                }
            }
            Console.WriteLine(adatok[ind].getNev());


            //hányféle van vmiből? -> HashSet
            Console.WriteLine($"Milyen kerületekben laknak?");           
            HashSet<int> keruletek = new HashSet<int>();
            foreach (Adat adat in adatok)
            {
                keruletek.Add(adat.getKer());
            }

            foreach (int ker in keruletek)
            {
                Console.WriteLine($"\t{ker}");
            }

            //melyikből hány darab van? -> Dictionary
            Console.WriteLine($"Melyik kerületben hányan laknak?");           
            //          kulcs:érték
            Dictionary<int, int> kerDb = new Dictionary<int, int>();
            foreach (Adat adat in adatok)
            {
                int kulcs = adat.getKer();
                if (kerDb.ContainsKey(kulcs))
                {
                    kerDb[kulcs]++;
                }
                else
                {
                    kerDb.Add(kulcs, 1);
                }
            }
            foreach (KeyValuePair<int, int> item in kerDb)
            {
                Console.WriteLine($"{item.Key}. kerületben {item.Value} ember lakik");
            }

            Console.WriteLine($"Ki(k) lakik(nak) a XIII. kerületben?");
            for (i = 1; i < N; i++)
            {
                if (adatok[i].getKor() == 13)
                {
                    Console.WriteLine(adatok[i].getNev());
                }
            }
            //Console.WriteLine(adatok[].getNev());


            Console.ReadLine();
        }
    }
}
