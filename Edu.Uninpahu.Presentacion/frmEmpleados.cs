using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.Sena.Presentacion
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
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

        private void frmEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
