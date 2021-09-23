using System;

namespace Komunikacni_hra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, já se jmenuju Robot, prosím nesměj se mi, ale neumím skloňovat jména");
            Console.WriteLine("Jak se jmenuješ?");
            string jmeno = Console.ReadLine();
            Console.WriteLine(jmeno + ", to je ale krásné jméno!");
            Console.WriteLine("Kolik máš roků " + jmeno + "?");
            bool kontrola = true;
            do
            {
                string vek = Console.ReadLine();
                int cislo;
                bool prevod = Int32.TryParse(vek, out cislo);
                if (prevod == true)
                {
                    cislo = Int32.Parse(vek);
                    if (cislo < 0 || cislo > 125)
                    {
                        Console.WriteLine("Nevěřím, že ti je " + cislo + ", zkus to znovu");

                    }
                    else
                    {
                        Console.WriteLine("Tobě je " + cislo + ", mně je sotva několik dnů!");
                        kontrola = false;
                    }
                }
                else
                {
                    Console.WriteLine("Tady se něco nepovedlo, zkus to znovu");
                }
            }
            while (kontrola == true);
            Console.WriteLine("Jaká je tvá oblíbená barva " + jmeno + "?");
            string barva = Console.ReadLine();
            Console.WriteLine(barva + " musí být velice hezká. Škoda, že nic nevidím.");
            Console.WriteLine(jmeno + ", jaké je tvé oblíbené zvíře?");
            string zvire = Console.ReadLine();
            Console.WriteLine(zvire + "je taky moje oblíbené zvíře!");
            Console.WriteLine("Zeptám se tě už jenom naposledy.");
            Console.WriteLine("Jaký je tvůj oblíbený předmět ve škole?");
            string predmet = Console.ReadLine();
            Console.WriteLine(predmet + ", to zní zajímavě, ale asi by mi to nešlo.");
            Console.WriteLine("Děkuji, že jsi se mnou strávil čas, bylo to velice přínosné.");
            Console.WriteLine("Na shledanou");

        }
    }
}
