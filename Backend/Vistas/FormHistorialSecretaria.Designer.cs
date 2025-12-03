namespace Clinica_de_salud
{
    partial class FormHistorialSecretaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorialSecretaria));
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            BtnRefrescar = new Button();
            label1 = new Label();
            cmbNombrePaciente = new ComboBox();
            dgvHistorialSecretaria = new DataGridView();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialSecretaria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(BtnRefrescar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbNombrePaciente);
            groupBox1.Controls.Add(dgvHistorialSecretaria);
            groupBox1.Location = new Point(14, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(774, 378);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ficha Paciente:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.ForestGreen;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(651, 313);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(103, 40);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.ForestGreen;
            btnEditar.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(396, 315);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(103, 42);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnRefrescar
            // 
            BtnRefrescar.BackColor = Color.ForestGreen;
            BtnRefrescar.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRefrescar.Location = new Point(520, 315);
            BtnRefrescar.Name = "BtnRefrescar";
            BtnRefrescar.Size = new Size(107, 38);
            BtnRefrescar.TabIndex = 3;
            BtnRefrescar.Text = "Refrescar";
            BtnRefrescar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 29);
            label1.Name = "label1";
            label1.Size = new Size(116, 17);
            label1.TabIndex = 2;
            label1.Text = "Nombre Paciente:";
            label1.Click += label1_Click;
            // 
            // cmbNombrePaciente
            // 
            cmbNombrePaciente.FormattingEnabled = true;
            cmbNombrePaciente.Location = new Point(8, 61);
            cmbNombrePaciente.Name = "cmbNombrePaciente";
            cmbNombrePaciente.Size = new Size(264, 23);
            cmbNombrePaciente.TabIndex = 1;
            // 
            // dgvHistorialSecretaria
            // 
            dgvHistorialSecretaria.BackgroundColor = Color.PaleGreen;
            dgvHistorialSecretaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialSecretaria.Location = new Point(296, 29);
            dgvHistorialSecretaria.Name = "dgvHistorialSecretaria";
            dgvHistorialSecretaria.Size = new Size(459, 261);
            dgvHistorialSecretaria.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = (Image)resources.GetObject("groupBox3.BackgroundImage");
            groupBox3.Location = new Point(12, 295);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(98, 93);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // FormHistorialSecretaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 400);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "FormHistorialSecretaria";
            Text = "Historial Paciente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialSecretaria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbNombrePaciente;
        private DataGridView dgvHistorialSecretaria;
        private Button BtnRefrescar;
        private Button btnEliminar;
        private Button btnEditar;
        private GroupBox groupBox3;
    }
}