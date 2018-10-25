using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valgusfoor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (false)
            {
                Console.Write("mis värvi tuli seal on: ");
                string värv = Console.ReadLine().ToLower();
                // ülesANNET VÕIB LAHENDADA nii, aga mis siin valesti on
                if (värv == "roheline" || värv == "green")
                {
                    Console.WriteLine("sõida julgelt edasi");
                }
                else if (värv == "punane" || värv == "red")
                {
                    Console.WriteLine("jää kohe seisma");
                }
                else if (värv == "kollane" || värv == "yellow")
                {
                    Console.WriteLine("oota kuni tuleb roheline"); 
                }
                else
                {
                    Console.WriteLine("värvipime oled sa");
                }
            }

            if (false)
            {
                Console.Write("mis värvi tuli seal on: ");
                string värv2 = Console.ReadLine().ToLower();

                switch (värv2)
                {
                    case "roheline": case "green": Console.WriteLine("sõida edasi"); break;
                    case "punane":
                        Console.WriteLine("jää seisma");
                        break;
                    case "kollane":
                        Console.WriteLine("oota natsa");
                        goto case "roheline";
                    default:
                        Console.WriteLine("värvipime oled");
                        break;
                }

            }

            // Laupäeval-pühapäeval õlut
            // laupäeval sauna
            // E-R tööle
            // K - peale tööd trenni

            DayOfWeek np = (DateTime.Now).DayOfWeek;
            if (np == DayOfWeek.Sunday)
            {
                Console.WriteLine("õlut tuua");
            }
            else if (np == DayOfWeek.Saturday)
            {
                Console.WriteLine("õlut tuua ja sauna kütta");
            }
            else
            {
                Console.WriteLine("tööle minna");
                if (np == DayOfWeek.Wednesday)
                {
                    Console.WriteLine("trenni vaja minna");
                }
            }

            switch(np)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("õlutit juua ohtrasti");
                    break;
                //case DayOfWeek.Saturday:
                //    Console.WriteLine("sauna kütta");
                //    goto case DayOfWeek.Sunday;
                ////case DayOfWeek.Wednesday:
                //    Console.WriteLine("õhtul läheme trenni");
                //    goto default;
                default:
                    Console.WriteLine("täna vaja tööle minna");
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                        Console.WriteLine("õhtul trenni");
                    break;
            }

            string npNimi = np.ToString();
            Console.WriteLine("Täna on " + npNimi);
            if (npNimi[0] == 'S') Console.WriteLine("õlutit!");
            else Console.WriteLine("täna õlutit ei saa");


        }
    }
}
