namespace Vistas.Formularios
{
    partial class frmBienvenidoDIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenidoDIT));
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVer = new System.Windows.Forms.Label();
            this.icbtnInventario = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVerSoli = new System.Windows.Forms.Label();
            this.icbtnSol = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblVerConsumo = new System.Windows.Forms.Label();
            this.icbtnConsumo = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(464, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(685, 69);
            this.label2.TabIndex = 0;
            this.label2.Text = "¿Qué desea hacer hoy?";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.25272F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.71698F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.28302F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1580, 310);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 224);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1574, 84);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1574, 96);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(595, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡Bienvenido!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vistas.Properties.Resources.Group_4;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 310);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1580, 460);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblVer);
            this.panel3.Controls.Add(this.icbtnInventario);
            this.panel3.Location = new System.Drawing.Point(95, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 411);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(105, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Inventario";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(45, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 58);
            this.label6.TabIndex = 2;
            this.label6.Text = "Articulos en DIT, actualizar materiales.";
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.BackColor = System.Drawing.Color.Transparent;
            this.lblVer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVer.ForeColor = System.Drawing.Color.White;
            this.lblVer.Location = new System.Drawing.Point(151, 47);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(43, 23);
            this.lblVer.TabIndex = 1;
            this.lblVer.Text = "Ver";
            this.lblVer.Click += new System.EventHandler(this.lblVer_Click);
            this.lblVer.MouseLeave += new System.EventHandler(this.lblVer_MouseLeave);
            this.lblVer.MouseHover += new System.EventHandler(this.lblVer_MouseHover);
            // 
            // icbtnInventario
            // 
            this.icbtnInventario.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            this.icbtnInventario.IconColor = System.Drawing.Color.Black;
            this.icbtnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnInventario.IconSize = 125;
            this.icbtnInventario.Location = new System.Drawing.Point(77, 78);
            this.icbtnInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icbtnInventario.Name = "icbtnInventario";
            this.icbtnInventario.Size = new System.Drawing.Size(181, 164);
            this.icbtnInventario.TabIndex = 0;
            this.icbtnInventario.UseVisualStyleBackColor = true;
            this.icbtnInventario.Click += new System.EventHandler(this.icbtnInventario_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lblVerSoli);
            this.panel4.Controls.Add(this.icbtnSol);
            this.panel4.Location = new System.Drawing.Point(621, 24);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(335, 411);
            this.panel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(105, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Solicitudes";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 73);
            this.label5.TabIndex = 3;
            this.label5.Text = "Solicitudes a jefatura por necesidad de articulos en DIT.";
            // 
            // lblVerSoli
            // 
            this.lblVerSoli.AutoSize = true;
            this.lblVerSoli.BackColor = System.Drawing.Color.Transparent;
            this.lblVerSoli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerSoli.ForeColor = System.Drawing.Color.White;
            this.lblVerSoli.Location = new System.Drawing.Point(147, 47);
            this.lblVerSoli.Name = "lblVerSoli";
            this.lblVerSoli.Size = new System.Drawing.Size(43, 23);
            this.lblVerSoli.TabIndex = 2;
            this.lblVerSoli.Text = "Ver";
            this.lblVerSoli.Click += new System.EventHandler(this.lblVerSoli_Click);
            this.lblVerSoli.MouseLeave += new System.EventHandler(this.lblVerSoli_MouseLeave);
            this.lblVerSoli.MouseHover += new System.EventHandler(this.lblVerSoli_MouseHover);
            // 
            // icbtnSol
            // 
            this.icbtnSol.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.icbtnSol.IconColor = System.Drawing.Color.Black;
            this.icbtnSol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnSol.IconSize = 125;
            this.icbtnSol.Location = new System.Drawing.Point(79, 80);
            this.icbtnSol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icbtnSol.Name = "icbtnSol";
            this.icbtnSol.Size = new System.Drawing.Size(181, 164);
            this.icbtnSol.TabIndex = 0;
            this.icbtnSol.UseVisualStyleBackColor = true;
            this.icbtnSol.Click += new System.EventHandler(this.icbtnSol_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.lblVerConsumo);
            this.panel5.Controls.Add(this.icbtnConsumo);
            this.panel5.Location = new System.Drawing.Point(1148, 24);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(335, 411);
            this.panel5.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(112, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Consumo";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(56, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 58);
            this.label11.TabIndex = 5;
            this.label11.Text = "Comparacion de gastos entre meses.";
            // 
            // lblVerConsumo
            // 
            this.lblVerConsumo.AutoSize = true;
            this.lblVerConsumo.BackColor = System.Drawing.Color.Transparent;
            this.lblVerConsumo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerConsumo.ForeColor = System.Drawing.Color.White;
            this.lblVerConsumo.Location = new System.Drawing.Point(155, 47);
            this.lblVerConsumo.Name = "lblVerConsumo";
            this.lblVerConsumo.Size = new System.Drawing.Size(43, 23);
            this.lblVerConsumo.TabIndex = 5;
            this.lblVerConsumo.Text = "Ver";
            this.lblVerConsumo.MouseLeave += new System.EventHandler(this.lblVerConsumo_MouseLeave);
            this.lblVerConsumo.MouseHover += new System.EventHandler(this.lblVerConsumo_MouseHover);
            // 
            // icbtnConsumo
            // 
            this.icbtnConsumo.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.icbtnConsumo.IconColor = System.Drawing.Color.Black;
            this.icbtnConsumo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnConsumo.IconSize = 125;
            this.icbtnConsumo.Location = new System.Drawing.Point(81, 80);
            this.icbtnConsumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icbtnConsumo.Name = "icbtnConsumo";
            this.icbtnConsumo.Size = new System.Drawing.Size(181, 164);
            this.icbtnConsumo.TabIndex = 0;
            this.icbtnConsumo.UseVisualStyleBackColor = true;
            this.icbtnConsumo.Click += new System.EventHandler(this.icbtnConsumo_Click);
            // 
            // frmBienvenidoDIT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1580, 770);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1598, 787);
            this.Name = "frmBienvenidoDIT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton icbtnInventario;
        private FontAwesome.Sharp.IconButton icbtnSol;
        private FontAwesome.Sharp.IconButton icbtnConsumo;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVerSoli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblVerConsumo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}