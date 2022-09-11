using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtisTHEOMessageLib
{
    public class Assessment : IMessage
    {
        private string TextoValoracion;
        private List<CommentToAssessment> ListaComentarios;
        public Assessment(string TextoValoracion)
        {
            this.TextoValoracion = TextoValoracion;
            this.ListaComentarios = new List<CommentToAssessment>();
        }
        public string GetMessageText()
        {
            return this.TextoValoracion;
        }

        public void AddComment(CommentToAssessment comentario)
        {
            this.ListaComentarios.Add(comentario);
        }

        public int GetNumberOfComments()
        {
            return this.ListaComentarios.Count();
        }

        public bool IsRoot()
        {
            return true;
        }
    }
}
