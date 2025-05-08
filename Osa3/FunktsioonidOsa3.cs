using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjects.Osa3
{
    internal class FunktsioonidOsa3
    {
        public static List<string> Sõnad()
        {
            List<string> sonad = new List<string>();
            for (int j = 0; j < 5; j++)
            {
                Console.Write("Nimi: ");
                sonad.Add(Console.ReadLine());
            }
            return sonad;
        }

        public static Isik[] Isikud(int k, string[] nimed, string[] aadressid)
        {
            Isik[] isikud = new Isik[k];

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(i);
                //isikud[i] = new Isik();
                Console.Write("Isikukood: ");

                isikud[i] = new Isik
                {
                    Nimi = nimed[i],
                    Vanus = i + 10,
                    Isikukood = Console.ReadLine(),
                    Aadress = aadressid[i]
                };
            }
            return isikud;
        }

        public static List<Isik> Isikud2()
        {
            string[] nimed = new string[] { "Juku", "Mari", "Peeter", "Mati", "Anna", "Nastja", "Liina", "Katrin", "Liis", "Ilona" };
            string[] aadressid = new string[] { "Tallinn", "Tartu", "Narva", "Parnu", "Paide", "Keila", "Johvi", "Rakvere", "Viljandi", "Kohtla-Jarve" };

            List<Isik> isikud2 = new List<Isik>();
            int i = nimed.Length;

            for (int j = i - 1; j > -1; j--)
            {
                Console.WriteLine(j);
                Isik isik = new Isik
                {
                    Nimi = nimed[j],
                    Vanus = 50,
                    Isikukood = Console.ReadLine(),
                    Aadress = aadressid[j]
                };
                isikud2.Add(isik);
            }
            return isikud2;
        }

        public static void SuurimNeljarv(double[] arvud)
        {
            // Проверяем, что массив содержит ровно 4 элемента
            if (arvud.Length != 4)
            {
                Console.WriteLine("Viga! Sisesta täpselt 4 arvu.");
                return;
            }

            // Проверяем, что все числа являются однозначными (0-9)
            foreach (var arv in arvud)
            {
                if (arv < 0 || arv > 9 || arv != Math.Floor(arv))
                {
                    Console.WriteLine("Viga! Kõik arvud peavad olema täisarvud vahemikus 0 kuni 9.");
                    return;
                }
            }

            // Преобразуем double в int (так как мы уже проверили, что это целые числа)
            int[] täisarvud = arvud.Select(arv => (int)arv).ToArray();

            // Сортируем цифры по убыванию
            var sorteeritud = täisarvud.OrderByDescending(x => x).ToArray();

            // Собираем максимальное число
            int suurimArv = sorteeritud[0] * 1000 +
                            sorteeritud[1] * 100 +
                            sorteeritud[2] * 10 +
                            sorteeritud[3];

            Console.WriteLine($"Suurim neljakohaline arv: {suurimArv}");
        }

        public static void SuuremArv()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };

            int max = numbrid[0]; // Начинаем с первого элемента
            int indeks = 0; // Хранит индекс максимального элемента

            for (int i = 0; i < numbrid.Length; i++)
            {
                if (numbrid[i] > max)
                {
                    max = numbrid[i]; // Обновляем максимум
                    indeks = i; // Обновляем индекс при нахождении нового максимума
                }
            }

            Console.WriteLine($"Suurim arv on {max} ja see asub indeksil {indeks}");
        }

        public static void PositiivsedNegatiivsed()
        {
            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };
            int positiivsed = 0, negatiivsed = 0, zero = 0;
            foreach (int a in arvud)
            {
                if (a > 0)
                {
                    positiivsed++;
                }
                else if (a < 0)
                {
                    negatiivsed++;
                }
                else
                {
                    zero++;
                }
            }
            Console.WriteLine("Positiivsed numbrid = {0}", positiivsed);
            Console.WriteLine("Negatiivsed numbrid = {0}", negatiivsed);
            Console.WriteLine("Null numbrid = {0}", zero);
        }

        public static void ArvamiseMang()
        {
            // Создаем генератор случайных чисел
            Random rnd = new Random();

            // Флаг для повторной игры (по умолчанию true)
            bool mangimeUuesti = true;

            // Основной цикл игры (пока пользователь хочет играть)
            while (mangimeUuesti)
            {
                // Генерируем случайное число от 1 до 100
                /*
                 * В C# метод Random.Next(minValue, maxValue) работает по следующим правилам:
                  minValue (1) - включается в диапазон возможных значений
                  maxValue (101) - НЕ включается в диапазон
                 */
                int arvutiArv = rnd.Next(1, 101);

                // Количество попыток (5)
                int katseteArv = 5;

                // Флаг угадывания (false - пока не угадано)
                bool arvatud = false;

                Console.WriteLine("Arva ära arvuti poolt valitud arv (1-100). Sul on 5 katset!");

                // Цикл попыток (от 1 до 5, или пока не угадано)
                for (int katse = 1; katse <= katseteArv && !arvatud; katse++)
                //for (инициализация; условие; итерация) { тело_цикла }
                //Выполняется цикл, начиная с katse=1, пока katse ≤ katseteArv И НЕ arvatud, увеличивая katse на 1 после каждой итерации
                {
                    Console.Write($"Katse {katse}: ");

                    // Проверка ввода (чтобы пользователь ввел число)
                    if (!int.TryParse(Console.ReadLine(), out int kasutajaArv))
                    {
                        Console.WriteLine("Palun sisesta täisarv!");
                        katse--; // Откат счетчика попыток
                        continue; // Переход к следующей итерации
                    }

                    // Проверка угадывания
                    if (kasutajaArv == arvutiArv)
                    {
                        Console.WriteLine("Õige! Arvasid ära!");
                        arvatud = true; // Установка флага угадывания
                    }
                    else if (kasutajaArv < arvutiArv)
                    {
                        Console.WriteLine("Liiga väike!"); // Число меньше загаданного
                    }
                    else
                    {
                        Console.WriteLine("Liiga suur!"); // Число больше загаданного
                    }
                }

                // Если закончились попытки и не угадано
                if (!arvatud) //!arvatud - эквивалентно arvatud == false
                {
                    Console.WriteLine($"Kahjuks ei arvanud ära. Õige arv oli {arvutiArv}.");
                }

                // Предложение сыграть еще
                Console.Write("Kas soovid uuesti mängida? (jah/ei): ");
                mangimeUuesti = Console.ReadLine().ToLower() == "jah";
            }
        }
    }

    internal class Inimene
    {
        // Свойства с public доступом
        public string Nimi { get; set; }
        public int Vanus { get; set; }

        // Вложенный статический класс
        public static class StatistikaUtils
        {
            public static List<Inimene> KusiAndmeid(int kogus)
            {
                var inimesed = new List<Inimene>();
                for (int i = 0; i < kogus; i++)
                {
                    Console.WriteLine($"\nInimene {i + 1}:");
                    var inimene = new Inimene();

                    Console.Write("Nimi: ");
                    inimene.Nimi = Console.ReadLine();

                    Console.Write("Vanus: ");
                    int vanus;
                    while (!int.TryParse(Console.ReadLine(), out vanus) || vanus <= 0)
                        Console.Write("Vigane vanus! Sisesta uuesti: ");

                    inimene.Vanus = vanus;
                    inimesed.Add(inimene);
                }
                return inimesed;
            }

            public static (int summa, double keskmine, Inimene vanim, Inimene noorim)
                ArvutaStatistika(List<Inimene> inimesed)
            {
                if (inimesed == null || inimesed.Count == 0)
                    throw new ArgumentException("Inimeste nimekiri ei saa olla tühi");

                int summa = 0;
                var vanim = inimesed[0];
                var noorim = inimesed[0];  // Отдельная инициализация

                foreach (var inimene in inimesed)
                {
                    summa += inimene.Vanus;
                    if (inimene.Vanus > vanim.Vanus) vanim = inimene;
                    if (inimene.Vanus < noorim.Vanus) noorim = inimene;
                }

                return (summa, (double)summa / inimesed.Count, vanim, noorim);
            }
        }
    }
}
