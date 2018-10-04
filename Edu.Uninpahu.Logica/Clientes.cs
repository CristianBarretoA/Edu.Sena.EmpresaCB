using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edu.Sena.Datos;
using System.Data.SqlClient;

namespace Edu.Sena.Logica
{
    public class Clientes
    {
        //Atributos
        private long identificacionCliente;
        private string nombreCliente;
        private string apellidoCliente;
        private string direccionCliente;
        private int telefonoFijoCliente;
        private int telefonoCelularCliente;
        private string usuario;
        private string contrasena;


        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        //Propiedades
        public long IdentificacionCliente { get => identificacionCliente; set => identificacionCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string DireccionCliente { get => direccionCliente; set => direccionCliente = value; }
        public int TelefonoFijoCliente { get => telefonoFijoCliente; set => telefonoFijoCliente = value; }
        public int TelefonoCelularCliente { get => telefonoCelularCliente; set => telefonoCelularCliente = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        
        //Constructor
        public Clientes()
        {
            
        }

        public Clientes(long identifiacionCliente, string nombreCliente, string apellidoCliente, string direccionCliente, int telefonoFijoCliente, int telefonoCelularCliente, string usuario, string contrasena)
        {
            this.IdentificacionCliente = identifiacionCliente;
            this.NombreCliente = nombreCliente;
            this.ApellidoCliente = apellidoCliente;
            this.DireccionCliente = direccionCliente;
            this.TelefonoFijoCliente = telefonoFijoCliente;
            this.TelefonoCelularCliente = telefonoCelularCliente;
            this.usuario = usuario;
            this.contrasena = contrasena;
            
        }

        //Metodos
        public void Registrar(Clientes cliente)
        {

        }

        public Clientes consultarCliente(long identificacionCliente)
        {
            Clientes cl = new Clientes();
            try
            {
                con = Conexion.conectDB();
                cmd = new SqlCommand("SELECT * FROM Clientes WHERE identificacionCliente = " + identificacionCliente, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cl.IdentificacionCliente = long.Parse(reader["identificacionCliente"].ToString());
                    cl.NombreCliente = reader["nombreCliente"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return cl;
        }

        public List<Clientes> BuscarTodos()
        {
            return new List<Clientes>();
        }
        
        public void Modificar(Clientes cliente)
        {

        }

        public void Eliminar(long identifiacionCliente)
        {

        }

        public int login(string usuario,string contrasena )
        {
            int salida = 0;
            try
            {
                this.con = Conexion.conectDB();
                cmd = new SqlCommand("SELECT nombreCliente FROM Clientes WHERE usuario='" + usuario + "' AND pass='" + contrasena + "'", con);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    salida = 1;
                }
                else
                {
                    salida = 0;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en conexion: " + ex);
                salida = 0;
                throw;
            }
            return salida;
        }

    }
   
}
