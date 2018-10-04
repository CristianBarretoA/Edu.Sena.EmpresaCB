using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Logica
{
    class Facturas
    {
        //Atributos
        private int numFacturas;
        private long identificacionClienteFK;
        private long identificacionEmpleadosFK;
        private string fecha;

        //Propiedades
        public int NumFacturas
        {
            get => numFacturas;
            set => numFacturas = value;
        }
        public long IdentificacionClienteFK
        {
            get => identificacionClienteFK;
            set => identificacionClienteFK = value;
        }
        public long IdentificacionEmpleadosFK
        {
            get => identificacionEmpleadosFK;
            set => identificacionEmpleadosFK = value;
        }
        public string Fecha
        {
            get => fecha;
            set => fecha = value;
        }

        //Constructor
        public Facturas()
        {

        }

        public Facturas(int numFacturas, long identificacionClienteFK, long identificacionEmpleadosFK, string fecha)
        {
            this.NumFacturas = numFacturas;
            this.IdentificacionClienteFK = identificacionClienteFK;
            this.IdentificacionEmpleadosFK = identificacionEmpleadosFK;
            this.Fecha = fecha;

        }

        //Metodos
        public void Registrar(Facturas facturas)
        {

        }

        public Facturas Buscar(long numFacturas)
        {
            return new Facturas();
        }

        public List<Facturas> BuscarTodos()
        {
            return new List<Facturas>();
        }

        public void Modificar(Facturas facturas)
        {

        }

        public void Eliminar(long numFacturas)
        {

        }

    }
}
