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
using System.Data.SqlClient;

namespace Registro_en_txt
{
    public partial class Form1 : Form
    {
        private string Conexion = "Server=HAMMER;Database=Registro;Integrated Security=True;";

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
            if (!Validacion.TextoValido(TextboxName.Text))
            {
                MessageBox.Show("Nombre inválido.");
                return;
            }

            if (!Validacion.TextoValido(Textboxapellidos.Text))
            {
                MessageBox.Show("Apellidos inválidos.");
                return;
            }

            if (!Validacion.TelefonoValido(textBoxtelefono.Text))
            {
                MessageBox.Show("Teléfono inválido.");
                return;
            }

            if (!Validacion.EstaturaValido(textBoxEstatura.Text))
            {
                MessageBox.Show("Estatura inválida.");
                return;
            }

            if (!Validacion.EdadValido(textBoxEdad.Text))
            {
                MessageBox.Show("Edad inválida.");
                return;
            }


            string genero = radioButtonMasculino.Checked ? "Hombre" : "Mujer";


            string Datos = "Nombre: " + TextboxName.Text + "\n" +
                           "Apellidos: " + Textboxapellidos.Text + "\n" +
                           "Teléfono: " + textBoxtelefono.Text + "\n" +
                           "Estatura: " + textBoxEstatura.Text + "\n" +
                           "Edad: " + textBoxEdad.Text + "\n" +
                           "Género: " + genero + "\n";

            string Nombre_archivo = "Datos_registro.txt";
            File.WriteAllText(Nombre_archivo, Datos);

 
            using (SqlConnection connection = new SqlConnection(Conexion))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Tabla (Nombre, Apellidos, Telefono, Estatura, Edad, Genero) VALUES (@Nombre, @Apellidos, @Telefono, @Estatura, @Edad, @Genero)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
 
                        command.Parameters.AddWithValue("@Nombre", TextboxName.Text);
                        command.Parameters.AddWithValue("@Apellidos", Textboxapellidos.Text);
                        command.Parameters.AddWithValue("@Telefono", textBoxtelefono.Text);
                        command.Parameters.AddWithValue("@Estatura", Convert.ToDecimal(textBoxEstatura.Text));
                        command.Parameters.AddWithValue("@Edad", Convert.ToInt32(textBoxEdad.Text));
                        command.Parameters.AddWithValue("@Genero", genero);

                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Datos guardados correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message);
                }
            }
        }
    }
}
