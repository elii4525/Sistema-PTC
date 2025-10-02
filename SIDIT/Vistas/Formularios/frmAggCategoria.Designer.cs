namespace Vistas.Formularios
{
    partial class frmAggCategoria
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
            this.pnlAggCategorias = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAggCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.icbtnSalir = new FontAwesome.Sharp.IconPictureBox();
            this.pnlAggCategorias.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbtnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAggCategorias
            // 
            this.pnlAggCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAggCategorias.BackColor = System.Drawing.Color.Black;
            this.pnlAggCategorias.Controls.Add(this.icbtnSalir);
            this.pnlAggCategorias.Controls.Add(this.label5);
            this.pnlAggCategorias.Controls.Add(this.btnAggCategoria);
            this.pnlAggCategorias.Controls.Add(this.label1);
            this.pnlAggCategorias.Controls.Add(this.txtCategoria);
            this.pnlAggCategorias.Location = new System.Drawing.Point(3, 2);
            this.pnlAggCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAggCategorias.Name = "pnlAggCategorias";
            this.pnlAggCategorias.Size = new System.Drawing.Size(663, 344);
            this.pnlAggCategorias.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(228, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Agregar Categoría";
            // 
            // btnAggCategoria
            // 
            this.btnAggCategoria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAggCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(216)))), ((int)(((byte)(112)))));
            this.btnAggCategoria.FlatAppearance.BorderSize = 0;
            this.btnAggCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggCategoria.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnAggCategoria.Location = new System.Drawing.Point(478, 203);
            this.btnAggCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAggCategoria.Name = "btnAggCategoria";
            this.btnAggCategoria.Size = new System.Drawing.Size(132, 46);
            this.btnAggCategoria.TabIndex = 4;
            this.btnAggCategoria.Text = "Registrar";
            this.btnAggCategoria.UseVisualStyleBackColor = false;
            this.btnAggCategoria.Click += new System.EventHandler(this.btnAggCategoria_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoría:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.Color.Black;
            this.txtCategoria.Location = new System.Drawing.Point(49, 215);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(269, 34);
            this.txtCategoria.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlAggCategorias, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 348);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.icbtnSalir.TabIndex = 49;
            this.icbtnSalir.TabStop = false;
            this.icbtnSalir.Click += new System.EventHandler(this.icbtnSalir_Click);
            // 
            // frmAggCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(669, 348);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAggCategoria";
            this.Text = "frmAggCategoria";
            this.pnlAggCategorias.ResumeLayout(false);
            this.pnlAggCategorias.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icbtnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAggCategorias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAggCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox icbtnSalir;
    }
}