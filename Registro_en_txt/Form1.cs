using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_en_txt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            TextboxName.Text = string.Empty;
            Textboxapellidos.Text = string.Empty;
            textBoxEstatura.Text = string.Empty;
            textBoxEdad.Text = string.Empty;
            textBoxtelefono.Text = string.Empty;
            radioButtonMasculino.Checked = false;
            radioButtonMujer.Checked = false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string Datos = "Nombre: " + TextboxName.Text + "\n" +
                           "Apellidos: " + Textboxapellidos.Text + "\n" +
                           "Teléfono: " + textBoxtelefono.Text + "\n" +
                           "Estatura: " + textBoxEstatura.Text + "\n" +
                           "Edad: " + textBoxEdad.Text + "\n" +
                           "Sexo: " + "\n";
            if (radioButtonMasculino.Checked == true)
            {
                Datos += "Hombre";
            }
            else if (radioButtonMujer.Checked == true)
            {
                Datos += "Mujer";
            }
            string Nombre_archivo = "Datos_registro.txt";

            File.WriteAllText(Nombre_archivo, Datos);

            MessageBox.Show("Guardado");
        }
    }
}
