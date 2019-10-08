using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace IPN1
{
    public partial class MenuInicio : Form
    {
      
        String UsuarioID;//Creamos un nuevo String para almacenar nuestro NombreUsuario
        public MenuInicio(String Nombre)//Lo obtenemos como parametro NombreUsuario
        {
            InitializeComponent();
            UsuarioID = Nombre;//Asignamos el NombreUsuario a nuestra variable String
            
        }

        private void IniciarEntrenamiento_Click(object sender, EventArgs e)
        {
            IniciarEntrenamiento ie = new IniciarEntrenamiento();
            ie.Show();
                
                /*Transition t = new Transition(new TransitionType_EaseInEaseOut(2000));
            t.add(Progreso, "Left", 378);
            t.run();*/
        }

        private void Progreso_Click(object sender, EventArgs e)
        {
            MiProgreso mp = new MiProgreso();
            mp.Show();
        }

        private void Cuenta_Click(object sender, EventArgs e)
        {
            Micuenta mc = new Micuenta(UsuarioID);//Enviamos NombreUsuario como parametro almacenado en UsuarioID
            mc.Show();
        }
         /**************************************HOVER and LEAVE*******************************************/

        private void MouseHover_Iniciar(object sender, EventArgs e) {
            IniciarEntrenamiento.BackgroundImage = IPN1.Properties.Resources.B1_1;
        }

        private void MouseLeave_Iniciar(object sender, EventArgs e)
        {
            IniciarEntrenamiento.BackgroundImage = IPN1.Properties.Resources.B1;
        }
        //
        private void Miprogreso_Hover(object sender, EventArgs e)
        {
            Progreso.Image = IPN1.Properties.Resources.Miprogreso_Hover;
        }

        private void Miprogreso_Leave(object sender, EventArgs e)
        {
            Progreso.Image = IPN1.Properties.Resources.Miprogreso;
        }
        //
        private void Micuenta_Hover(object sender, EventArgs e)
        {
            Cuenta.Image = IPN1.Properties.Resources.Micuenta_Hover;
        }

        private void Micuenta_Leave(object sender, EventArgs e)
        {
            Cuenta.Image = IPN1.Properties.Resources.Micuenta;
        }
        //
        private void Salir_Hover(object sender, EventArgs e)
        {
           Salir.Image = IPN1.Properties.Resources.Salir_Hover;
        }

        private void Salir_Leave(object sender, EventArgs e)
        {
            Salir.Image = IPN1.Properties.Resources.Salir;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}
