//Datos de la serie de televisión
using System.Collections.Generic;

namespace EstructuraDinamica {
	class Serie {
		public string Nombre { get; set; }
		public string URLIMDB { get; set; }

		//Listado de actores y actrices que actúan en la serie
		public List<ActorActriz> Protagonistas = new List<ActorActriz>();

		//Constructor
		public Serie(string Nombre, string URLIMDB) {
			this.Nombre = Nombre;
			this.URLIMDB = URLIMDB;
		}
	}
}
