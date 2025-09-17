using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class edicionNegocio
    {
        public List<TipoDeEdicion> listar() 
        {
            List<TipoDeEdicion> lista = new List<TipoDeEdicion>();
            accesodatos datos = new accesodatos();
            try
            {
                datos.setearconsulta("select Id, Descripcion from TIPOSEDICION");
                datos.ejecutarlectura();
                while (datos.Lector.Read())
                {
                    TipoDeEdicion aux = new TipoDeEdicion();
                    aux.id = (int)datos.Lector["Id"];
                    aux.EdicionDescripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);

                }

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                datos.cerrarconexion();
            }

        }
    }
}
