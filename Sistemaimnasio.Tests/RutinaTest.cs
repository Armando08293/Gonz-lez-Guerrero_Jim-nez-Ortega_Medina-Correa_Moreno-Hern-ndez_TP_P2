using Xunit;
using SistemaGimnasio.Modelos;
namespace Sistemaimnasio.Tests {

   public class RutinaTest {
        [Fact]
        public void AgregarEjercico_DebeAgregarALista() {

            var rutina = new Rutina("Yo puedo", 120);
            var ejercicio1 = new Ejercicio("Levanta", 15, 5, 90);
            var ejercicio2 = new Ejercicio("Press", 12, 4, 30);


            rutina.AgregarEjercico(ejercicio1 );
            rutina.AgregarEjercicio(ejercicio2 );


            Assert.NotEmpty(rutina.ObtenerEjercicios());
            Assert.Equal(rutina.ObtenerEjercicios());
        }
    }
}
