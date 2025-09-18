using dominio;
using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
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
                    aux.FechaLanzamiento = Convert.ToString(lector["FechaLanzamiento"]);
                    aux.CantidadDeCanciones = (int)lector["CantidadCanciones"];
                    if (!(lector["UrlImagenTapa"] is DBNull))
                    {
                        aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    }
                    aux.Estilo = new TipoDeEstilo();
                    aux.Estilo.Descripcion = (string)lector["Descripcion"];
                    aux.Edicion = new TipoDeEdicion();
                    aux.Edicion.EdicionDescripcion = (string)lector[5];

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
        public void agregar(disco nuevo) 
        {
            accesodatos datos = new accesodatos();
            try
            {

                //datos.setearconsulta("insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa) values (@Titulo,@Fecha,@CantidadDeCanciones,@UrlImagenTapa)");
                //SqlCommand comando = new SqlCommand();
                //string titulo, url;
                //int cantcanciones;
                //DateTime fecha;
                //titulo = nuevo.Titulo;
                //fecha = nuevo.FechaLanzamiento;
                //cantcanciones = nuevo.CantidadDeCanciones;
                //url = nuevo.UrlImagenTapa;
                //comando.Parameters.AddWithValue("@Titulo", titulo);
                //comando.Parameters.AddWithValue("@Fecha", fecha);
                //comando.Parameters.AddWithValue("@CantidadDeCanciones", cantcanciones);
                //comando.Parameters.AddWithValue("@UrlImagenTapa", url);                
                //datos.setearconsulta("insert into DISCOS (Titulo, CantidadCanciones) values ('"+nuevo.Titulo+"', "+nuevo.CantidadDeCanciones+")");
                datos.setearconsulta("insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion) values ('"+nuevo.Titulo+ "','"+nuevo.FechaLanzamiento+"',"+nuevo.CantidadDeCanciones+",'"+nuevo.UrlImagenTapa+"', @IdEstilo, @IdTipoEdicion)");
                datos.setearParametro("@IdEstilo", nuevo.Estilo.id);
                datos.setearParametro("@IdTipoEdicion", nuevo.Edicion.id);
                datos.ejercutaraccion();
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
        public void modificar(disco modificar)
        {

        }

    }
}
