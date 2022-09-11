using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtisTHEOMessageLib;

namespace AtisTHEOTesting
{
    public class ComentariosUT
    {
        [Fact]
        public void TestMetodo1()
        {
            //Arrange
            string TextoValoracion = "Este es el mensaje de prueba de mi primera valoración";

            //Act
            Assessment valoracion = new Assessment(TextoValoracion);

            //Assert
            Assert.Equal(TextoValoracion, valoracion.GetMessageText());

        }
    }
}
