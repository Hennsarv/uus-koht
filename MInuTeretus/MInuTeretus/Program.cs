using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MInuTeretus
{
    class Program
    {

        /// <summary>
        /// see funktsioon liidab asju kokku
        /// </summary>
        /// <param name="x">esimene liidetav</param>
        /// <param name="y">teine liidetav</param>
        /// <returns></returns>
        public static int Liida(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {

            string nimi = "\tHenn on " + (char)10 +  " \"hea\" \t poiss";

            Console.WriteLine(nimi);

            Console.WriteLine('0'+0);
            Console.WriteLine('\0'+0);

            string failinimi = @"C:\Users\sarvi\Source\Repos\Teispäev\MInuTeretus\MInuTeretus\App.config";

            Console.Write("anna üks arv: ");
            string lugesin = Console.ReadLine();
            int arv = int.Parse(lugesin);
            Console.WriteLine($"lugesin {lugesin} ja sain {arv}");

            Console.WriteLine($"Sinu arv oli {arv} ja tema ruut on {arv*arv}");
            Console.WriteLine("sinu arv oli {0} ja tema " +
                "ruut on {1}", arv, arv*arv);

            string vastus1 = $"Sinu arv oli {arv} ja tema ruut on {arv * arv}";
            string vastus2 = 
                string.Format("sinu arv oli {0} ja tema ruut on {1}", arv, arv * arv);

            string vastus3 = 
                "sinu arv oli " + arv + 
                " ja tema ruut on " + (arv * arv).ToString();
            Console.WriteLine(vastus3);
            string eesnimi = "Henn";
            string nimi1 = eesnimi + " " + "Sarv";
            string nimi2 = "Henn Sarv";
            if (nimi1.Equals(nimi2)) Console.WriteLine("nimed on samad");
            else Console.WriteLine("nimed erinevad");



        }
    }
}
