namespace Clinica_de_salud
{
    partial class FormHistorialPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorialPaciente));
            groupBox1 = new GroupBox();
            btnRefrescar = new Button();
            dgvHistorialPaciente = new DataGridView();
            groupBox3 = new GroupBox();
            label1 = new Label();
            cmbNombrePaciente = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialPaciente).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbNombrePaciente);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(btnRefrescar);
            groupBox1.Controls.Add(dgvHistorialPaciente);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(8, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(740, 453);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ficha Paciente:";
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.ForestGreen;
            btnRefrescar.ForeColor = Color.Black;
            btnRefrescar.Location = new Point(560, 359);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(161, 42);
            btnRefrescar.TabIndex = 1;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            // 
            // dgvHistorialPaciente
            // 
            dgvHistorialPaciente.BackgroundColor = Color.PaleGreen;
            dgvHistorialPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialPaciente.Location = new Point(293, 22);
            dgvHistorialPaciente.Name = "dgvHistorialPaciente";
            dgvHistorialPaciente.Size = new Size(428, 315);
            dgvHistorialPaciente.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = (Image)resources.GetObject("groupBox3.BackgroundImage");
            groupBox3.Location = new Point(16, 343);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(98, 93);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 12;
            label1.Text = "Nombre Paciente:";
            label1.Click += label1_Click;
            // 
            // cmbNombrePaciente
            // 
            cmbNombrePaciente.FormattingEnabled = true;
            cmbNombrePaciente.Location = new Point(120, 33);
            cmbNombrePaciente.Name = "cmbNombrePaciente";
            cmbNombrePaciente.Size = new Size(156, 23);
            cmbNombrePaciente.TabIndex = 11;
            // 
            // FormHistorialPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(764, 469);
            Controls.Add(groupBox1);
            Name = "FormHistorialPaciente";
            Text = "Ficha Médica";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialPaciente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRefrescar;
        private DataGridView dgvHistorialPaciente;
        private GroupBox groupBox3;
        private Label label1;
        private ComboBox cmbNombrePaciente;
    }
}