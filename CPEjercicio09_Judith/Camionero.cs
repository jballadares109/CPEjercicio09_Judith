using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio09_Judith
{
    internal class Camionero
    {
        string nomb;
        int telef;
        string direccion;
        string poblacion;
        float salario;
        int rec;
        public Camionero() { }

        public Camionero(string nomb, int telef, string direccion, string poblacion, float salario, int rec)
        {
            this.Nomb = nomb;
            this.Telef = telef;
            this.Direccion = direccion;
            this.Poblacion = poblacion;
            this.Salario = salario;
            this.Rec = rec;
        }

        public string Nomb { get => nomb; set => nomb = value; }
        public int Telef { get => telef; set => telef = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Poblacion { get => poblacion; set => poblacion = value; }
        public float Salario { get => salario; set => salario = value; }
        public int Rec { get => rec; set => rec = value; }

        public void Conduce()
        {
            Console.WriteLine(" ");
        }
        public void Distribuye()
        {
            Console.WriteLine(" ");
        }
    }
}
