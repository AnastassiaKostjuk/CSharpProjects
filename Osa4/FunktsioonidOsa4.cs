using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjects.Osa4
{
    internal class FunktsioonidOsa4
    {

        public static void FailiKirjutamine()
        {
            string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\Kuud.txt"); //@"..\..\..\Kuud.txt"
            StreamWriter text = new StreamWriter(path1, true); // true = lisa lõppu
            Console.WriteLine("Sisesta mingi tekst: ");
            string lause = Console.ReadLine();
            text.WriteLine(lause);
            text.Close();
        }

        public static void FailiLugemine()
        {
            string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\Kuud.txt");
            StreamReader text = new StreamReader(path2);
            string laused = text.ReadToEnd();
            text.Close();
            Console.WriteLine(laused);
        }

        public static void RidadeLugemine()
        {
            List<string> kuude_list = new List<string>();
            string path3 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\Kuud.txt");
            foreach (string rida in File.ReadAllLines(path3))
            {
                kuude_list.Add(rida);
            }
        }
    }
}
