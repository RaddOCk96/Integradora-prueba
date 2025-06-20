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
    public partial class Creditos1 : Form
    {
        public Creditos1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Creditos ventanaC = new Creditos();
            ventanaC.StartPosition = this.StartPosition;
            ventanaC.Size = this.Size;
            ventanaC.Show();
            this.Close();
        }
    }
}
