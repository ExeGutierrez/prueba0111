using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
     
            MessageBox.Show("¿Que estamos programando?");

            pictureBox1.Visible = true;

            // proceso lento
            await Task.Delay(5000);

            pictureBox1.Visible = false;

            await Task.Delay(5000);
        }

    }
}
