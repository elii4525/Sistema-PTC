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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.dgvMaterialesD = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiarB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.icbtnMarcaEli = new FontAwesome.Sharp.IconButton();
            this.icbtnCategoriaEli = new FontAwesome.Sharp.IconButton();
            this.icbtnMaterialEli = new FontAwesome.Sharp.IconButton();
            this.pnlAgg = new System.Windows.Forms.Panel();
            this.icbtnMarca = new FontAwesome.Sharp.IconButton();
            this.icbtnCategoria = new FontAwesome.Sharp.IconButton();
            this.icbtnMaterial = new FontAwesome.Sharp.IconButton();
            this.pnlContenedorPestañas = new System.Windows.Forms.Panel();
            this.icbtnActualizar = new FontAwesome.Sharp.IconButton();
            this.icbtnAgg = new FontAwesome.Sharp.IconButton();
            this.icbtnEliminar = new FontAwesome.Sharp.IconButton();
            this.tlpFrmInventario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesD)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlEliminar.SuspendLayout();
            this.pnlAgg.SuspendLayout();
            this.pnlContenedorPestañas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFrmInventario
            // 
            this.tlpFrmInventario.ColumnCount = 1;
            this.tlpFrmInventario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFrmInventario.Controls.Add(this.panel1, 0, 0);
            this.tlpFrmInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFrmInventario.Location = new System.Drawing.Point(0, 0);
            this.tlpFrmInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpFrmInventario.Name = "tlpFrmInventario";
            this.tlpFrmInventario.RowCount = 1;
            this.tlpFrmInventario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.725761F));
            this.tlpFrmInventario.Size = new System.Drawing.Size(1546, 722);
            this.tlpFrmInventario.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pnlEliminar);
            this.panel1.Controls.Add(this.pnlAgg);
            this.panel1.Controls.Add(this.pnlContenedorPestañas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1546, 722);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.15152F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.84849F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1546, 651);
            this.tableLayoutPanel1.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblMarcas);
            this.panel2.Controls.Add(this.lblCategoria);
            this.panel2.Controls.Add(this.dgvMarcas);
            this.panel2.Controls.Add(this.dgvCategorias);
            this.panel2.Controls.Add(this.dgvMaterialesD);
            this.panel2.Location = new System.Drawing.Point(3, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1540, 579);
            this.panel2.TabIndex = 0;
            // 
            // lblMarcas
            // 
            this.lblMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.BackColor = System.Drawing.Color.Transparent;
            this.lblMarcas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.ForeColor = System.Drawing.Color.White;
            this.lblMarcas.Location = new System.Drawing.Point(1169, 283);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(85, 24);
            this.lblMarcas.TabIndex = 5;
            this.lblMarcas.Text = "Marcas";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(1136, 17);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(118, 24);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categorías";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(982, 321);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.RowTemplate.Height = 24;
            this.dgvMarcas.Size = new System.Drawing.Size(485, 214);
            this.dgvMarcas.TabIndex = 2;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(982, 61);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(485, 190);
            this.dgvCategorias.TabIndex = 1;
            // 
            // dgvMaterialesD
            // 
            this.dgvMaterialesD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaterialesD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialesD.Location = new System.Drawing.Point(31, 32);
            this.dgvMaterialesD.Name = "dgvMaterialesD";
            this.dgvMaterialesD.RowHeadersWidth = 51;
            this.dgvMaterialesD.RowTemplate.Height = 24;
            this.dgvMaterialesD.Size = new System.Drawing.Size(869, 503);
            this.dgvMaterialesD.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.btnLimpiarB);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1540, 60);
            this.panel3.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(216)))), ((int)(((byte)(112)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(616, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 34);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnLimpiarB
            // 
            this.btnLimpiarB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(216)))), ((int)(((byte)(112)))));
            this.btnLimpiarB.FlatAppearance.BorderSize = 0;
            this.btnLimpiarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarB.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarB.Location = new System.Drawing.Point(728, 14);
            this.btnLimpiarB.Name = "btnLimpiarB";
            this.btnLimpiarB.Size = new System.Drawing.Size(181, 37);
            this.btnLimpiarB.TabIndex = 7;
            this.btnLimpiarB.Text = "Limpiar búsqueda";
            this.btnLimpiarB.UseVisualStyleBackColor = false;
            this.btnLimpiarB.Click += new System.EventHandler(this.btnLimpiarB_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por Nombre:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(254, 20);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(192, 27);
            this.txtBuscar.TabIndex = 0;
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.pnlEliminar.Controls.Add(this.icbtnMarcaEli);
            this.pnlEliminar.Controls.Add(this.icbtnCategoriaEli);
            this.pnlEliminar.Controls.Add(this.icbtnMaterialEli);
            this.pnlEliminar.Location = new System.Drawing.Point(181, 71);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(164, 140);
            this.pnlEliminar.TabIndex = 50;
            this.pnlEliminar.Visible = false;
            // 
            // icbtnMarcaEli
            // 
            this.icbtnMarcaEli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.icbtnMarcaEli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbtnMarcaEli.FlatAppearance.BorderSize = 0;
            this.icbtnMarcaEli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.icbtnMarcaEli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.icbtnMarcaEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnMarcaEli.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnMarcaEli.ForeColor = System.Drawing.Color.White;
            this.icbtnMarcaEli.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icbtnMarcaEli.IconColor = System.Drawing.Color.White;
            this.icbtnMarcaEli.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnMarcaEli.IconSize = 33;
            this.icbtnMarcaEli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbtnMarcaEli.Location = new System.Drawing.Point(0, 98);
            this.icbtnMarcaEli.Margin = new System.Windows.Forms.Padding(10, 2, 3, 2);
            this.icbtnMarcaEli.Name = "icbtnMarcaEli";
            this.icbtnMarcaEli.Padding = new System.Windows.Forms.Padding(11, 0, 10, 0);
            this.icbtnMarcaEli.Size = new System.Drawing.Size(164, 42);
            this.icbtnMarcaEli.TabIndex = 9;
            this.icbtnMarcaEli.Text = "Marca";
            this.icbtnMarcaEli.UseVisualStyleBackColor = false;
            this.icbtnMarcaEli.Click += new System.EventHandler(this.icbtnMarcaEli_Click);
            // 
            // icbtnCategoriaEli
            // 
            this.icbtnCategoriaEli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.icbtnCategoriaEli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbtnCategoriaEli.FlatAppearance.BorderSize = 0;
            this.icbtnCategoriaEli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.icbtnCategoriaEli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.icbtnCategoriaEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnCategoriaEli.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnCategoriaEli.ForeColor = System.Drawing.Color.White;
            this.icbtnCategoriaEli.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icbtnCategoriaEli.IconColor = System.Drawing.Color.White;
            this.icbtnCategoriaEli.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnCategoriaEli.IconSize = 33;
            this.icbtnCategoriaEli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbtnCategoriaEli.Location = new System.Drawing.Point(0, 50);
            this.icbtnCategoriaEli.Margin = new System.Windows.Forms.Padding(10, 2, 3, 2);
            this.icbtnCategoriaEli.Name = "icbtnCategoriaEli";
            this.icbtnCategoriaEli.Padding = new System.Windows.Forms.Padding(11, 0, 10, 0);
            this.icbtnCategoriaEli.Size = new System.Drawing.Size(164, 42);
            this.icbtnCategoriaEli.TabIndex = 8;
            this.icbtnCategoriaEli.Text = "Categoría";
            this.icbtnCategoriaEli.UseVisualStyleBackColor = false;
            this.icbtnCategoriaEli.Click += new System.EventHandler(this.icbtnCategoriaEli_Click);
            // 
            // icbtnMaterialEli
            // 
            this.icbtnMaterialEli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.icbtnMaterialEli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbtnMaterialEli.FlatAppearance.BorderSize = 0;
            this.icbtnMaterialEli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.icbtnMaterialEli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.icbtnMaterialEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnMaterialEli.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnMaterialEli.ForeColor = System.Drawing.Color.White;
            this.icbtnMaterialEli.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icbtnMaterialEli.IconColor = System.Drawing.Color.White;
            this.icbtnMaterialEli.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnMaterialEli.IconSize = 33;
            this.icbtnMaterialEli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbtnMaterialEli.Location = new System.Drawing.Point(0, 2);
            this.icbtnMaterialEli.Margin = new System.Windows.Forms.Padding(10, 2, 3, 2);
            this.icbtnMaterialEli.Name = "icbtnMaterialEli";
            this.icbtnMaterialEli.Padding = new System.Windows.Forms.Padding(11, 0, 10, 0);
            this.icbtnMaterialEli.Size = new System.Drawing.Size(164, 42);
            this.icbtnMaterialEli.TabIndex = 7;
            this.icbtnMaterialEli.Text = "Material";
            this.icbtnMaterialEli.UseVisualStyleBackColor = false;
            this.icbtnMaterialEli.Click += new System.EventHandler(this.icbtnMaterialEli_Click);
            // 
            // pnlAgg
            // 
            this.pnlAgg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.pnlAgg.Controls.Add(this.icbtnMarca);
            this.pnlAgg.Controls.Add(this.icbtnCategoria);
            this.pnlAgg.Controls.Add(this.icbtnMaterial);
            this.pnlAgg.Location = new System.Drawing.Point(8, 71);
            this.pnlAgg.Name = "pnlAgg";
            this.pnlAgg.Size = new System.Drawing.Size(164, 140);
            this.pnlAgg.TabIndex = 49;
            this.pnlAgg.Visible = false;
            // 
            // icbtnMarca
            // 
            this.icbtnMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.icbtnMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbtnMarca.FlatAppearance.BorderSize = 0;
            this.icbtnMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.icbtnMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.icbtnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnMarca.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnMarca.ForeColor = System.Drawing.Color.White;
            this.icbtnMarca.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icbtnMarca.IconColor = System.Drawing.Color.White;
            this.icbtnMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnMarca.IconSize = 33;
            this.icbtnMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbtnMarca.Location = new System.Drawing.Point(0, 98);
            this.icbtnMarca.Margin = new System.Windows.Forms.Padding(10, 2, 3, 2);
            this.icbtnMarca.Name = "icbtnMarca";
            this.icbtnMarca.Padding = new System.Windows.Forms.Padding(11, 0, 10, 0);
            this.icbtnMarca.Size = new System.Drawing.Size(164, 42);
            this.icbtnMarca.TabIndex = 9;
            this.icbtnMarca.Text = "Marca";
            this.icbtnMarca.UseVisualStyleBackColor = false;
            this.icbtnMarca.Click += new System.EventHandler(this.icbtnMarca_Click);
            // 
            // icbtnCategoria
            // 
            this.icbtnCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.icbtnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbtnCategoria.FlatAppearance.BorderSize = 0;
            this.icbtnCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.icbtnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.icbtnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnCategoria.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnCategoria.ForeColor = System.Drawing.Color.White;
            this.icbtnCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icbtnCategoria.IconColor = System.Drawing.Color.White;
            this.icbtnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnCategoria.IconSize = 33;
            this.icbtnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbtnCategoria.Location = new System.Drawing.Point(0, 50);
            this.icbtnCategoria.Margin = new System.Windows.Forms.Padding(10, 2, 3, 2);
            this.icbtnCategoria.Name = "icbtnCategoria";
            this.icbtnCategoria.Padding = new System.Windows.Forms.Padding(11, 0, 10, 0);
            this.icbtnCategoria.Size = new System.Drawing.Size(164, 42);
            this.icbtnCategoria.TabIndex = 8;
            this.icbtnCategoria.Text = "Categoría";
            this.icbtnCategoria.UseVisualStyleBackColor = false;
            this.icbtnCategoria.Click += new System.EventHandler(this.icbtnCategoria_Click);
            // 
            // icbtnMaterial
            // 
            this.icbtnMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.icbtnMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbtnMaterial.FlatAppearance.BorderSize = 0;
            this.icbtnMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.icbtnMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.icbtnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnMaterial.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnMaterial.ForeColor = System.Drawing.Color.White;
            this.icbtnMaterial.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icbtnMaterial.IconColor = System.Drawing.Color.White;
            this.icbtnMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnMaterial.IconSize = 33;
            this.icbtnMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbtnMaterial.Location = new System.Drawing.Point(0, 2);
            this.icbtnMaterial.Margin = new System.Windows.Forms.Padding(10, 2, 3, 2);
            this.icbtnMaterial.Name = "icbtnMaterial";
            this.icbtnMaterial.Padding = new System.Windows.Forms.Padding(11, 0, 10, 0);
            this.icbtnMaterial.Size = new System.Drawing.Size(164, 42);
            this.icbtnMaterial.TabIndex = 7;
            this.icbtnMaterial.Text = "Material";
            this.icbtnMaterial.UseVisualStyleBackColor = false;
            this.icbtnMaterial.Click += new System.EventHandler(this.icbtnMaterial_Click);
            // 
            // pnlContenedorPestañas
            // 
            this.pnlContenedorPestañas.BackColor = System.Drawing.Color.Black;
            this.pnlContenedorPestañas.Controls.Add(this.icbtnActualizar);
            this.pnlContenedorPestañas.Controls.Add(this.icbtnAgg);
            this.pnlContenedorPestañas.Controls.Add(this.icbtnEliminar);
            this.pnlContenedorPestañas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContenedorPestañas.ForeColor = System.Drawing.Color.White;
            this.pnlContenedorPestañas.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorPestañas.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContenedorPestañas.Name = "pnlContenedorPestañas";
            this.pnlContenedorPestañas.Size = new System.Drawing.Size(1546, 71);
            this.pnlContenedorPestañas.TabIndex = 48;
            // 
            // icbtnActualizar
            // 
            this.icbtnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.icbtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbtnActualizar.FlatAppearance.BorderSize = 0;
            this.icbtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.icbtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.icbtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnActualizar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnActualizar.ForeColor = System.Drawing.Color.White;
            this.icbtnActualizar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icbtnActualizar.IconColor = System.Drawing.Color.White;
            this.icbtnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnActualizar.IconSize = 33;
            this.icbtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbtnActualizar.Location = new System.Drawing.Point(351, 0);
            this.icbtnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icbtnActualizar.Name = "icbtnActualizar";
            this.icbtnActualizar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.icbtnActualizar.Size = new System.Drawing.Size(164, 63);
            this.icbtnActualizar.TabIndex = 7;
            this.icbtnActualizar.Text = "Actualizar";
            this.icbtnActualizar.UseVisualStyleBackColor = false;
            this.icbtnActualizar.Click += new System.EventHandler(this.icbtnActualizar_Click);
            this.icbtnActualizar.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.icbtnActualizar.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // icbtnAgg
            // 
            this.icbtnAgg.BackColor = System.Drawing.Color.Transparent;
            this.icbtnAgg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbtnAgg.FlatAppearance.BorderSize = 0;
            this.icbtnAgg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.icbtnAgg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.icbtnAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnAgg.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnAgg.ForeColor = System.Drawing.Color.White;
            this.icbtnAgg.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.icbtnAgg.IconColor = System.Drawing.Color.White;
            this.icbtnAgg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnAgg.IconSize = 33;
            this.icbtnAgg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbtnAgg.Location = new System.Drawing.Point(8, 0);
            this.icbtnAgg.Margin = new System.Windows.Forms.Padding(10, 2, 3, 2);
            this.icbtnAgg.Name = "icbtnAgg";
            this.icbtnAgg.Padding = new System.Windows.Forms.Padding(11, 0, 10, 0);
            this.icbtnAgg.Size = new System.Drawing.Size(164, 63);
            this.icbtnAgg.TabIndex = 6;
            this.icbtnAgg.Text = "Agregar";
            this.icbtnAgg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnAgg.UseVisualStyleBackColor = false;
            this.icbtnAgg.Click += new System.EventHandler(this.icbtnAgg_Click);
            this.icbtnAgg.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.icbtnAgg.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // icbtnEliminar
            // 
            this.icbtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.icbtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbtnEliminar.FlatAppearance.BorderSize = 0;
            this.icbtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.icbtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.icbtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtnEliminar.ForeColor = System.Drawing.Color.White;
            this.icbtnEliminar.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.icbtnEliminar.IconColor = System.Drawing.Color.White;
            this.icbtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnEliminar.IconSize = 33;
            this.icbtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbtnEliminar.Location = new System.Drawing.Point(181, 0);
            this.icbtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icbtnEliminar.Name = "icbtnEliminar";
            this.icbtnEliminar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.icbtnEliminar.Size = new System.Drawing.Size(164, 63);
            this.icbtnEliminar.TabIndex = 6;
            this.icbtnEliminar.Text = "Eliminar";
            this.icbtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnEliminar.UseVisualStyleBackColor = false;
            this.icbtnEliminar.Click += new System.EventHandler(this.icbtnEliminar_Click);
            this.icbtnEliminar.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.icbtnEliminar.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // frmInventarioDIT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1546, 722);
            this.Controls.Add(this.tlpFrmInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmInventarioDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInventarioDIT_Load);
            this.tlpFrmInventario.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlEliminar.ResumeLayout(false);
            this.pnlAgg.ResumeLayout(false);
            this.pnlContenedorPestañas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpFrmInventario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlContenedorPestañas;
        private FontAwesome.Sharp.IconButton icbtnAgg;
        private FontAwesome.Sharp.IconButton icbtnEliminar;
        private System.Windows.Forms.Panel pnlAgg;
        private FontAwesome.Sharp.IconButton icbtnMaterial;
        private FontAwesome.Sharp.IconButton icbtnMarca;
        private FontAwesome.Sharp.IconButton icbtnCategoria;
        private System.Windows.Forms.Panel pnlEliminar;
        private FontAwesome.Sharp.IconButton icbtnMarcaEli;
        private FontAwesome.Sharp.IconButton icbtnCategoriaEli;
        private FontAwesome.Sharp.IconButton icbtnMaterialEli;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMaterialesD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnLimpiarB;
        private System.Windows.Forms.Button btnBuscar;
        private FontAwesome.Sharp.IconButton icbtnActualizar;
    }
}