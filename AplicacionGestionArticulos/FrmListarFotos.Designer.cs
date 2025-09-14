namespace AplicacionGestionArticulos
{
    partial class FrmListarFotos
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
            this.pcbFotosArticulos = new System.Windows.Forms.PictureBox();
            this.dgvFotos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotosArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbFotosArticulos
            // 
            this.pcbFotosArticulos.Location = new System.Drawing.Point(347, 61);
            this.pcbFotosArticulos.Name = "pcbFotosArticulos";
            this.pcbFotosArticulos.Size = new System.Drawing.Size(346, 321);
            this.pcbFotosArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFotosArticulos.TabIndex = 0;
            this.pcbFotosArticulos.TabStop = false;
            // 
            // dgvFotos
            // 
            this.dgvFotos.AllowUserToAddRows = false;
            this.dgvFotos.AllowUserToDeleteRows = false;
            this.dgvFotos.AllowUserToResizeColumns = false;
            this.dgvFotos.AllowUserToResizeRows = false;
            this.dgvFotos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvFotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFotos.Location = new System.Drawing.Point(43, 61);
            this.dgvFotos.Name = "dgvFotos";
            this.dgvFotos.ReadOnly = true;
            this.dgvFotos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFotos.Size = new System.Drawing.Size(215, 321);
            this.dgvFotos.TabIndex = 1;
            this.dgvFotos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFotos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imagenes";
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(343, 29);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(65, 20);
            this.lblArticulo.TabIndex = 3;
            this.lblArticulo.Text = "default";
            // 
            // FrmListarFotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFotos);
            this.Controls.Add(this.pcbFotosArticulos);
            this.Name = "FrmListarFotos";
            this.Text = "FrmListarFotos";
            this.Load += new System.EventHandler(this.FrmListarFotos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotosArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbFotosArticulos;
        private System.Windows.Forms.DataGridView dgvFotos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblArticulo;
    }
}