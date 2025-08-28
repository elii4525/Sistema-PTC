namespace Vistas
{
    partial class frmListaInventario
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
            this.components = new System.ComponentModel.Container();
            this.timerMenuPleg = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControlControlesP1 = new Vistas.ControlesPersonalizados.UserControlControlesP();
            this.txtPersonad = new Vistas.ControlesPersonalizados.UserControlControlesP();
            this.userControlControlesP2 = new Vistas.ControlesPersonalizados.UserControlControlesP();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMenuPleg
            // 
            this.timerMenuPleg.Interval = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1242, 645);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.userControlControlesP2);
            this.panel1.Controls.Add(this.userControlControlesP1);
            this.panel1.Controls.Add(this.txtPersonad);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 315);
            this.panel1.TabIndex = 0;
            // 
            // userControlControlesP1
            // 
            this.userControlControlesP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userControlControlesP1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userControlControlesP1.BorderSize = 2;
            this.userControlControlesP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlControlesP1.ForeColor = System.Drawing.Color.DimGray;
            this.userControlControlesP1.Location = new System.Drawing.Point(526, 62);
            this.userControlControlesP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlControlesP1.Multiline = false;
            this.userControlControlesP1.Name = "userControlControlesP1";
            this.userControlControlesP1.Padding = new System.Windows.Forms.Padding(7);
            this.userControlControlesP1.PasswordChar = false;
            this.userControlControlesP1.Size = new System.Drawing.Size(356, 35);
            this.userControlControlesP1.TabIndex = 1;
            this.userControlControlesP1.Texts = "";
            this.userControlControlesP1.UnderlineStyle = true;
            // 
            // txtPersonad
            // 
            this.txtPersonad.BackColor = System.Drawing.SystemColors.Window;
            this.txtPersonad.BorderColor = System.Drawing.Color.Red;
            this.txtPersonad.BorderSize = 2;
            this.txtPersonad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonad.ForeColor = System.Drawing.Color.DimGray;
            this.txtPersonad.Location = new System.Drawing.Point(738, 193);
            this.txtPersonad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPersonad.Multiline = false;
            this.txtPersonad.Name = "txtPersonad";
            this.txtPersonad.Padding = new System.Windows.Forms.Padding(7);
            this.txtPersonad.PasswordChar = false;
            this.txtPersonad.Size = new System.Drawing.Size(250, 35);
            this.txtPersonad.TabIndex = 2;
            this.txtPersonad.Texts = "";
            this.txtPersonad.UnderlineStyle = false;
            // 
            // userControlControlesP2
            // 
            this.userControlControlesP2.BackColor = System.Drawing.SystemColors.Window;
            this.userControlControlesP2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.userControlControlesP2.BorderSize = 2;
            this.userControlControlesP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlControlesP2.ForeColor = System.Drawing.Color.DimGray;
            this.userControlControlesP2.Location = new System.Drawing.Point(102, 144);
            this.userControlControlesP2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlControlesP2.Multiline = true;
            this.userControlControlesP2.Name = "userControlControlesP2";
            this.userControlControlesP2.Padding = new System.Windows.Forms.Padding(7);
            this.userControlControlesP2.PasswordChar = false;
            this.userControlControlesP2.Size = new System.Drawing.Size(450, 99);
            this.userControlControlesP2.TabIndex = 1;
            this.userControlControlesP2.Texts = "";
            this.userControlControlesP2.UnderlineStyle = false;
            // 
            // frmListaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmListaInventario";
            this.Size = new System.Drawing.Size(1242, 645);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerMenuPleg;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private ControlesPersonalizados.UserControlControlesP txtPersonad;
        private ControlesPersonalizados.UserControlControlesP userControlControlesP1;
        private ControlesPersonalizados.UserControlControlesP userControlControlesP2;
    }
}
