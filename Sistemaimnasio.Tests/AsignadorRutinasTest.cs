
using SistemaGimnasio.Tests;

namespace Sistemaimnasio.Tests {
    internal class AsignadorRutinasTest {
        [Fact]
        public void AsignarRutinaAlUsuario_DebeAsignarCorretmente() { 

            var usuario = new Usuario("Gael", 20, "Definir");
            var rutina = new Rutina("Yo puedo", 20);
            var asignador = new AsignadorRutinas();


        }
}
}
