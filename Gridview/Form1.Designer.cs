namespace Gridview
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbcode = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txbAnimal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCodeagregar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbEnfermedad = new System.Windows.Forms.TextBox();
            this.btnAgregarPaciente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTipoSangre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbTratamiento = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnmostrar
            // 
            this.btnmostrar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnmostrar.Location = new System.Drawing.Point(226, 367);
            this.btnmostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(164, 24);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identificacion de paciente";
            // 
            // txbcode
            // 
            this.txbcode.BackColor = System.Drawing.Color.MistyRose;
            this.txbcode.Location = new System.Drawing.Point(24, 475);
            this.txbcode.Name = "txbcode";
            this.txbcode.Size = new System.Drawing.Size(95, 20);
            this.txbcode.TabIndex = 3;
            // 
            // btneliminar
            // 
            this.btneliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btneliminar.Location = new System.Drawing.Point(35, 501);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 33);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpiar.Location = new System.Drawing.Point(461, 11);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(164, 24);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txbAnimal
            // 
            this.txbAnimal.BackColor = System.Drawing.Color.MistyRose;
            this.txbAnimal.Location = new System.Drawing.Point(547, 71);
            this.txbAnimal.Name = "txbAnimal";
            this.txbAnimal.Size = new System.Drawing.Size(78, 20);
            this.txbAnimal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(552, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Animal";
            // 
            // txbNombre
            // 
            this.txbNombre.BackColor = System.Drawing.Color.MistyRose;
            this.txbNombre.Location = new System.Drawing.Point(547, 122);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(78, 20);
            this.txbNombre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(552, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(549, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Identificacion\r\n de paciente";
            // 
            // txbCodeagregar
            // 
            this.txbCodeagregar.BackColor = System.Drawing.Color.MistyRose;
            this.txbCodeagregar.Location = new System.Drawing.Point(546, 365);
            this.txbCodeagregar.Name = "txbCodeagregar";
            this.txbCodeagregar.Size = new System.Drawing.Size(78, 20);
            this.txbCodeagregar.TabIndex = 11;
            this.txbCodeagregar.TextChanged += new System.EventHandler(this.txbCodeagregar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(552, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enfermedad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txbEnfermedad
            // 
            this.txbEnfermedad.BackColor = System.Drawing.Color.MistyRose;
            this.txbEnfermedad.Location = new System.Drawing.Point(546, 176);
            this.txbEnfermedad.Name = "txbEnfermedad";
            this.txbEnfermedad.Size = new System.Drawing.Size(78, 20);
            this.txbEnfermedad.TabIndex = 13;
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarPaciente.Location = new System.Drawing.Point(460, 391);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarPaciente.TabIndex = 14;
            this.btnAgregarPaciente.Text = "Agregar";
            this.btnAgregarPaciente.UseVisualStyleBackColor = true;
            this.btnAgregarPaciente.Click += new System.EventHandler(this.btnAgregarPaciente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(549, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(545, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo de Sangre";
            // 
            // txbTipoSangre
            // 
            this.txbTipoSangre.BackColor = System.Drawing.Color.MistyRose;
            this.txbTipoSangre.Location = new System.Drawing.Point(546, 233);
            this.txbTipoSangre.Name = "txbTipoSangre";
            this.txbTipoSangre.Size = new System.Drawing.Size(78, 20);
            this.txbTipoSangre.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(555, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tratamiento";
            // 
            // txbTratamiento
            // 
            this.txbTratamiento.BackColor = System.Drawing.Color.MistyRose;
            this.txbTratamiento.Location = new System.Drawing.Point(546, 296);
            this.txbTratamiento.Name = "txbTratamiento";
            this.txbTratamiento.Size = new System.Drawing.Size(78, 20);
            this.txbTratamiento.TabIndex = 20;
            // 
            // btnActualizar
            // 
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnActualizar.Location = new System.Drawing.Point(550, 391);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 33);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(656, 604);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txbTratamiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbTipoSangre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregarPaciente);
            this.Controls.Add(this.txbEnfermedad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbCodeagregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbAnimal);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.txbcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbcode;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txbAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCodeagregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbEnfermedad;
        private System.Windows.Forms.Button btnAgregarPaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTipoSangre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbTratamiento;
        private System.Windows.Forms.Button btnActualizar;
    }
}

