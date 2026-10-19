using Xunit;
using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Tests {
    public class EntrenadorTest {
        [Fact]
        public void Asignar_Usuario_DebeAgrgarUsuarioALista() {
            var usaurio = new Usuario("Gael", 20, "Definir");
            var usaurio2 = new Usuario("Sebastian", 20, "Aumentar masa");
            var entrenador = new Entrenador("Pepe", "Licuados proteicos");

            entrenador.AsignarUsuario(usuario);
            entrenador.AsignarUsuario(usuario2);


            Assert.NotEmpty(entrenador.ObtenerUsuariosAsignados());
            Assert.Contains(usuario2,entrenador.ObtenerUsuariosAsignados());


        }
    }
}
