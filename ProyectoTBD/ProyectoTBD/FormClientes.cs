using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace ProyectoTBD
{
    public partial class FormClientes : MetroFramework.Forms.MetroForm
    {
        public FormClientes()
        {
            InitializeComponent();
                CotxMenu.Items.Add("Editar");
                CotxMenu.Items.Add("Eliminar");
        }

        private void gridClientes_MouseClick(object sender, MouseEventArgs e)
         {
            if (e.Button == MouseButtons.Right)
            {            
                int currentMouseOverRow = gridClientes.HitTest(e.X, e.Y).RowIndex;
                CotxMenu.Show(gridClientes, new Point(e.X, e.Y));
            }
        }

        private void CotxMenu_MouseClick(object sender, MouseEventArgs e)
        {
            switch (sender.ToString().Trim())
            {
                case "Editar":
                     //Manda el panel de editar
                    break;
                case "Eliminar":
                       //manda un mensaje de si esta seguro (solo es logico)
                    break;
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
          
        }
    }
}
