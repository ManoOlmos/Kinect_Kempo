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
    public partial class IniciarEntrenamiento : Form
    {
        public IniciarEntrenamiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoKata ik = new InfoKata();
            ik.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            InfoKata ik = new InfoKata();
            ik.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            InfoKata ik = new InfoKata();
            ik.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            InfoKata ik = new InfoKata();
            ik.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            InfoKata ik = new InfoKata();
            ik.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            InfoKata ik = new InfoKata();
            ik.Show();
        }
        /*********************************************************************************/
        private void button1_Hover(object sender, EventArgs e)
        {
            button1.Image = IPN1.Properties.Resources.Secuencia1GIF;
        }
        private void button1_Leave(object sender, EventArgs e)
        {
            button1.Image = IPN1.Properties.Resources.Secuencia1;
        }


    }
}
