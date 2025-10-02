namespace Vistas.Formularios
{
    partial class frmSolicitudesAnteriores
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRedondeado2 = new Vistas.controles.ButtonRedondeado();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitudes anteriores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 649);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonRedondeado2
            // 
            this.buttonRedondeado2.BackColor = System.Drawing.Color.Black;
            this.buttonRedondeado2.BorderColor = System.Drawing.Color.White;
            this.buttonRedondeado2.BorderRadius = 18;
            this.buttonRedondeado2.BorderSize = 2;
            this.buttonRedondeado2.FlatAppearance.BorderSize = 0;
            this.buttonRedondeado2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRedondeado2.ForeColor = System.Drawing.Color.White;
            this.buttonRedondeado2.Location = new System.Drawing.Point(1154, 37);
            this.buttonRedondeado2.Name = "buttonRedondeado2";
            this.buttonRedondeado2.Size = new System.Drawing.Size(125, 50);
            this.buttonRedondeado2.TabIndex = 18;
            this.buttonRedondeado2.Text = "Regresar";
            this.buttonRedondeado2.UseVisualStyleBackColor = false;
            this.buttonRedondeado2.Click += new System.EventHandler(this.buttonRedondeado2_Click);
            // 
            // frmSolicitudesAnteriores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1317, 801);
            this.Controls.Add(this.buttonRedondeado2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(1335, 848);
            this.MinimumSize = new System.Drawing.Size(1335, 848);
            this.Name = "frmSolicitudesAnteriores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSolicitudesAnteriores";
            this.Load += new System.EventHandler(this.frmSolicitudesAnteriores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private controles.ButtonRedondeado buttonRedondeado2;
    }
}