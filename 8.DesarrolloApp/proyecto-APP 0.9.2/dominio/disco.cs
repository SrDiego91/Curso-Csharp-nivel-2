using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class disco
    {
        public int Id { get; set; }
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Fecha de lanzamiento")]
        public string FechaLanzamiento { get; set; }
        [DisplayName("Cantidad de canciones")]
        public int CantidadDeCanciones { get; set; }
        public string UrlImagenTapa { get; set; }
        public TipoDeEstilo Estilo { get; set; }
        public TipoDeEdicion Edicion { get; set; }
    }
}
