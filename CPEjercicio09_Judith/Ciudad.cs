using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio09_Judith
{
    internal class Ciudad
    {
        int cod;
        string n;

        public Ciudad(int cod, string n)
        {
            this.cod = cod;
            this.n = n;
        }
        public Ciudad() { }

        public int Cod { get => cod; set => cod = value; }
        public string N { get => n; set => n = value; }

        public void Destinado()
        {
            Console.WriteLine(" ");
        }
    }
}
