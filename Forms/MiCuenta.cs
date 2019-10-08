using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPN1
{
    public partial class Micuenta : Form
    {
        String UsuarioID; //Declaramos un nuevo String que almacenara el NombreUsuario
        public Micuenta(String Nombre1) //Obtenemos como parametro el nombre con el que se ingresó
        {
            InitializeComponent();//Iniciamos el componente
            UsuarioID = Nombre1;//Asignamos el NombreUsuario con el que se ingreso para hacer la consulta

            Conexion c = new Conexion();
            c.verImagen(pictureBox1, UsuarioID);//Enviamos como parametro el picturebox, asi como el NombreUsuario

            Bitmap objBitmap = new Bitmap(pictureBox1.Image, new Size(90, 90));
            pictureBox1.Image = objBitmap;

            c.Consulta(UsuarioID, NombreUsuario, Nombre, ApellidoPaterno, ApellidoMaterno, Edad, CorreoElectronico, Peso, Estatura, Genero);


        }

        private void NombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
