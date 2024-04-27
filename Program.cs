using Segundo_Parcial.Clases;
using Segundo_Parcial.Evento;


Perro miPerro = new Perro("Firulais", 3, "Marron", true);
Gato miGato = new Gato("Garfield", 5, "Naranja", true);

miPerro.SonidoHizo += ManejadorSonido.ManejarSonido;
miGato.SonidoHizo += ManejadorSonido.ManejarSonido;

miPerro.Mostrardetalles();
miPerro.HacerSonido();

miGato.Mostrardetalles();
miGato.HacerSonido();