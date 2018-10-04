using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Sena.Logica
{
    class DetalleFactura
    {
        //Atributos
        private int idDetalleFactura;
        private int numFacturaFK;
        private int codigoProducto;
        private int cantidad;
        private int valorIva;
        private int subtotal;

        //Propiedades
        public int IdDetalleFactura
        {
            get => idDetalleFactura;
            set => idDetalleFactura = value;
        }
        public int NumFacturaFK
        {
            get => numFacturaFK;
            set => numFacturaFK = value;
        }
        public int CodigoProducto
        {
            get => codigoProducto;
            set => codigoProducto = value;
        }
        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }
        public int ValorIva
        {
            get => valorIva;
            set => valorIva = value;
        }
        public int Subtotal
        {
            get => subtotal;
            set => subtotal = value;
        }

        //Constructor
        public DetalleFactura()
        {

        }

        public DetalleFactura(int idDetalleFactura, int numFacturaFK, int codigoProducto, int cantidad, int valorIva, int subtotal)
        {
            this.IdDetalleFactura = idDetalleFactura;
            this.NumFacturaFK = numFacturaFK;
            this.CodigoProducto = codigoProducto;
            this.Cantidad = cantidad;
            this.ValorIva = valorIva;
            this.Subtotal = subtotal;
        }

        //Metodos
        public void Registrar(DetalleFactura detalleFactura)
        {

        }

        public DetalleFactura Buscar(int idDetalleFactura)
        {
            return new DetalleFactura();
        }

        public List<DetalleFactura> BuscarTodos()
        {
            return new List<DetalleFactura>();
        }

        public void Modificar(DetalleFactura detalleFactura)
        {

        }

        public void Eliminar(int idDetalleFactura)
        {

        }
    }
}
