using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Data.SqlClient;
namespace proyecto_APP_0._1._0
{
    public partial class Frmagregardiscos : Form
    {
        public Frmagregardiscos()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            disco disco = new disco();
            NegocioDisco negocio = new NegocioDisco();
            
            try
            {
              
                disco.Titulo = txttitulo.Text;
                disco.FechaLanzamiento = dtpfechalanzamiento.Value;
                disco.CantidadDeCanciones = int.Parse(txtcantidadcanciones.Text);
                disco.Estilo = (TipoDeEstilo)cbestilo.SelectedItem;
                disco.Edicion = (TipoDeEdicion)cbedicion.SelectedItem;

                negocio.agregar(disco);
                MessageBox.Show("Agregado exitosamente");
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
                cbedicion.DataSource = edicion.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        
    }
}
