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
                comando.CommandText = "select D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion, T.Descripcion, D.IdEstilo, D.IdTipoEdicion, D.Id from DISCOS D, ESTILOS E, TIPOSEDICION T where E.Id = D.IdEstilo and E.Id = T.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    disco aux = new disco();
                    aux.Id = (int)lector["Id"];
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = Convert.ToString(lector["FechaLanzamiento"]);
                    aux.CantidadDeCanciones = (int)lector["CantidadCanciones"];
                    if (!(lector["UrlImagenTapa"] is DBNull))
                    {
                        aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    }
                    aux.Estilo = new TipoDeEstilo();
                    aux.Estilo.id = (int)lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)lector["Descripcion"];
                    aux.Edicion = new TipoDeEdicion();
                    aux.Edicion.id = (int)lector["IdTipoEdicion"];
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
        public void agregar(disco disconuevo) 
        {
            accesodatos datos = new accesodatos();
            try
            {
                datos.setearconsulta("insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion) values ('"+disconuevo.Titulo+ "','"+disconuevo.FechaLanzamiento+"',"+disconuevo.CantidadDeCanciones+",'"+disconuevo.UrlImagenTapa+"', @IdEstilo, @IdTipoEdicion)");
                datos.setearParametro("@IdEstilo", disconuevo.Estilo.id);
                datos.setearParametro("@IdTipoEdicion", disconuevo.Edicion.id);
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
        public void modificar(disco discomodificado)
        {
            accesodatos datos = new accesodatos();
            try
            {
                datos.setearconsulta("update DISCOS set Titulo = @titulo, FechaLanzamiento = @fecha, CantidadCanciones = @cantidadcanciones, UrlImagenTapa = @url, IdEstilo = @idestilo, IdTipoEdicion = @idedicion where id = @id");
                datos.setearParametro("@titulo", discomodificado.Titulo);
                datos.setearParametro("@fecha", discomodificado.FechaLanzamiento);
                datos.setearParametro("@cantidadcanciones", discomodificado.CantidadDeCanciones);
                datos.setearParametro("@url", discomodificado.UrlImagenTapa);
                datos.setearParametro("@idestilo", discomodificado.Estilo.id);
                datos.setearParametro("@idedicion", discomodificado.Edicion.id);
                datos.setearParametro("@id", discomodificado.Id);

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
        public void eliminar(disco discoeliminar) 
        {
            accesodatos datos = new accesodatos();
            try
            {
                datos.setearconsulta("delete from DISCOS where id = @id");
                datos.setearParametro("@id", discoeliminar.Id);
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

    }
}
