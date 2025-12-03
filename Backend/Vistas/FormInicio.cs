using Clinica_de_salud.Modelos;
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
    public partial class FormInicio : Form
    {
        private string rut;
        public FormInicio(string rut)
        {
            InitializeComponent();
            rut = rut;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ciao");
            Application.Exit();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
        }

        private void medicinaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void medicosYEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
