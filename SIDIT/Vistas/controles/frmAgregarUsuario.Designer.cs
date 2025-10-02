namespace Vistas.Controles
{
    partial class frmAgregarUsuario
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.dgvUltimosUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo = new Vistas.Controles.TextBox();
            this.txtNumero = new Vistas.Controles.TextBox();
            this.txtNombre = new Vistas.Controles.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimosUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(31, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(110, 16);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Agregar usuarios";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(219, 111);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(59, 16);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Nombre:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(219, 283);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(31, 16);
            this.lbl5.TabIndex = 2;
            this.lbl5.Text = "Rol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(219, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Agregar usuarios:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(219, 228);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(128, 16);
            this.lbl4.TabIndex = 2;
            this.lbl4.Text = "Numero de telefono:\r\n";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(219, 170);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(135, 16);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Fecha de nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ultimos usuarios agregados";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.ForeColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(219, 334);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(120, 16);
            this.lbl6.TabIndex = 4;
            this.lbl6.Text = "Correo electronico;";
            // 
            // dgvUltimosUsuarios
            // 
            this.dgvUltimosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUltimosUsuarios.Location = new System.Drawing.Point(114, 440);
            this.dgvUltimosUsuarios.Name = "dgvUltimosUsuarios";
            this.dgvUltimosUsuarios.RowHeadersWidth = 51;
            this.dgvUltimosUsuarios.RowTemplate.Height = 24;
            this.dgvUltimosUsuarios.Size = new System.Drawing.Size(1050, 150);
            this.dgvUltimosUsuarios.TabIndex = 10;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(987, 228);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(155, 68);
            this.btnAgregarUsuario.TabIndex = 11;
            this.btnAgregarUsuario.Text = "Agregar usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(484, 294);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(423, 24);
            this.cbRol.TabIndex = 12;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(484, 177);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(423, 22);
            this.dtpFechaNacimiento.TabIndex = 13;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Black;
            this.txtCorreo.BorderColor = System.Drawing.Color.White;
            this.txtCorreo.BorderSize = 2;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreo.Location = new System.Drawing.Point(484, 334);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 75;
            this.txtCorreo.multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(7);
            this.txtCorreo.PasswordChar = false;
            this.txtCorreo.ReadOnly = false;
            this.txtCorreo.Size = new System.Drawing.Size(423, 30);
            this.txtCorreo.SoloLetras = false;
            this.txtCorreo.SoloNumeros = false;
            this.txtCorreo.TabIndex = 9;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.Texts = "";
            this.txtCorreo.UnderlinedStyle = true;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.Black;
            this.txtNumero.BorderColor = System.Drawing.Color.White;
            this.txtNumero.BorderSize = 2;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumero.Location = new System.Drawing.Point(484, 228);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.MaxLength = 8;
            this.txtNumero.multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumero.PasswordChar = false;
            this.txtNumero.ReadOnly = false;
            this.txtNumero.Size = new System.Drawing.Size(423, 30);
            this.txtNumero.SoloLetras = false;
            this.txtNumero.SoloNumeros = false;
            this.txtNumero.TabIndex = 7;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumero.Texts = "";
            this.txtNumero.UnderlinedStyle = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Black;
            this.txtNombre.BorderColor = System.Drawing.Color.White;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(484, 111);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.ReadOnly = false;
            this.txtNombre.Size = new System.Drawing.Size(423, 30);
            this.txtNombre.SoloLetras = false;
            this.txtNombre.SoloNumeros = false;
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = true;
            // 
            // frmAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.dgvUltimosUsuarios);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmAgregarUsuario";
            this.Size = new System.Drawing.Size(1257, 639);
            this.Load += new System.EventHandler(this.frmAgregarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimosUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl6;
        private TextBox txtNombre;
        private TextBox txtNumero;
        private TextBox txtCorreo;
        private System.Windows.Forms.DataGridView dgvUltimosUsuarios;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    }
}
