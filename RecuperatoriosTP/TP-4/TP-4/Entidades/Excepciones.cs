using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrackingIDRepetidoException : Exception
    {
        public TrackingIDRepetidoException(string cadena) : base(cadena)
        {
        }

        public TrackingIDRepetidoException(string cadena, Exception inner) : base(cadena, inner)
        {
        }
    }
}
