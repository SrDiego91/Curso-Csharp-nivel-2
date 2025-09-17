using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class disco
    {
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public int CantidadDeCanciones { get; set; }
        public string UrlImagenTapa { get; set; }
        public TipoDeEstilo Estilo { get; set; }
        public TipoDeEdicion Edicion { get; set; }
    }
}
