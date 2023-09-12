using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWindows_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tbxNombre_Validated(object sender, EventArgs e)  
        {
            if (tbxNombre.Text == string.Empty)
            {
                tbxNombre.BackColor = Color.Red;
                MessageBox.Show("CAMPO OBLIGATORIO.");
            }
            else if (tbxNombre.Text.Length >= 4)
            {
                tbxNombre.BackColor = SystemColors.Window;
            }
            else 
                MessageBox.Show("Debe contener al menos 4 caracteres. "); 
        }

        private void tbxApellido_Validated(object sender, EventArgs e)
        {
            if (tbxApellido.Text == string.Empty)
            {
                tbxApellido.BackColor = Color.Red;
                MessageBox.Show("CAMPO OBLIGATORIO.");
            }
            else if (tbxApellido.Text.Length >= 4)
            {
                tbxApellido.BackColor = SystemColors.Window;
            }
            else
                MessageBox.Show("Debe contener al menos 4 caracteres. ");
        }

        private void tbxEdad_Validated(object sender, EventArgs e)
        {
            if (tbxEdad.Text == string.Empty)
            {
                tbxEdad.BackColor = Color.Red;
                MessageBox.Show("CAMPO OBLIGATORIO.");
            }
            else
                tbxEdad.BackColor = SystemColors.Window;
        }

        //Para ingresar solo nros en elTextBoxEdad
        private void tbxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void tbxDireccion_Validated(object sender, EventArgs e)
        {
            if (tbxDireccion.Text == string.Empty)
            {
                tbxDireccion.BackColor = Color.Red;
                MessageBox.Show("CAMPO OBLIGATORIO.");
            }
            else if (tbxDireccion.Text.Length >= 4)
            {
                tbxDireccion.BackColor = SystemColors.Window;
            }
            else
                MessageBox.Show("Debe contener al menos 4 caracteres. ");
        }


        //Agregar para el ListWiew. 
        private int conAceptar = 1; 
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string textoNombre = tbxNombre.Text;
            string textoApellido = tbxApellido.Text;
            string textoEdad = tbxEdad.Text;
            string textoDireccion = tbxDireccion.Text;
            
            if (conAceptar == 1 && !string.IsNullOrWhiteSpace(textoNombre) && !string.IsNullOrWhiteSpace(textoApellido) && !string.IsNullOrWhiteSpace(textoEdad) && !string.IsNullOrWhiteSpace(textoDireccion))
            {
                string formatoNombre = new string('x', Math.Max(15, textoNombre.Length)); 
                tbxResultado.Text += formatoNombre + Environment.NewLine; 
                string formatoApellido = new string('x', Math.Max(15, textoApellido.Length));
                tbxResultado.Text += formatoApellido + Environment.NewLine;
                string formatoEdad = new string('x', Math.Max(3, textoEdad.Length));
                tbxResultado.Text += formatoEdad + Environment.NewLine;
                string formatoDireccion = new string('x', Math.Max(20, textoDireccion.Length));
                tbxResultado.Text += formatoDireccion + Environment.NewLine; 
                conAceptar++; 
            }
        }

        //Cerrar con el btn2 = "Cancelar"
        private bool btnCancelarClicked = false;
        private bool cerrando = false;
        private int contador = 1;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!btnCancelarClicked)
            {
                MessageBox.Show("Gracias por su tiempo...");
                cerrando = true;
                this.Close();
                btnCancelarClicked = true;
            }
        }

    }
}
