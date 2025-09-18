using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
namespace proyecto_APP_0._1._0
{
    public partial class Frmagregardiscos : Form
    {
        private disco disco = null;
        public Frmagregardiscos()
        {
            InitializeComponent();
        }
        public Frmagregardiscos(disco disco)
        {
            InitializeComponent();
            this.disco = disco;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            
            NegocioDisco negocio = new NegocioDisco();
            
            try
            {
                if (disco == null)
                    disco = new disco();
              
                disco.Titulo = txttitulo.Text;
                disco.FechaLanzamiento = dtpfechalanzamiento.Text;
                disco.CantidadDeCanciones = int.Parse(txtcantidadcanciones.Text);
                disco.UrlImagenTapa = txturltapadisco.Text;
                disco.Estilo = (TipoDeEstilo)cbestilo.SelectedItem;
                disco.Edicion = (TipoDeEdicion)cbedicion.SelectedItem;

                if (disco.Id != 0)
                {
                    negocio.modificar(disco);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(disco);
                    MessageBox.Show("Agregado exitosamente");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        

        private void Frmagregardiscos_Load(object sender, EventArgs e)
        {
            estilonegocio estilo = new estilonegocio();
            edicionNegocio edicion = new edicionNegocio();
            try
            {
                cbestilo.DataSource = estilo.listar();
                cbestilo.ValueMember = "Id";
                cbestilo.DisplayMember = "Descripcion";
                cbedicion.DataSource = edicion.listar();
                cbedicion.ValueMember = "Id";
                cbedicion.DisplayMember = "EdicionDescripcion";

                if (disco != null)
                {
                    txttitulo.Text = disco.Titulo;
                    //fecha
                    txtcantidadcanciones.Text = disco.CantidadDeCanciones.ToString();
                    txturltapadisco.Text = disco.UrlImagenTapa;
                    CargarImagen(disco.UrlImagenTapa);
                    cbestilo.SelectedValue = disco.Estilo.id;
                    cbedicion.SelectedValue = disco.Edicion.id;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void txturltapadisco_Leave(object sender, EventArgs e)
        {
            CargarImagen(txturltapadisco.Text);
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pbprecargardeagregarimagen.Load(imagen);
            }
            catch (Exception ex)
            {

                pbprecargardeagregarimagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRGh5WFH8TOIfRKxUrIgJZoDCs1yvQ4hIcppw&s");
            }
        }

    }
}
