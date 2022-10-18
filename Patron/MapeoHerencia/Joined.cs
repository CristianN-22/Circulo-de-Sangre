using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeoHerencia
{
    public class Joined
    {
        public void CargarDatos()
        {
            string s = "server=localhost;user=root;pwd=cristian2210;database='mapeodeherencia'";
            MySqlConnection conexion = new MySqlConnection(s);
            conexion.Open();

            string datos = "INSERT INTO `jugador` (`idJugador`, `Nombre`, `Pais`, `Club`) VALUES ('1', 'Di Maria', 'Argentina', 'Juventus'); " +
                           "INSERT INTO `jugador` (`idJugador`, `Nombre`, `Pais`, `Club`) VALUES ('2', 'Montiel', 'Argentina', 'Sevilla'); " +
                           "INSERT INTO `delantero` (`IdDelantero`, `Goles`) VALUES ('1', '1'); " +
                           "INSERT INTO `lateral` (`IdLateral`, `Recuperos`) VALUES ('2', '3'); " +
                           "INSERT INTO `lateral derecho` (`IdLateralDerecho`, `Patadas A Neymar`) VALUES ('2', '10'); ";
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
                "`Club` VARCHAR(45) NULL," +
                "PRIMARY KEY(`idJugador`));" +
                "" +
                "CREATE TABLE `mapeodeherencia`.`delantero` (" +
                "`IdDelantero` INT NOT NULL," +
                "`Goles` INT NULL," +
                "PRIMARY KEY (`IdDelantero`)," +
                "INDEX `delantero_idx` (`IdDelantero` ASC) VISIBLE," +
                "CONSTRAINT `delantero`" +
                "FOREIGN KEY(`IdDelantero`)" +
                "REFERENCES `mapeodeherencia`.`jugador` (`idJugador`)" +
                "ON DELETE NO ACTION " +
                "ON UPDATE NO ACTION ); " +
                "" +
                "CREATE TABLE `mapeodeherencia`.`lateral`(" +
                "`IdLateral` INT NOT NULL," +
                "`Recuperos` INT NULL," +
                "PRIMARY KEY (`IdLateral`)," +
                "INDEX `lateral_idx` (`IdLateral` ASC) VISIBLE," +
                "CONSTRAINT `lateral`FOREIGN KEY(`IdLateral`)" +
                "REFERENCES `mapeodeherencia`.`jugador` (`idJugador`) " +
                "ON DELETE NO ACTION " +
                "ON UPDATE NO ACTION); " +
                "" +
                "CREATE TABLE `mapeodeherencia`.`lateral derecho` (`IdLateralDerecho` INT NOT NULL," +
                "`Patadas A Neymar` INT NULL," +
                "PRIMARY KEY (`IdLateralDerecho`)," +
                "INDEX `lateral derecho_idx` (`IdLateralDerecho` ASC) VISIBLE," +
                "CONSTRAINT `lateral derecho`FOREIGN KEY(`IdLateralDerecho`)" +
                "REFERENCES `mapeodeherencia`.`lateral` (`IdLateral`) " +
                "ON DELETE NO ACTION " +
                "ON UPDATE NO ACTION);"
                ;
            MySqlCommand comando = new MySqlCommand(tablas, conexion);
            comando.ExecuteNonQuery();
        }

        public MySqlConnection AbrirConexion()
        {
            string s = "server=localhost;user=root;pwd=cristian2210;database='mapeodeherencia'";
            MySqlConnection conexion = new MySqlConnection(s);
            conexion.Open();
            return conexion;
        }

        public void BorrarTablas()
        {
            string s = "server=localhost;user=root;pwd=cristian2210;database='mapeodeherencia'";
            MySqlConnection conexion = new MySqlConnection(s);
            conexion.Open();

            string borrar = "DROP TABLE `mapeodeherencia`.`lateral derecho`; " +
                "DROP TABLE `mapeodeherencia`.`delantero`; " +
                "DROP TABLE `mapeodeherencia`.`lateral`; " +
                "DROP TABLE `mapeodeherencia`.`jugador`;";

            MySqlCommand comando = new MySqlCommand(borrar, conexion);
            comando.ExecuteNonQuery();
        }
    }
}
