using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTBD
{
    public partial class FormMenu : MetroFramework.Forms.MetroForm
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            FormVendedores vendedores = new FormVendedores();
            vendedores.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas misVentas = new FormVentas();
            misVentas.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos misProductos = new FormProductos();
            misProductos.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes misClientes = new FormClientes();
            misClientes.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FormProveedores miProveedores = new FormProveedores();
            miProveedores.Show();
        }
    }
}
