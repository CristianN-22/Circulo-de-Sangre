using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeoHerencia
{
    internal class TablePerClass
    {
      

        public void CargarDatos()
        {
            string s = "server=localhost;user=root;pwd=cristian2210;database='mapeodeherencia'";
            MySqlConnection conexion = new MySqlConnection(s);
            conexion.Open();

            string datos = "INSERT INTO `delantero` (`idDelantero`, `Nombre`, `Pais`, `Club`, `Goles`) VALUES ('1', 'Di Maria', 'Argentina', 'Juventus', '1'); " +
                           "INSERT INTO `lateral` (`idLateral`, `Nombre`, `Pais`, `Club`, `Recuperos`) VALUES ('2', 'Acuña', 'Argentina', 'Sevilla', '3'); " +
                           "INSERT INTO `lateral derecho` (`idLateralDerecho`, `Nombre`, `Pais`, `Club`, `Recuperos`, `Despejes`) VALUES('3', 'Montiel', 'Argentina', 'Sevilla', '3', '5'); ";

            MySqlCommand comando = new MySqlCommand(datos, conexion);
            comando.ExecuteNonQuery();
        }

        public void CrearTablas()
        {
            string s = "server=localhost;user=root;pwd=cristian2210;database='mapeodeherencia'";
            MySqlConnection conexion = new MySqlConnection(s);
            conexion.Open();

            string tablas = "CREATE TABLE `mapeodeherencia`.`delantero`(`idDelantero` INT NOT NULL, " +
                "`Nombre` VARCHAR(45) NULL," +
                "`Pais` VARCHAR(45) NULL, " +
                "`Club` VARCHAR(45) NULL, " +
                "`Goles` INT NULL, " +
                "PRIMARY KEY(`idDelantero`)); " +
                "" +
                "CREATE TABLE `mapeodeherencia`.`lateral`(`idLateral` INT NOT NULL, " +
                "`Nombre` VARCHAR(45) NULL," +
                "`Pais` VARCHAR(45) NULL, " +
                "`Club` VARCHAR(45) NULL, " +
                "`Recuperos` INT NULL, " +
                "PRIMARY KEY(`idLateral`)); " +
                "" +
                "CREATE TABLE `mapeodeherencia`.`lateral derecho`(`idLateralDerecho` INT NOT NULL, " +
                "`Nombre` VARCHAR(45) NULL," +
                "`Pais` VARCHAR(45) NULL, " +
                "`Club` VARCHAR(45) NULL, " +
                "`Recuperos` INT NULL, " +
                "`Despejes` INT NULL, " +
                "PRIMARY KEY(`idLateralDerecho`)); ";

            MySqlCommand comando = new MySqlCommand(tablas, conexion);
            comando.ExecuteNonQuery();
        }

        public void BorrarTablas()
        {
            string s = "server=localhost;user=root;pwd=cristian2210;database='mapeodeherencia'";
            MySqlConnection conexion = new MySqlConnection(s);
            conexion.Open();

            string borrar = "DROP TABLE `mapeodeherencia`.`lateral derecho`; " +
                "DROP TABLE `mapeodeherencia`.`delantero`; " +
                "DROP TABLE `mapeodeherencia`.`lateral`; " ;

            MySqlCommand comando = new MySqlCommand(borrar, conexion);
            comando.ExecuteNonQuery();
        }
    }
}
