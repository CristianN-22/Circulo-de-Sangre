using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeoHerencia
{
    internal class SingleTable
    {

        public void CargarDatos()
        {
            string s = "server=localhost;user=root;pwd=cristian2210;database='mapeodeherencia'";
            MySqlConnection conexion = new MySqlConnection(s);
            conexion.Open();

            string datos = "INSERT INTO `jugador` (`idJugador`, `Nombre`, `Pais`, `Club`, `Goles` ) VALUES ('1', 'Di Maria', 'Argentina', 'Juventus', '1'); " +
                           "INSERT INTO `jugador` (`idJugador`, `Nombre`, `Pais`, `Club`, `Recuperos`) VALUES ('2', 'Acuña', 'Argentina', 'Sevilla', '3'); " +
                           "INSERT INTO `jugador` (`idJugador`, `Nombre`, `Pais`, `Club`, `Recuperos`, `Patadas A Neymar`) VALUES ('3', 'Montiel', 'Argentina', 'Sevilla', '0' , '5'); ";

            MySqlCommand comando = new MySqlCommand(datos, conexion);
            comando.ExecuteNonQuery();
        }

        public void CrearTablas()
        {
            string s = "server=localhost;user=root;pwd=cristian2210;database='mapeodeherencia'";
            MySqlConnection conexion = new MySqlConnection(s);
            conexion.Open();

            string tablas = "CREATE TABLE `mapeodeherencia`.`jugador`(`idJugador` INT NOT NULL, " +
                "`Nombre` VARCHAR(45) NULL," +
                "`Pais` VARCHAR(45) NULL, " +
                "`Club` VARCHAR(45) NULL, " +
                "`Goles` INT NULL, " +
                "`Recuperos` INT NULL, " +
                "`Patadas A Neymar` INT NULL, " +
                "PRIMARY KEY(`idJugador`)); ";

            MySqlCommand comando = new MySqlCommand(tablas, conexion);
            comando.ExecuteNonQuery();
        }

        public void BorrarTabla()
        {
            string s = "server=localhost;user=root;pwd=cristian2210;database='mapeodeherencia'";
            MySqlConnection conexion = new MySqlConnection(s);
            conexion.Open();

            string borrar = "DROP TABLE `mapeodeherencia`.`jugador`; ";

            MySqlCommand comando = new MySqlCommand(borrar, conexion);
            comando.ExecuteNonQuery();
        }
    }
}
