using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisekcja
{
    static public class GetData
    {
        /*
         * Klasa przechowująca metody służące do pobierania wszystkich wartości
         * od użytkownika. Każda z funkcji zawiera mechanizm zabezpieczający przed 
         * wprowadzeniem danych o nieprawidłowym formacie.
         */

        /*
         * Metoda pobierająca dane mówiące o ilości argumentów wielomianu oraz ich wartościach
         */
        static public double[] getValues()
        {
            bool status = true;
            int amount = 0;

            while (status)
            {
                Console.Write("\nPodaj ilość współczynników: ");
                if (int.TryParse(Console.ReadLine(), out amount))
                    status = false;
                else
                {
                    Console.WriteLine("\nZły format danych wejściowych!");
                    status = true;
                }
            }
                

            double[] a = new double[amount];
            Operations.zeroArgumentsCheck(amount);
            for (int i = a.Length - 1; i >= 0; i--)
            {
                bool loopstatus = true;
                while (loopstatus)
                {
                    Console.Write("Podaj współczynnik a{0}: ", i);
                    if (double.TryParse(Console.ReadLine().Replace('.', ','), out a[i]))
                        loopstatus = false;
                    else
                    {
                        Console.WriteLine("\nZły format danych wejściowych!");
                        loopstatus = true;
                    }
                }
            }
            Console.WriteLine("\n");
            return a;
        }

        /*
         * Poniżej znajdują się metody, które są odpowiedzialne za pobranie
         * danych niezbędnych do sprawdzenia warunku funkcji oraz ewentualnego
         * obliczenia jej pierwiastków za pomocą bisekcji - przedział, dokładność
         * oraz maksymalna liczba iteracji obliczeń 
         */
        static public double getIntervala()
        {
            double k = 0;
            bool loopstatus = true;
            while (loopstatus)
            {
                Console.Write("Podaj pierwszą granicę przedziału (a): ");
                if (double.TryParse(Console.ReadLine(), out k))
                    loopstatus = false;
                else
                {
                    Console.WriteLine("\nZły format danych wejściowych!");
                    loopstatus = true;
                }
            }
            return k;
        }

        static public double getIntervalb()
        {
            double l = 0;
            bool loopstatus = true;
            while (loopstatus)
            {
                Console.Write("Podaj drugą granicę przedziału (b): ");
                if (double.TryParse(Console.ReadLine(), out l))
                    loopstatus = false;
                else
                {
                    Console.WriteLine("\nZły format danych wejściowych!");
                    loopstatus = true;
                }
            }
            return l;
        }

        static public double getEps()
        {
            double eps = 0;
            bool loopstatus = true;
            while (loopstatus)
            {
                Console.Write("Podaj dokładność obliczanej wartości pierwiastka funkcji: ");
                if (double.TryParse(Console.ReadLine(), out eps))
                    loopstatus = false;
                else
                {
                    Console.WriteLine("\nZły format danych wejściowych!");
                    loopstatus = true;
                }
            }
            return eps;
        }

        static public int getMax()
        { 
            int max = 0;
            bool loopstatus = true;
            while (loopstatus)
            {
                Console.Write("Podaj maksymalną liczbę iteracji obliczeń: ");
                if (int.TryParse(Console.ReadLine(), out max))
                    loopstatus = false;
                else
                {
                    Console.WriteLine("\nZły format danych wejściowych!");
                    loopstatus = true;
                }
            }
            return max;
        }
    }
}
