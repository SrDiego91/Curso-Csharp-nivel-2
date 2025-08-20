using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafiowinsform_mod_4_c__n2
{
    public partial class ForDatosPersonales : Form
    {
        public ForDatosPersonales()
        {
            InitializeComponent();
        }

        

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtapellido.Text == "")
            {
                txtapellido.BackColor = Color.Red;
                
            }
            if (txtnombre.Text == "")
            {
                txtnombre.BackColor = Color.Red;

            }
            if (txtedad.Text == "")
            {
                txtedad.BackColor = Color.Red;

            }
            if (txtdireccion.Text == "")
            {
                txtdireccion.BackColor = Color.Red;

            }else
            {
                rtxtresultado.Text = "Apellido y Nombre: " + txtapellido.Text +""+ txtnombre.Text + "\n" + "Edad: " + txtedad.Text + "\n"+ "Direccion: " + txtdireccion.Text;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
