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

        private void tbx1_Validated(object sender, EventArgs e)  
        {
            if (tbx1.Text == string.Empty)
            {
                tbx1.BackColor = Color.Red;
                MessageBox.Show("CAMPO OBLIGATORIO.");
            }
            else if (tbx1.Text.Length >= 4)
            {
                tbx1.BackColor = SystemColors.Window;
            }
            else 
                MessageBox.Show("Debe contener al menos 4 caracteres. "); 
        }

        private void tbx2_Validated(object sender, EventArgs e)
        {
            if (tbx2.Text == string.Empty)
            {
                tbx2.BackColor = Color.Red;
                MessageBox.Show("CAMPO OBLIGATORIO.");
            }
            else if (tbx2.Text.Length >= 4)
            {
                tbx2.BackColor = SystemColors.Window;
            }
            else
                MessageBox.Show("Debe contener al menos 4 caracteres. ");
        }

        private void tbx3_Validated(object sender, EventArgs e)
        {
            if (tbx3.Text == string.Empty)
            {
                tbx3.BackColor = Color.Red;
                MessageBox.Show("CAMPO OBLIGATORIO.");
            }
            else
                tbx3.BackColor = SystemColors.Window;
        }

        //Para ingresar solo nros en elTextBoxEdad
        private void tbx3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void tbx4_Validated(object sender, EventArgs e)
        {
            if (tbx4.Text == string.Empty)
            {
                tbx4.BackColor = Color.Red;
                MessageBox.Show("CAMPO OBLIGATORIO.");
            }
            else if (tbx4.Text.Length >= 4)
            {
                tbx4.BackColor = SystemColors.Window;
            }
            else
                MessageBox.Show("Debe contener al menos 4 caracteres. ");
        }


        //Agregar para el ListWiew. 
        private int conAceptar = 1; 
        private void btn1_Click(object sender, EventArgs e)
        {
            string textoNombre = tbx1.Text;
            string textoApellido = tbx2.Text;
            string textoEdad = tbx3.Text;
            string textoDireccion = tbx4.Text;
            
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
        private bool btn2Clicked = false;
        private bool cerrando = false;
        private int contador = 1;
        private void btn2_Click(object sender, EventArgs e)
        {
            if (!btn2Clicked)
            {
                MessageBox.Show("Gracias por su tiempo...");
                cerrando = true;
                this.Close();
                btn2Clicked = true;
            }
        }

    }
}
