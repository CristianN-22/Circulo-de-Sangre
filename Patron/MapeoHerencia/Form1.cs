using MySql.Data.MySqlClient;
using MapeoHerencia;

namespace MapeoHerencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var joined = new Joined();
            //Joined

            joined.CrearTablas();
            joined.CargarDatos();

            try
            {
                MessageBox.Show("Tablas Creadas");
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var joined = new Joined();    

            joined.BorrarTablas();


            try
            {
                MessageBox.Show("Tablas Borradas");
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Table Per Class
            var tableClass = new TablePerClass();

            tableClass.CrearTablas();
            tableClass.CargarDatos();

            try
            {
                MessageBox.Show("Tablas Creadas");
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Single Table

            var single = new SingleTable();

            single.CrearTablas();
            single.CargarDatos();

            try
            {
                MessageBox.Show("Tablas Creadas");
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var table = new TablePerClass();

            table.BorrarTablas();

            try
            {
                MessageBox.Show("Tablas Borradas");
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var single = new SingleTable();

            single.BorrarTabla();

            try
            {
                MessageBox.Show("Tablas Borradas");
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
        }
    }
}