namespace Clinica_de_salud
{
    partial class FormAdministrador
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrador));
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem1 = new ToolStripMenuItem();
            pacientesToolStripMenuItem1 = new ToolStripMenuItem();
            flujoDeCajaToolStripMenuItem = new ToolStripMenuItem();
            totalRecaudadoToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            secretariaToolStripMenuItem = new ToolStripMenuItem();
            medicosToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Location = new Point(9, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(592, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestion:";
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = (Image)resources.GetObject("groupBox3.BackgroundImage");
            groupBox3.Location = new Point(494, 99);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(98, 93);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, usuariosToolStripMenuItem1, flujoDeCajaToolStripMenuItem });
            menuStrip1.Location = new Point(3, 19);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(586, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem, salirToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(143, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(143, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem1
            // 
            usuariosToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { pacientesToolStripMenuItem1 });
            usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            usuariosToolStripMenuItem1.Size = new Size(100, 20);
            usuariosToolStripMenuItem1.Text = "Administración";
            // 
            // pacientesToolStripMenuItem1
            // 
            pacientesToolStripMenuItem1.Name = "pacientesToolStripMenuItem1";
            pacientesToolStripMenuItem1.Size = new Size(180, 22);
            pacientesToolStripMenuItem1.Text = "Editor de Usuarios";
            pacientesToolStripMenuItem1.Click += pacientesToolStripMenuItem1_Click;
            // 
            // flujoDeCajaToolStripMenuItem
            // 
            flujoDeCajaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { totalRecaudadoToolStripMenuItem });
            flujoDeCajaToolStripMenuItem.Name = "flujoDeCajaToolStripMenuItem";
            flujoDeCajaToolStripMenuItem.Size = new Size(87, 20);
            flujoDeCajaToolStripMenuItem.Text = "Flujo de Caja";
            // 
            // totalRecaudadoToolStripMenuItem
            // 
            totalRecaudadoToolStripMenuItem.Name = "totalRecaudadoToolStripMenuItem";
            totalRecaudadoToolStripMenuItem.Size = new Size(180, 22);
            totalRecaudadoToolStripMenuItem.Text = "Total recaudado";
            totalRecaudadoToolStripMenuItem.Click += totalRecaudadoToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, pacientesToolStripMenuItem, secretariaToolStripMenuItem, medicosToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(126, 92);
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(125, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new Size(125, 22);
            pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // secretariaToolStripMenuItem
            // 
            secretariaToolStripMenuItem.Name = "secretariaToolStripMenuItem";
            secretariaToolStripMenuItem.Size = new Size(125, 22);
            secretariaToolStripMenuItem.Text = "Secretaria";
            // 
            // medicosToolStripMenuItem
            // 
            medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            medicosToolStripMenuItem.Size = new Size(125, 22);
            medicosToolStripMenuItem.Text = "Medicos";
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.Location = new Point(9, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(592, 80);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(609, 302);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MainMenuStrip = menuStrip1;
            Name = "FormAdministrador";
            Text = "Adminsitrador";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem secretariaToolStripMenuItem;
        private ToolStripMenuItem medicosToolStripMenuItem;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem flujoDeCajaToolStripMenuItem;
        private ToolStripMenuItem totalRecaudadoToolStripMenuItem;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ToolStripMenuItem usuariosToolStripMenuItem1;
        private ToolStripMenuItem pacientesToolStripMenuItem1;
    }
}