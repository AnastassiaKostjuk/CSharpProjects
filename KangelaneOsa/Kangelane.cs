using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjects.KangelaneOsa
{
    internal class Kangelane
    {
        private string nimi;
        private string asukoht;

        public Kangelane(string nimi, string asukoht)
        {
            this.nimi = nimi;
            this.asukoht = asukoht;
        }

        public string Nimi
        {
            get { return nimi; }
            set { nimi = value; }
        }

        public string Asukoht
        {
            get { return asukoht; }
            set { asukoht = value; }
        }

        public virtual int Paasta(int ohus)
        {
            return (int)Math.Round(ohus * 0.95);
        }

        public virtual string Vormiriietus()
        {
            return "Tavaline vormiriietus";
        }

        public virtual string Tervitus()
        {
            return $"Tere! Mina olen {nimi}, {asukoht} kangelane!";
        }

        public virtual string MissiooniStaatus()
        {
            return "Olen saadaval uuteks missioonideks!";
        }

        public override string ToString()
        {
            return $"{nimi} - {asukoht} kangelane";
        }
    }
}
