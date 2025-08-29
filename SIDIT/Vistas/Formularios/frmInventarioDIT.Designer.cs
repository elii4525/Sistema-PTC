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
            this.tlpFrmInventario = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContenedorPestañas = new System.Windows.Forms.Panel();
            this.icbtnActualizarYEliminarMaterial = new FontAwesome.Sharp.IconButton();
            this.icbtnAggMaterial = new FontAwesome.Sharp.IconButton();
            this.icbtnVerMaterial = new FontAwesome.Sharp.IconButton();
            this.pnlContenedorUC = new System.Windows.Forms.Panel();
            this.tlpFrmInventario.SuspendLayout();
            this.pnlContenedorPestañas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFrmInventario
            // 
            this.tlpFrmInventario.ColumnCount = 1;
            this.tlpFrmInventario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFrmInventario.Controls.Add(this.pnlContenedorPestañas, 0, 0);
            this.tlpFrmInventario.Controls.Add(this.pnlContenedorUC, 0, 1);
            this.tlpFrmInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFrmInventario.Location = new System.Drawing.Point(0, 0);
            this.tlpFrmInventario.Margin = new System.Windows.Forms.Padding(2);
            this.tlpFrmInventario.Name = "tlpFrmInventario";
            this.tlpFrmInventario.RowCount = 2;
            this.tlpFrmInventario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.52205F));
            this.tlpFrmInventario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.47795F));
            this.tlpFrmInventario.Size = new System.Drawing.Size(936, 571);
            this.tlpFrmInventario.TabIndex = 1;
            // 
            // pnlContenedorPestañas
            // 
            this.pnlContenedorPestañas.Controls.Add(this.icbtnActualizarYEliminarMaterial);
            this.pnlContenedorPestañas.Controls.Add(this.icbtnAggMaterial);
            this.pnlContenedorPestañas.Controls.Add(this.icbtnVerMaterial);
            this.pnlContenedorPestañas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorPestañas.Location = new System.Drawing.Point(2, 2);
            this.pnlContenedorPestañas.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContenedorPestañas.Name = "pnlContenedorPestañas";
            this.pnlContenedorPestañas.Size = new System.Drawing.Size(932, 61);
            this.pnlContenedorPestañas.TabIndex = 0;
            // 
            // icbtnActualizarYEliminarMaterial
            // 
            this.icbtnActualizarYEliminarMaterial.BackColor = System.Drawing.Color.Black;
            this.icbtnActualizarYEliminarMaterial.Dock = System.Windows.Forms.DockStyle.Left;
            this.icbtnActualizarYEliminarMaterial.FlatAppearance.BorderSize = 0;
            this.icbtnActualizarYEliminarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnActualizarYEliminarMaterial.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnActualizarYEliminarMaterial.ForeColor = System.Drawing.Color.White;
            this.icbtnActualizarYEliminarMaterial.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.icbtnActualizarYEliminarMaterial.IconColor = System.Drawing.Color.White;
            this.icbtnActualizarYEliminarMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnActualizarYEliminarMaterial.IconSize = 33;
            this.icbtnActualizarYEliminarMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnActualizarYEliminarMaterial.Location = new System.Drawing.Point(356, 0);
            this.icbtnActualizarYEliminarMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.icbtnActualizarYEliminarMaterial.Name = "icbtnActualizarYEliminarMaterial";
            this.icbtnActualizarYEliminarMaterial.Size = new System.Drawing.Size(202, 61);
            this.icbtnActualizarYEliminarMaterial.TabIndex = 6;
            this.icbtnActualizarYEliminarMaterial.Text = "Actualizar y eliminar";
            this.icbtnActualizarYEliminarMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbtnActualizarYEliminarMaterial.UseVisualStyleBackColor = false;
            this.icbtnActualizarYEliminarMaterial.Click += new System.EventHandler(this.icbtnActualizarYEliminarMaterial_Click);
            // 
            // icbtnAggMaterial
            // 
            this.icbtnAggMaterial.BackColor = System.Drawing.Color.Black;
            this.icbtnAggMaterial.Dock = System.Windows.Forms.DockStyle.Left;
            this.icbtnAggMaterial.FlatAppearance.BorderSize = 0;
            this.icbtnAggMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnAggMaterial.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnAggMaterial.ForeColor = System.Drawing.Color.White;
            this.icbtnAggMaterial.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.icbtnAggMaterial.IconColor = System.Drawing.Color.White;
            this.icbtnAggMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnAggMaterial.IconSize = 33;
            this.icbtnAggMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnAggMaterial.Location = new System.Drawing.Point(168, 0);
            this.icbtnAggMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.icbtnAggMaterial.Name = "icbtnAggMaterial";
            this.icbtnAggMaterial.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.icbtnAggMaterial.Size = new System.Drawing.Size(188, 61);
            this.icbtnAggMaterial.TabIndex = 6;
            this.icbtnAggMaterial.Text = "Agregar material";
            this.icbtnAggMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbtnAggMaterial.UseVisualStyleBackColor = false;
            this.icbtnAggMaterial.Click += new System.EventHandler(this.icbtnAggMaterial_Click);
            // 
            // icbtnVerMaterial
            // 
            this.icbtnVerMaterial.BackColor = System.Drawing.Color.Black;
            this.icbtnVerMaterial.Dock = System.Windows.Forms.DockStyle.Left;
            this.icbtnVerMaterial.FlatAppearance.BorderSize = 0;
            this.icbtnVerMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnVerMaterial.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnVerMaterial.ForeColor = System.Drawing.Color.White;
            this.icbtnVerMaterial.IconChar = FontAwesome.Sharp.IconChar.List;
            this.icbtnVerMaterial.IconColor = System.Drawing.Color.White;
            this.icbtnVerMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnVerMaterial.IconSize = 33;
            this.icbtnVerMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnVerMaterial.Location = new System.Drawing.Point(0, 0);
            this.icbtnVerMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.icbtnVerMaterial.Name = "icbtnVerMaterial";
            this.icbtnVerMaterial.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.icbtnVerMaterial.Size = new System.Drawing.Size(168, 61);
            this.icbtnVerMaterial.TabIndex = 5;
            this.icbtnVerMaterial.Text = "Ver materiales";
            this.icbtnVerMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbtnVerMaterial.UseVisualStyleBackColor = false;
            this.icbtnVerMaterial.Click += new System.EventHandler(this.icbtnVerMaterial_Click);
            // 
            // pnlContenedorUC
            // 
            this.pnlContenedorUC.Location = new System.Drawing.Point(2, 67);
            this.pnlContenedorUC.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContenedorUC.Name = "pnlContenedorUC";
            this.pnlContenedorUC.Size = new System.Drawing.Size(932, 500);
            this.pnlContenedorUC.TabIndex = 1;
            // 
            // frmInventarioDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(936, 571);
            this.Controls.Add(this.tlpFrmInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInventarioDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInventarioDIT_Load);
            this.tlpFrmInventario.ResumeLayout(false);
            this.pnlContenedorPestañas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpFrmInventario;
        private System.Windows.Forms.Panel pnlContenedorPestañas;
        private FontAwesome.Sharp.IconButton icbtnActualizarYEliminarMaterial;
        private FontAwesome.Sharp.IconButton icbtnAggMaterial;
        private FontAwesome.Sharp.IconButton icbtnVerMaterial;
        private System.Windows.Forms.Panel pnlContenedorUC;
    }
}