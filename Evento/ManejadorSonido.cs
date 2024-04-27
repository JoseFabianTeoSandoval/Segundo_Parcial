using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial.Evento
{
    public static class ManejadorSonido
    {
        public static void ManejarSonido(string mensaje)
        {
            Console.WriteLine($"El animal hizo el siguiente sonido: {mensaje}");
        }
    }
}
