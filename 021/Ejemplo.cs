using System;

namespace EstructuraDinamica {
	class Ejemplo {
		//Atributos variados
		public int ValorEntero { get; set; }
		public double NumeroReal { get; set; }
		public char Caracter { get; set; }
		public string Cadena { get; set; }

		//Constructor
		public Ejemplo(int ValorEntero, double NumeroReal, char Caracter, string Cadena) {
			this.ValorEntero = ValorEntero;
			this.NumeroReal = NumeroReal;
			this.Caracter = Caracter;
			this.Cadena = Cadena;
		}

		//Imprime los valores
		public void Imprime() {
			Console.WriteLine("\r\nEntero: " + ValorEntero.ToString());
			Console.WriteLine("Real: " + NumeroReal.ToString());
			Console.WriteLine("Caracter: " + Caracter.ToString());
			Console.WriteLine("Cadena: [" + Cadena + "]");
		}
	}
}
