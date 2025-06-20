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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 ventana3 = new Form3();
            ventana3.StartPosition = this.StartPosition;
            ventana3.Size = this.Size;
            ventana3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Creditos ventanaC = new Creditos();
            ventanaC.StartPosition = this.StartPosition;
            ventanaC.Size = this.Size;
            ventanaC.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
