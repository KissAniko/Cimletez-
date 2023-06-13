using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimletező
{


    class Program
    {
        static void Main()
        {
            string mondat = "";
            bool megfelelo = false;

            while (!megfelelo)
            {
                Console.WriteLine("Kérem írjon be egy mondatot, ami megfelel az alábbi feltételeknek:");
                Console.WriteLine(" A mondat végén legyen a következők valamelyike [. ! ?]!");
                Console.WriteLine(" A mondat nagybetűvel kezdődjön!");
                Console.WriteLine(" A mondat legalább három szóból álljon! (szóközzel elválasztott részek)");
                mondat = Console.ReadLine();

                Console.WriteLine();

                if (mondat.EndsWith(".") || mondat.EndsWith("!") || mondat.EndsWith("?"))
                {
                    if (char.IsUpper(mondat[0]))
                    {
                        string[] szavak = mondat.Split(' ');
                        if (szavak.Length >= 3)
                        {
                            megfelelo = true;
                        }
                    }
                }

                if (!megfelelo)
                {
                    Console.WriteLine("A megadott mondat nem felel meg a feltételeknek! Próbáld újra.");
                }
            }

            Console.WriteLine("A megadott mondat megfelel a feltételeknek.");

            

            
        }

    }
}