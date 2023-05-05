using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio09_Judith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(123, 656, "jasg", "kahdb");
            Camionero cam = new Camionero("adf", 2344, "ajdfga ajdf", "Mangua", 16323, 1038);
            Paquete paquete = new Paquete(124, "kajsgdiye", "ajksfh akjf", "adhifauh");
            Ciudad ciudad = new Ciudad(1876, "ASHBF");

            ciudad.Destinado();
            cam.Conduce();
            cam.Distribuye();

            Console.ReadKey();
        }
    }
}
