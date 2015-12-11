using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerbestandrechnung
{
    class Program
    {
        static void Main()
        {
            double dlagerb;
            double us;
            double dlagerd;
            double lagerz;

            Console.WriteLine("Bitte geben Sie den Jahresanfangs Bestand ein: ");
            double jab = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie den Jahresbestand ein: ");
            double jb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wieviel Komponenten wurden im Laufe des Jahres entnommen: ");
            double entkomp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben sie den Jahreszinssatz in % ein");
            double jzs = Convert.ToDouble(Console.ReadLine());

            dlagerb = (jab + jb) / 2;
            us = entkomp / dlagerb;
            dlagerd = 360 / us;
            lagerz = (jzs * us) / 360;

            Console.WriteLine("Durchschnittlicher Lagerbestand \n Berechnung: ( Jahresanfangs + Jahresbestand ) /2 ) \n also ( {0} + {1} ) / 2 ) \n", jab, jb);
            Console.WriteLine("Durchschnittlicher Lagerbestand beträgt: " + dlagerb + " Komponenten \n");

            Console.WriteLine("Berechnung Umschlagshäufigkeit \n ( Laufende Komponenten im Jahr / Durchschnittlicher Lagerbestand ) \n ( {0} / {1} ) \n", entkomp, dlagerb);
            Console.WriteLine("Die Umschlagshäufigkeit beträgt: " + us +"\n");

            Console.WriteLine("Die Durchschnittliche Lagerdauer beträgt " + dlagerd + " Tage");
            Console.WriteLine("Der Lagerzinssatz beträgt " + lagerz + "%");

            Console.ReadKey();
        }
    }
}
