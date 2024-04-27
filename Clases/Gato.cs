using Segundo_Parcial.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial.Clases
{
    public class Gato : Animal, IAnimal
    {
        public Gato(string nombre, int edad, string color, bool esDomestico)
            : base(nombre, edad, "Gato", color, esDomestico)
        {
        }

        protected override string ObtenerSonido()
        {
            return "¡Miau! ¡Miau!";
        }
    }
}
