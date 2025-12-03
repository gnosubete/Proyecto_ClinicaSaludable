namespace Clinica_de_salud
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            groupBox1 = new GroupBox();
            txtContraseña = new TextBox();
            label11 = new Label();
            txtPrevision = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            cmbFiltroRol = new ComboBox();
            dgvUsuarios = new DataGridView();
            label10 = new Label();
            cmbRol = new ComboBox();
            cmbSeso = new ComboBox();
            txtTipoSangre = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtRut = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtPrevision);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(cmbFiltroRol);
            groupBox1.Controls.Add(dgvUsuarios);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cmbRol);
            groupBox1.Controls.Add(cmbSeso);
            groupBox1.Controls.Add(txtTipoSangre);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtRut);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(904, 487);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administrar usuarios";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(125, 440);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(200, 23);
            txtContraseña.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(26, 443);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 27;
            label11.Text = "Contraseña:";
            // 
            // txtPrevision
            // 
            txtPrevision.Location = new Point(124, 318);
            txtPrevision.Name = "txtPrevision";
            txtPrevision.Size = new Size(200, 23);
            txtPrevision.TabIndex = 25;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(799, 422);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 46);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(684, 422);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(92, 47);
            btnEditar.TabIndex = 23;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(561, 422);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 47);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbFiltroRol
            // 
            cmbFiltroRol.FormattingEnabled = true;
            cmbFiltroRol.Location = new Point(371, 36);
            cmbFiltroRol.Name = "cmbFiltroRol";
            cmbFiltroRol.Size = new Size(519, 23);
            cmbFiltroRol.TabIndex = 21;
            cmbFiltroRol.SelectedIndexChanged += cmbFiltroRol_SelectedIndexChanged;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = Color.PaleGreen;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(371, 80);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(519, 325);
            dgvUsuarios.TabIndex = 20;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(28, 405);
            label10.Name = "label10";
            label10.Size = new Size(27, 15);
            label10.TabIndex = 19;
            label10.Text = "Rol:";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(124, 397);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(200, 23);
            cmbRol.TabIndex = 18;
            // 
            // cmbSeso
            // 
            cmbSeso.FormattingEnabled = true;
            cmbSeso.Location = new Point(124, 357);
            cmbSeso.Name = "cmbSeso";
            cmbSeso.Size = new Size(200, 23);
            cmbSeso.TabIndex = 17;
            // 
            // txtTipoSangre
            // 
            txtTipoSangre.Location = new Point(125, 268);
            txtTipoSangre.Name = "txtTipoSangre";
            txtTipoSangre.Size = new Size(207, 23);
            txtTipoSangre.TabIndex = 15;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(124, 223);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(208, 23);
            txtDireccion.TabIndex = 14;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(124, 184);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(208, 23);
            txtCorreo.TabIndex = 13;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(122, 133);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(210, 23);
            txtTelefono.TabIndex = 12;
            // 
            // txtRut
            // 
            txtRut.Location = new Point(125, 93);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(207, 23);
            txtRut.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(122, 55);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(210, 23);
            txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(122, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(26, 365);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 8;
            label9.Text = "Sexo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(28, 321);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 7;
            label8.Text = "Prevision:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(26, 276);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 6;
            label7.Text = "Tipo de Sangre:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(28, 231);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 5;
            label6.Text = "Direccion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(30, 187);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 4;
            label5.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(28, 136);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(32, 96);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "Rut:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(30, 58);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(925, 510);
            Controls.Add(groupBox1);
            Name = "FormUsuarios";
            Text = "Usuarios";
            Load += FormUsuarios_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cmbRol;
        private ComboBox cmbSeso;
        private TextBox txtTipoSangre;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtRut;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private ComboBox cmbFiltroRol;
        private DataGridView dgvUsuarios;
        private TextBox txtPrevision;
        private Label label11;
        private TextBox txtContraseña;
    }
}