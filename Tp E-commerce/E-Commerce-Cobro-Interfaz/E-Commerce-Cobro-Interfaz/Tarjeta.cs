using Newtonsoft.Json;
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
    public partial class Tarjeta : Form
    {
        public Tarjeta()
        {
            InitializeComponent();
            comboCuotas.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void buttonPagarFin_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboFormaPago.SelectedIndex == 0)
                {
                    Tarjetaclass tarjetaclass = new Tarjetaclass(textNroTarjeta.Text, textNombreApellido.Text, Convert.ToInt32(textDNI.Text), Convert.ToDateTime(dateTimeVencimiento.Text), Convert.ToInt32(textCodigoSegurirdad.Text), Convert.ToInt32(comboCuotas.Text), TipoTarjeta.Credito);
                    var prueba = JsonConvert.SerializeObject(tarjetaclass);
                    File.WriteAllText("tarjetaDTO.txt", prueba);
                    //JsonSerializer.Serialize(File.WriteAllText("tarjeta.txt"));


                }
                else if (comboFormaPago.SelectedIndex == 1)
                {
                    
                    Tarjetaclass tarjetaclass = new Tarjetaclass(textNroTarjeta.Text, textNombreApellido.Text, Convert.ToInt32(textDNI.Text), Convert.ToDateTime(dateTimeVencimiento.Text), Convert.ToInt32(textCodigoSegurirdad.Text), 1 , TipoTarjeta.Debito);
                    var prueba = JsonConvert.SerializeObject(tarjetaclass);
                    File.WriteAllText("tarjetaDTO.txt", prueba);
                }
               
            }

            catch 
            { 
                MessageBox.Show("Error");
            }

            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();  
        }


        private void Tarjeta_Load(object sender, EventArgs e)
        {

        }

        private void comboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFormaPago.SelectedIndex == 0)
            {
                comboCuotas.Enabled = true;
            }
            else 
            {
                comboCuotas.Enabled = false;
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void textNroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textNombreApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textCodigoSegurirdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dateTimeVencimiento_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeVencimiento.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser menor al dia actual");
                return;
            }
        }
    }
    }

