using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeljapäevaneTeineÜlesanne
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            // teeme massiivi
            int[,] arvud = new int[8, 8];
            // täidame selle juhuslike arvudega
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    arvud[i, j] = r.Next(1, 100);
                }
            }

            // trükime välja
            Console.Write("\t|"); // tabeli vasak ülemine nurk + TAB
            for (int i = 0; i < 8; i++) Console.Write($"{i}\t|"); 
            // seejärel numbrid 0..7 iga järel TAB ja püstkriips
            Console.WriteLine();
            Console.Write(new string('-',100)); // vahele pikk joon
            for (int i = 0; i < 8; i++) // nüüd ridade kaupa
            {
                Console.Write($"\n{i}\t|"); // iga rida uuelt realt, rea nr TAB |
                for (int j = 0; j < 8; j++) // siis veergude kaupa
                {
                    Console.Write($"{arvud[i,j]}\t|"); // arv massiivist TAB |
                }

            }
            Console.WriteLine(); // kuna ridu rohkem pole, siis tühi reavahetus lõppu
            //                  et oleks ilusam


                Console.Write("Mida otsid: ");
                int otsitav = int.Parse(Console.ReadLine());
                bool eiLeidnud = true;
                for (int i = 0; i < 8 && eiLeidnud; i++)
                    for (int j = 0; j < 8 && eiLeidnud; j++)
                    {
                        if (arvud[i, j] == otsitav)
                        {
                            Console.WriteLine($"leidsin arvu {otsitav} reast {i} ja veerust {j}");
                            eiLeidnud = false;
                        }

                    }
                if (eiLeidnud) Console.WriteLine("sellist arvu ma ei leidnud");
            
            
        }
    }
}
