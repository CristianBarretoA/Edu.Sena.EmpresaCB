using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Logica
{
    class Productos
    {
        //Atributos
        private int codigoProductos;
        private string nombreProducto;
        private int cantidadDisponible;
        private int valorUnitario;
        private int porcentajeIva;

        //Propiedades
        public int CodigoProductos
        {
            get => codigoProductos;
            set => codigoProductos = value;
        }
        public string NombreProducto
        {
            get => nombreProducto;
            set => nombreProducto = value;
        }
        public int CantidadDisponible
        {
            get => cantidadDisponible;
            set => cantidadDisponible = value;
        }
        public int ValorUnitario
        {
            get => valorUnitario;
            set => valorUnitario = value;
        }
        public int PorcentajeIva
        {
            get => porcentajeIva;
            set => porcentajeIva = value;
        }

        //Constructor
        public Productos()
        {

        }

        public Productos(int codigoProductos, string nombreProducto, int cantidadDisponible, int valorUnitario, int porcentajeIva)
        {
            this.CodigoProductos = codigoProductos;
            this.NombreProducto = nombreProducto;
            this.CantidadDisponible = cantidadDisponible;
            this.ValorUnitario = valorUnitario;
            this.PorcentajeIva = porcentajeIva;
        }

        //Metodos
        public void Registrar(Productos productos)
        {

        }

        public Productos Buscar(int codigoProductos)
        {
            return new Productos();
        }

        public List<Productos> BuscarTodos()
        {
            return new List<Productos>();
        }

        public void Modificar(Productos productos)
        {

        }

        public void Eliminar(int codigoProductos)
        {

        }
    }
}
