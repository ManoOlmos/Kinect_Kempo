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
    public partial class TerminosDeUso : Form
    {
        String UsuarioID; //Creamos un tipo String para almacenar NombreUsuario recibido por parametro

        public TerminosDeUso(String NombreID)//Obtenemos el NombreUsuario por parametro
        {
            InitializeComponent();
            UsuarioID = NombreID;//Asignamos el NombreUsuario a nuestro nuevo String 

            MessageBox.Show("Usuario" + NombreID);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
            MenuInicio mi = new MenuInicio(UsuarioID);//Enviamos como parametro nuestro nuevo String con el NombreUsuario
            mi.Show();
            //Agregar llamada a Inicio 
        }

        private void OK_Hover(object sender, EventArgs e)
        {
            OK.Image = IPN1.Properties.Resources.BO1_Hover;
        }
        private void OK_Leave(object sender, EventArgs e)
        {
            OK.Image = IPN1.Properties.Resources.BO1;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
