using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_hola_mundo_Winforms.NET_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsaludo_Click(object sender, EventArgs e)
        {
            //Crear un proyecto de WinForm con .Net Framework y ejecutar nuestra primera ventana gráfica.
            MessageBox.Show("Hola mundo");
        }
    }
}
