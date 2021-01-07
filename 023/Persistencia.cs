using System.Collections.Generic;

//La parte que simula la capa de persistencia
namespace EstructuraDinamica {
	class Persistencia {
		List<ActorActriz> Actores;
		List<Serie> Series;

		//Carga datos de prueba
		public Persistencia() {
			Actores = new List<ActorActriz>();
			Series = new List<Serie>();

			//Un listado de actores y actrices
			Actores.Add(new ActorActriz("Paulina Andreeva", "https://www.imdb.com/name/nm5475514/"));
			Actores.Add(new ActorActriz("Kirill Käro", "https://www.imdb.com/name/nm1874211/"));
			Actores.Add(new ActorActriz("Aleksandr Ustyugov", "https://www.imdb.com/name/nm1784957/"));
			Actores.Add(new ActorActriz("Emily Berrington", "https://www.imdb.com/name/nm4970834/"));
			Actores.Add(new ActorActriz("Gemma Chan", "https://www.imdb.com/name/nm2110418/"));
			Actores.Add(new ActorActriz("Lucy Carless", "https://www.imdb.com/name/nm6845331/"));

			//Un listado de series
			Series.Add(new Serie("Better Than US", "https://www.imdb.com/title/tt8285216/"));
			Series.Add(new Serie("Humans", "https://www.imdb.com/title/tt4122068/"));
			Series.Add(new Serie("Westworld", "https://www.imdb.com/title/tt0475784/"));
			Series.Add(new Serie("Real Humans", "https://www.imdb.com/title/tt2180271/"));
			Series.Add(new Serie("Almost Human", "https://www.imdb.com/title/tt2654580/"));
			Series.Add(new Serie("Battlestar Galactica", "https://www.imdb.com/title/tt0407362/"));
			Series.Add(new Serie("Metod", "https://www.imdb.com/title/tt5135336/"));

			//Añado actores y actrices a la serie "Better Than US"
			Series[0].Protagonistas.Add(Actores[1]);
			Series[0].Protagonistas.Add(Actores[2]);

			//Observe que un mismo actor o actriz puede estar en dos series distintas
			Series[0].Protagonistas.Add(Actores[0]);
			Series[6].Protagonistas.Add(Actores[0]);
		}

		//Trae datos de la serie
		public string SerieNombre(int pos) { return Series[pos].Nombre; }
		public string SerieIMDB(int pos) { return Series[pos].URLIMDB; }

		//Trae datos del actor
		public string ActorNombre(int pos) { return Actores[pos].Nombre; }
		public string ActorURL(int pos) { return Actores[pos].URLIMDB; }

		//Total de registros
		public int ActorTotal() { return Actores.Count; }
		public int SerieTotal() { return Series.Count; }

		//Adicionar actor
		public void ActorAdiciona(string Nombre, string URL) {
			Actores.Add(new ActorActriz(Nombre, URL));
		}

		//Editar actor
		public void ActorEdita(int codigo, string Nombre, string URL) {
			Actores[codigo].Nombre = Nombre;
			Actores[codigo].URLIMDB = URL;
		}

		//Borrar actor
		public void ActorBorra(int codigo) {
			Actores.RemoveAt(codigo);
		}

		//Retorna una lista de series donde el actor trabaja
		public List<string> ActorTrabaja(int codigo) {
			List<string> ListaSeries = new List<string>();
			for (int cont = 0; cont < Series.Count; cont++) {
				for (int num = 0; num < Series[cont].Protagonistas.Count; num++) {
					if (Actores[codigo] == Series[cont].Protagonistas[num])
						ListaSeries.Add(Series[cont].Nombre);
				}
			}
			return ListaSeries;
		}

		//Adicionar serie
		public void SerieAdiciona(string Nombre, string URL) {
			Series.Add(new Serie(Nombre, URL));
		}

		//Editar serie
		public void SerieEdita(int codigo, string Nombre, string URL) {
			Series[codigo].Nombre = Nombre;
			Series[codigo].URLIMDB = URL;
		}

		//Borrar serie
		public void SerieBorra(int codigo) {
			Series.RemoveAt(codigo);
		}

		//Retornar los actores que trabajan en la serie
		public List<string> SerieActores(int codigo) {
			List<ActorActriz> actores = Series[codigo].Protagonistas;
			List<string> Nombres = new List<string>();
			for (int cont = 0; cont < actores.Count; cont++)
				Nombres.Add(actores[cont].Nombre);
			return Nombres;
		}

		//Añade un actor a una serie
		public void SerieAsocia(int serie, int actor) {
			Series[serie].Protagonistas.Add(Actores[actor]);
		}

		//Quita un actor de una serie
		public void SerieDisocia(int serie, int actor) {
			Series[serie].Protagonistas.RemoveAt(actor);
		}

	}
}
