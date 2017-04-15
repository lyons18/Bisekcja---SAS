using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisekcja
{
    static class Calculations
    {
        /*
        *Klasa w której znajdują się metody służące do wykonywania obliczeń,
        *sprawdzenia podstawowych warunków oraz przeprowadzenia obliczeń metodą bisekcji 
        */




        /*
         * Metoda służąca do obliczenia i zwracania wartości wielomianu 
         * w zależności od podanego argumentu 
        */
        static public double solveFunction(double[] a, double arg)
        {
            double functionResult = 0;
            for (int i = a.Length - 1; i >= 0; i--)
                functionResult += (a[i] * (Math.Pow(arg, Convert.ToDouble(i))));
            return functionResult;
        }

        /*
         * Metoda służąca do sprawdzenia podstawowego warunku funkcji, 
         * który musi być spełniony, aby można byłą ją obliczyć za pomocą
         * bisekcji. 
         * Jeśli szukamy pierwiastka funkcji f(x) w przedziale [a,b], 
         * to na krańcach tego przedziału musi mieć różne znaki - f(a) * f(b) < 0 
        */
        static public bool checkCondition(double[] a, double k, double l)
        {
            bool status = false;
            double condition = Calculations.solveFunction(a, k) * 
                Calculations.solveFunction(a, l);
            if (condition < 0)
                status = true;
            return status;    
        }

        /*
         * Metoda służąca do obliczenia pierwiastka funkcji metodą bisekcji. 
         * Wcześniej trzeba określić, czy funkcja spełnia podstawowy warunek
         * opisany wyżej. Wykonywanie funkcji kończy się w momencie znalezienia 
         * pierwiastka funkcji lub gdy funkcja wykonana maksymalną liczbę
         * iteracji obliczeń.
        */
        static public void bisectionMethod(double[] arguments, double k, double l, double eps, double max)
        {
            double arg = (k + l) / 2;
            double result;
            double result_a = Calculations.solveFunction(arguments, k);
            for (int i = 0; i <= max; i++)
            {
                if (i < max)
                {
                    if (Math.Abs(k - l) > eps)
                    {
                        arg = (k + l) / 2;
                        result = Calculations.solveFunction(arguments, arg);
                        if (result * result_a < 0)
                            l = arg;
                        else
                        {
                            k = arg;
                            result_a = result;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nUzyskany wynik: {0}", arg);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\nZostała przekroczona ilość iteracji.\nUzyskany wynik po {0} iteracjach: {1}", max, arg);
                    break;
                }
                   
            }
        }

    }
}
