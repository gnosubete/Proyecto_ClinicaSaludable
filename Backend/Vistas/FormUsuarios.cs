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

    public partial class FormUsuarios : Form
    {
        Conexion conn = new Conexion();
        public FormUsuarios()
        {
            InitializeComponent();
            LimpiarCampos();
            cmbSeso.Items.Add("masculino");
            cmbSeso.Items.Add("femenino");
            cmbRol.Items.Add("medico");
            cmbRol.Items.Add("secretaria");
            cmbRol.Items.Add("paciente");
        }


        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtRut.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTipoSangre.Text = string.Empty;
            txtPrevision.Text = string.Empty;
            cmbSeso.Text = string.Empty;
            cmbSeso.Text = string.Empty;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string rut = txtRut.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string sexo = cmbSeso.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string email = txtCorreo.Text.Trim();
            string prevision = txtPrevision.Text.Trim();
            string rol = cmbRol.Text.Trim();
            string sangre = txtTipoSangre.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(sexo) || string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Validación", MessageBoxButtons.OK);
                return;
            }

            string contraseña_pura = BCrypt.Net.BCrypt.HashPassword(contraseña);

            try
            {
                using (var conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    string queryUsuario = "INSERT INTO usuarios (nombre,apellido,rut,telefono,email,direccion,tipo_sangre,prevision,sexo,rol,password) VALUES (@nombre,@apellido,@rut,@telefono,@email,@direccion,@tipo_sangre,@prevision,@sexo,@rol,@password)";

                    MySqlCommand cmdUsuarios = new MySqlCommand(queryUsuario, conn);
                    cmdUsuarios.Parameters.AddWithValue("@nombre", nombre);
                    cmdUsuarios.Parameters.AddWithValue("@rut", rut);
                    cmdUsuarios.Parameters.AddWithValue("@rol", rol);
                    cmdUsuarios.Parameters.AddWithValue("@sexo", sexo);
                    cmdUsuarios.Parameters.AddWithValue("@direccion", direccion);
                    cmdUsuarios.Parameters.AddWithValue("@telefono", telefono);
                    cmdUsuarios.Parameters.AddWithValue("@email", email);
                    cmdUsuarios.Parameters.AddWithValue("@prevision", prevision);
                    cmdUsuarios.Parameters.AddWithValue("@tipo_sangre", sangre);
                    cmdUsuarios.Parameters.AddWithValue("@apellido", apellido);
                    cmdUsuarios.Parameters.AddWithValue("@password", contraseña_pura);

                    cmdUsuarios.ExecuteNonQuery();
                    MessageBox.Show("Registro completo", "Éxito", MessageBoxButtons.OK);
                    LimpiarCampos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error 😣😣😣: {ex.Message}", "Error", MessageBoxButtons.OK);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para editar");
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["id"].Value);

                using (var conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "UPDATE usuarios SET nombre=@nombre,apellido=@apellido,rut=@rut,telefono=@telefono,email=@email,direccion=@direccion,tipo_sangre=@tipo_sangre,prevision=@prevision,sexo=@sexo,rol=@rol,password=@password WHERE id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                        cmd.Parameters.AddWithValue("@rut", txtRut.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@email", txtCorreo.Text);
                        cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@tipo_sangre", txtTipoSangre.Text);
                        cmd.Parameters.AddWithValue("@prevision", txtPrevision.Text);
                        cmd.Parameters.AddWithValue("@sexo", cmbSeso.Text);
                        cmd.Parameters.AddWithValue("@rol", cmbRol.Text);
                        cmd.Parameters.AddWithValue("@password", txtContraseña.Text);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuario actualizado correctamente");
                //CargarUsuarios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar usuario: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["id"].Value);
                var confirm = MessageBox.Show("¿Estás seguro de que quieres eliminar a este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (var conn = Conexion.ObtenerConexion())
                        {
                            conn.Open();

                            string query = "DELETE FROM usuarios WHERE id = @id";

                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Usuario eliminado correctamente");
                            //CargarUsuarios();
                            LimpiarCampos();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
            }
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void cmbFiltroRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsuarios.Rows[e.RowIndex].Cells["id"].Value != null)
            {
                txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                txtRut.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Rut"].Value.ToString();
                txtTelefono.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                txtCorreo.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                txtDireccion.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                txtTipoSangre.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Tipo_Sangre"].Value.ToString();
                txtPrevision.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Prevision"].Value.ToString();
                cmbSeso.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();
                cmbRol.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Rol"].Value.ToString();                

            }
        }
    }
}