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
    public partial class RecuperarContraseña : Form
    {

        Conexion c = new Conexion();
        int contador = 1;

        public RecuperarContraseña() 
        {
            InitializeComponent();//Iniciamos el componente

            c.verImagen1(pictureBox1, contador,Usuario);//Enviamos como parametro el picturebox, asi como el NombreUsuario

            Bitmap objBitmap = new Bitmap(pictureBox1.Image, new Size(90, 90));
            pictureBox1.Image = objBitmap;

        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            int NumUsuarios = c.Conteo();

            contador++;
            if (contador > NumUsuarios)
            {
                MessageBox.Show("No hay mas usuarios");
            }
            else
            {
            c.verImagen1(pictureBox1, contador, Usuario);//Enviamos como parametro el picturebox, asi como el NombreUsuario

            Bitmap objBitmap = new Bitmap(pictureBox1.Image, new Size(90, 90));
            pictureBox1.Image = objBitmap;
            }

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            contador--;
            if (contador == 0)
            {
                MessageBox.Show("No hay mas usuarios");
            }
            else
            {
                c.verImagen1(pictureBox1, contador, Usuario);//Enviamos como parametro el picturebox, asi como el NombreUsuario

                Bitmap objBitmap = new Bitmap(pictureBox1.Image, new Size(90, 90));
                pictureBox1.Image = objBitmap;
            }
        }
    }
}
