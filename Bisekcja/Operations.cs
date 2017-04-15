using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisekcja
{
    public static class Operations
    {
        /*
         * Klasa przechowująca metody służące do obsługi programu,
         * w razie, gdyby wprowadzone wartości uniemożliwiałyby 
         * policzenie argumentów za pomocą bisekcji
         */


        /*
        * Metoda obsugująca wyłączenie programu, w razie gdyby
        * wprowadzona ilość argumentów wielomianu była mniejsza lub równa 0
        */
        public static void zeroArgumentsCheck(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Brak współczynników! Zamykanie...");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        /*
        * Metoda obsługująca wyłączenie programu w razie gdyby
        * podstawowy warunek funkcji nie został spełniony 
        */
        public static void checkFunctionCondition(double[] a, double k, double l)
        {
            if (!Calculations.checkCondition(a, k, l))
            {
                Console.WriteLine("Funkcja nie spełnia podstawowego warunku! Zamykanie...");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

    }
}
