using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neved:");
            string nev = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Havi alapbéred:");
            int alapber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Havi juttatásaid:");
            int juttatas=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Havi nyelvi pótlékod:");
            int nypotlek=Convert.ToInt32(Console.ReadLine());

            int jovedelem = (alapber + juttatas + nypotlek)*12;
            double kisado = jovedelem * 0.16;
            double nagyado = jovedelem * 0.36;

            if (jovedelem > 1000000)
            {
                Console.WriteLine("Mivel az éves jövedelmed {0} Ft, így 36%-os adót kell fizetned. Összege: {1} Ft", jovedelem, nagyado);
            }
            else
            {
                Console.WriteLine("Mivel az éves jövedelmed {0} Ft, így 16%-os adót kell fizetned. Összege: {1} Ft", jovedelem, kisado);
            }

            Console.Read();
        }
    }
}
