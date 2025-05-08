using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjects.Osa2
{
    internal class FunktsioonidOsa2
    {
        public static float Kalkulaator(int arv1, int arv2)
        {
            float kalkulaator = 0;
            kalkulaator = arv1 * arv2;
            return kalkulaator;
        }
        public static string Paevad(int a)
        {
            switch (a)
            {
                case 1: return "Esmaspäev";
                case 2: return "Teisipäev";
                case 3: return "Kolmapäev";
                case 4: return "Neljapäev";
                case 5: return "Reede";
                case 6: return "Laupäev";
                case 7: return "Pühapäev";
                default: return "Tundmatu";
            }
        }


        public static void Juku()
        {
            string tekst;
            tekst = Console.ReadLine();
            Console.WriteLine("Tere, {0}!", tekst); //текст подставляется в ноль
            if (tekst.ToLower() == "juku")
            {
                Console.WriteLine("Lahme kinno!");
                try
                {
                    Console.WriteLine("{0}, kui vana sa oled?", tekst);
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus <= 0 || vanus > 100) // ||(or), &&(and)
                    {
                        Console.WriteLine("Viga!");
                    }
                    else if (vanus > 0 && vanus <= 6)
                    {
                        Console.WriteLine("Tasuta!");
                    }
                    else if (vanus <= 15)
                    {
                        Console.WriteLine("Lastepilet");
                    }
                    else if (vanus <= 65)
                    {
                        Console.WriteLine("Taispilet");
                    }
                    else if (vanus <= 100)
                    {
                        Console.WriteLine("Sooduspilet");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                //Console.WriteLine("Lahme kinno!");
            }
            else
            {
                Console.WriteLine("Olen Hoivatud!");
            }
        }


        public static void Naabrid(string nimi1, string nimi2)
        {
            Console.WriteLine($"{nimi1} ja {nimi2}, täna te olete pinginaabrid!");
        }

        public static void ArvutaPindalaJaRemondiHind()
        {
            Console.WriteLine("Sisestage ruumi pikkus meetrites: ");
            double pikkus = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisestage ruumi laius meetrites: ");
            double laius = double.Parse(Console.ReadLine());

            double pindala = pikkus * laius;
            Console.WriteLine($"Pindala: {pindala} m²"); // $ для интерполяции

            Console.WriteLine("Kas te tahate teha remondi? ");
            string vastus = Console.ReadLine().ToLower(); // Приводим к нижнему регистру

            if (vastus == "jah")
            {
                Console.WriteLine("Kui palju maksab põranda remont ruutmeetri kohta?");
                double hind = double.Parse(Console.ReadLine());

                double koguHind = pindala * hind;
                Console.WriteLine($"Põrandate asendamise kulud: {koguHind} eurot");
            }
            else
            {
                Console.WriteLine("Te ei taha põrandat parandada.");
            }
        }

        public static double Soodustus(double alghind)
        {
            // Arvutame soodushinna (30% allahindlus)
            double soodushind = alghind * 0.7;
            return soodushind;
        }

        public static void Temperatuur(float temp)
        {
            if (temp > 18)
            {
                Console.WriteLine("See on soovitav toasoojus talvel");
            }
            else
            {
                Console.WriteLine("See on mitte soovitav toasoojus talvel");
            }
        }


        public static void Pikkus(float pikkus)
        {
            if (pikkus <= 160)
            {
                Console.WriteLine("Teie pikkus on lühike");
            }
            else if (pikkus > 160 && pikkus <= 175)
            {
                Console.WriteLine("Teie pikkus on keskmine");
            }
            else if (pikkus > 175)
            {
                Console.WriteLine("Teie pikkus on pikk");
            }
        }

        public static void PikkusSugu(float pikkus2, string sugu)
        {
            if (sugu.ToLower() == "mees")
            {
                if (pikkus2 > 185)
                    Console.WriteLine("Meeste jaoks on see kõrge kasv!");
                else if (pikkus2 >= 165)
                    Console.WriteLine("Meeste jaoks on see keskmine kasv!");
                else
                    Console.WriteLine("Meeste jaoks on see lühike kasv!");
            }
            else if (sugu.ToLower() == "naine")
            {
                if (pikkus2 > 175)
                    Console.WriteLine("Naiste jaoks on see kõrge kasv!");
                else if (pikkus2 >= 155)
                    Console.WriteLine("Naiste jaoks on see keskmine kasv!");
                else
                    Console.WriteLine("Naiste jaoks on see lühike kasv!");
            }
            else
            {
                Console.WriteLine("Vale sugu! Sisestage 'mees' või 'naine'.");
            }
        }

        public static (string ostetudTooted, double kogusumma) ArvutaOstukorv()
        {
            double piimaHind = 1.20;
            double saiaHind = 0.80;
            double leivaHind = 1.50;

            double kogusumma = 0;
            List<string> ostetudTooted = new List<string>();

            Console.WriteLine("Kas soovite osta piima? (jah/ei)");
            if (Console.ReadLine().ToLower() == "jah")
            {
                kogusumma += piimaHind;
                ostetudTooted.Add("piima");
            }

            Console.WriteLine("Kas soovite osta saia? (jah/ei)");
            if (Console.ReadLine().ToLower() == "jah")
            {
                kogusumma += saiaHind;
                ostetudTooted.Add("saia");
            }

            Console.WriteLine("Kas soovite osta leiba? (jah/ei)");
            if (Console.ReadLine().ToLower() == "jah")
            {
                kogusumma += leivaHind;
                ostetudTooted.Add("leiba");
            }

            string teade = ostetudTooted.Count > 0
                ? "Te ostsite: " + string.Join(", ", ostetudTooted)
                : "Te ei ostnud midagi";

            return (teade, kogusumma);
        }
    }
}
