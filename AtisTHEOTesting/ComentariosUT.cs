﻿using System;
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
        public void TestCrearUnaValoracion()
        {
            //Arrange
            string TextoValoracion = "Este es el mensaje de prueba de mi primera valoración";

            //Act
            Assessment valoracion = new Assessment(TextoValoracion);

            //Assert
            Assert.Equal(TextoValoracion, valoracion.GetMessageText());

        }

        [Fact]
        public void TestCrearUnComentario()
        {
            //Arrange
            string TextoComentario = "Esto es un comentario para una valoración";

            //Act
            CommentToAssessment comentario = new CommentToAssessment(TextoComentario);

            //Assert
            Assert.Equal(TextoComentario, comentario.GetMessageText());
        }
    }
}
