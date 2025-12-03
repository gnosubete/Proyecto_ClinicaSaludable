namespace Clinica_de_salud
{
    partial class FormCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaja));
            groupBox1 = new GroupBox();
            btnRefrescar = new Button();
            dgvRegistro = new DataGridView();
            btnPagar = new Button();
            label2 = new Label();
            label1 = new Label();
            cmbNombrePaciente = new ComboBox();
            txtTotal = new TextBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(btnRefrescar);
            groupBox1.Controls.Add(dgvRegistro);
            groupBox1.Controls.Add(btnPagar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbNombrePaciente);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 331);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.ForestGreen;
            btnRefrescar.Location = new Point(408, 277);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(144, 39);
            btnRefrescar.TabIndex = 7;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            // 
            // dgvRegistro
            // 
            dgvRegistro.BackgroundColor = Color.PaleGreen;
            dgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistro.Location = new Point(408, 9);
            dgvRegistro.Name = "dgvRegistro";
            dgvRegistro.Size = new Size(350, 247);
            dgvRegistro.TabIndex = 6;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.ForestGreen;
            btnPagar.Location = new Point(614, 277);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(144, 39);
            btnPagar.TabIndex = 5;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 4;
            label2.Text = "Total a pagar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre Paciente:";
            label1.Click += label1_Click;
            // 
            // cmbNombrePaciente
            // 
            cmbNombrePaciente.FormattingEnabled = true;
            cmbNombrePaciente.Location = new Point(124, 16);
            cmbNombrePaciente.Name = "cmbNombrePaciente";
            cmbNombrePaciente.Size = new Size(244, 23);
            cmbNombrePaciente.TabIndex = 2;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(124, 57);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(244, 23);
            txtTotal.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = (Image)resources.GetObject("groupBox3.BackgroundImage");
            groupBox3.Location = new Point(0, 238);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(98, 93);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // FormCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 356);
            Controls.Add(groupBox1);
            Name = "FormCaja";
            Text = "Registro Financiero";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbNombrePaciente;
        private TextBox txtTotal;
        private Label label2;
        private Button btnPagar;
        private Button btnRefrescar;
        private DataGridView dgvRegistro;
        private GroupBox groupBox3;
    }
}