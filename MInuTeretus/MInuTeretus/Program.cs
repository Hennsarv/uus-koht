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
            // tavaline string \-ga on erimärgid
            // erimärgid tuleb topeldada
            string nimi = "\tHenn on \n \"hea\" \t poiss";

            Console.WriteLine(nimi);

            Console.WriteLine('0'+0);
            Console.WriteLine('\0'+0);

            // see on esceipimata string \ ei ole vaja topeldada
            string failinimi = @"C:\Users\sarvi\Source\Repos\Teispäev\MInuTeretus\MInuTeretus\App.config";

            Console.Write("anna üks arv: ");
            string lugesin = Console.ReadLine();
            int arv = int.Parse(lugesin);
            Console.WriteLine($"lugesin {lugesin} ja sain {arv}");

            // interpoleeritud string e $ string
            // stringi see on {} vahel avaldised, mis arvutatakse
            // ja pistetakse vahele
            Console.WriteLine($"Sinu arv oli {arv} ja tema ruut on {arv*arv}");

            // sama tulemus placeholderitega
            Console.WriteLine("sinu arv oli {0} ja tema " +
                "ruut on {1}", arv, arv*arv);

            // interpoleeritud string avaldises
            string vastus1 = $"Sinu arv oli {arv} ja tema ruut on {arv * arv}";
            string vastus2 = 
                string.Format("sinu arv oli {0} ja tema ruut on {1}", arv, arv * arv);
            // ja sama lugu string.Format funktsiooni ja placeholderitega

            // ning sama tulemuse stringi kokkuliitmise tehtega
            string vastus3 = 
                "sinu arv oli " + arv + 
                " ja tema ruut on " + (arv * arv).ToString();
            Console.WriteLine(vastus3);

            // stringi võrdlemine
            string eesnimi = "Henn";
            string nimi1 = eesnimi + " " + "Sarv";
            string nimi2 = "Henn Sarv";

            // stringi võrdlemine Equals tehtega
            // nii võib teha C# ja nii TULEB teha Javas (seal on küll equals väikese tähega)
            if (nimi1.Equals(nimi2)) Console.WriteLine("nimed on samad");
            else Console.WriteLine("nimed erinevad");

            // c# lubab stringe ka otse võrrelda 
            // Javas annab selline võrdlemine vale tulemuse
            if (nimi1 == nimi2) Console.WriteLine("nimed on samad");
            else Console.WriteLine("nimed erinevad");



        }
    }
}
