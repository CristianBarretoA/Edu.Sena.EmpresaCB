using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Edu.Sena.Datos
{
    public class Conexion
    {

        public static SqlConnection conectDB()
        {
            string queryCon1 = "Data Source=MIKESAVAGEDESKT\\SQLEXPRESS;Initial Catalog=ProyectoClase;Integrated Security=True";
            //static string queryCon2 = "server = EQUIPO_02_16 ; database=ProyectoArquitecturaSoftware ; integrated security = true";
            SqlConnection con = new SqlConnection(queryCon1);
            try
            {
                con.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al conectar a la base de datos = " + error);
                //MessageBox.Show(error.ToString());
            }
            return con;
            
        }

        public static void cerrarDB()
        {
            string queryCon1 = "Data Source=MIKESAVAGEDESKT\\SQLEXPRESS;Initial Catalog=ProyectoClase;Integrated Security=True";
            //static string queryCon2 = "server = EQUIPO_02_16 ; database=ProyectoArquitecturaSoftware ; integrated security = true";
            SqlConnection con = new SqlConnection(queryCon1);
            try
            {
                con.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al cerrar la base de datos");
                //MessageBox.Show(error.ToString());
            }
        }
        

    }
}
