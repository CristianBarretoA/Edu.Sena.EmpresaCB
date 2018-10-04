using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Logica
{
    class Empleados
    {
        //Atributos
        private long identificacionEmpleado;
        private string nombreEmpleado;
        private string apellidoEmpleado;
        private string direccionEmpleado;
        private string cargoEmpleado;
        private int telefonoFijoEmpleado;
        private int telefonoCelularEmpleado;

        //Propiedades
        public long IdentificacionEmpleado
        {
            get => identificacionEmpleado;
            set => identificacionEmpleado = value;
        }
        public string NombreEmpleado
        {
            get => nombreEmpleado;
            set => nombreEmpleado = value;
        }
        public string ApellidoEmpleado
        {
            get => apellidoEmpleado;
            set => apellidoEmpleado = value;
        }
        public string DireccionEmpleado
        {
            get => direccionEmpleado;
            set => direccionEmpleado = value;
        }
        public string CargoEmpleado
        {
            get => cargoEmpleado;
            set => direccionEmpleado = value;
        }
        public int TelefonoFijoEmpleado
        {
            get => telefonoFijoEmpleado;
            set => telefonoFijoEmpleado = value;
        }
        public int TelefonoCelularEmpleado
        {
            get => telefonoCelularEmpleado;
            set => telefonoCelularEmpleado = value;
        }

        //Constructor
        public Empleados()
        {

        }

        public Empleados(long identificacionEmpleado, string nombreEmpleado, string direccionEmpleado, string cargoEmpleado, int telefonoFijoEmpleado, int telefonoCelularEmpleado)
        {
            this.IdentificacionEmpleado = identificacionEmpleado;
            this.NombreEmpleado = nombreEmpleado;
            this.DireccionEmpleado = direccionEmpleado;
            this.CargoEmpleado = cargoEmpleado;
            this.TelefonoFijoEmpleado = telefonoFijoEmpleado;
            this.TelefonoCelularEmpleado = telefonoCelularEmpleado;
        }

        //Metodos
        public void Registrar(Empleados empleado)
        {

        }

        public Empleados Buscar(long identificacionEmpleado)
        {
            return new Empleados();
        }

        public List<Empleados> BuscarTodos()
        {
            return new List<Empleados>();
        }

        public void Modificar(Empleados empleados)
        {

        }

        public void Eliminar(long identificacionEmpleado)
        {

        }
    }
}
