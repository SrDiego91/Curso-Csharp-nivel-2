using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace proyecto_APP_0._1._0
{
    public class NegocioDisco
    {
        public List<disco> listar()
        {
            List<disco> lista = new List<disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion, T.Descripcion from DISCOS D, ESTILOS E, TIPOSEDICION T where E.Id = D.IdEstilo and E.Id = T.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    disco aux = new disco();
                    aux.Titulo = (string)lector["Titulo"];
                    DateTime fecha = lector.GetDateTime(1);
                    aux.FechaLanzamiento = fecha;   
                    aux.CantidadDeCanciones = (int)lector["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    aux.Estilo = new TipoDeEstilo();
                    aux.Estilo.Descripcion = (string)lector["Descripcion"];
                    aux.TipoEdicion = new TipoDeEdicion();
                    aux.TipoEdicion.Edicion = (string)lector[5];

                    lista.Add(aux);
                    
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
