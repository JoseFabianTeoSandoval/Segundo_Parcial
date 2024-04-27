using Segundo_Parcial.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Segundo_Parcial.Clases
{
    public class Animal : IAnimal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Especie { get; set; }
        public string Color { get; set; }
        public bool EsDomestico { get; set; }

        public delegate void SonidoEventHandler(string mensaje);
        public event SonidoEventHandler SonidoHizo;

        public Animal(string nombre, int edad, string especie, string color, bool esDomestico)
        {
            Nombre = nombre;
            Edad = edad;
            Especie = especie;
            Color = color;
            EsDomestico = esDomestico;
        }
    
        public void Mostrardetalles()
        {
            Console.WriteLine($"\nSu nombre es {Nombre}, su edad es {Edad},su especie es {Especie}, su color es {Color}, es domestico {EsDomestico}.");
        }

        protected virtual string ObtenerSonido()
        {
            return "Haciendo un sonido genérico";
        }

        public void HacerSonido()
        {
            string sonido = ObtenerSonido();
            Console.WriteLine(sonido);

            SonidoHizo?.Invoke(sonido);
        }
    }


}
