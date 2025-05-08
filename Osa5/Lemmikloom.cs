using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjects.Osa5
{
    internal class Lemmikloom
    {
        // Свойства класса
        public string Nimi { get; set; }
        public string Liik { get; set; }
        public int Vanus { get; set; }


        // Конструктор класса
        public Lemmikloom(string nimi, string liik, int vanus)
        {
            Nimi = nimi;
            Liik = liik;
            Vanus = vanus;
        }

        public override string ToString()
        {
            return $"{Nimi} - ({Liik}), vanus: {Vanus}"; // Преобразует объект Film в строку для удобного вывода
        }

        public static List<Lemmikloom> KusiLemmikloomadeAndmeid()
        {
            var loomaList = new List<Lemmikloom>();
            Console.WriteLine("Sisesta oma lemmikloomade andmed (vähemalt 5):");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nLemmikloom {i + 1}:");

                Console.Write("Nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Liik (nt kass, koer): ");
                string liik = Console.ReadLine();

                Console.Write("Vanus (nt '3 kuud' või '2 aastat'): ");
                string vanusSisend = Console.ReadLine().ToLower();

                int vanusKuudes;

                if (vanusSisend.Contains("kuud"))
                {
                    // если пользователь ввел в месяцах
                    string[] osad = vanusSisend.Split(' ');
                    if (osad.Length >= 1 && int.TryParse(osad[0], out int kuud))
                    {
                        vanusKuudes = kuud;
                    }
                    else
                    {
                        Console.WriteLine("Vigane kuude arv! Kasutame vaikeväärtust 0.");
                        vanusKuudes = 0;
                    }
                }
                else if (vanusSisend.Contains("aastat"))
                {
                    // если пользователь ввел в годах
                    string[] osad = vanusSisend.Split(' ');
                    if (osad.Length >= 1 && int.TryParse(osad[0], out int aastad))
                    {
                        vanusKuudes = aastad * 12;
                    }
                    else
                    {
                        Console.WriteLine("Vigane aastate arv! Kasutame vaikeväärtust 0.");
                        vanusKuudes = 0;
                    }
                }
                else
                {
                    // если пользователь ввел просто число(автоматически считается, что введено в годах)
                    if (int.TryParse(vanusSisend, out int aastad))
                    {
                        vanusKuudes = aastad * 12;
                    }
                    else
                    {
                        Console.WriteLine("Vigane vanuse sisend! Kasutame vaikeväärtust 0.");
                        vanusKuudes = 0;
                    }
                }


                int vanusAastates = vanusKuudes / 12;


                loomaList.Add(new Lemmikloom(nimi, liik, vanusAastates));
            }

            // возможность добавить больше животных
            while (true)
            {
                Console.Write("\nKas soovid lisada veel loomi? (jah/ei): ");
                if (Console.ReadLine().ToLower() != "jah")
                    break;

                Console.Write("Nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Liik: ");
                string liik = Console.ReadLine();

                Console.Write("Vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                loomaList.Add(new Lemmikloom(nimi, liik, vanus));
            }

            return loomaList;
        }


        /// все кошки/коты в списке
        public static void KuvaKassid(List<Lemmikloom> loomad)
        {
            var kassid = loomad.Where(l => l.Liik == "kass").ToList();

            Console.WriteLine("\nKõik kassid:");
            if (kassid.Any())
            {
                foreach (var kass in kassid)
                    Console.WriteLine(kass);
            }
            else
            {
                Console.WriteLine("Kasse ei leitud.");
            }
        }


        /// средний возраст животных
        public static void ArvutaKeskmineVanus(List<Lemmikloom> loomad)
        {
            double keskmine = loomad.Average(l => l.Vanus);
            Console.WriteLine($"\nLemmikloomade keskmine vanus: {keskmine:F1} aastat");
        }


        /// самое старое животное
        public static void LeiaVanimLoom(List<Lemmikloom> loomad)
        {
            if (loomad == null || loomad.Count == 0)
            {
                Console.WriteLine("\nLemmikloomade nimekiri on tühi!");
                return;
            }

            // находит самое большое число
            int maxVanus = loomad.Max(l => l.Vanus);

            // находим всех животных с таким возрастом
            var vanimadLoomad = loomad.Where(l => l.Vanus == maxVanus).ToList();

            Console.WriteLine($"\nVanimad lemmikloomad ({maxVanus} aastat):");

            if (vanimadLoomad.Any())
            {
                foreach (var loom in vanimadLoomad)
                {
                    Console.WriteLine(loom);
                }
            }
            else
            {
                Console.WriteLine("Vigu andmetöötluses - vanimaid loomi ei leitud.");
            }
        }


        /// Поиск по имени животного (бонусное задание)
        public static void OtsiLoomNimeJargi(List<Lemmikloom> loomad)
        {
            Console.WriteLine("\nOtsi looma nime järgi:");
            Console.Write("Sisesta otsitav nimi: ");
            string otsing = Console.ReadLine().ToLower();

            var tulemused = loomad.Where(l => l.Nimi.ToLower().Contains(otsing)).ToList();

            Console.WriteLine("\nOtsingu tulemused:");
            if (tulemused.Any())
            {
                foreach (var loom in tulemused)
                    Console.WriteLine(loom);
            }
            else
            {
                Console.WriteLine("Sellise nimega loomi ei leitud.");
            }
        }
    }
}
