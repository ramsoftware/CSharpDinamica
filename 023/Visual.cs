using System;
using System.Collections.Generic;

//La parte visual del programa
namespace EstructuraDinamica {
	class Visual {
		public Persistencia Datos;

		//Conecta con la capa de persistencia
		public Visual(Persistencia objDatos) {
			Datos = objDatos;
		}

		//Menú principal
		public void Menu() {
			int opcion;
			do {
				Console.Clear();
				Console.WriteLine("\n=========== Software TV Show 1.3 (Diciembre de 2020) ===========");
				Console.WriteLine("1. CRUD de actores y actrices");
				Console.WriteLine("2. CRUD de series");
				Console.WriteLine("3. Salir");
				Console.Write("¿Opción? ");
				opcion = Convert.ToInt32(Console.ReadLine());
				switch (opcion) {
					case 1: CRUDactores(); break;
					case 2: CRUDseries(); break;
				}
			} while (opcion != 3);
		}

		//Menú de actores y actrices
		public void CRUDactores() {
			int opcion;
			do {
				Console.Clear();
				Console.WriteLine("\n=========== Software TV Show. Actores/Actrices ===========");
				for (int cont = 0; cont < Datos.ActorTotal(); cont++) {
					Console.Write("[" + cont.ToString() + "] ");
					Console.Write(Datos.ActorNombre(cont));
					Console.WriteLine(" Nace: " + Datos.ActorURL(cont).ToString());
				}
				Console.WriteLine(" \n1. Adicionar");
				Console.WriteLine("2. Editar");
				Console.WriteLine("3. Borrar");
				Console.WriteLine("4. ¿En cuáles series trabaja?");
				Console.WriteLine("5. Volver a menú principal");
				Console.Write("¿Opción? ");
				opcion = Convert.ToInt32(Console.ReadLine());
				switch (opcion) {
					case 1: ActorAdiciona(); break;
					case 2: ActorEdita(); break;
					case 3: ActorBorra(); break;
					case 4: ActorTrabaja(); break;
				}
			} while (opcion != 5);
		}

		//Menú de series de TV
		public void CRUDseries() {
			int opcion;
			do {
				Console.Clear();
				Console.WriteLine("\n=========== Software TV Show. Series ===========");
				for (int cont = 0; cont < Datos.SerieTotal(); cont++) {
					Console.Write("[" + cont.ToString() + "] ");
					Console.Write(Datos.SerieNombre(cont));
					Console.WriteLine(" URL: " + Datos.SerieIMDB(cont));
				}
				Console.WriteLine("\n1. Adicionar");
				Console.WriteLine("2. Editar");
				Console.WriteLine("3. Borrar");
				Console.WriteLine("4. Detalles de la serie");
				Console.WriteLine("5. Asociar actor/actriz a serie");
				Console.WriteLine("6. Disociar actor/actriz a serie");
				Console.WriteLine("7. Volver a menú principal");
				Console.Write("¿Opción? ");
				opcion = Convert.ToInt32(Console.ReadLine());
				switch (opcion) {
					case 1: SerieAdiciona(); break;
					case 2: SerieEdita(); break;
					case 3: SerieBorra(); break;
					case 4: SerieDetalle(); break;
					case 5: SerieAsocia(); break;
					case 6: SerieDisocia(); break;
				}
			} while (opcion != 7);
		}

		//Pantalla para adicionar actores
		public void ActorAdiciona() {
			Console.WriteLine("\tAdicionar actor o actriz al listado");
			Console.Write("¿Nombre? ");
			string nombre = Console.ReadLine();
			Console.Write("¿URL de IMDB? ");
			string URL = Console.ReadLine();
			Datos.ActorAdiciona(nombre, URL);
			Console.WriteLine("\nActor/actriz adicionado. Presione ENTER para continuar");
			Console.ReadKey();
		}

		//Pantalla para editar actores
		public void ActorEdita() {
			Console.WriteLine("\tEditar actor o actriz");
			Console.Write("¿Cuál? Escriba el número que está entre [ ]: ");
			int codigo = Convert.ToInt32(Console.ReadLine());
			Console.Write("¿Nombre? ");
			string nombre = Console.ReadLine();
			Console.Write("¿URL de IMDB? ");
			string URL = Console.ReadLine();
			Datos.ActorEdita(codigo, nombre, URL);
			Console.WriteLine("\nActor/actriz editado. Presione ENTER para continuar");
			Console.ReadKey();
		}

		//Pantalla para borrar actores
		public void ActorBorra() {
			Console.WriteLine("\tBorrar actor o actriz");
			Console.Write("¿Cuál? Escriba el número que está entre [ ]: ");
			int codigo = Convert.ToInt32(Console.ReadLine());
			Datos.ActorBorra(codigo);
			Console.WriteLine("\nActor/actriz borrado. Presione ENTER para continuar");
			Console.ReadKey();
		}

		//Pantalla para mostrar en que series trabaja el actor
		public void ActorTrabaja() {
			List<string> ListaSeries;
			Console.WriteLine("\tListar las series donde trabaja el actor/actriz");
			Console.Write("¿Cuál? Escriba el número que está entre [ ]: ");
			int codigo = Convert.ToInt32(Console.ReadLine());
			ListaSeries = Datos.ActorTrabaja(codigo);
			for (int cont = 0; cont < ListaSeries.Count; cont++)  Console.WriteLine(ListaSeries[cont]);
			Console.WriteLine("\nPresione ENTER para continuar");
			Console.ReadKey();
		}

		//Pantalla para adicionar series
		public void SerieAdiciona() {
			Console.WriteLine("\tAdicionar serie al listado");
			Console.Write("¿Nombre? ");
			string nombre = Console.ReadLine();
			Console.Write("¿URL en IMDB? ");
			string url = Console.ReadLine();
			Datos.SerieAdiciona(nombre, url);
			Console.WriteLine("\nSerie adicionada. Presione ENTER para continuar");
			Console.ReadKey();
		}

		//Pantalla para editar series
		public void SerieEdita() {
			Console.WriteLine("\tEditar serie");
			Console.Write("¿Cuál? Escriba el número que está entre [ ]: ");
			int codigo = Convert.ToInt32(Console.ReadLine());
			Console.Write("¿Nombre? ");
			string nombre = Console.ReadLine();
			Console.Write("¿URL en IMDB? ");
			string url = Console.ReadLine();
			Datos.SerieEdita(codigo, nombre, url);
			Console.WriteLine("\nSerie editada. Presione ENTER para continuar");
			Console.ReadKey();
		}

		//Pantalla para borrar series
		public void SerieBorra() {
			Console.WriteLine("\tBorrar serie");
			Console.Write("¿Cuál? Escriba el número que está entre [ ]: ");
			int codigo = Convert.ToInt32(Console.ReadLine());
			Datos.SerieBorra(codigo);
			Console.WriteLine("\nSerie borrada. Presione ENTER para continuar");
			Console.ReadKey();
		}

		//Pantalla para ver el detalle de la serie
		public void SerieDetalle() {
			List<string> ListaActores;

			Console.WriteLine("\t === Detalle de una serie ===");
			Console.Write("¿Cuál? Escriba el número que está entre [ ]: ");
			int codigo = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Nombre: " + Datos.SerieNombre(codigo));
			Console.WriteLine("URL: " + Datos.SerieIMDB(codigo));
			Console.WriteLine("Actores");
			ListaActores = Datos.SerieActores(codigo);
			for (int cont = 0; cont < ListaActores.Count; cont++)  Console.WriteLine("\t" + ListaActores[cont]);

			Console.WriteLine("\nPresione ENTER para continuar");
			Console.ReadKey();
		}

		//Asociar actor o actriz a una serie
		public void SerieAsocia() {
			Console.WriteLine("\tAsocia un actor o actriz a una serie");
			Console.Write("¿Cuál serie? Escriba el número que está entre [ ]: ");
			int serie = Convert.ToInt32(Console.ReadLine());
			for (int cont = 0; cont < Datos.ActorTotal(); cont++) {
				Console.Write("[" + cont.ToString() + "] ");
				Console.Write(Datos.ActorNombre(cont));
				Console.WriteLine(" URL: " + Datos.ActorURL(cont).ToString());
			}
			Console.Write("¿Cuál actor/actriz? Escriba el número que está entre [ ]: ");
			int actor = Convert.ToInt32(Console.ReadLine());
			Datos.SerieAsocia(serie, actor);
			Console.WriteLine("\nActor/actriz asociado a la serie. Presione ENTER para continuar");
			Console.ReadKey();
		}

		//Pantalla para disociar actor de alguna serie
		public void SerieDisocia() {
			List<string> ListaActores;

			Console.WriteLine("\t === Disociar actor de la serie ===");
			Console.Write("¿Cuál serie? Escriba el número que está entre [ ]: ");
			int serie = Convert.ToInt32(Console.ReadLine());

			ListaActores = Datos.SerieActores(serie);
			for (int cont = 0; cont < ListaActores.Count; cont++)
				Console.WriteLine("[" + cont.ToString() + "] " + ListaActores[cont]);

			Console.Write("¿Cuál actor/actriz quiere quitar? Escriba el número que está entre [ ]: ");
			int actor = Convert.ToInt32(Console.ReadLine());

			Datos.SerieDisocia(serie, actor);
			Console.WriteLine("\nActor/actriz retirado de la serie. Presione ENTER para continuar");
			Console.ReadKey();
		}

	}
}
