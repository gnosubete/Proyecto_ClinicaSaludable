namespace Clinica_de_salud
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            groupBox1 = new GroupBox();
            btnregistro = new Button();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            sobreNosotrosToolStripMenuItem = new ToolStripMenuItem();
            nuestraHistoriaToolStripMenuItem = new ToolStripMenuItem();
            miHistorialToolStripMenuItem = new ToolStripMenuItem();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnregistro);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 214);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clínica Saludable";
            // 
            // btnregistro
            // 
            btnregistro.BackColor = Color.ForestGreen;
            btnregistro.Location = new Point(121, 96);
            btnregistro.Name = "btnregistro";
            btnregistro.Size = new Size(382, 58);
            btnregistro.TabIndex = 0;
            btnregistro.Text = "Toma tu cita Médica";
            btnregistro.UseVisualStyleBackColor = false;
            btnregistro.Click += btnregistro_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, sobreNosotrosToolStripMenuItem, miHistorialToolStripMenuItem });
            menuStrip1.Location = new Point(3, 25);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(611, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            // sobreNosotrosToolStripMenuItem
            // 
            sobreNosotrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuestraHistoriaToolStripMenuItem });
            sobreNosotrosToolStripMenuItem.Name = "sobreNosotrosToolStripMenuItem";
            sobreNosotrosToolStripMenuItem.Size = new Size(99, 20);
            sobreNosotrosToolStripMenuItem.Text = "Nuestra Clinica";
            // 
            // nuestraHistoriaToolStripMenuItem
            // 
            nuestraHistoriaToolStripMenuItem.Name = "nuestraHistoriaToolStripMenuItem";
            nuestraHistoriaToolStripMenuItem.Size = new Size(180, 22);
            nuestraHistoriaToolStripMenuItem.Text = "Nuestra historia";
            // 
            // miHistorialToolStripMenuItem
            // 
            miHistorialToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            miHistorialToolStripMenuItem.Name = "miHistorialToolStripMenuItem";
            miHistorialToolStripMenuItem.Size = new Size(12, 20);
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(67, 22);
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.Location = new Point(15, 244);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(614, 159);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(648, 414);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormInicio";
            Text = " ";
            Load += FormInicio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem sobreNosotrosToolStripMenuItem;
        private ToolStripMenuItem nuestraHistoriaToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem miHistorialToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private Button btnregistro;
        private GroupBox groupBox2;
    }
}