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
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantidadDeCanciones = (int)lector["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
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

                datos.setearconsulta("insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa) values (@Titulo,@Fecha,@CantidadDeCanciones,@UrlImagenTapa)");
                SqlCommand comando = new SqlCommand();
                comando.Parameters.AddWithValue("@Titulo", Convert.(nuevo.Titulo));
                comando.Parameters.AddWithValue("@Fecha", Convert.ToDateTime(nuevo.FechaLanzamiento));
                comando.Parameters.AddWithValue("@CantidadDeCanciones", Convert.ToInt32(nuevo.CantidadDeCanciones));
                comando.Parameters.AddWithValue("@UrlImagenTapa", Convert.ToString(nuevo.UrlImagenTapa));                
                //datos.setearconsulta("insert into DISCOS (Titulo, CantidadCanciones) values ('"+nuevo.Titulo+"', "+nuevo.CantidadDeCanciones+")");
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
