using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_APP_0._1._0
{
    public partial class frmdiscos : Form
    {
        public frmdiscos()
        {
            InitializeComponent();
        }

        private void frmdiscos_Load(object sender, EventArgs e)
        {
            NegocioDisco negocio = new NegocioDisco();
            dgvdisco.DataSource = negocio.listar();
        }
    }
}
