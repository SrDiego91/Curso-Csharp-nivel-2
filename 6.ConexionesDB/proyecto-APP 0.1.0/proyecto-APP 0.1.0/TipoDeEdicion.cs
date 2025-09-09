using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_APP_0._1._0
{
    internal class TipoDeEdicion
    {
        public int id { get; set; }
        public string Edicion { get; set; }
        public override string ToString()
        {
            return Edicion;
        }
    }
}
