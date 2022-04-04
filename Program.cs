using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ucitavanje koeficijenata kvadratne jednadzbe
            Console.WriteLine("Unesite koeficijent x2");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite koeficijent ispred x");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite slobodan koeficijent");
            double c = Convert.ToDouble(Console.ReadLine());

            //Izracunavanje elemenata potrebnih za rjesenje jednadzbe
           double b2 = Math.Pow(  b, 2);
           double diskriminanta = Math.Sqrt(b2-(4 * a * c));

            //Grananje s obzirom na diskriminantu
            if (diskriminanta > 0)
            {
                double rjesenje1 = (-b - diskriminanta)/ 2 * a;
                double rjesenje2 = (-b + diskriminanta) / 2 * a;
                Console.Write("x1= {0} \nx2= {1}", rjesenje1, rjesenje2);
            }
            else if(diskriminanta == 0)
            {
                double rjesenje1 = (-b - diskriminanta) / 2 * a;
                double rjesenje2 = (-b + diskriminanta) / 2 * a;
                Console.Write("Jednadzba ima jedno dvostruko realno rjesenje \nx1={0}\nx2={1}"
                              ,rjesenje1,rjesenje2);

            }
            else
            {
                Console.Write("Jednadzba nema realna rjesenja");
            }

        }
    }
}

