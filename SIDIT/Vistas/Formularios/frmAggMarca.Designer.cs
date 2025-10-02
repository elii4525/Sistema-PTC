namespace Vistas.Formularios
{
    partial class frmAggMarca
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAggMarcas = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAggMarca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.icbtnSalir = new FontAwesome.Sharp.IconPictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlAggMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbtnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pnlAggMarcas, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(669, 348);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // pnlAggMarcas
            // 
            this.pnlAggMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAggMarcas.BackColor = System.Drawing.Color.Black;
            this.pnlAggMarcas.Controls.Add(this.icbtnSalir);
            this.pnlAggMarcas.Controls.Add(this.label6);
            this.pnlAggMarcas.Controls.Add(this.btnAggMarca);
            this.pnlAggMarcas.Controls.Add(this.label2);
            this.pnlAggMarcas.Controls.Add(this.txtMarca);
            this.pnlAggMarcas.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAggMarcas.ForeColor = System.Drawing.Color.White;
            this.pnlAggMarcas.Location = new System.Drawing.Point(3, 2);
            this.pnlAggMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 10);
            this.pnlAggMarcas.Name = "pnlAggMarcas";
            this.pnlAggMarcas.Size = new System.Drawing.Size(663, 336);
            this.pnlAggMarcas.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(247, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Agregar Marca";
            // 
            // btnAggMarca
            // 
            this.btnAggMarca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAggMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(216)))), ((int)(((byte)(112)))));
            this.btnAggMarca.FlatAppearance.BorderSize = 0;
            this.btnAggMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggMarca.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggMarca.ForeColor = System.Drawing.Color.Black;
            this.btnAggMarca.Location = new System.Drawing.Point(484, 199);
            this.btnAggMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAggMarca.Name = "btnAggMarca";
            this.btnAggMarca.Size = new System.Drawing.Size(132, 46);
            this.btnAggMarca.TabIndex = 5;
            this.btnAggMarca.Text = "Registrar";
            this.btnAggMarca.UseVisualStyleBackColor = false;
            this.btnAggMarca.Click += new System.EventHandler(this.btnAggMarca_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMarca.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.Black;
            this.txtMarca.Location = new System.Drawing.Point(49, 209);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(269, 36);
            this.txtMarca.TabIndex = 0;
            // 
            // icbtnSalir
            // 
            this.icbtnSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            this.icbtnSalir.IconColor = System.Drawing.Color.White;
            this.icbtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnSalir.IconSize = 27;
            this.icbtnSalir.Location = new System.Drawing.Point(622, 10);
            this.icbtnSalir.Name = "icbtnSalir";
            this.icbtnSalir.Size = new System.Drawing.Size(32, 27);
            this.icbtnSalir.TabIndex = 50;
            this.icbtnSalir.TabStop = false;
            this.icbtnSalir.Click += new System.EventHandler(this.icbtnSalir_Click);
            // 
            // frmAggMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(669, 348);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAggMarca";
            this.Text = "frmAggMarca";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlAggMarcas.ResumeLayout(false);
            this.pnlAggMarcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbtnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlAggMarcas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAggMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private FontAwesome.Sharp.IconPictureBox icbtnSalir;
    }
}