namespace EstructuraDinamica {
	//Una clase con varios atributos
	class Ejemplo {
		public int Numero { get; set; }
		public double Valor { get; set; }
		public char Caracter { get; set; }
		public string Cadena { get; set; }

		public Ejemplo(int Numero, double Valor, char Caracter, string Cadena) {
			this.Numero = Numero;
			this.Valor = Valor;
			this.Caracter = Caracter;
			this.Cadena = Cadena;
		}
	}
}
