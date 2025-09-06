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
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtapadiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdisco
            // 
            this.dgvdisco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdisco.Location = new System.Drawing.Point(12, 13);
            this.dgvdisco.Name = "dgvdisco";
            this.dgvdisco.Size = new System.Drawing.Size(532, 370);
            this.dgvdisco.TabIndex = 0;
            this.dgvdisco.SelectionChanged += new System.EventHandler(this.dgvdisco_SelectionChanged);
            // 
            // pbtapadiscos
            // 
            this.pbtapadiscos.Location = new System.Drawing.Point(550, 13);
            this.pbtapadiscos.Name = "pbtapadiscos";
            this.pbtapadiscos.Size = new System.Drawing.Size(343, 370);
            this.pbtapadiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtapadiscos.TabIndex = 1;
            this.pbtapadiscos.TabStop = false;
            // 
            // frmdiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 395);
            this.Controls.Add(this.pbtapadiscos);
            this.Controls.Add(this.dgvdisco);
            this.MaximumSize = new System.Drawing.Size(921, 434);
            this.MinimumSize = new System.Drawing.Size(921, 434);
            this.Name = "frmdiscos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmdiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtapadiscos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdisco;
        private System.Windows.Forms.PictureBox pbtapadiscos;
    }
}

