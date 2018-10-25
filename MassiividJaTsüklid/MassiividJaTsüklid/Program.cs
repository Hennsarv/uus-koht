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
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine($"massiivi {i}. element on {arvud[i]}");
            }


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


        }
    }
}
