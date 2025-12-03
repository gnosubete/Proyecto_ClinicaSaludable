namespace Clinica_de_salud
{
    partial class FormCalendarioMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendarioMedico));
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            monthCalendar1 = new MonthCalendar();
            cmbMedicos = new ComboBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dgvHorasMedico = new DataGridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorasMedico).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(monthCalendar1);
            groupBox2.Controls.Add(cmbMedicos);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(dgvHorasMedico);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(14, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(773, 422);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Horarios Disponibles";
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(140, 259);
            button1.Name = "button1";
            button1.Size = new Size(110, 42);
            button1.TabIndex = 19;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(24, 259);
            button2.Name = "button2";
            button2.Size = new Size(110, 42);
            button2.TabIndex = 18;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(9, 89);
            monthCalendar1.Margin = new Padding(6, 5, 6, 5);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 16;
            // 
            // cmbMedicos
            // 
            cmbMedicos.FormattingEnabled = true;
            cmbMedicos.Location = new Point(88, 41);
            cmbMedicos.Name = "cmbMedicos";
            cmbMedicos.Size = new Size(164, 23);
            cmbMedicos.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(27, 44);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 14;
            label1.Text = "Medicos:";
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = (Image)resources.GetObject("groupBox3.BackgroundImage");
            groupBox3.Location = new Point(0, 329);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(98, 93);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            // 
            // dgvHorasMedico
            // 
            dgvHorasMedico.BackgroundColor = Color.PaleGreen;
            dgvHorasMedico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHorasMedico.Location = new Point(269, 22);
            dgvHorasMedico.Name = "dgvHorasMedico";
            dgvHorasMedico.Size = new Size(470, 297);
            dgvHorasMedico.TabIndex = 11;
            // 
            // FormCalendarioMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Name = "FormCalendarioMedico";
            Text = "Calendario";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorasMedico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgvHorasMedico;
        private ComboBox cmbMedicos;
        private Label label1;
        private Button button1;
        private Button button2;
        private MonthCalendar monthCalendar1;
    }
}