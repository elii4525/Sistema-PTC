namespace Vistas.Controles
{
    partial class frmVerUsuarios
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVerUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ver usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(116, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de usuarios (de forma ascendente):";
            // 
            // dgvVerUsuarios
            // 
            this.dgvVerUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerUsuarios.Location = new System.Drawing.Point(153, 174);
            this.dgvVerUsuarios.Name = "dgvVerUsuarios";
            this.dgvVerUsuarios.RowHeadersWidth = 51;
            this.dgvVerUsuarios.RowTemplate.Height = 24;
            this.dgvVerUsuarios.Size = new System.Drawing.Size(943, 398);
            this.dgvVerUsuarios.TabIndex = 2;
            // 
            // frmVerUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dgvVerUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmVerUsuarios";
            this.Size = new System.Drawing.Size(1238, 667);
            this.Load += new System.EventHandler(this.frmVerUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVerUsuarios;
    }
}
