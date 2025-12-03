namespace Clinica_de_salud
{
    partial class FormMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedico));
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            menuStrip1 = new MenuStrip();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            calendarioToolStripMenuItem = new ToolStripMenuItem();
            horasAgendadasToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            fiToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Location = new Point(12, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = (Image)resources.GetObject("groupBox3.BackgroundImage");
            groupBox3.Location = new Point(498, 84);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(98, 93);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem, calendarioToolStripMenuItem, pacientesToolStripMenuItem });
            menuStrip1.Location = new Point(3, 19);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(589, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem, salirToolStripMenuItem1 });
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(48, 20);
            cerrarSesionToolStripMenuItem.Text = "Inicio";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(143, 22);
            salirToolStripMenuItem.Text = "Cerrar Sesión";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(143, 22);
            salirToolStripMenuItem1.Text = "Salir";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // calendarioToolStripMenuItem
            // 
            calendarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { horasAgendadasToolStripMenuItem });
            calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            calendarioToolStripMenuItem.Size = new Size(76, 20);
            calendarioToolStripMenuItem.Text = "Calendario";
            // 
            // horasAgendadasToolStripMenuItem
            // 
            horasAgendadasToolStripMenuItem.Name = "horasAgendadasToolStripMenuItem";
            horasAgendadasToolStripMenuItem.Size = new Size(167, 22);
            horasAgendadasToolStripMenuItem.Text = "Horas Agendadas";
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fiToolStripMenuItem });
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new Size(69, 20);
            pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // fiToolStripMenuItem
            // 
            fiToolStripMenuItem.Name = "fiToolStripMenuItem";
            fiToolStripMenuItem.Size = new Size(150, 22);
            fiToolStripMenuItem.Text = "Ficha Paciente";
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.Location = new Point(15, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(592, 80);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // FormMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(615, 284);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MainMenuStrip = menuStrip1;
            Name = "FormMedico";
            Text = "Medico";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem calendarioToolStripMenuItem;
        private ToolStripMenuItem horasAgendadasToolStripMenuItem;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem fiToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}