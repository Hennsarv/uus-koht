using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolmapäev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("anna üks arv: ");
            //string loetud = Console.ReadLine();
            //int arv = int.Parse(loetud);
            //Console.WriteLine(arv*arv);

            //Console.Write("millal sa sündinud oled: ");
            //DateTime sünnipäev = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine(
            //    $"sa oled {DateTime.Today.Year - sünnipäev.Year} aastat vana" 
            //    );

            //double d = 77.77;
            //Console.WriteLine($"Anna uus arv {d} asemele");
            //d = double.Parse(Console.ReadLine());
            //Console.WriteLine($"saime uue arvu {d}");

            int Int = int.MaxValue;   // väga halb komme kasutada muutuja nimeks

            Console.WriteLine(Int);

            long Long = Int;    // andmetüüpi suure tähega
            Console.WriteLine(Long);
            Int = (int)(Long*Long);
            Console.WriteLine($"int on {Int} ruut on {Long*Long}");
            Long = 4611686014132420609L;
            unchecked
            {
                Int = (int)Long; 
            }
            Console.WriteLine(Int);



        }
    }
}
