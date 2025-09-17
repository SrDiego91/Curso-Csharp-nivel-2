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

namespace proyecto_APP_0._1._0
{
    public partial class frmdiscos : Form
    {
        private List<disco> listadisco;
        public frmdiscos()
        {
            InitializeComponent();
        }

        private void frmdiscos_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar() 
        {
            try
            {
                NegocioDisco negocio = new NegocioDisco();
                listadisco = negocio.listar();
                dgvdisco.DataSource = listadisco;
                dgvdisco.Columns["UrlImagenTapa"].Visible = false;
                CargarImagen(listadisco[0].UrlImagenTapa);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvdisco_SelectionChanged(object sender, EventArgs e)
        {
            disco discselecionado = (disco)dgvdisco.CurrentRow.DataBoundItem;
            CargarImagen(discselecionado.UrlImagenTapa);
        }
        private void CargarImagen(string imagen) 
        {
            try
            {
                pbtapadiscos.Load(imagen);
            }
            catch (Exception ex)
            {

                pbtapadiscos.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRGh5WFH8TOIfRKxUrIgJZoDCs1yvQ4hIcppw&s");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Frmagregardiscos agregar = new Frmagregardiscos();
            agregar.ShowDialog();
            cargar();
        }
    }
}
