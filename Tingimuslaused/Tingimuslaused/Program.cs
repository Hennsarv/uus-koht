using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tingimuslaused
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                const decimal MIINIMUM = 500M;
                // misasi on tingimuslause
                Console.Write("Palju sa palka saad: ");
                //decimal palk = decimal.Parse(Console.ReadLine());
                string vastus = Console.ReadLine();
                if (decimal.TryParse(vastus, out decimal palk))
                {
                    decimal tulumaks = (palk - MIINIMUM) * (palk < MIINIMUM ? 0.0M : 0.2M);
                    Console.WriteLine($"sinu tulumaks on {tulumaks}");

                    if (palk > 1000)
                    {
                        Console.WriteLine("sinuga võiks õhtul sööma minna kuhugi");
                    }
                    else if (palk > 500)
                    {
                        Console.WriteLine("läheme siis sööme jäätist");
                    }
                    else
                    {
                        Console.WriteLine("läheme siis harjumäele jalutama");
                    }
                }
                else Console.WriteLine("ära keeruta");
            }

            if ( ! (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)) 
            Console.WriteLine("täna olen õhtul kodus");

            string kastänaonkolmapäev
                = DateTime.Today.DayOfWeek == DayOfWeek.Wednesday
                ? "täna on kolmapäev" : "täna ei ole kolmapäev";

            Console.WriteLine(kastänaonkolmapäev);
        }
    }
}
