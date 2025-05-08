using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjects.Osa2
{
    internal class MainClass2
    {
        public static void Main(string[] args)
        {
            //1osa. andmetuubid, if, case, random,
            Console.WriteLine("1. osa C# Põhikonstruktsionid. Projekti loomine, ikooni lisamine ja arvutamine. Teoria+Praaktika");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello, world!"); //print in python/после каждой команды точка с запятой/I.часть.Andmetüübid, If, Case, Random, Alamfunktsioonid
            int a = 0;
            string tekst = "Python";
            char taht = 'A';
            double arv = 5.4536237287;
            float arv1 = 2;

            Console.WriteLine("-----");


            Console.WriteLine("Arv 2: ");
            int arv2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
            arv1 = FunktsioonidOsa2.Kalkulaator(a, arv2);
            Console.WriteLine(arv1);

            Console.WriteLine("-----");

            Console.WriteLine("Switch`i kasutamine");
            Random rnd = new Random();
            a = rnd.Next(1, 7);
            Console.WriteLine(a);

            Console.WriteLine("-----");

            tekst = FunktsioonidOsa2.Paevad(a);
            Console.WriteLine(tekst);
            Console.ReadKey();

            Console.WriteLine("-----");

            //Kui eesnimi on Juku siis lähme Jukuga kinno. Lisa valiku, kus Juku vanuse alusel otsustate mis pilet talle vaja osta.
            Console.WriteLine("2. osa C# Valikute konstruktsionid. Teoria+Ülesanded/Kui eesnimi on Juku siis lähme Jukuga kinno. Lisa valiku, kus Juku vanuse alusel otsustate mis pilet talle vaja osta.");
            Console.Write("Mis on sinu nimi? ");
            FunktsioonidOsa2.Juku();


            //Küsi kahe inimese nimed ning teata, et nad on täna pinginaabrid
            Console.WriteLine("2. osa C# Valikute konstruktsionid. Teoria+Ülesanded/Küsi kahe inimese nimed ning teata, et nad on täna pinginaabrid");
            Console.WriteLine("Esimene nimi on: ");
            string nimi1 = Console.ReadLine();
            Console.WriteLine("Teine nimi on: ");
            string nimi2 = Console.ReadLine();
            FunktsioonidOsa2.Naabrid(nimi1, nimi2);

            Console.WriteLine("-----");

            //Küsi ristkülikukujulise toa seinte pikkused ning arvuta põranda pindala.
            //Küsi kasutajalt remondi tegemise soov, kui ta on positiivne, siis küsi kui palju maksab ruutmeeter ja leia põranda vahetamise hind
            // Вызов основной функции
            Console.WriteLine("2. osa C# Valikute konstruktsionid. Teoria+Ülesanded/Küsi ristkülikukujulise toa seinte pikkused ning arvuta põranda pindala.");
            FunktsioonidOsa2.ArvutaPindalaJaRemondiHind();

            // Ожидание нажатия клавиши перед закрытием
            Console.WriteLine("\nVajuta suvalist klahvi, et väljuda...");
            Console.ReadKey();

            Console.WriteLine("-----");

            //Leia 30% hinnasoodustusega hinna põhjal alghind
            Console.WriteLine("2. osa C# Valikute konstruktsionid. Teoria+Ülesanded/Leia 30% hinnasoodustusega hinna põhjal alghind");
            Console.WriteLine("Sisesta toote alghind:");
            double alghind = double.Parse(Console.ReadLine());

            double soodushind = FunktsioonidOsa2.Soodustus(alghind);
            Console.WriteLine($"30% soodushind: {soodushind:F2} eurot");

            Console.WriteLine("-----");

            //Küsi temperatuur ning teata, kas see on üle kaheksateistkümne kraadi (soovitav toasoojus talvel).
            Console.WriteLine("2. osa C# Valikute konstruktsionid. Teoria+Ülesanded/Küsi temperatuur ning teata, kas see on üle kaheksateistkümne kraadi (soovitav toasoojus talvel).");
            Console.WriteLine("Mis on praegune temperatuur?");
            float temp = float.Parse(Console.ReadLine());
            FunktsioonidOsa2.Temperatuur(temp);
            Console.ReadLine();

            Console.WriteLine("-----");

            //Küsi inimese pikkus ning teata, kas ta on lühike, keskmine või pikk (piirid pane ise paika)
            Console.WriteLine("2. osa C# Valikute konstruktsionid. Teoria+Ülesanded/Küsi inimese pikkus ning teata, kas ta on lühike, keskmine või pikk (piirid pane ise paika)");
            Console.WriteLine("Teie pikkus on: ");
            float pikkus = float.Parse(Console.ReadLine());
            FunktsioonidOsa2.Pikkus(pikkus);
            // Ожидание нажатия клавиши перед закрытием
            Console.WriteLine("\nVajuta suvalist klahvi, et väljuda...");
            Console.ReadKey();

            Console.WriteLine("-----");


            //Küsi inimeselt pikkus ja sugu ning teata, kas ta on lühike, keskmine või pikk (mitu tingimusplokki võib olla üksteise sees).
            Console.WriteLine("2. osa C# Valikute konstruktsionid. Teoria+Ülesanded/Küsi inimeselt pikkus ja sugu ning teata, kas ta on lühike, keskmine või pikk (mitu tingimusplokki võib olla üksteise sees).");
            Console.WriteLine("Kas olete mees või naine? (mees/naine)");
            string sugu = Console.ReadLine();
            Console.WriteLine("Mis on teie pikkus?");
            float pikkus2 = float.Parse(Console.ReadLine());  // Сначала запрашиваем рост, потом анализируем  

            // Теперь проверяем рост и пол  
            FunktsioonidOsa2.PikkusSugu(pikkus2, sugu);


            //Küsi inimeselt poes eraldi kas ta soovib osta piima, saia, leiba. Löö hinnad kokku ning teata, mis kõik ostetud kraam maksma läheb.
            Console.WriteLine("2. osa C# Valikute konstruktsionid. Teoria+Ülesanded/Küsi inimeselt poes eraldi kas ta soovib osta piima, saia, leiba. Löö hinnad kokku ning teata, mis kõik ostetud kraam maksma läheb.");
            var (ostetudTooted, kogusumma) = FunktsioonidOsa2.ArvutaOstukorv();

            Console.WriteLine(ostetudTooted);
            Console.WriteLine($"Kogusumma: {kogusumma:F2} eurot");

            Console.WriteLine("\nVajuta suvalist klahvi, et väljuda...");
            Console.ReadKey();

        }
    }
}
