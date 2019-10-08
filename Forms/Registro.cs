using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace IPN1
{
    public partial class Registro : Form
    {
        Conexion c = new Conexion();

        public Registro()
        {
            InitializeComponent();

            string ruta = Application.StartupPath;
            string rutaOriginal = ruta.Substring(0, ruta.Length - 9);
            string ruta1 = rutaOriginal + @"Videos\Registro.mp4";

            axWindowsMediaPlayer1.URL = ruta1;

        }

        /***************************************************************Boton Guardar****************************************************/
        private void Guardar_Click(object sender, EventArgs e)
        {
            if (c.Validacion(NombreUsuario.Text) == 0)//Validacion de Disponibilidad NombreUsuario 
            {
                if (String.Compare(Contrasenia.Text, ConfirmarContrasenia.Text) == 0)//Validacion Contraseña
                {
                    if (VerificacionCorreo(Correo.Text))//Si el Correo es Valido
                    {
                        
                        c.Insertar(NombreUsuario.Text, Contrasenia.Text, Nombre.Text, Apellido1.Text, Apellido2.Text, Convert.ToInt32(Edad.Text), Correo.Text, Convert.ToInt32(Peso.Text), Convert.ToInt32(Estatura.Text), Sexo.SelectedItem.ToString(),pictureBox1);
                        MessageBox.Show("Registro Exitoso");
                        Guardar.Enabled = false;
                    }
                    else
                        MessageBox.Show("No se puede hacer el registro CORREO INVALIDO");
                }
                else
                    MessageBox.Show("La contraseñas NO coinciden");
            }
            else
                MessageBox.Show("Nombre de Usuario NO disponible");
        }
        /******************************************************************************************************************************************/

        /*********************************************Validacion Correo***************************************/
        public Boolean VerificacionCorreo(String Correo)
        {

            return Regex.IsMatch(Correo,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }
        /************************* PLACE HOLDER ************************************************************************/
        private void NombreUsuario_Enter(object sender, EventArgs e)
        {
            if (NombreUsuario.Text == "Nombre de Usuario")
            {
                NombreUsuario.ForeColor = Color.Black;
                NombreUsuario.Text = "";
               
            }
        }
        private void NombreUsuario_Leave(object sender, EventArgs e)
        {
            if (NombreUsuario.Text == "")
            {
                NombreUsuario.ForeColor = Color.LightGray;
                NombreUsuario.Text = "Nombre de Usuario";
                
            }
        }

        //
        //Contrasenia
        //
        private void Contrasenia_Enter(object sender, EventArgs e)
        {
            if (Contrasenia.Text == "Contraseña")
            {
                Contrasenia.ForeColor = Color.Black;
                Contrasenia.Text = "";
               
            }
        }
        private void Contrasenia_Leave(object sender, EventArgs e)
        {
            if (Contrasenia.Text == "")
            {
                Contrasenia.ForeColor = Color.LightGray;
                Contrasenia.Text = "Contraseña";
               
            }
        }
        //
        //Confirmar Contrasenia
        //
        private void ConfirmarContrasenia_Enter(object sender, EventArgs e)
        {
            if (ConfirmarContrasenia.Text == "Confirmar Contraseña")
            {
                ConfirmarContrasenia.ForeColor = Color.Black;
                ConfirmarContrasenia.Text = "";
                
            }
        }
        private void ConfirmarContrasenia_Leave(object sender, EventArgs e)
        {
            if (ConfirmarContrasenia.Text == "")
            {
                ConfirmarContrasenia.ForeColor = Color.LightGray;
                ConfirmarContrasenia.Text = "Confirmar Contraseña";
               
            }
        }

        //
        //Nombre
        //
        private void Nombre_Enter(object sender, EventArgs e)
        {
            if (Nombre.Text == "Nombre")
            {
                Nombre.ForeColor = Color.Black;
                Nombre.Text = "";
              
            }
        }
        private void Nombre_Leave(object sender, EventArgs e)
        {
            if (Nombre.Text == "")
            {
                Nombre.ForeColor = Color.LightGray;
                Nombre.Text = "Nombre";
               
            }
        }
        //
        //ApellidoPaterno
        //
        private void Apellido1_Enter(object sender, EventArgs e)
        {
            if (Apellido1.Text == "Apellido Paterno")
            {
                Apellido1.ForeColor = Color.Black;
                Apellido1.Text = "";

            }
        }
        private void Apellido1_Leave(object sender, EventArgs e)
        {
            if (Apellido1.Text == "")
            {
                Apellido1.ForeColor = Color.LightGray;
                Apellido1.Text = "Apellido Paterno";
                
            }
        }
        //
        //ApellidoMaterno
        //
        private void Apellido2_Enter(object sender, EventArgs e)
        {
            if (Apellido2.Text == "Apellido Materno")
            {
                Apellido2.ForeColor = Color.Black;
                Apellido2.Text = "";
              
            }
        }
        private void Apellido2_Leave(object sender, EventArgs e)
        {
            if (Apellido2.Text == "")
            {
                Apellido2.ForeColor = Color.LightGray;
                Apellido2.Text = "Apellido Materno";
              
            }
        }
        //
        //Edad
        //
        private void Edad_Enter(object sender, EventArgs e)
        {
            if (Edad.Text == "Edad")
            {
                Edad.ForeColor = Color.Black;
                Edad.Text = "";
               
            }
        }
        private void Edad_Leave(object sender, EventArgs e)
        {
            if (Edad.Text == "")
            {
                Edad.ForeColor = Color.LightGray;
                Edad.Text = "Edad";
               
            }
        }
        //
        //Correo
        //
        private void Correo_Enter(object sender, EventArgs e)
        {
            if (Correo.Text == "Correo Electrónico")
            {
                Correo.ForeColor = Color.Black;
                Correo.Text = "";
              
            }
        }
        private void Correo_Leave(object sender, EventArgs e)
        {
            if (Correo.Text == "")
            {
                Correo.ForeColor = Color.LightGray;
                Correo.Text = "Correo Electrónico";
             
            }
        }
        //
        //Peso
        //
        private void Peso_Enter(object sender, EventArgs e)
        {
            if (Peso.Text == "Peso (Opcional)")
            {
                Peso.ForeColor = Color.Black;
                Peso.Text = "";
               
            }
        }
        private void Peso_Leave(object sender, EventArgs e)
        {
            if (Peso.Text == "")
            {
                Peso.ForeColor = Color.LightGray;
                Peso.Text = "Peso (Opcional)";
               
            }
        }

        //
        //Estatura
        //
        private void Estatura_Enter(object sender, EventArgs e)
        {
            if (Estatura.Text == "Estatura (Opcional) ")
            {
                Estatura.ForeColor = Color.Black;
                Estatura.Text = "";
             
            }
        }
        private void Estatura_Leave(object sender, EventArgs e)
        {
            if (Estatura.Text == "")
            {
                Estatura.ForeColor = Color.LightGray;
                Estatura.Text = "Estatura (Opcional) ";
              
            }
        }
        

        /***************************************************** CARGAR IMAGEN ************************************************/
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pictureBox1.Load(this.openFileDialog1.FileName);
                    Bitmap objBitmap = new Bitmap(pictureBox1.Image, new Size(267, 267));
                    pictureBox1.Image = objBitmap;

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        /****************************************************************************************************/

    }//Fin Class Registro

}
