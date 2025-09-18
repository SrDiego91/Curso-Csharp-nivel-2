namespace proyecto_APP_0._1._0
{
    partial class frmdiscos
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
            this.dgvdisco = new System.Windows.Forms.DataGridView();
            this.pbtapadiscos = new System.Windows.Forms.PictureBox();
            this.btnagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtapadiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdisco
            // 
            this.dgvdisco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdisco.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvdisco.Location = new System.Drawing.Point(12, 14);
            this.dgvdisco.MultiSelect = false;
            this.dgvdisco.Name = "dgvdisco";
            this.dgvdisco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdisco.Size = new System.Drawing.Size(556, 286);
            this.dgvdisco.TabIndex = 0;
            this.dgvdisco.SelectionChanged += new System.EventHandler(this.dgvdisco_SelectionChanged);
            // 
            // pbtapadiscos
            // 
            this.pbtapadiscos.Location = new System.Drawing.Point(574, 14);
            this.pbtapadiscos.Name = "pbtapadiscos";
            this.pbtapadiscos.Size = new System.Drawing.Size(268, 287);
            this.pbtapadiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtapadiscos.TabIndex = 1;
            this.pbtapadiscos.TabStop = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(12, 305);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // frmdiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 335);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.pbtapadiscos);
            this.Controls.Add(this.dgvdisco);
            this.Name = "frmdiscos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discos";
            this.Load += new System.EventHandler(this.frmdiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtapadiscos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdisco;
        private System.Windows.Forms.PictureBox pbtapadiscos;
        private System.Windows.Forms.Button btnagregar;
    }
}

