using Segundo_Parcial.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial.Clases
{
    public class Perro : Animal, IAnimal
    {
        public Perro(string nombre, int edad, string color, bool esDomestico)
            : base(nombre, edad, "Perro", color, esDomestico)
        {
        }

        protected override string ObtenerSonido()
        {
            return "¡Guau! ¡Guau!";
        }
    }
}
