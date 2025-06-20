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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 ventana4 = new Form4();
            ventana4.StartPosition = this.StartPosition;
            ventana4.Size = this.Size;
            ventana4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 ventana2 = new Form2();
            ventana2.StartPosition = this.StartPosition;
            ventana2.Size = this.Size;
            ventana2.Show();
            this.Close();
        }
    }
}
