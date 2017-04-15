using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisekcja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
-------------------------------------------------------------------------------
OBLICZANIE PIERWIASTKÓW FUNKCJI METODĄ BISEKCJI                                |
-------------------------------------------------------------------------------
Program dla SAS Institute Polska na potrzeby rekrutacji do Akademii SAS        |
-------------------------------------------------------------------------------
Marek Pankowski - kwiecień 2017                                                |
-------------------------------------------------------------------------------");


            /*
             * Zbieranie niezbędnych danych do wykonania programu za pomocą 
             * funkcji z klasy GetData
             */
            double[] arguments = GetData.getValues();
            double k = GetData.getIntervala();
            double l = GetData.getIntervalb();
            double eps = GetData.getEps();
            int max = GetData.getMax();

            /*
             * Poniższe metody służą do:
             * - sprawdzenia podstawowego warunku funkcji, której pierwiastek
             * chcemy obliczyć
             * - wykonania obliczenia pierwiastków za pomocą bisekcji
             */
            Operations.checkFunctionCondition(arguments, k, l);
            Calculations.bisectionMethod(arguments, k, l, eps, max);
            Console.ReadLine();
        }
    }
}
