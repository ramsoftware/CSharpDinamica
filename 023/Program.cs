//Inicia el programa
namespace EstructuraDinamica {
	class Program {
		static void Main() {
			//Se debe llamar primero la capa de persistencia (carga datos de ejemplo)
			Persistencia objDatos = new Persistencia();

			//Luego se llama la capa visual
			Visual objVisual = new Visual(objDatos);
			objVisual.Menu();
		}
	}
}
