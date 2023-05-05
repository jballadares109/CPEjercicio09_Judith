using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio09_Judith
{
    internal class Camion
    {
        int potencia;
        int matricula;
        string modelo;
        string tipo;

        public Camion() { }
        public Camion(int potencia, int matricula, string modelo, string tipo)
        {
            this.potencia = potencia;
            this.matricula = matricula;
            this.modelo = modelo;
            this.tipo = tipo;
        }

        public int Potencia { get => potencia; set => potencia = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
