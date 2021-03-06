﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
meil on nimekiri (nimed teada, näiteks Henn, Ants, Peeter, mõtle ise...)

meil on massiiv, kuhu tulevad vanused
need küsid ekraanilt (võid ka lisada, et kui vigane vastus, küsid uuesti)
ntx: Anna õpilase HENN vanus:
loed vanused ja jätad meelde (mõtled kuidas)

1. Leiad, kes (nimeliselt) on kõige vanem
2. Leiad keskmise vanuse
3. Leiad, kelle vanus on keskmisele kõige lähemal!

kui valmis, vaatad, kuidas naabril läheb ja kas ta vajab abi või nõu

Kui viitsimist, teed sama ülesande, aga nii, et ksüid iga inimese sünnipäeva
Kui VEEL viitsimist, siis sünnipäeva asemel isikukoodi 
(vajab isesesivat pusimist) punktid 1. 2. 3. jäävad samaks 
*/

namespace NeljapäevaneÜlesanne
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nimekiri =
            { // siia võib siis nimesid lisada
                "Henn",
                "Ants",
                "Peeter",
                "Jaan",
                "Joosep"
            };
            // siin on oluline, et vanuste massiiv oleks (vähemalt) samapikk
            int[] vanused = new int[nimekiri.Length];
            // laiskusest jätan selle vanuste küsimise ära, pärast teen
            //vanused = new int[] { 63, 80, 28, 40, 80 };
            // NB! siin ei saa new int[] ära jätta - seda saab vaid siis,
            //     kui initsializer on muutuja definitsiooniga samas lauses

            // teeme siia vanuste lugemise
            for (int i = 0; i < nimekiri.Length; i++)
            {
                Console.Write($"Anna õpilase {nimekiri[i]} vanus: ");
                int vastus; // = int.Parse(Console.ReadLine());
                while(! int.TryParse(Console.ReadLine(), out vastus ))
                {
                    Console.WriteLine("see pole miski vanus");
                    Console.Write("anna uuesti: ");
                }
                vanused[i] = vastus;
            }


            // kontrollliks trükime välja
            Console.WriteLine("\nNimekiri kontrolliks\n");
            for (int i = 0; i < nimekiri.Length; i++)
            {
                Console.WriteLine($"{nimekiri[i]} vanus on {vanused[i]}");
            }
                        
            // kuidas leiame keskmise
            // liidame vanused kokku ja jagame õpilaste arvuga
            double  summa = 0;
            foreach (int v in vanused) summa += v;
            Console.WriteLine($"\nKeskmine vanus on {(summa) / nimekiri.Length}\n");

            // NB! tagapool läheb seda keskmist vaja - jätame meelde
            double keskmine = summa / nimekiri.Length;

            // NB! siin tuleb vale vastus - õige oleks 45,6

            // edasi vaja leida, kes on kõige vanem
            // leiame kõige suurema numbri massiivis ja jätame meelde,
            // mitmes see oli - siis saame nime öelda (teisest)

            
            

            // oletame, et 1. nimekirjas on kõige vanem
            int mitmes = 0; int vanus = vanused[mitmes];
            // nüüd vaatame teised vanused üle ja kui mõni on suurem
            // jätame selle meelde hoopis
            for (int i = 1; i < vanused.Length; i++)
                if (vanused[i] > vanus)
                { vanus = vanused[i]; mitmes = i; }
            Console.WriteLine($"Kõige vanem on {nimekiri[mitmes]} ta on {vanused[mitmes]} aastane");

            //NB! mõtle, mis juhtub, kui samavanu on mitu, 
            // kes siis vastuseks satub - PROOVI!
            // kuidas teha nii, et KÕIK samavanad (vanimad) välja tükitaks

            //for (int i = 0; i < nimekiri.Length; i++)
            //    if(vanused[i] == vanus)
            //{
            //    Console.WriteLine($"Kõige vanem on {nimekiri[i]} ta on {vanus} aastane");

            //    }




            double kaugus = (keskmine - vanused[0]);
            if (kaugus < 0) kaugus = -kaugus;
            mitmes = 0;
            for (int i = 0; i < vanused.Length; i++)
                if(Math.Abs(keskmine-vanused[i]) < kaugus)
                {
                    kaugus = Math.Abs(keskmine - vanused[i]);
                    mitmes = i;

                }
            Console.WriteLine($"\nkeskmisele lähim on {nimekiri[mitmes]}\n");

            // NB! nüüd, kui keskmise-vanima-lähima arvutamine NÄIDISVANUSTEGA
            // on tehtud, nüüd võiks siis lisada (algusse) selle osa, mis käib
            // vanuseid küsimas
        }
    }
}
