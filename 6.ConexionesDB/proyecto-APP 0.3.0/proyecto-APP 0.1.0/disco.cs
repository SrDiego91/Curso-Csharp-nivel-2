using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_APP_0._1._0
{
    internal class disco
    {
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public int CantidadDeCanciones { get; set; }
        public string UrlImagenTapa { get; set; }
        public TipoDeEstilo Estilo { get; set; }
        public TipoDeEdicion EdicionTipo { get; set; }
    }
}
