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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListaMaterial = new System.Windows.Forms.Button();
            this.btnAggMaterial = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.94452F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.05547F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1248, 703);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnAggMaterial);
            this.panel1.Controls.Add(this.btnListaMaterial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 85);
            this.panel1.TabIndex = 0;
            // 
            // btnListaMaterial
            // 
            this.btnListaMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListaMaterial.FlatAppearance.BorderSize = 0;
            this.btnListaMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaMaterial.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaMaterial.ForeColor = System.Drawing.Color.White;
            this.btnListaMaterial.Location = new System.Drawing.Point(-7, -3);
            this.btnListaMaterial.Name = "btnListaMaterial";
            this.btnListaMaterial.Size = new System.Drawing.Size(231, 85);
            this.btnListaMaterial.TabIndex = 0;
            this.btnListaMaterial.Text = "Lista de materiales";
            this.btnListaMaterial.UseVisualStyleBackColor = true;
            // 
            // btnAggMaterial
            // 
            this.btnAggMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAggMaterial.FlatAppearance.BorderSize = 0;
            this.btnAggMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggMaterial.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggMaterial.ForeColor = System.Drawing.Color.White;
            this.btnAggMaterial.Location = new System.Drawing.Point(223, -3);
            this.btnAggMaterial.Name = "btnAggMaterial";
            this.btnAggMaterial.Size = new System.Drawing.Size(234, 85);
            this.btnAggMaterial.TabIndex = 2;
            this.btnAggMaterial.Text = "Agregar material";
            this.btnAggMaterial.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Location = new System.Drawing.Point(1018, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 50);
            this.button6.TabIndex = 3;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // frmInventarioDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1248, 703);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmInventarioDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnAggMaterial;
        private System.Windows.Forms.Button btnListaMaterial;
    }
}