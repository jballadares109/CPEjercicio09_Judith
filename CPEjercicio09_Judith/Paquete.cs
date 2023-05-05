using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio09_Judith
{
    internal class Paquete
    {
        int c;
        string descrip;
        string destinatario;
        string dirreccion;
        public Paquete() { }
        public Paquete(int c, string descrip, string destinatario, string dirreccion)
        {
            this.c = c;
            this.descrip = descrip;
            this.destinatario = destinatario;
            this.dirreccion = dirreccion;
        }

        public int C { get => c; set => c = value; }
        public string Descrip { get => descrip; set => descrip = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Dirreccion { get => dirreccion; set => dirreccion = value; }
    }
}
