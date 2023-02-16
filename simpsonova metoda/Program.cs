using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpsonova_metoda
{
    class Program
    {
        public static double F(double x)
        {
            double y = Math.Sin(x);
            return y;
        }
        static double SimpsonovaMetoda(double a, double b, int m)
        {
            double S = 0;
            double h = (b - a) / (2 * m);
            S += F(a);
            for (int i = 1; i <= m; i++)
            {
                S += 4 * F(a + h * (2 * i - 1));
                S += 2 * F(a + h * (2 * i));
            }
            return S * (h/3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("NUMERICKÁ INTEGRACE");
            Console.Write("    Zadej dolní mez intervalu: ");
            double dolní = double.Parse(Console.ReadLine());
            Console.Write("    Zadej horní mez intervalu: ");
            double horní = double.Parse(Console.ReadLine());
            Console.Write("    Zadej počet dělení intervalu: ");
            int pocet = int.Parse(Console.ReadLine());
            Console.WriteLine("    Obsah obrazce ohraničeného grafem: " + SimpsonovaMetoda(dolní, horní, pocet));
            Console.ReadLine();
        }
    }
}
