namespace Vistas.Formularios
{
    partial class frmMenuJefatura
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
            this.tlpMenuDIT = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBarraLateral = new System.Windows.Forms.Panel();
            this.icbtnUsuario = new FontAwesome.Sharp.IconButton();
            this.icbtnConsumoJ = new FontAwesome.Sharp.IconButton();
            this.icbtnSolicitudesJ = new FontAwesome.Sharp.IconButton();
            this.icbtnInventarioJ = new FontAwesome.Sharp.IconButton();
            this.pnlContenedorJ = new System.Windows.Forms.Panel();
            this.pnlBarraSuperior = new System.Windows.Forms.Panel();
            this.pbAjustes = new System.Windows.Forms.PictureBox();
            this.lblTituloUsuarios = new System.Windows.Forms.Label();
            this.lblTituloInventarioJ = new System.Windows.Forms.Label();
            this.lblTituloSolicitudJ = new System.Windows.Forms.Label();
            this.lblTituloConsumoJ = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pbLogoITEC = new System.Windows.Forms.PictureBox();
            this.tlpMenuDIT.SuspendLayout();
            this.pnlBarraLateral.SuspendLayout();
            this.pnlBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAjustes)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoITEC)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMenuDIT
            // 
            this.tlpMenuDIT.BackColor = System.Drawing.Color.Black;
            this.tlpMenuDIT.ColumnCount = 2;
            this.tlpMenuDIT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.23442F));
            this.tlpMenuDIT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.76558F));
            this.tlpMenuDIT.Controls.Add(this.pnlBarraLateral, 0, 1);
            this.tlpMenuDIT.Controls.Add(this.pnlContenedorJ, 1, 1);
            this.tlpMenuDIT.Controls.Add(this.pnlBarraSuperior, 1, 0);
            this.tlpMenuDIT.Controls.Add(this.pnlLogo, 0, 0);
            this.tlpMenuDIT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenuDIT.Location = new System.Drawing.Point(0, 0);
            this.tlpMenuDIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpMenuDIT.Name = "tlpMenuDIT";
            this.tlpMenuDIT.RowCount = 2;
            this.tlpMenuDIT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.6643F));
            this.tlpMenuDIT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.3357F));
            this.tlpMenuDIT.Size = new System.Drawing.Size(1749, 751);
            this.tlpMenuDIT.TabIndex = 1;
            // 
            // pnlBarraLateral
            // 
            this.pnlBarraLateral.Controls.Add(this.icbtnUsuario);
            this.pnlBarraLateral.Controls.Add(this.icbtnConsumoJ);
            this.pnlBarraLateral.Controls.Add(this.icbtnSolicitudesJ);
            this.pnlBarraLateral.Controls.Add(this.icbtnInventarioJ);
            this.pnlBarraLateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBarraLateral.Location = new System.Drawing.Point(3, 89);
            this.pnlBarraLateral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBarraLateral.Name = "pnlBarraLateral";
            this.pnlBarraLateral.Size = new System.Drawing.Size(173, 660);
            this.pnlBarraLateral.TabIndex = 0;
            this.pnlBarraLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraLateral_Paint);
            this.pnlBarraLateral.Resize += new System.EventHandler(this.pnlBarraLateral_Resize);
            // 
            // icbtnUsuario
            // 
            this.icbtnUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.icbtnUsuario.BackColor = System.Drawing.Color.White;
            this.icbtnUsuario.FlatAppearance.BorderSize = 0;
            this.icbtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnUsuario.ForeColor = System.Drawing.Color.Black;
            this.icbtnUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.icbtnUsuario.IconColor = System.Drawing.Color.Black;
            this.icbtnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnUsuario.IconSize = 64;
            this.icbtnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.icbtnUsuario.Location = new System.Drawing.Point(12, 512);
            this.icbtnUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icbtnUsuario.Name = "icbtnUsuario";
            this.icbtnUsuario.Padding = new System.Windows.Forms.Padding(0, 20, 0, 15);
            this.icbtnUsuario.Size = new System.Drawing.Size(140, 130);
            this.icbtnUsuario.TabIndex = 14;
            this.icbtnUsuario.Text = "Usuarios";
            this.icbtnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.icbtnUsuario.UseVisualStyleBackColor = false;
            this.icbtnUsuario.Click += new System.EventHandler(this.icbtnUsuario_Click);
            // 
            // icbtnConsumoJ
            // 
            this.icbtnConsumoJ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.icbtnConsumoJ.BackColor = System.Drawing.Color.White;
            this.icbtnConsumoJ.FlatAppearance.BorderSize = 0;
            this.icbtnConsumoJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnConsumoJ.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnConsumoJ.ForeColor = System.Drawing.Color.Black;
            this.icbtnConsumoJ.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.icbtnConsumoJ.IconColor = System.Drawing.Color.Black;
            this.icbtnConsumoJ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnConsumoJ.IconSize = 64;
            this.icbtnConsumoJ.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.icbtnConsumoJ.Location = new System.Drawing.Point(12, 358);
            this.icbtnConsumoJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icbtnConsumoJ.Name = "icbtnConsumoJ";
            this.icbtnConsumoJ.Padding = new System.Windows.Forms.Padding(0, 20, 0, 15);
            this.icbtnConsumoJ.Size = new System.Drawing.Size(140, 130);
            this.icbtnConsumoJ.TabIndex = 13;
            this.icbtnConsumoJ.Text = "Consumo";
            this.icbtnConsumoJ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.icbtnConsumoJ.UseVisualStyleBackColor = false;
            this.icbtnConsumoJ.Click += new System.EventHandler(this.icbtnConsumoJ_Click);
            // 
            // icbtnSolicitudesJ
            // 
            this.icbtnSolicitudesJ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.icbtnSolicitudesJ.BackColor = System.Drawing.Color.White;
            this.icbtnSolicitudesJ.FlatAppearance.BorderSize = 0;
            this.icbtnSolicitudesJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnSolicitudesJ.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnSolicitudesJ.ForeColor = System.Drawing.Color.Black;
            this.icbtnSolicitudesJ.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.icbtnSolicitudesJ.IconColor = System.Drawing.Color.Black;
            this.icbtnSolicitudesJ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnSolicitudesJ.IconSize = 64;
            this.icbtnSolicitudesJ.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.icbtnSolicitudesJ.Location = new System.Drawing.Point(12, 201);
            this.icbtnSolicitudesJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icbtnSolicitudesJ.Name = "icbtnSolicitudesJ";
            this.icbtnSolicitudesJ.Padding = new System.Windows.Forms.Padding(0, 20, 0, 15);
            this.icbtnSolicitudesJ.Size = new System.Drawing.Size(140, 130);
            this.icbtnSolicitudesJ.TabIndex = 10;
            this.icbtnSolicitudesJ.Text = "Solicitudes";
            this.icbtnSolicitudesJ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.icbtnSolicitudesJ.UseVisualStyleBackColor = false;
            this.icbtnSolicitudesJ.Click += new System.EventHandler(this.icbtnSolicitudesJ_Click);
            // 
            // icbtnInventarioJ
            // 
            this.icbtnInventarioJ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.icbtnInventarioJ.BackColor = System.Drawing.Color.White;
            this.icbtnInventarioJ.FlatAppearance.BorderSize = 0;
            this.icbtnInventarioJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnInventarioJ.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnInventarioJ.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            this.icbtnInventarioJ.IconColor = System.Drawing.Color.Black;
            this.icbtnInventarioJ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnInventarioJ.IconSize = 64;
            this.icbtnInventarioJ.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.icbtnInventarioJ.Location = new System.Drawing.Point(12, 42);
            this.icbtnInventarioJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icbtnInventarioJ.Name = "icbtnInventarioJ";
            this.icbtnInventarioJ.Padding = new System.Windows.Forms.Padding(0, 20, 0, 15);
            this.icbtnInventarioJ.Size = new System.Drawing.Size(140, 130);
            this.icbtnInventarioJ.TabIndex = 9;
            this.icbtnInventarioJ.Text = "Inventario";
            this.icbtnInventarioJ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.icbtnInventarioJ.UseVisualStyleBackColor = false;
            this.icbtnInventarioJ.Click += new System.EventHandler(this.icbtnInventarioJ_Click);
            // 
            // pnlContenedorJ
            // 
            this.pnlContenedorJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorJ.Location = new System.Drawing.Point(182, 89);
            this.pnlContenedorJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContenedorJ.Name = "pnlContenedorJ";
            this.pnlContenedorJ.Size = new System.Drawing.Size(1564, 660);
            this.pnlContenedorJ.TabIndex = 2;
            // 
            // pnlBarraSuperior
            // 
            this.pnlBarraSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBarraSuperior.Controls.Add(this.pbAjustes);
            this.pnlBarraSuperior.Controls.Add(this.lblTituloUsuarios);
            this.pnlBarraSuperior.Controls.Add(this.lblTituloInventarioJ);
            this.pnlBarraSuperior.Controls.Add(this.lblTituloSolicitudJ);
            this.pnlBarraSuperior.Controls.Add(this.lblTituloConsumoJ);
            this.pnlBarraSuperior.Location = new System.Drawing.Point(182, 2);
            this.pnlBarraSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Size = new System.Drawing.Size(1564, 83);
            this.pnlBarraSuperior.TabIndex = 3;
            this.pnlBarraSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraSuperior_Paint);
            this.pnlBarraSuperior.Resize += new System.EventHandler(this.pnlBarraSuperior_Resize);
            // 
            // pbAjustes
            // 
            this.pbAjustes.Image = global::Vistas.Properties.Resources.icons8_ajustes_50;
            this.pbAjustes.Location = new System.Drawing.Point(1498, 20);
            this.pbAjustes.Name = "pbAjustes";
            this.pbAjustes.Size = new System.Drawing.Size(57, 50);
            this.pbAjustes.TabIndex = 4;
            this.pbAjustes.TabStop = false;
            this.pbAjustes.Click += new System.EventHandler(this.pbAjustes_Click);
            // 
            // lblTituloUsuarios
            // 
            this.lblTituloUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloUsuarios.AutoSize = true;
            this.lblTituloUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloUsuarios.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblTituloUsuarios.Location = new System.Drawing.Point(707, 33);
            this.lblTituloUsuarios.Name = "lblTituloUsuarios";
            this.lblTituloUsuarios.Size = new System.Drawing.Size(181, 47);
            this.lblTituloUsuarios.TabIndex = 3;
            this.lblTituloUsuarios.Text = "Usuarios";
            this.lblTituloUsuarios.Visible = false;
            // 
            // lblTituloInventarioJ
            // 
            this.lblTituloInventarioJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloInventarioJ.AutoSize = true;
            this.lblTituloInventarioJ.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloInventarioJ.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInventarioJ.ForeColor = System.Drawing.Color.White;
            this.lblTituloInventarioJ.Location = new System.Drawing.Point(707, 20);
            this.lblTituloInventarioJ.Name = "lblTituloInventarioJ";
            this.lblTituloInventarioJ.Size = new System.Drawing.Size(214, 47);
            this.lblTituloInventarioJ.TabIndex = 0;
            this.lblTituloInventarioJ.Text = "Inventario";
            this.lblTituloInventarioJ.Visible = false;
            // 
            // lblTituloSolicitudJ
            // 
            this.lblTituloSolicitudJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloSolicitudJ.AutoSize = true;
            this.lblTituloSolicitudJ.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloSolicitudJ.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSolicitudJ.ForeColor = System.Drawing.Color.White;
            this.lblTituloSolicitudJ.Location = new System.Drawing.Point(695, 20);
            this.lblTituloSolicitudJ.Name = "lblTituloSolicitudJ";
            this.lblTituloSolicitudJ.Size = new System.Drawing.Size(229, 47);
            this.lblTituloSolicitudJ.TabIndex = 2;
            this.lblTituloSolicitudJ.Text = "Solicitudes";
            this.lblTituloSolicitudJ.Visible = false;
            // 
            // lblTituloConsumoJ
            // 
            this.lblTituloConsumoJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloConsumoJ.AutoSize = true;
            this.lblTituloConsumoJ.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloConsumoJ.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConsumoJ.ForeColor = System.Drawing.Color.White;
            this.lblTituloConsumoJ.Location = new System.Drawing.Point(707, 20);
            this.lblTituloConsumoJ.Name = "lblTituloConsumoJ";
            this.lblTituloConsumoJ.Size = new System.Drawing.Size(207, 47);
            this.lblTituloConsumoJ.TabIndex = 1;
            this.lblTituloConsumoJ.Text = "Consumo";
            this.lblTituloConsumoJ.Visible = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pbLogoITEC);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogo.Location = new System.Drawing.Point(3, 3);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(173, 81);
            this.pnlLogo.TabIndex = 4;
            // 
            // pbLogoITEC
            // 
            this.pbLogoITEC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogoITEC.Image = global::Vistas.Properties.Resources.Group_4;
            this.pbLogoITEC.Location = new System.Drawing.Point(3, 0);
            this.pbLogoITEC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogoITEC.Name = "pbLogoITEC";
            this.pbLogoITEC.Size = new System.Drawing.Size(171, 79);
            this.pbLogoITEC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoITEC.TabIndex = 1;
            this.pbLogoITEC.TabStop = false;
            this.pbLogoITEC.Paint += new System.Windows.Forms.PaintEventHandler(this.pbLogoITEC_Paint);
            this.pbLogoITEC.Resize += new System.EventHandler(this.pbLogoITEC_Resize);
            // 
            // frmMenuJefatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1749, 751);
            this.Controls.Add(this.tlpMenuDIT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1699, 798);
            this.Name = "frmMenuJefatura";
            this.Text = "frmMenuJefatura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuJefatura_Load);
            this.tlpMenuDIT.ResumeLayout(false);
            this.pnlBarraLateral.ResumeLayout(false);
            this.pnlBarraSuperior.ResumeLayout(false);
            this.pnlBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAjustes)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoITEC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMenuDIT;
        private System.Windows.Forms.Panel pnlBarraLateral;
        private FontAwesome.Sharp.IconButton icbtnConsumoJ;
        private FontAwesome.Sharp.IconButton icbtnSolicitudesJ;
        private FontAwesome.Sharp.IconButton icbtnInventarioJ;
        private System.Windows.Forms.Panel pnlContenedorJ;
        private System.Windows.Forms.Panel pnlBarraSuperior;
        private System.Windows.Forms.Label lblTituloSolicitudJ;
        private System.Windows.Forms.Label lblTituloConsumoJ;
        private System.Windows.Forms.Label lblTituloInventarioJ;
        private System.Windows.Forms.PictureBox pbLogoITEC;
        private FontAwesome.Sharp.IconButton icbtnUsuario;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblTituloUsuarios;
        private System.Windows.Forms.PictureBox pbAjustes;
    }
}