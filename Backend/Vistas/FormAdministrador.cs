using Clinica_de_salud.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_de_salud
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormUsuarios u = new FormUsuarios();
            u.ShowDialog();
        }

        private void totalRecaudadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
