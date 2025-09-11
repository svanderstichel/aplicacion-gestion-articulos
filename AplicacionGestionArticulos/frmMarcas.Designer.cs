namespace presentacion
{
    partial class FrmMarcas
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
            this.lblNombreMarca = new System.Windows.Forms.Label();
            this.txtCargarNombreMarca = new System.Windows.Forms.TextBox();
            this.BotonAceptarCargaMarca = new System.Windows.Forms.Button();
            this.BotonCancelarCargaMarca = new System.Windows.Forms.Button();
            this.BotonLimpiarDatosCargaMarca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreMarca
            // 
            this.lblNombreMarca.AutoSize = true;
            this.lblNombreMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMarca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombreMarca.Location = new System.Drawing.Point(36, 26);
            this.lblNombreMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMarca.Name = "lblNombreMarca";
            this.lblNombreMarca.Size = new System.Drawing.Size(108, 17);
            this.lblNombreMarca.TabIndex = 0;
            this.lblNombreMarca.Text = "Nueva marca:";
            this.lblNombreMarca.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // txtCargarNombreMarca
            // 
            this.txtCargarNombreMarca.Location = new System.Drawing.Point(159, 22);
            this.txtCargarNombreMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtCargarNombreMarca.Name = "txtCargarNombreMarca";
            this.txtCargarNombreMarca.Size = new System.Drawing.Size(240, 22);
            this.txtCargarNombreMarca.TabIndex = 1;
            this.txtCargarNombreMarca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BotonAceptarCargaMarca
            // 
            this.BotonAceptarCargaMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonAceptarCargaMarca.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BotonAceptarCargaMarca.FlatAppearance.BorderSize = 7;
            this.BotonAceptarCargaMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BotonAceptarCargaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAceptarCargaMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonAceptarCargaMarca.Location = new System.Drawing.Point(408, 15);
            this.BotonAceptarCargaMarca.Margin = new System.Windows.Forms.Padding(4);
            this.BotonAceptarCargaMarca.Name = "BotonAceptarCargaMarca";
            this.BotonAceptarCargaMarca.Size = new System.Drawing.Size(273, 36);
            this.BotonAceptarCargaMarca.TabIndex = 1;
            this.BotonAceptarCargaMarca.Text = "&Cargar nueva marca";
            this.BotonAceptarCargaMarca.UseVisualStyleBackColor = false;
            this.BotonAceptarCargaMarca.Click += new System.EventHandler(this.BotonAceptarCargaMarca_Click);
            // 
            // BotonCancelarCargaMarca
            // 
            this.BotonCancelarCargaMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonCancelarCargaMarca.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BotonCancelarCargaMarca.FlatAppearance.BorderSize = 7;
            this.BotonCancelarCargaMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BotonCancelarCargaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCancelarCargaMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonCancelarCargaMarca.Location = new System.Drawing.Point(721, 494);
            this.BotonCancelarCargaMarca.Margin = new System.Windows.Forms.Padding(4);
            this.BotonCancelarCargaMarca.Name = "BotonCancelarCargaMarca";
            this.BotonCancelarCargaMarca.Size = new System.Drawing.Size(129, 46);
            this.BotonCancelarCargaMarca.TabIndex = 2;
            this.BotonCancelarCargaMarca.Text = "&Cancelar";
            this.BotonCancelarCargaMarca.UseVisualStyleBackColor = false;
            // 
            // BotonLimpiarDatosCargaMarca
            // 
            this.BotonLimpiarDatosCargaMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonLimpiarDatosCargaMarca.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BotonLimpiarDatosCargaMarca.FlatAppearance.BorderSize = 7;
            this.BotonLimpiarDatosCargaMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BotonLimpiarDatosCargaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonLimpiarDatosCargaMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonLimpiarDatosCargaMarca.Location = new System.Drawing.Point(859, 494);
            this.BotonLimpiarDatosCargaMarca.Margin = new System.Windows.Forms.Padding(4);
            this.BotonLimpiarDatosCargaMarca.Name = "BotonLimpiarDatosCargaMarca";
            this.BotonLimpiarDatosCargaMarca.Size = new System.Drawing.Size(196, 46);
            this.BotonLimpiarDatosCargaMarca.TabIndex = 3;
            this.BotonLimpiarDatosCargaMarca.Text = "&Eliminar marca";
            this.BotonLimpiarDatosCargaMarca.UseVisualStyleBackColor = false;
            this.BotonLimpiarDatosCargaMarca.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMarcas);
            this.groupBox1.Location = new System.Drawing.Point(36, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(932, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de marcas";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(20, 37);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.Size = new System.Drawing.Size(904, 342);
            this.dgvMarcas.TabIndex = 0;
            // 
            // FrmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtCargarNombreMarca);
            this.Controls.Add(this.lblNombreMarca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BotonLimpiarDatosCargaMarca);
            this.Controls.Add(this.BotonCancelarCargaMarca);
            this.Controls.Add(this.BotonAceptarCargaMarca);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMarcas";
            this.ShowIcon = false;
            this.Text = "Administrar marcas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreMarca;
        private System.Windows.Forms.TextBox txtCargarNombreMarca;
        private System.Windows.Forms.Button BotonAceptarCargaMarca;
        private System.Windows.Forms.Button BotonCancelarCargaMarca;
        private System.Windows.Forms.Button BotonLimpiarDatosCargaMarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMarcas;
    }
}