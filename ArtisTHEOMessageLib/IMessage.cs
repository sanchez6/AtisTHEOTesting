using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtisTHEOMessageLib
{
    public interface IMessage
    {
        
        public bool IsRoot();
        public string GetMessageText();
        


    }
}
