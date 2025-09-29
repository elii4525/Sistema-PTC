namespace Vistas
{
    partial class frmAggMaterial
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvMaterialAgg = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAggRegistro = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarcas = new System.Windows.Forms.ComboBox();
            this.dtpFechaIng = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAggCategorias = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAggCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.pnlAggMarcas = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAggMarca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialAgg)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlAggCategorias.SuspendLayout();
            this.pnlAggMarcas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.15315F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.88733F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.11267F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(827, 699);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dgvMaterialAgg);
            this.panel4.Location = new System.Drawing.Point(0, 334);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(807, 365);
            this.panel4.TabIndex = 9;
            // 
            // dgvMaterialAgg
            // 
            this.dgvMaterialAgg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaterialAgg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialAgg.Location = new System.Drawing.Point(20, 14);
            this.dgvMaterialAgg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMaterialAgg.Name = "dgvMaterialAgg";
            this.dgvMaterialAgg.RowHeadersWidth = 51;
            this.dgvMaterialAgg.RowTemplate.Height = 24;
            this.dgvMaterialAgg.Size = new System.Drawing.Size(772, 330);
            this.dgvMaterialAgg.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnAggRegistro);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbCategoria);
            this.panel2.Controls.Add(this.cbMarcas);
            this.panel2.Controls.Add(this.dtpFechaIng);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.txtModelo);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 334);
            this.panel2.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(216)))), ((int)(((byte)(112)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(664, 31);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 39);
            this.btnLimpiar.TabIndex = 46;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(32, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "Nombre:";
            // 
            // btnAggRegistro
            // 
            this.btnAggRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(216)))), ((int)(((byte)(112)))));
            this.btnAggRegistro.FlatAppearance.BorderSize = 0;
            this.btnAggRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggRegistro.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggRegistro.Location = new System.Drawing.Point(664, 102);
            this.btnAggRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAggRegistro.Name = "btnAggRegistro";
            this.btnAggRegistro.Size = new System.Drawing.Size(119, 39);
            this.btnAggRegistro.TabIndex = 45;
            this.btnAggRegistro.Text = "Agregar";
            this.btnAggRegistro.UseVisualStyleBackColor = false;
            this.btnAggRegistro.Click += new System.EventHandler(this.btnAggRegistro_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(32, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "Marca:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(205, 159);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(247, 24);
            this.cbCategoria.TabIndex = 44;
            // 
            // cbMarcas
            // 
            this.cbMarcas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarcas.FormattingEnabled = true;
            this.cbMarcas.Location = new System.Drawing.Point(205, 63);
            this.cbMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMarcas.Name = "cbMarcas";
            this.cbMarcas.Size = new System.Drawing.Size(247, 24);
            this.cbMarcas.TabIndex = 43;
            // 
            // dtpFechaIng
            // 
            this.dtpFechaIng.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFechaIng.Location = new System.Drawing.Point(205, 254);
            this.dtpFechaIng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaIng.Name = "dtpFechaIng";
            this.dtpFechaIng.Size = new System.Drawing.Size(289, 22);
            this.dtpFechaIng.TabIndex = 42;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCantidad.Location = new System.Drawing.Point(205, 294);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(247, 22);
            this.txtCantidad.TabIndex = 41;
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtModelo.Location = new System.Drawing.Point(205, 112);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(247, 22);
            this.txtModelo.TabIndex = 40;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescripcion.Location = new System.Drawing.Point(205, 209);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(433, 22);
            this.txtDescripcion.TabIndex = 39;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Location = new System.Drawing.Point(205, 21);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 22);
            this.txtNombre.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(32, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "Fecha de Ingreso:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(32, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 19);
            this.label12.TabIndex = 34;
            this.label12.Text = "Cantidad:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(32, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 19);
            this.label13.TabIndex = 37;
            this.label13.Text = "Categoría:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(32, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 19);
            this.label14.TabIndex = 36;
            this.label14.Text = "Descripción:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(32, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 19);
            this.label15.TabIndex = 32;
            this.label15.Text = "Modelo:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pnlAggCategorias, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlAggMarcas, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(827, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 407F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(737, 699);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // pnlAggCategorias
            // 
            this.pnlAggCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAggCategorias.BackColor = System.Drawing.Color.Black;
            this.pnlAggCategorias.Controls.Add(this.label5);
            this.pnlAggCategorias.Controls.Add(this.btnAggCategoria);
            this.pnlAggCategorias.Controls.Add(this.label1);
            this.pnlAggCategorias.Controls.Add(this.txtCategoria);
            this.pnlAggCategorias.Location = new System.Drawing.Point(3, 2);
            this.pnlAggCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAggCategorias.Name = "pnlAggCategorias";
            this.pnlAggCategorias.Size = new System.Drawing.Size(731, 287);
            this.pnlAggCategorias.TabIndex = 0;
            this.pnlAggCategorias.Resize += new System.EventHandler(this.pnlAggCategorias_Resize);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(268, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Agregar Categorías";
            // 
            // btnAggCategoria
            // 
            this.btnAggCategoria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAggCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(216)))), ((int)(((byte)(112)))));
            this.btnAggCategoria.FlatAppearance.BorderSize = 0;
            this.btnAggCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggCategoria.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnAggCategoria.Location = new System.Drawing.Point(490, 110);
            this.btnAggCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAggCategoria.Name = "btnAggCategoria";
            this.btnAggCategoria.Size = new System.Drawing.Size(188, 46);
            this.btnAggCategoria.TabIndex = 4;
            this.btnAggCategoria.Text = "Agregar";
            this.btnAggCategoria.UseVisualStyleBackColor = false;
            this.btnAggCategoria.Click += new System.EventHandler(this.btnAggCategoria_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 122);
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
            this.txtCategoria.Location = new System.Drawing.Point(84, 176);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(269, 34);
            this.txtCategoria.TabIndex = 0;
            // 
            // pnlAggMarcas
            // 
            this.pnlAggMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAggMarcas.BackColor = System.Drawing.Color.Black;
            this.pnlAggMarcas.Controls.Add(this.label6);
            this.pnlAggMarcas.Controls.Add(this.btnAggMarca);
            this.pnlAggMarcas.Controls.Add(this.label2);
            this.pnlAggMarcas.Controls.Add(this.txtMarca);
            this.pnlAggMarcas.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAggMarcas.ForeColor = System.Drawing.Color.White;
            this.pnlAggMarcas.Location = new System.Drawing.Point(3, 294);
            this.pnlAggMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 10);
            this.pnlAggMarcas.Name = "pnlAggMarcas";
            this.pnlAggMarcas.Size = new System.Drawing.Size(731, 395);
            this.pnlAggMarcas.TabIndex = 1;
            this.pnlAggMarcas.Resize += new System.EventHandler(this.pnlAggMarcas_Resize);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(303, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Agregar Marcas";
            // 
            // btnAggMarca
            // 
            this.btnAggMarca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAggMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(216)))), ((int)(((byte)(112)))));
            this.btnAggMarca.FlatAppearance.BorderSize = 0;
            this.btnAggMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggMarca.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggMarca.ForeColor = System.Drawing.Color.Black;
            this.btnAggMarca.Location = new System.Drawing.Point(490, 142);
            this.btnAggMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAggMarca.Name = "btnAggMarca";
            this.btnAggMarca.Size = new System.Drawing.Size(188, 46);
            this.btnAggMarca.TabIndex = 5;
            this.btnAggMarca.Text = "Agregar";
            this.btnAggMarca.UseVisualStyleBackColor = false;
            this.btnAggMarca.Click += new System.EventHandler(this.btnAggMarca_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 94);
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
            this.txtMarca.Location = new System.Drawing.Point(102, 150);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(269, 36);
            this.txtMarca.TabIndex = 0;
            // 
            // frmAggMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "frmAggMaterial";
            this.Size = new System.Drawing.Size(1564, 699);
            this.Load += new System.EventHandler(this.frmAggMaterial_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialAgg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlAggCategorias.ResumeLayout(false);
            this.pnlAggCategorias.PerformLayout();
            this.pnlAggMarcas.ResumeLayout(false);
            this.pnlAggMarcas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAggRegistro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbMarcas;
        private System.Windows.Forms.DateTimePicker dtpFechaIng;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlAggCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Panel pnlAggMarcas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnAggCategoria;
        private System.Windows.Forms.Button btnAggMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvMaterialAgg;
    }
}
