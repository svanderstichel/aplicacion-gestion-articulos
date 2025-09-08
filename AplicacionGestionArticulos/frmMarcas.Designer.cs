namespace AplicacionGestionArticulos
{
    partial class Marcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marcas));
            this.lblNombreMarca = new System.Windows.Forms.Label();
            this.CargaNombreMarca = new System.Windows.Forms.TextBox();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.CargaIdMarca = new System.Windows.Forms.TextBox();
            this.BotonAceptarCargaMarca = new System.Windows.Forms.Button();
            this.BotonCancelarCargaMarca = new System.Windows.Forms.Button();
            this.BotonLimpiarDatosCargaMarca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buscarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreMarca
            // 
            this.lblNombreMarca.AutoSize = true;
            this.lblNombreMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMarca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombreMarca.Location = new System.Drawing.Point(54, 87);
            this.lblNombreMarca.Name = "lblNombreMarca";
            this.lblNombreMarca.Size = new System.Drawing.Size(77, 13);
            this.lblNombreMarca.TabIndex = 0;
            this.lblNombreMarca.Text = "Nombre Marca";
            this.lblNombreMarca.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // CargaNombreMarca
            // 
            this.CargaNombreMarca.Location = new System.Drawing.Point(194, 87);
            this.CargaNombreMarca.Name = "CargaNombreMarca";
            this.CargaNombreMarca.Size = new System.Drawing.Size(181, 20);
            this.CargaNombreMarca.TabIndex = 1;
            this.CargaNombreMarca.Text = "txtNombreMarca";
            this.CargaNombreMarca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIdMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMarca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIdMarca.Location = new System.Drawing.Point(54, 41);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(49, 13);
            this.lblIdMarca.TabIndex = 2;
            this.lblIdMarca.Text = "Id Marca";
            // 
            // CargaIdMarca
            // 
            this.CargaIdMarca.Location = new System.Drawing.Point(194, 43);
            this.CargaIdMarca.Name = "CargaIdMarca";
            this.CargaIdMarca.Size = new System.Drawing.Size(52, 20);
            this.CargaIdMarca.TabIndex = 0;
            this.CargaIdMarca.Text = "txtIdMarca";
            this.CargaIdMarca.TextChanged += new System.EventHandler(this.CargaIdMarca_TextChanged);
            // 
            // BotonAceptarCargaMarca
            // 
            this.BotonAceptarCargaMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonAceptarCargaMarca.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BotonAceptarCargaMarca.FlatAppearance.BorderSize = 7;
            this.BotonAceptarCargaMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BotonAceptarCargaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAceptarCargaMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonAceptarCargaMarca.Location = new System.Drawing.Point(426, 217);
            this.BotonAceptarCargaMarca.Name = "BotonAceptarCargaMarca";
            this.BotonAceptarCargaMarca.Size = new System.Drawing.Size(91, 36);
            this.BotonAceptarCargaMarca.TabIndex = 1;
            this.BotonAceptarCargaMarca.Text = "&Aceptar";
            this.BotonAceptarCargaMarca.UseVisualStyleBackColor = false;
            // 
            // BotonCancelarCargaMarca
            // 
            this.BotonCancelarCargaMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonCancelarCargaMarca.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BotonCancelarCargaMarca.FlatAppearance.BorderSize = 7;
            this.BotonCancelarCargaMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BotonCancelarCargaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCancelarCargaMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonCancelarCargaMarca.Location = new System.Drawing.Point(523, 216);
            this.BotonCancelarCargaMarca.Name = "BotonCancelarCargaMarca";
            this.BotonCancelarCargaMarca.Size = new System.Drawing.Size(97, 37);
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
            this.BotonLimpiarDatosCargaMarca.Location = new System.Drawing.Point(626, 216);
            this.BotonLimpiarDatosCargaMarca.Name = "BotonLimpiarDatosCargaMarca";
            this.BotonLimpiarDatosCargaMarca.Size = new System.Drawing.Size(147, 37);
            this.BotonLimpiarDatosCargaMarca.TabIndex = 3;
            this.BotonLimpiarDatosCargaMarca.Text = "Limpiar &Datos";
            this.BotonLimpiarDatosCargaMarca.UseVisualStyleBackColor = false;
            this.BotonLimpiarDatosCargaMarca.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CargaIdMarca);
            this.groupBox1.Controls.Add(this.lblIdMarca);
            this.groupBox1.Controls.Add(this.CargaNombreMarca);
            this.groupBox1.Controls.Add(this.lblNombreMarca);
            this.groupBox1.Location = new System.Drawing.Point(45, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Marca";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarMarcaToolStripMenuItem,
            this.listarMarcasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "Listado de Marcas";
            // 
            // buscarMarcaToolStripMenuItem
            // 
            this.buscarMarcaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarMarcaToolStripMenuItem.Image")));
            this.buscarMarcaToolStripMenuItem.Name = "buscarMarcaToolStripMenuItem";
            this.buscarMarcaToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.buscarMarcaToolStripMenuItem.Text = "&Buscar Marca";
            // 
            // listarMarcasToolStripMenuItem
            // 
            this.listarMarcasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarMarcasToolStripMenuItem.Image")));
            this.listarMarcasToolStripMenuItem.Name = "listarMarcasToolStripMenuItem";
            this.listarMarcasToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.listarMarcasToolStripMenuItem.Text = "&Listar Marcas";
            // 
            // Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BotonLimpiarDatosCargaMarca);
            this.Controls.Add(this.BotonCancelarCargaMarca);
            this.Controls.Add(this.BotonAceptarCargaMarca);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Marcas";
            this.Text = "CargarMarcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreMarca;
        private System.Windows.Forms.TextBox CargaNombreMarca;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.TextBox CargaIdMarca;
        private System.Windows.Forms.Button BotonAceptarCargaMarca;
        private System.Windows.Forms.Button BotonCancelarCargaMarca;
        private System.Windows.Forms.Button BotonLimpiarDatosCargaMarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buscarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMarcasToolStripMenuItem;
    }
}