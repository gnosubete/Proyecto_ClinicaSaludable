using Clinica_de_salud;
using Clinica_de_salud.Modelos;
using Clinica_de_salud.Vistas;
using MySql.Data.MySqlClient;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rut = txtrut.Text.Trim();
            string contraseña = txtcontraseña.Text.Trim();
            if (string.IsNullOrEmpty(rut) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese RUT y contraseña.", "Aviso", MessageBoxButtons.OK);
                return;
            }
            try
            {
                using (var conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT nombre, password, rol FROM usuarios WHERE rut = @rut";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@rut", rut);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombre = reader["nombre"].ToString();
                            string hash = reader["password"].ToString();
                            string rol = reader["rol"].ToString();
                            bool correcto = BCrypt.Net.BCrypt.Verify(contraseña, hash);

                            if (!correcto)
                            {
                                MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK);
                                return;
                            }

                            Form menu = null;

                            if (rol == "admin")
                            {
                                MessageBox.Show("Bienvenido/a " + nombre);
                                menu = new FormAdministrador();
                                this.Hide();
                                menu.ShowDialog();
                                this.Show();
                            }
                            else if (rol == "secretaria")
                            {
                                MessageBox.Show("Bienvenido/a " + nombre);
                                menu = new FormSecretaria();
                                this.Hide();
                                menu.ShowDialog();
                                this.Show();
                            }
                            else if (rol == "medico")
                            {
                                MessageBox.Show("Bienvenido/a " + nombre);
                                menu = new FormMedico();
                                this.Hide();
                                menu.ShowDialog();
                                this.Show();
                            }
                            else if (rol == "paciente")
                            {
                                MessageBox.Show("Bienvenido/a " + nombre);
                                menu = new FormInicio(rut);
                                this.Hide();
                                menu.ShowDialog();
                                this.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error","Error", MessageBoxButtons.OK);
            }
        }
    


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistrosPacientes c = new FormRegistrosPacientes();
            c.ShowDialog();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}