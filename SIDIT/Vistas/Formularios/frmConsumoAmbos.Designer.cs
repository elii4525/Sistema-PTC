namespace Vistas.Formularios
{
    partial class frmConsumoAmbos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.icbtnGraficas = new FontAwesome.Sharp.IconButton();
            this.icbtnRegistro = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pnlContenedor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlButtons, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.18354F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.81645F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1122, 632);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(3, 79);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1116, 550);
            this.pnlContenedor.TabIndex = 2;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Black;
            this.pnlButtons.Controls.Add(this.icbtnGraficas);
            this.pnlButtons.Controls.Add(this.icbtnRegistro);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(3, 3);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1116, 70);
            this.pnlButtons.TabIndex = 0;
            // 
            // icbtnGraficas
            // 
            this.icbtnGraficas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.icbtnGraficas.BackColor = System.Drawing.Color.Transparent;
            this.icbtnGraficas.FlatAppearance.BorderSize = 0;
            this.icbtnGraficas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.icbtnGraficas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.icbtnGraficas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnGraficas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnGraficas.ForeColor = System.Drawing.Color.White;
            this.icbtnGraficas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icbtnGraficas.IconColor = System.Drawing.Color.Black;
            this.icbtnGraficas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnGraficas.Location = new System.Drawing.Point(178, 11);
            this.icbtnGraficas.Name = "icbtnGraficas";
            this.icbtnGraficas.Size = new System.Drawing.Size(167, 43);
            this.icbtnGraficas.TabIndex = 1;
            this.icbtnGraficas.Text = "Gráficas";
            this.icbtnGraficas.UseVisualStyleBackColor = false;
            this.icbtnGraficas.Click += new System.EventHandler(this.icbtnGraficas_Click);
            this.icbtnGraficas.Enter += new System.EventHandler(this.btnMouseEnter);
            this.icbtnGraficas.Leave += new System.EventHandler(this.btnMouseLeave);
            // 
            // icbtnRegistro
            // 
            this.icbtnRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.icbtnRegistro.BackColor = System.Drawing.Color.Transparent;
            this.icbtnRegistro.FlatAppearance.BorderSize = 0;
            this.icbtnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.icbtnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.icbtnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnRegistro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnRegistro.ForeColor = System.Drawing.Color.White;
            this.icbtnRegistro.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icbtnRegistro.IconColor = System.Drawing.Color.Black;
            this.icbtnRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnRegistro.Location = new System.Drawing.Point(5, 6);
            this.icbtnRegistro.Name = "icbtnRegistro";
            this.icbtnRegistro.Size = new System.Drawing.Size(167, 48);
            this.icbtnRegistro.TabIndex = 0;
            this.icbtnRegistro.Text = "Registrar Consumo";
            this.icbtnRegistro.UseVisualStyleBackColor = false;
            this.icbtnRegistro.Click += new System.EventHandler(this.icbtnRegistro_Click);
            this.icbtnRegistro.Enter += new System.EventHandler(this.btnMouseEnter);
            this.icbtnRegistro.Leave += new System.EventHandler(this.btnMouseLeave);
            // 
            // frmConsumoAmbos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 632);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmConsumoAmbos";
            this.Load += new System.EventHandler(this.frmConsumoAmbos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlButtons;
        private FontAwesome.Sharp.IconButton icbtnGraficas;
        private FontAwesome.Sharp.IconButton icbtnRegistro;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}