namespace Vistas.Formularios
{
    partial class frmCambiarContraseña
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevaContraseña = new Vistas.controles.TextBoxRedondeado();
            this.txtConfirmarContraseña = new Vistas.controles.TextBoxRedondeado();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new Vistas.controles.ButtonRedondeado();
            this.txtContraseñaActual = new Vistas.controles.TextBoxRedondeado();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cambiar contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña nueva:";
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.BackColor = System.Drawing.Color.Black;
            this.txtNuevaContraseña.BorderColor = System.Drawing.Color.White;
            this.txtNuevaContraseña.BorderRadius = 10;
            this.txtNuevaContraseña.BorderSize = 1;
            this.txtNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContraseña.ForeColor = System.Drawing.Color.White;
            this.txtNuevaContraseña.Location = new System.Drawing.Point(75, 145);
            this.txtNuevaContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevaContraseña.MaxLength = 32767;
            this.txtNuevaContraseña.Multiline = true;
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Padding = new System.Windows.Forms.Padding(7);
            this.txtNuevaContraseña.PasswordChar = false;
            this.txtNuevaContraseña.ReadOnly = false;
            this.txtNuevaContraseña.Size = new System.Drawing.Size(250, 30);
            this.txtNuevaContraseña.SoloLetras = false;
            this.txtNuevaContraseña.SoloNumeros = false;
            this.txtNuevaContraseña.TabIndex = 2;
            this.txtNuevaContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNuevaContraseña.Texts = "";
            this.txtNuevaContraseña.UnderlinedStyle = false;
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.BackColor = System.Drawing.Color.Black;
            this.txtConfirmarContraseña.BorderColor = System.Drawing.Color.White;
            this.txtConfirmarContraseña.BorderRadius = 10;
            this.txtConfirmarContraseña.BorderSize = 1;
            this.txtConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContraseña.ForeColor = System.Drawing.Color.White;
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(75, 212);
            this.txtConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmarContraseña.MaxLength = 32767;
            this.txtConfirmarContraseña.Multiline = true;
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.Padding = new System.Windows.Forms.Padding(7);
            this.txtConfirmarContraseña.PasswordChar = false;
            this.txtConfirmarContraseña.ReadOnly = false;
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(250, 30);
            this.txtConfirmarContraseña.SoloLetras = false;
            this.txtConfirmarContraseña.SoloNumeros = false;
            this.txtConfirmarContraseña.TabIndex = 4;
            this.txtConfirmarContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmarContraseña.Texts = "";
            this.txtConfirmarContraseña.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmar contraseña:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Black;
            this.btnAceptar.BorderColor = System.Drawing.Color.White;
            this.btnAceptar.BorderRadius = 12;
            this.btnAceptar.BorderSize = 1;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(373, 142);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 33);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.BackColor = System.Drawing.Color.Black;
            this.txtContraseñaActual.BorderColor = System.Drawing.Color.White;
            this.txtContraseñaActual.BorderRadius = 10;
            this.txtContraseñaActual.BorderSize = 1;
            this.txtContraseñaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaActual.ForeColor = System.Drawing.Color.White;
            this.txtContraseñaActual.Location = new System.Drawing.Point(75, 73);
            this.txtContraseñaActual.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseñaActual.MaxLength = 32767;
            this.txtContraseñaActual.Multiline = true;
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Padding = new System.Windows.Forms.Padding(7);
            this.txtContraseñaActual.PasswordChar = false;
            this.txtContraseñaActual.ReadOnly = false;
            this.txtContraseñaActual.Size = new System.Drawing.Size(250, 30);
            this.txtContraseñaActual.SoloLetras = false;
            this.txtContraseñaActual.SoloNumeros = false;
            this.txtContraseñaActual.TabIndex = 7;
            this.txtContraseñaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraseñaActual.Texts = "";
            this.txtContraseñaActual.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña actual:";
            // 
            // frmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(512, 281);
            this.Controls.Add(this.txtContraseñaActual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmCambiarContraseña";
            this.Text = "frmCambiarContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private controles.TextBoxRedondeado txtNuevaContraseña;
        private controles.TextBoxRedondeado txtConfirmarContraseña;
        private System.Windows.Forms.Label label3;
        private controles.ButtonRedondeado btnAceptar;
        private controles.TextBoxRedondeado txtContraseñaActual;
        private System.Windows.Forms.Label label4;
    }
}