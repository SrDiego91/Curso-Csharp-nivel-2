using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class TipoDeEdicion
    {
        public int id { get; set; }
        public string EdicionDescripcion { get; set; }
        public override string ToString()
        {
            return EdicionDescripcion;
        }
    }
}
