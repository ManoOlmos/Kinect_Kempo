using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Para que los videos se puedan reproducir es necesario cambiar la URL de fuente desde el FORM.
//Importante para poder hacer la conexion de la base hay que cambiar el servidor el cambio de hace en "Conexion.cs".


namespace IPN1
{
    public partial class Form1 : Form
    {
        String UsuarioID;
        

        public Form1()
        {
          

            InitializeComponent(); 
            axWindowsMediaPlayer2.settings.setMode("loop", true);

            string ruta = Application.StartupPath;
            string rutaOriginal = ruta.Substring(0, ruta.Length - 9);
            string ruta2 = rutaOriginal + @"Videos\Inicio.mp4";
            string ruta3 = rutaOriginal + @"Videos\Fondo1.mp4";
           
            axWindowsMediaPlayer1.URL = ruta2;
            axWindowsMediaPlayer2.URL = ruta3;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
          
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
 /****************************************CARGA DE VIDEOS FONDO******************************************/

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        int contador =0;
/*****************************************OCULTAR CONTRASEÑA**********************************************/

               private void checkBox1_CheckedChanged(object sender, EventArgs e)
               {
                   if (contador == 0)
                   {
                       Contrasenia.UseSystemPasswordChar = false;
                       contador++;
                   }
                   else if (contador == 1)
                   {
                       Contrasenia.UseSystemPasswordChar = true;
                       contador--;
                   }
               }

/*********************************************INICIAR SESION *******************************************/

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();

            if (c.Validacion(Usuario.Text) != 0)
            {
                if (c.ValidacionUsuarioContrasenia(Usuario.Text, Contrasenia.Text) != 0)
                {
                    UsuarioID = Usuario.Text;//Asignamos el nombre con el que se ingresó a UsuarioID para hacer consultas

                    TerminosDeUso tu = new TerminosDeUso(UsuarioID);//Enviamos como parametro el NombreUsuario, para saber quien entró
                    tu.Show();

                }
                else
                    MessageBox.Show("Contraseña Incorrecta");
            }
            else
                MessageBox.Show("El usuario NO existe");
        }
/********************************************************LLAMADA BOTON SALIR*********************************/
        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente quieres Salir?","Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                  == DialogResult.Yes)
            {
                Application.Exit();
            }

    }
/************************************************************LLAMADA A FORM REGISTRO*********************/
                private void Registrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                    Registro r = new Registro();
                    r.Show();
                }
/**********************************************VIDEO FONDO***********************************************/

        private void axWindowsMediaPlayer2_Enter_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.settings.setMode("loop", true);
        }
        /************************************************************************************************************/

 /************************* PLACE HOLDER ************************************************************************/
        private void NombreUsuario_Enter(object sender, EventArgs e)
        {
            if (Usuario.Text == "Usuario")
            {
                Usuario.ForeColor = Color.Black;
                Usuario.Text = "";
            }
        }
        private void NombreUsuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text == "")
            {
                Usuario.ForeColor = Color.LightGray;
                Usuario.Text = "Usuario";
            }
        }

        private void Contrasenia_Enter(object sender, EventArgs e)
        {
            if (Contrasenia.Text == "Password")
            {
                Contrasenia.ForeColor = Color.Black;
                Contrasenia.Text = "";
                Contrasenia.UseSystemPasswordChar = true;
            }
        }
        private void Contrasenia_Leave(object sender, EventArgs e)
        {
            if (Contrasenia.Text == "")
            {
                Contrasenia.ForeColor = Color.LightGray;
                Contrasenia.Text = "Password";
                Contrasenia.UseSystemPasswordChar = false;
            }
        }

        private void OlvidasteContrasenia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContraseña rc = new RecuperarContraseña();
            rc.Show();
        }
/******************************************************************HOVER & LEAVE**********************************************/
        private void Inicio_Hover(object sender, EventArgs e)
        {
            IniciarSesion.BackgroundImage = IPN1.Properties.Resources.BI1_Hover;
        }
        private void Inicio_Leave(object sender, EventArgs e)
        {
            IniciarSesion.BackgroundImage = IPN1.Properties.Resources.BI1;
        }

        private void Salir_Hover(object sender, EventArgs e)
        {
            Salir.BackgroundImage = IPN1.Properties.Resources.BS1_Hover;
        }
        private void Salir_Leave(object sender, EventArgs e)
        {
            Salir.BackgroundImage = IPN1.Properties.Resources.BS1;
        }


    }
}
