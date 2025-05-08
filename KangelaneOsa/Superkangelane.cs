using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjects.KangelaneOsa
{
    internal class Superkangelane : Kangelane
    {
        private double osavus;
        private static Random random = new Random();

        public Superkangelane(string nimi, string asukoht)
            : base(nimi, asukoht)
        {
            this.osavus = random.NextDouble() * 4.0 + 1.0;
        }

        public double Osavus
        {
            get { return osavus; }
        }

        public override int Paasta(int ohus)
        {
            double protsent = 95.0 + osavus;
            if (protsent > 100.0)
                protsent = 100.0;

            return (int)Math.Round(ohus * protsent / 100.0);
        }

        public override string Vormiriietus()
        {
            return "Eriline superkangelase vorm";
        }

        public override string MissiooniStaatus()
        {
            return "Minu pluusi-S on säranud, mis tähendab, et olen valmis kurjusele vastu lööma!";
        }

        public override string Tervitus()
        {
            return $"Tere! Mina olen superkangelane {Nimi}, kaitsen linna {Asukoht}!";
        }

        public override string ToString()
        {
            return $"Osavuse info: {osavus:F2} - Super kangelane!";
        }
    }
}
