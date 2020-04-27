
using System;

namespace Referencja
{

    class refere
        {
        public int wartosc3;
        }
    class Program
    {
        static void Main(string[] args)
        {
            int wartosc = 5;
            int wartosc2 = wartosc;
            Console.WriteLine("Pierwsza wartość: " + wartosc + " " + "Druga wartość: " + " " + wartosc2);
            wartosc2 = 10;
            Console.WriteLine("Pierwsza wartość: " + wartosc + " " + "Druga wartość: " + " " + wartosc2);

            refere obj1 = new refere();
            obj1.wartosc3 = 20;
            refere obj2 = obj1;
            Console.WriteLine("Wartość obiektu 1: " + obj1.wartosc3 + " " + "Wartość obiektu 2: " + " " + obj2.wartosc3);
            obj2.wartosc3 = 25;
            Console.WriteLine("Wartość obiektu 1: " + obj1.wartosc3 + " " + "Wartość obiektu 2: " + " " + obj2.wartosc3);

            Console.ReadKey();
        }
    }

}