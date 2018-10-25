using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiividJaTsüklid
{
    class Program
    {
        static void Main(string[] args)
        {
            int arv=77;

            //int[] arvud = new int[10];
            //int[] arvud = new int[] {1,2,3,4+arv,5,6,7,8,9,11,22,33};
            int[] arvud = {1,2,3,4+arv,5,6,7,8,9,11,22,33};
            int[] tyhi = { };
            arvud[4] = 7;
            arvud[4]++;
            Console.WriteLine(arvud[4]);
            Console.WriteLine(arvud[7]);



            int[][] misasiseeon = {
                    new int[]{ 1, 2, 3 },
                    new int[]{ 7, 5 },
                    new int[]{ },
                    new int[]{ 1, 2, 3, 4, 5 }
            };
            Console.WriteLine(misasiseeon[1][0]);
            int[,] tabel = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 2, 4, 8 } };
            Console.WriteLine(tabel[2,0]);




            // tsükkel


            // esimene kõige lihtsam tsükkel
            // FOR-tsükkel

            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine(arvud[i]);
            }

            // kolm lauset tükli peas
            // 1. initializer 
            // 2. terminator
            // 3. iterrator
            // body

            // a) initializer
            // b) termninator
            // c) if (terminator) {body; iterrator; goto b} 

            for (int i = 0; i < arvud.Length; i++) { arvud[i] = i * i; }

            // for tsükkel ei ole ainukene
            // teine on while tsükkel (mid ategelikult ei ole vaja)

            // võimalik while tsükkel
            int j = arvud.Length;
            while ( j > 0)
            {
                Console.WriteLine(arvud[--j]);
            }

            // seesama ÜLESANNE for tsükliga
            for (int jj = arvud.Length; jj > 0; jj--)
            {
                Console.WriteLine(arvud[jj]);
            }

            // foreach tsükkel
            // töötab massiividel ja teistel kollektsioonidel
            // keeruline selgitada kuidas, aga näe toimib ja lihtne lugeda
            {
                int jrknr = 0;
                foreach (int x in arvud)
                {
                    Console.WriteLine($"element numbriga {jrknr++} on {x}");
                }

            }

            {
                int k = 0; // muutuja k ei lähe üleüldiseks
                while (arvud[k] == 22 || ++k > arvud.Length) ;
                if (k < arvud.Length) Console.WriteLine($"leidsin pesast {k}");
                else Console.WriteLine("ei leidnud seekord");
            }
            Console.Write("anna üks arv");
            int vastus = 0;
            while( ! int.TryParse(Console.ReadLine(), out vastus))
                Console.Write("see pole miski arv, anna uus: ");
            Console.WriteLine($"tubli - sinu antud arv on {vastus}");
        }
    }
}
