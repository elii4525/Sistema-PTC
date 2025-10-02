namespace Vistas.Formularios
{
    partial class frmActualizarMaterial
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.icbtnSalir = new FontAwesome.Sharp.IconPictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbtnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(730, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Material:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(431, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "Actualizar\r\n";
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Location = new System.Drawing.Point(35, 136);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.RowHeadersWidth = 51;
            this.dgvMaterial.RowTemplate.Height = 24;
            this.dgvMaterial.Size = new System.Drawing.Size(654, 353);
            this.dgvMaterial.TabIndex = 19;
            this.dgvMaterial.DoubleClick += new System.EventHandler(this.dgvMaterial_DoubleClick);
            // 
            // icbtnSalir
            // 
            this.icbtnSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            this.icbtnSalir.IconColor = System.Drawing.Color.White;
            this.icbtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnSalir.IconSize = 27;
            this.icbtnSalir.Location = new System.Drawing.Point(902, 12);
            this.icbtnSalir.Name = "icbtnSalir";
            this.icbtnSalir.Size = new System.Drawing.Size(32, 27);
            this.icbtnSalir.TabIndex = 50;
            this.icbtnSalir.TabStop = false;
            this.icbtnSalir.Click += new System.EventHandler(this.icbtnSalir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(66, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(343, 18);
            this.label8.TabIndex = 51;
            this.label8.Text = "Haz doble click en el registro para actualizar.";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(734, 220);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(165, 28);
            this.txtNombre.TabIndex = 54;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(216)))), ((int)(((byte)(112)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(772, 391);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 39);
            this.btnActualizar.TabIndex = 55;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(734, 322);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(165, 28);
            this.txtCantidad.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(730, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "Cantidad nueva:";
            // 
            // frmActualizarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(946, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.icbtnSalir);
            this.Controls.Add(this.dgvMaterial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActualizarMaterial";
            this.Text = "frmActualizarMaterial";
            this.Load += new System.EventHandler(this.frmActualizarMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbtnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private FontAwesome.Sharp.IconPictureBox icbtnSalir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
    }
}