//Datos del actor o actriz
namespace EstructuraDinamica {
	class ActorActriz {
		public string Nombre { get; set; }
		public string URLIMDB { get; set; }

		//Constructor
		public ActorActriz(string Nombre, string URLIMDB) {
			this.Nombre = Nombre;
			this.URLIMDB = URLIMDB;
		}
	}
}
