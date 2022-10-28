using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce_Cobro_Interfaz
{
    public partial class Factura : Form
    {
        public Factura(string mostrar)
        {
            
            InitializeComponent();
            textMostrar.Text = mostrar;
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textMostrar_TextChanged(object sender, EventArgs e)
        {
            textMostrar.Enabled = false;
        }

        private void Cobro_Click(object sender, EventArgs e)
        {

        }
    }
}
