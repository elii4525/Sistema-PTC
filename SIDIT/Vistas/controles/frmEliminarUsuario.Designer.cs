namespace Vistas.Controles
{
    partial class frmEliminarUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoUsuario = new Vistas.Controles.TextBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del usuario:";
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.BackColor = System.Drawing.Color.Black;
            this.txtCodigoUsuario.BorderColor = System.Drawing.Color.White;
            this.txtCodigoUsuario.BorderSize = 2;
            this.txtCodigoUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigoUsuario.Location = new System.Drawing.Point(104, 262);
            this.txtCodigoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoUsuario.MaxLength = 32767;
            this.txtCodigoUsuario.multiline = true;
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodigoUsuario.PasswordChar = false;
            this.txtCodigoUsuario.ReadOnly = false;
            this.txtCodigoUsuario.Size = new System.Drawing.Size(428, 30);
            this.txtCodigoUsuario.SoloLetras = false;
            this.txtCodigoUsuario.SoloNumeros = false;
            this.txtCodigoUsuario.TabIndex = 2;
            this.txtCodigoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoUsuario.Texts = "";
            this.txtCodigoUsuario.UnderlinedStyle = true;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(245, 342);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(132, 50);
            this.btnEliminarUsuario.TabIndex = 3;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(737, 74);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(472, 461);
            this.dgvUsuarios.TabIndex = 4;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvUsuarios);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEliminarUsuario);
            this.panel1.Controls.Add(this.txtCodigoUsuario);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 664);
            this.panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1244, 670);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // frmEliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmEliminarUsuario";
            this.Size = new System.Drawing.Size(1244, 670);
            this.Load += new System.EventHandler(this.frmEliminarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private TextBox txtCodigoUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
