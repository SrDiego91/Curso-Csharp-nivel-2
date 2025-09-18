namespace proyecto_APP_0._1._0
{
    partial class Frmagregardiscos
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
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblfechadelanzamiento = new System.Windows.Forms.Label();
            this.lblcantidadcanciones = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtcantidadcanciones = new System.Windows.Forms.TextBox();
            this.dtpfechalanzamiento = new System.Windows.Forms.DateTimePicker();
            this.lblestilo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbestilo = new System.Windows.Forms.ComboBox();
            this.cbedicion = new System.Windows.Forms.ComboBox();
            this.lblurltapaimagen = new System.Windows.Forms.Label();
            this.txturltapadisco = new System.Windows.Forms.TextBox();
            this.pbprecargardeagregarimagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbprecargardeagregarimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(176, 208);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 24);
            this.btnaceptar.TabIndex = 6;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(317, 208);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 24);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(48, 20);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(81, 13);
            this.lbltitulo.TabIndex = 2;
            this.lbltitulo.Text = "Titulo del disco:";
            // 
            // lblfechadelanzamiento
            // 
            this.lblfechadelanzamiento.AutoSize = true;
            this.lblfechadelanzamiento.Location = new System.Drawing.Point(15, 51);
            this.lblfechadelanzamiento.Name = "lblfechadelanzamiento";
            this.lblfechadelanzamiento.Size = new System.Drawing.Size(114, 13);
            this.lblfechadelanzamiento.TabIndex = 3;
            this.lblfechadelanzamiento.Text = "Fecha de lanzamiento:";
            // 
            // lblcantidadcanciones
            // 
            this.lblcantidadcanciones.AutoSize = true;
            this.lblcantidadcanciones.Location = new System.Drawing.Point(10, 75);
            this.lblcantidadcanciones.Name = "lblcantidadcanciones";
            this.lblcantidadcanciones.Size = new System.Drawing.Size(119, 13);
            this.lblcantidadcanciones.TabIndex = 4;
            this.lblcantidadcanciones.Text = "Cantidad de canciones:";
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(135, 17);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(198, 20);
            this.txttitulo.TabIndex = 0;
            // 
            // txtcantidadcanciones
            // 
            this.txtcantidadcanciones.Location = new System.Drawing.Point(135, 72);
            this.txtcantidadcanciones.Name = "txtcantidadcanciones";
            this.txtcantidadcanciones.Size = new System.Drawing.Size(198, 20);
            this.txtcantidadcanciones.TabIndex = 2;
            // 
            // dtpfechalanzamiento
            // 
            this.dtpfechalanzamiento.CustomFormat = "yyyy-MM-dd";
            this.dtpfechalanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechalanzamiento.Location = new System.Drawing.Point(135, 45);
            this.dtpfechalanzamiento.Name = "dtpfechalanzamiento";
            this.dtpfechalanzamiento.Size = new System.Drawing.Size(198, 20);
            this.dtpfechalanzamiento.TabIndex = 1;
            this.dtpfechalanzamiento.Value = new System.DateTime(2025, 9, 15, 0, 0, 0, 0);
            // 
            // lblestilo
            // 
            this.lblestilo.AutoSize = true;
            this.lblestilo.Location = new System.Drawing.Point(94, 128);
            this.lblestilo.Name = "lblestilo";
            this.lblestilo.Size = new System.Drawing.Size(35, 13);
            this.lblestilo.TabIndex = 9;
            this.lblestilo.Text = "Estilo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo de edicion:";
            // 
            // cbestilo
            // 
            this.cbestilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestilo.FormattingEnabled = true;
            this.cbestilo.Location = new System.Drawing.Point(135, 125);
            this.cbestilo.Name = "cbestilo";
            this.cbestilo.Size = new System.Drawing.Size(198, 21);
            this.cbestilo.TabIndex = 4;
            // 
            // cbedicion
            // 
            this.cbedicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbedicion.FormattingEnabled = true;
            this.cbedicion.Location = new System.Drawing.Point(135, 153);
            this.cbedicion.Name = "cbedicion";
            this.cbedicion.Size = new System.Drawing.Size(198, 21);
            this.cbedicion.TabIndex = 5;
            // 
            // lblurltapaimagen
            // 
            this.lblurltapaimagen.AutoSize = true;
            this.lblurltapaimagen.Location = new System.Drawing.Point(11, 102);
            this.lblurltapaimagen.Name = "lblurltapaimagen";
            this.lblurltapaimagen.Size = new System.Drawing.Size(118, 13);
            this.lblurltapaimagen.TabIndex = 13;
            this.lblurltapaimagen.Text = "Url de la tapa del disco:";
            // 
            // txturltapadisco
            // 
            this.txturltapadisco.Location = new System.Drawing.Point(135, 99);
            this.txturltapadisco.Name = "txturltapadisco";
            this.txturltapadisco.Size = new System.Drawing.Size(198, 20);
            this.txturltapadisco.TabIndex = 3;
            this.txturltapadisco.Leave += new System.EventHandler(this.txturltapadisco_Leave);
            // 
            // pbprecargardeagregarimagen
            // 
            this.pbprecargardeagregarimagen.Location = new System.Drawing.Point(352, 17);
            this.pbprecargardeagregarimagen.Name = "pbprecargardeagregarimagen";
            this.pbprecargardeagregarimagen.Size = new System.Drawing.Size(197, 157);
            this.pbprecargardeagregarimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbprecargardeagregarimagen.TabIndex = 14;
            this.pbprecargardeagregarimagen.TabStop = false;
            // 
            // Frmagregardiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 260);
            this.Controls.Add(this.pbprecargardeagregarimagen);
            this.Controls.Add(this.txturltapadisco);
            this.Controls.Add(this.lblurltapaimagen);
            this.Controls.Add(this.cbedicion);
            this.Controls.Add(this.cbestilo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblestilo);
            this.Controls.Add(this.dtpfechalanzamiento);
            this.Controls.Add(this.txtcantidadcanciones);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.lblcantidadcanciones);
            this.Controls.Add(this.lblfechadelanzamiento);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.MaximumSize = new System.Drawing.Size(584, 299);
            this.MinimumSize = new System.Drawing.Size(584, 299);
            this.Name = "Frmagregardiscos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar discos";
            this.Load += new System.EventHandler(this.Frmagregardiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbprecargardeagregarimagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblfechadelanzamiento;
        private System.Windows.Forms.Label lblcantidadcanciones;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtcantidadcanciones;
        private System.Windows.Forms.DateTimePicker dtpfechalanzamiento;
        private System.Windows.Forms.Label lblestilo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbestilo;
        private System.Windows.Forms.ComboBox cbedicion;
        private System.Windows.Forms.Label lblurltapaimagen;
        private System.Windows.Forms.TextBox txturltapadisco;
        private System.Windows.Forms.PictureBox pbprecargardeagregarimagen;
    }
}