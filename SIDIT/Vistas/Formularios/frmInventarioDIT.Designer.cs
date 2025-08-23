namespace Vistas.Formularios
{
    partial class frmInventarioDIT
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
            this.pnlIventarioCategoria = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPerifericos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvComputacion = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAlmacenamiento = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvLimpieza = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvRedes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvPapelería = new System.Windows.Forms.DataGridView();
            this.pnlMenuDesplegable = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlIventarioCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerifericos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLimpieza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapelería)).BeginInit();
            this.pnlMenuDesplegable.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIventarioCategoria
            // 
            this.pnlIventarioCategoria.Controls.Add(this.btnFiltrar);
            this.pnlIventarioCategoria.Controls.Add(this.label1);
            this.pnlIventarioCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIventarioCategoria.Location = new System.Drawing.Point(0, 0);
            this.pnlIventarioCategoria.Name = "pnlIventarioCategoria";
            this.pnlIventarioCategoria.Size = new System.Drawing.Size(919, 73);
            this.pnlIventarioCategoria.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.White;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Image = global::Vistas.Properties.Resources.icons8_sort_down_24;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.Location = new System.Drawing.Point(67, 43);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(104, 24);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar por";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de materiales";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(708, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar Material";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Periféricos --";
            // 
            // dgvPerifericos
            // 
            this.dgvPerifericos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerifericos.Location = new System.Drawing.Point(58, 174);
            this.dgvPerifericos.Name = "dgvPerifericos";
            this.dgvPerifericos.RowHeadersWidth = 51;
            this.dgvPerifericos.Size = new System.Drawing.Size(750, 370);
            this.dgvPerifericos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Computación --";
            // 
            // dgvComputacion
            // 
            this.dgvComputacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComputacion.Location = new System.Drawing.Point(58, 626);
            this.dgvComputacion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvComputacion.Name = "dgvComputacion";
            this.dgvComputacion.RowHeadersWidth = 51;
            this.dgvComputacion.RowTemplate.Height = 24;
            this.dgvComputacion.Size = new System.Drawing.Size(748, 370);
            this.dgvComputacion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 1059);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Almacenamiento --";
            // 
            // dgvAlmacenamiento
            // 
            this.dgvAlmacenamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacenamiento.Location = new System.Drawing.Point(58, 1088);
            this.dgvAlmacenamiento.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAlmacenamiento.Name = "dgvAlmacenamiento";
            this.dgvAlmacenamiento.RowHeadersWidth = 51;
            this.dgvAlmacenamiento.RowTemplate.Height = 24;
            this.dgvAlmacenamiento.Size = new System.Drawing.Size(748, 370);
            this.dgvAlmacenamiento.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 1524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Limpieza --";
            // 
            // dgvLimpieza
            // 
            this.dgvLimpieza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLimpieza.Location = new System.Drawing.Point(58, 1556);
            this.dgvLimpieza.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLimpieza.Name = "dgvLimpieza";
            this.dgvLimpieza.RowHeadersWidth = 51;
            this.dgvLimpieza.RowTemplate.Height = 24;
            this.dgvLimpieza.Size = new System.Drawing.Size(748, 370);
            this.dgvLimpieza.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 1993);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Redes --";
            // 
            // dgvRedes
            // 
            this.dgvRedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRedes.Location = new System.Drawing.Point(58, 2022);
            this.dgvRedes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRedes.Name = "dgvRedes";
            this.dgvRedes.RowHeadersWidth = 51;
            this.dgvRedes.RowTemplate.Height = 24;
            this.dgvRedes.Size = new System.Drawing.Size(748, 370);
            this.dgvRedes.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(55, 2473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Papelería --";
            // 
            // dgvPapelería
            // 
            this.dgvPapelería.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPapelería.Location = new System.Drawing.Point(58, 2502);
            this.dgvPapelería.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPapelería.Name = "dgvPapelería";
            this.dgvPapelería.RowHeadersWidth = 51;
            this.dgvPapelería.RowTemplate.Height = 24;
            this.dgvPapelería.Size = new System.Drawing.Size(748, 370);
            this.dgvPapelería.TabIndex = 14;
            // 
            // pnlMenuDesplegable
            // 
            this.pnlMenuDesplegable.BackColor = System.Drawing.Color.White;
            this.pnlMenuDesplegable.Controls.Add(this.button4);
            this.pnlMenuDesplegable.Controls.Add(this.button3);
            this.pnlMenuDesplegable.Location = new System.Drawing.Point(67, 73);
            this.pnlMenuDesplegable.Name = "pnlMenuDesplegable";
            this.pnlMenuDesplegable.Size = new System.Drawing.Size(104, 46);
            this.pnlMenuDesplegable.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 22);
            this.button3.TabIndex = 0;
            this.button3.Text = "Categoría";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 22);
            this.button4.TabIndex = 1;
            this.button4.Text = "Sin Categoría";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmInventarioDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(936, 571);
            this.Controls.Add(this.pnlMenuDesplegable);
            this.Controls.Add(this.dgvPapelería);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvRedes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvLimpieza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvAlmacenamiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvComputacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPerifericos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlIventarioCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInventarioDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlIventarioCategoria.ResumeLayout(false);
            this.pnlIventarioCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerifericos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLimpieza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapelería)).EndInit();
            this.pnlMenuDesplegable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlIventarioCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPerifericos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvComputacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAlmacenamiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvLimpieza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvRedes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvPapelería;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Panel pnlMenuDesplegable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}