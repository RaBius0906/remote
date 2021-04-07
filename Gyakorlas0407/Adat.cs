using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas0407
{
    class Adat
    {
        //fejléc: Név;Kor;Hely;Ker
        private string nev;
        private int kor;
        private string hely;
        private int ker;


        public Adat(string fajlEgySora)
        {

            string[] s = fajlEgySora.Split('|');
            //indexek:     0     1  2   3
            //fájl 1 sora: Petra;19;Bp;20
            this.nev = s[0];
            this.kor = int.Parse(s[1]);
            this.hely = s[2];
            this.ker = int.Parse(s[3]);

        }

        public string getNev() { return nev; }
        public int getKor() { return kor; }
        public string getHely() { return hely; }
        public int getKer() { return ker; }



    }
}
