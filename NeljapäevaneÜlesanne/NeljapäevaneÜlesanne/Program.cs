using System;
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
(vajab isesesivat pusimist) punktid 1. 2. 3. jäävad samaks * /
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
            vanused = new int[] { 63, 80, 28, 40, 17 };
            // NB! siin ei saa new int[] ära jätta - seda saab vaid siis,
            //     kui initsializer on muutuja definitsiooniga samas lauses
        }
    }
}
