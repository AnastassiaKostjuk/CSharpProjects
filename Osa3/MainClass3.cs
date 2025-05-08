using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjects.Osa3
{
    internal class MainClass3
    {
        public static void Main(string[] args)
        {
            //5.Arvamise mäng
            Console.WriteLine("5. Arvamise mäng");
            FunktsioonidOsa3.ArvamiseMang();
            Console.WriteLine("Mäng läbi. Head päeva!");

            Console.WriteLine("-----");

            //10 – Positiivsed ja negatiivsed
            Console.WriteLine("10 – Positiivsed ja negatiivsed");
            Console.WriteLine("{ 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 }");
            FunktsioonidOsa3.PositiivsedNegatiivsed();

            Console.WriteLine("-----");


            //12 – Kõige suurema arvu otsing
            Console.WriteLine("12 – Kõige suurema arvu otsing");
            Console.WriteLine("{ 12, 56, 78, 2, 90, 43, 88, 67 }");
            FunktsioonidOsa3.SuuremArv();

            Console.WriteLine("-----");

            //6. Suurim neliarvuline arv
            Console.WriteLine("6. Suurim neljakohaline arv");
            Console.WriteLine("Sisesta 4 arvu vahemikus 0 kuni 9");

            double[] arvud = new double[4];
            for (int a = 0; a < 4; a++)
            {
                Console.Write($"Arv {a + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out arvud[a]) || arvud[a] < 0 || arvud[a] > 9 || arvud[a] != Math.Floor(arvud[a]))
                {
                    Console.WriteLine("Viga! Arv peab olema täisarv vahemikus 0 kuni 9.");
                    Console.Write($"Arv {a + 1}: ");
                }
            }

            FunktsioonidOsa3.SuurimNeljarv(arvud);


            Console.WriteLine("-----");

            //3. Nimed ja vanused
            Console.WriteLine("3. Nimed ja vanused");
            // 1. Получаем данные
            var inimesed = Inimene.StatistikaUtils.KusiAndmeid(5);

            // 2. Вычисляем статистику
            var (summa, keskmine, vanim, noorim) = Inimene.StatistikaUtils.ArvutaStatistika(inimesed);

            // 3. Выводим результаты
            Console.WriteLine("\nTulemused:");
            Console.WriteLine($"Vanuste summa: {summa}");
            Console.WriteLine($"Keskmine vanus: {keskmine:F1}");
            Console.WriteLine($"Vanim: {vanim.Nimi} ({vanim.Vanus} aastat)");
            Console.WriteLine($"Noorim: {noorim.Nimi} ({noorim.Vanus} aastat)");

            Console.WriteLine("\nVajuta suvalist klahvi...");
            Console.ReadKey();

            Console.WriteLine("-----");

            List<string> sonad = FunktsioonidOsa3.Sõnad();
            foreach (var item in sonad)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----");

            Isik isik1 = new Isik("Juku", 18, "12345678901", "Tallinn");
            isik1.PrindiInfo();
            Isik isik2 = new Isik();
            isik2.Nimi = "Mari";
            isik2.Aadress = "Tartu";
            isik2.Isikukood = "98765432101";
            isik2.Sugu = Sugu.Naine;
            isik2.PrindiInfo();


            int i;
            string[] nimed = new string[10] { "Juku", "Mari", "Kati", "Peeter", "Mati", "Liina", "Katrin", "Andres", "Marko", "Kristi" };
            string[] aadressid = new string[10] { "Tallinn", "Tartu", "Pärnu", "Narva", "Kohtla-Järve", "Viljandi", "Rakvere", "Paide", "Jõhvi", "Kuressaare" };
            Console.WriteLine("----- for++ Massiv -------");
            Isik[] isikud = FunktsioonidOsa3.Isikud(nimed.Length, nimed, aadressid);
            for (i = 0; i < nimed.Length; i++)
            {
                isikud[i].PrindiInfo();
            }

            Console.WriteLine("-----");

            Console.WriteLine("---for--List--");
            List<Isik> isikud2 = FunktsioonidOsa3.Isikud2();
            foreach (Isik isik in isikud2)
            {
                isik.PrindiInfo();
            }

            Console.WriteLine("-----");

            Console.WriteLine("---while----");
            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }


            Console.WriteLine("-----");


            Console.WriteLine("---do---");
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Backspace);

        }
    }
}
