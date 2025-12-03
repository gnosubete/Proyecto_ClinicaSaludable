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
    public partial class FormCalendarioMedico : Form
    {
        private string connectionString = "server=localhost;database=clinica_saludable;uid=root;pwd=;";
        private int medicoId;

        // No declaramos los controles aquí porque ya están en el diseñador

        public FormCalendarioMedico(int medicoID)
        {
            InitializeComponent();
            this.medicoId = medicoID;

        // Llamar después de InitializeComponent()
        InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            if (!VerificarMedicoExiste())
            {
                MessageBox.Show("El médico especificado no existe en el sistema.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            CargarMedicos();
            CargarHorasDisponibles();
            FormatearColumnas();
            FiltrarPorMedico();
            MostrarTodo();
        }

        private void MostrarTodo()
        {
            DataTable dt = (DataTable)dgvHorasMedico.DataSource;
            if (dt != null)
            {
                dt.DefaultView.RowFilter = "";
            }
        }

        private void FiltrarPorMedico()
        {
            //pendiente


        }

        private void FormatearColumnas()
        {
            if (dgvHorasMedico.Columns.Contains("fecha"))
            {
                dgvHorasMedico.Columns["fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvHorasMedico.Columns.Contains("hora"))
            {
                dgvHorasMedico.Columns["hora"].DefaultCellStyle.Format = "hh\\:mm";
            }
        }

        private bool VerificarMedicoExiste()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM usuarios WHERE id = @medico_id AND rol = 'medico'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@medico_id", medicoId);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar médico: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ... El resto de los métodos (VerificarMedicoExiste, CargarMedicos, etc.) ...

        private void CargarMedicos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, nombre FROM usuarios WHERE rol = 'medico' ORDER BY nombre";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    // Configurar el ComboBox
                    cmbMedicos.DataSource = dt;
                    cmbMedicos.DisplayMember = "nombre";
                    cmbMedicos.ValueMember = "id";
                    cmbMedicos.DropDownStyle = ComboBoxStyle.DropDownList;

                    // Seleccionar el médico actual
                    if (cmbMedicos.Items.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(dt.Rows[i]["id"]) == medicoId)
                            {
                                cmbMedicos.SelectedIndex = i;
                                break;
                            }
                        }
                    }

                    // El evento SelectedIndexChanged ya está asignado en el diseñador, pero si no, lo asignamos aquí.
                    // cmbMedicos.SelectedIndexChanged += cmbMedicos_SelectedIndexChanged;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar médicos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarHorasDisponibles()
        {
            int medicoActual = Convert.ToInt32(cmbMedicos.SelectedValue);

            if (medicoActual <= 0)
            {
                MessageBox.Show("ID de médico no válido", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // CONSULTA MODIFICADA: quitamos el filtro de fecha y ordenamos por fecha y hora
                    string query = @"
                SELECT 
                    h.id, 
                    h.fecha, 
                    h.hora, 
                    h.estado,
                    u.nombre as medico_nombre
                FROM horas_disponibles h
                INNER JOIN usuarios u ON h.medico_id = u.id
                WHERE h.medico_id = @medico_id
                ORDER BY h.fecha, h.hora";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@medico_id", medicoActual);

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    dgvHorasMedico.DataSource = dt;
                    PersonalizarColumnas();

                    Console.WriteLine($"Cargadas {dt.Rows.Count} horas para médico {medicoActual} ({cmbMedicos.Text})");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar horas: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PersonalizarColumnas()
        {
            if (dgvHorasMedico.Columns.Count > 0)
            {
                // Ocultar columnas
                if (dgvHorasMedico.Columns.Contains("id"))
                    dgvHorasMedico.Columns["id"].Visible = false;

                if (dgvHorasMedico.Columns.Contains("medico_id"))
                    dgvHorasMedico.Columns["medico_id"].Visible = false;

                // Configurar columnas
                if (dgvHorasMedico.Columns.Contains("fecha"))
                {
                    dgvHorasMedico.Columns["fecha"].HeaderText = "Fecha";
                    dgvHorasMedico.Columns["fecha"].Width = 100;
                    dgvHorasMedico.Columns["fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                if (dgvHorasMedico.Columns.Contains("hora"))
                {
                    dgvHorasMedico.Columns["hora"].HeaderText = "Hora";
                    dgvHorasMedico.Columns["hora"].Width = 80;
                    dgvHorasMedico.Columns["hora"].DefaultCellStyle.Format = "hh\\:mm";
                }

                if (dgvHorasMedico.Columns.Contains("estado"))
                {
                    dgvHorasMedico.Columns["estado"].HeaderText = "Estado";
                    dgvHorasMedico.Columns["estado"].Width = 100;
                }

                if (dgvHorasMedico.Columns.Contains("medico_nombre"))
                {
                    dgvHorasMedico.Columns["medico_nombre"].HeaderText = "Médico";
                    dgvHorasMedico.Columns["medico_nombre"].Width = 200;
                }
                FormatearColumnas();

            }
        }

        // ... Los métodos AgregarHoraDisponible, EliminarHoraDisponible, etc. ...

        private void AgregarHoraDisponible(DateTime fecha, TimeSpan hora)
        {
            int medicoActual = Convert.ToInt32(cmbMedicos.SelectedValue);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string checkQuery = @"SELECT COUNT(*) FROM horas_disponibles 
                        WHERE medico_id = @medico_id 
                        AND fecha = @fecha 
                        AND hora = @hora";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@medico_id", medicoActual);
                    checkCmd.Parameters.AddWithValue("@fecha", fecha);
                    checkCmd.Parameters.AddWithValue("@hora", hora);

                    int existe = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (existe > 0)
                    {
                        MessageBox.Show("Esta hora ya está registrada para el médico seleccionado",
                                      "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string insertQuery = @"INSERT INTO horas_disponibles (medico_id, fecha, hora, estado) 
                             VALUES (@medico_id, @fecha, @hora, 'disponible')";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@medico_id", medicoActual);
                    insertCmd.Parameters.AddWithValue("@fecha", fecha);
                    insertCmd.Parameters.AddWithValue("@hora", hora);

                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Hora agregada correctamente para {cmbMedicos.Text}",
                                      "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarHorasDisponibles(); // Recargar TODO después de agregar
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar hora: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarHoraDisponible(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM horas_disponibles WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Hora eliminada correctamente", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarHorasDisponibles();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar hora: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handlers

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }


        private void dgvHorasMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvHorasMedico.Rows.Count)
            {
                dgvHorasMedico.Rows[e.RowIndex].Selected = true;

                DataGridViewRow row = dgvHorasMedico.Rows[e.RowIndex];
                string hora = row.Cells["hora"].Value?.ToString() ?? "";
                string estado = row.Cells["estado"].Value?.ToString() ?? "";
                string fecha = row.Cells["fecha"].Value?.ToString() ?? "";

                Console.WriteLine($"Hora seleccionada: {hora}, Estado: {estado}, Fecha: {fecha}");
            }
        }

        private void cmbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedicos.SelectedValue != null)
            {
                medicoId = Convert.ToInt32(cmbMedicos.SelectedValue);


            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string medicoNombre = cmbMedicos.Text;
            string fechaSeleccionada = monthCalendar1.SelectionStart.ToShortDateString();

            string hora = Microsoft.VisualBasic.Interaction.InputBox(
                $"Agregar hora para: {medicoNombre}\nFecha: {fechaSeleccionada}\n\nIngrese la hora en formato HH:MM:",
                "Agregar Hora", "09:00");

            if (!string.IsNullOrEmpty(hora))
            {
                if (TimeSpan.TryParse(hora, out TimeSpan horaTime))
                {
                    AgregarHoraDisponible(monthCalendar1.SelectionStart.Date, horaTime);
                }
                else
                {
                    MessageBox.Show("Formato de hora inválido. Use HH:MM (ejemplo: 09:30)",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvHorasMedico.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una hora para eliminar", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idHora = Convert.ToInt32(dgvHorasMedico.SelectedRows[0].Cells["id"].Value);
            string horaSeleccionada = dgvHorasMedico.SelectedRows[0].Cells["hora"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"¿Está seguro de eliminar la hora {horaSeleccionada}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                EliminarHoraDisponible(idHora);
            }
        }
    }
}


