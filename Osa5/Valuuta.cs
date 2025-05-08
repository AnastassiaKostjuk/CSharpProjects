using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjects.Osa5
{
    internal class Valuuta
    {
        public string Nimetus { get; set; }

        public double KurssEurSuhte { get; set; }

        public Valuuta(string nimetus, double kurssEurSuhte)
        {
            Nimetus = nimetus;
            KurssEurSuhte = kurssEurSuhte;
        }

        public static List<Valuuta> LooValuutadeList()
        {
            // Создаем список валют и добавляем несколько валют
            return new List<Valuuta>
            {
                new Valuuta("EUR", 1.00),    // Евро (базовая валюта)
                new Valuuta("USD", 0.85),    // Доллар США
                new Valuuta("GBP", 1.16),    // Британский фунт
                new Valuuta("JPY", 0.0077),  // Японская йена
                new Valuuta("SEK", 0.098)    // Шведская крона
            };
        }

        public static void ArvutaVahetused(List<Valuuta> valuutad)
        {
            Console.WriteLine("Saadaolevad valuutad: " +
                            string.Join(", ", valuutad.Select(v => v.Nimetus)));

            Console.Write("Sisesta summa: ");
            double summa = double.Parse(Console.ReadLine());

            Console.Write("Sisesta valuuta (nt EUR, USD): ");
            string valuutaKood = Console.ReadLine().ToUpper();

            // Ищем валюту в списке
            Valuuta valitudValuuta = valuutad.FirstOrDefault(v => v.Nimetus.Equals(valuutaKood, StringComparison.OrdinalIgnoreCase));

            if (valitudValuuta != null)
            {
                // Конвертация в EUR
                double eurodes = summa * valitudValuuta.KurssEurSuhte;
                Console.WriteLine($"{summa} {valuutaKood} = {eurodes:F2} EUR");

                // Обратная конвертация (EUR в выбранную валюту)
                double vastupidi = 1 / valitudValuuta.KurssEurSuhte;
                Console.WriteLine($"1 EUR = {vastupidi:F2} {valuutaKood}");
            }
            else
            {
                Console.WriteLine("Vigane valuuta kood!");
            }
        }
    }
}
