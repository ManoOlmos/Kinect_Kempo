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
    public partial class InfoKata : Form
    {
        public InfoKata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DesarrolloKata dk = new DesarrolloKata();
            //dk.Show();

            VK vk = new VK();
            vk.Show();
            
        }
    }
}
