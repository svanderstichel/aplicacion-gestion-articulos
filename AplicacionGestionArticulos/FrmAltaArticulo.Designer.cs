namespace AplicacionGestionArticulos
{
    partial class FrmAltaArticulo
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
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImagenCargada = new System.Windows.Forms.Label();
            this.lblCargarImagen = new System.Windows.Forms.Label();
            this.gbDatosArticulo = new System.Windows.Forms.GroupBox();
            this.gbClasificacion = new System.Windows.Forms.GroupBox();
            this.gbImagenes = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.gbDatosArticulo.SuspendLayout();
            this.gbClasificacion.SuspendLayout();
            this.gbImagenes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(130, 40);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(112, 19);
            this.txtCodigoProducto.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(402, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(112, 19);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(659, 40);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(132, 22);
            this.txtDescripcion.TabIndex = 3;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(72, 31);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(136, 21);
            this.cmbMarca.TabIndex = 4;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(379, 31);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(136, 21);
            this.cmbCategoria.TabIndex = 5;
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(657, 31);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(135, 19);
            this.numPrecio.TabIndex = 6;
            // 
            // picImagen
            // 
            this.picImagen.Location = new System.Drawing.Point(14, 112);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(307, 173);
            this.picImagen.TabIndex = 7;
            this.picImagen.TabStop = false;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(71, 32);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(172, 23);
            this.btnCargarImagen.TabIndex = 8;
            this.btnCargarImagen.Text = "Seleccionar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(485, 397);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(84, 23);
            this.Guardar.TabIndex = 9;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(680, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(10, 40);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(97, 13);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo Articulo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(276, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(101, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre Articulo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(567, 43);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 13);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(11, 31);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 13);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(277, 31);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(65, 13);
            this.lblCategoria.TabIndex = 15;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(568, 31);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 13);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblImagenCargada
            // 
            this.lblImagenCargada.AutoSize = true;
            this.lblImagenCargada.Location = new System.Drawing.Point(91, 80);
            this.lblImagenCargada.Name = "lblImagenCargada";
            this.lblImagenCargada.Size = new System.Drawing.Size(103, 13);
            this.lblImagenCargada.TabIndex = 17;
            this.lblImagenCargada.Text = "Imagen Cargada:";
            // 
            // lblCargarImagen
            // 
            this.lblCargarImagen.AutoSize = true;
            this.lblCargarImagen.Location = new System.Drawing.Point(695, 86);
            this.lblCargarImagen.Name = "lblCargarImagen";
            this.lblCargarImagen.Size = new System.Drawing.Size(0, 13);
            this.lblCargarImagen.TabIndex = 18;
            // 
            // gbDatosArticulo
            // 
            this.gbDatosArticulo.Controls.Add(this.txtNombre);
            this.gbDatosArticulo.Controls.Add(this.txtCodigoProducto);
            this.gbDatosArticulo.Controls.Add(this.txtDescripcion);
            this.gbDatosArticulo.Controls.Add(this.lblCodigo);
            this.gbDatosArticulo.Controls.Add(this.lblNombre);
            this.gbDatosArticulo.Controls.Add(this.lblDescripcion);
            this.gbDatosArticulo.Location = new System.Drawing.Point(55, 34);
            this.gbDatosArticulo.Name = "gbDatosArticulo";
            this.gbDatosArticulo.Size = new System.Drawing.Size(807, 127);
            this.gbDatosArticulo.TabIndex = 19;
            this.gbDatosArticulo.TabStop = false;
            this.gbDatosArticulo.Text = "Datos Articulo:";
            // 
            // gbClasificacion
            // 
            this.gbClasificacion.Controls.Add(this.cmbMarca);
            this.gbClasificacion.Controls.Add(this.cmbCategoria);
            this.gbClasificacion.Controls.Add(this.numPrecio);
            this.gbClasificacion.Controls.Add(this.lblMarca);
            this.gbClasificacion.Controls.Add(this.lblPrecio);
            this.gbClasificacion.Controls.Add(this.lblCategoria);
            this.gbClasificacion.Location = new System.Drawing.Point(55, 182);
            this.gbClasificacion.Name = "gbClasificacion";
            this.gbClasificacion.Size = new System.Drawing.Size(807, 71);
            this.gbClasificacion.TabIndex = 20;
            this.gbClasificacion.TabStop = false;
            this.gbClasificacion.Text = "Clasificacion Articulo";
            // 
            // gbImagenes
            // 
            this.gbImagenes.Controls.Add(this.btnCargarImagen);
            this.gbImagenes.Controls.Add(this.picImagen);
            this.gbImagenes.Controls.Add(this.lblCargarImagen);
            this.gbImagenes.Controls.Add(this.lblImagenCargada);
            this.gbImagenes.Location = new System.Drawing.Point(55, 324);
            this.gbImagenes.Name = "gbImagenes";
            this.gbImagenes.Size = new System.Drawing.Size(335, 314);
            this.gbImagenes.TabIndex = 21;
            this.gbImagenes.TabStop = false;
            this.gbImagenes.Text = "Imagenes";
            // 
            // FrmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1381, 796);
            this.Controls.Add(this.gbImagenes);
            this.Controls.Add(this.gbClasificacion);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbDatosArticulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FrmAltaArticulo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear nuevo artículo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.gbDatosArticulo.ResumeLayout(false);
            this.gbDatosArticulo.PerformLayout();
            this.gbClasificacion.ResumeLayout(false);
            this.gbClasificacion.PerformLayout();
            this.gbImagenes.ResumeLayout(false);
            this.gbImagenes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImagenCargada;
        private System.Windows.Forms.Label lblCargarImagen;
        private System.Windows.Forms.GroupBox gbDatosArticulo;
        private System.Windows.Forms.GroupBox gbClasificacion;
        private System.Windows.Forms.GroupBox gbImagenes;
    }
}