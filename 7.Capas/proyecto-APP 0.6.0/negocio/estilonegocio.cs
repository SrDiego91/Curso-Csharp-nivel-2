using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class estilonegocio
    {
        public List<TipoDeEstilo> listar() 
        {
			List<TipoDeEstilo> lista = new List<TipoDeEstilo>();
			accesodatos datos =	new accesodatos();
            try
            {
                datos.setearconsulta("select id, descripcion from ESTILOS");
                datos.ejecutarlectura();
                while (datos.Lector.Read())
                {
                    TipoDeEstilo aux = new TipoDeEstilo();
                    aux.id = (int)datos.Lector["id"];
                    aux.Descripcion = (string)datos.Lector["descripcion"];

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
