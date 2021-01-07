using System;
using System.Collections;

namespace EstructuraDinamica {
	class Program {
		static void Main() {
			//Se define un Hashtable
			Hashtable Objetos = new Hashtable();

			Objetos.Add("uno", new Ejemplo(1, 0.2, 'r', "Leafar"));
			Objetos.Add("dos", new Ejemplo(8, -7.1, 'a', "Otrebla"));
			Objetos.Add("tres", new Ejemplo(23, -13.6, 'm', "Onerom"));
			Objetos.Add("cuatro", new Ejemplo(49, 16.83, 'p', "Arrap"));

			//Trae los datos del objeto guardado en el diccionario
			string Llave = "tres";
			Console.WriteLine("Llave: " + Llave + " atributo es: " + (Objetos[Llave] as Ejemplo).Cadena);
			Console.WriteLine("Llave: " + Llave + " atributo es: " + (Objetos[Llave] as Ejemplo).Numero);
			Console.WriteLine("Llave: " + Llave + " atributo es: " + (Objetos[Llave] as Ejemplo).Valor);

			//Guarda las llaves en una variable de colección
			Console.WriteLine("\r\nLista de Llaves:");
			var ListaLlaves = Objetos.Keys;
			foreach (string Llaves in ListaLlaves) {
				Console.WriteLine("Llave: " + Llaves);
			}

			//Verifica si existe una llave
			Console.WriteLine("\r\nVerifica si existe una llave:");
			if (Objetos.ContainsKey("cuatro")) {
				Console.WriteLine((Objetos["cuatro"] as Ejemplo).Cadena);
			}
			else {
				Console.WriteLine("No existe esa llave");
			}

			Console.ReadKey();
		}
	}
}
