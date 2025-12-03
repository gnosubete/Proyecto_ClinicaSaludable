namespace Clinica_de_salud
{
    partial class FormVista
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
            groupBox1 = new GroupBox();
            dgvVistas = new DataGridView();
            cmbPersonalMedico = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVistas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbPersonalMedico);
            groupBox1.Controls.Add(dgvVistas);
            groupBox1.Location = new Point(20, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 436);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dgvVistas
            // 
            dgvVistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVistas.Location = new Point(213, 15);
            dgvVistas.Name = "dgvVistas";
            dgvVistas.Size = new Size(565, 415);
            dgvVistas.TabIndex = 0;
            // 
            // cmbPersonalMedico
            // 
            cmbPersonalMedico.FormattingEnabled = true;
            cmbPersonalMedico.Location = new Point(6, 89);
            cmbPersonalMedico.Name = "cmbPersonalMedico";
            cmbPersonalMedico.Size = new Size(201, 23);
            cmbPersonalMedico.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 54);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Medicos";
            // 
            // FormVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormVista";
            Text = "Personal Clinica";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVistas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbPersonalMedico;
        private DataGridView dgvVistas;
        private Label label1;
    }
}