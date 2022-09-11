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
        public Assessment(string TextoValoracion)
        {
            this.TextoValoracion = TextoValoracion;
        }
        public string GetMessageText()
        {
            return this.TextoValoracion;
        }

        public bool IsRoot()
        {
            return true;
        }
    }
}
