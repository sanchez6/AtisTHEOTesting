using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtisTHEOMessageLib
{
    public class CommentToAssessment : IMessage
    {
        private string TextoComentario;
        public CommentToAssessment(string textoComentario)
        {
            TextoComentario = textoComentario;
        }
        public string GetMessageText()
        {
            return TextoComentario;
        }

        public bool IsRoot()
        {
            return false;
        }
    }
}
