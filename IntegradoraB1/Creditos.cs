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
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creditos1 ventanaC = new Creditos1();
            ventanaC.StartPosition = this.StartPosition;
            ventanaC.Size = this.Size;
            ventanaC.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ventana2 = new Form2();
            ventana2.StartPosition = this.StartPosition;
            ventana2.Size = this.Size;
            ventana2.Show();
            this.Close();
        }
    }
}
