using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegradoraB1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 ventana5 = new Form5();
            ventana5.StartPosition = this.StartPosition;
            ventana5.Size = this.Size;
            ventana5.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 ventana3 = new Form3();
            ventana3.StartPosition = this.StartPosition;
            ventana3.Size = this.Size;
            ventana3.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
