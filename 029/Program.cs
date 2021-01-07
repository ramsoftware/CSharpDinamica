﻿using System;
using System.Collections.Generic;

namespace EstructuraDinamica {
	class Program {
		static void Main() {
			//Se define una cola de tipo objeto personalizado
			Queue<Ejemplo> Cola = new Queue<Ejemplo>();

			//Se agregan elementos a la cola
			Cola.Enqueue(new Ejemplo(1, 0.2, 'r', "Leafar"));
			Cola.Enqueue(new Ejemplo(8, -7.1, 'a', "Otrebla"));
			Cola.Enqueue(new Ejemplo(23, -13.6, 'm', "Onerom"));
			Cola.Enqueue(new Ejemplo(49, 16.83, 'p', "Arrap"));

			//Número de elmentos en la cola
			Console.WriteLine("Número de elementos: " + Cola.Count);

			//Imprimir la cola
			Console.WriteLine("\r\nElementos: ");
			foreach (Ejemplo elemento in Cola) Console.Write(elemento.Cadena + ", ");

			//Quitar elemento de la cola
			Cola.Dequeue(); //Primero en llegar, primero en salir, luego quitaría a "aaa"
			Console.WriteLine("\r\nAl quitar un elemento de la cola: ");
			foreach (Ejemplo elemento in Cola) Console.Write(elemento.Cadena + ", ");

			//Obtener el primer elemento de la cola sin borrar ese elemento
			Ejemplo PrimerElemento = Cola.Peek();
			Console.WriteLine("\r\n\r\nPrimer elemento de la cola: " + PrimerElemento.Cadena);

			//Leer y borrar la cola
			Console.WriteLine("\r\nLee y borra la cola: ");
			while (Cola.Count > 0)
				Console.Write(Cola.Dequeue().Cadena + "; ");
			Console.WriteLine("\r\nNúmero de elementos: " + Cola.Count);

			//Agrega elementos a la cola y luego la borra
			Cola.Enqueue(new Ejemplo(7, 6.5, 'z', "qwerty"));
			Cola.Enqueue(new Ejemplo(4, -3.2, 'y', "asdfg"));
			Console.WriteLine("\r\nNúmero de elementos: " + Cola.Count);
			Cola.Clear();
			Console.WriteLine("Después de borrar. Número de elementos: " + Cola.Count);

			Console.ReadKey();
		}
	}
}
