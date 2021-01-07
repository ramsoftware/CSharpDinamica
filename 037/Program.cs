using System;
using System.Collections.Generic;

namespace EstructuraDinamica {
	class Program {
		static void Main() {
			//Se define una lista enlazada
			LinkedList<Ejemplo> Lenguajes = new LinkedList<Ejemplo>();

			//Agrega al final
			Lenguajes.AddLast(new Ejemplo(16, 83.29, 'R', "Lenguaje R"));
			Lenguajes.AddLast(new Ejemplo(29, 89.7, 'A', "ADA"));
			Lenguajes.AddLast(new Ejemplo(2, 80.19, 'M', "Máquina"));
			Lenguajes.AddLast(new Ejemplo(95, 7.21, 'P', "PHP"));

			//Imprime esa lista
			Console.WriteLine("Agregando con AddLast");
			foreach (Ejemplo elemento in Lenguajes) Console.Write(elemento.Cadena + "; ");

			//Agrega al inicio
			Lenguajes.AddFirst(new Ejemplo(78, 12.32, 'C', "C#"));
			Lenguajes.AddFirst(new Ejemplo(55, -3.21, 'V', "Visual Basic .NET"));

			//Imprime esa lista
			Console.WriteLine("\r\n\r\nAgregando con AddFirst");
			foreach (Ejemplo elemento in Lenguajes) Console.Write(elemento.Cadena + "; ");

			//Agrega al final
			Lenguajes.AddLast(new Ejemplo(16, 83.29, 'T', "TypeScript"));
			Console.WriteLine("\r\n\r\nAgregando con AddLast");
			foreach (Ejemplo elemento in Lenguajes) Console.Write(elemento.Cadena + "; ");

			//Cantidad
			Console.WriteLine("\r\n\r\nCantidad es: " + Lenguajes.Count);

			//Elimina primer elemento
			Lenguajes.RemoveFirst();
			Console.WriteLine("\r\nEliminado el primer elemento");
			foreach (Ejemplo elemento in Lenguajes) Console.Write(elemento.Cadena + "; ");

			//Elimina último elemento
			Lenguajes.RemoveLast();
			Console.WriteLine("\r\n\r\nEliminado el último elemento");
			foreach (Ejemplo elemento in Lenguajes) Console.Write(elemento.Cadena + "; ");

			Console.ReadKey();
		}
	}
}
