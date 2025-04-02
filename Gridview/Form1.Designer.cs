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
            this.label1.Location = new System.Drawing.Point(56, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code";
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
            this.btnLimpiar.Location = new System.Drawing.Point(440, 11);
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
            this.txbAnimal.Location = new System.Drawing.Point(509, 387);
            this.txbAnimal.Name = "txbAnimal";
            this.txbAnimal.Size = new System.Drawing.Size(78, 20);
            this.txbAnimal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(515, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Animal";
            // 
            // txbNombre
            // 
            this.txbNombre.BackColor = System.Drawing.Color.MistyRose;
            this.txbNombre.Location = new System.Drawing.Point(509, 429);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(78, 20);
            this.txbNombre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(515, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(515, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Code";
            // 
            // txbCodeagregar
            // 
            this.txbCodeagregar.BackColor = System.Drawing.Color.MistyRose;
            this.txbCodeagregar.Location = new System.Drawing.Point(509, 477);
            this.txbCodeagregar.Name = "txbCodeagregar";
            this.txbCodeagregar.Size = new System.Drawing.Size(78, 20);
            this.txbCodeagregar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(515, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enfermedad";
            // 
            // txbEnfermedad
            // 
            this.txbEnfermedad.BackColor = System.Drawing.Color.MistyRose;
            this.txbEnfermedad.Location = new System.Drawing.Point(509, 527);
            this.txbEnfermedad.Name = "txbEnfermedad";
            this.txbEnfermedad.Size = new System.Drawing.Size(78, 20);
            this.txbEnfermedad.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(615, 572);
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
    }
}

