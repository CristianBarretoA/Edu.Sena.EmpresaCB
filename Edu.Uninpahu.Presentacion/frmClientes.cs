using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edu.Sena.Logica;

namespace Edu.Sena.Presentacion
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            txtIdentificacion.Enabled = false;
        }

        public frmClientes(int id)
        {
            Clientes cl = new Clientes();
            InitializeComponent();
            cargarUsuario(cl.consultarCliente(id));
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLo = new frmLogin();
            frmLo.Show();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClientes frmCl = new frmClientes();
            frmCl.Show();
        }

        private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmpleados frmEm = new frmEmpleados();
            frmEm.Show();
        }

        private void consultarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFacturas frmFa = new frmFacturas();
            frmFa.Show();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProductos frmPr = new frmProductos();
            frmPr.Show();
        }

        private void frmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNombre.Text = dgCliente.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgCliente.CurrentRow.Cells[2].Value.ToString();
            txtIdentificacion.Text = dgCliente.CurrentRow.Cells[0].Value.ToString();
            txtDireccion.Text = dgCliente.CurrentRow.Cells[3].Value.ToString();
            txtFijo.Text = dgCliente.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = dgCliente.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsuario.ReadOnly = false;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoClaseDataSet1.DetalleFactura' Puede moverla o quitarla según sea necesario.
            this.detalleFacturaTableAdapter.Fill(this.proyectoClaseDataSet1.DetalleFactura);
            // TODO: esta línea de código carga datos en la tabla 'proyectoClaseDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.proyectoClaseDataSet.Clientes);

        }

        private void cargarUsuario(Clientes cl)
        {
            txtIdentificacion.Text = cl.IdentificacionCliente.ToString();
        }

    }
}
