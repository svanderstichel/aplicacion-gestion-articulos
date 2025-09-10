namespace presentacion
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
            this.txtNombreArtículo = new System.Windows.Forms.TextBox();
            this.txtDescripcionArtículo = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.picImagenArticulo = new System.Windows.Forms.PictureBox();
            this.btnCargarImagenArticulo = new System.Windows.Forms.Button();
            this.GuardarImagen = new System.Windows.Forms.Button();
            this.btnCancelarImagenArticulo = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.picImagenArticulo)).BeginInit();
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
            this.txtCodigoProducto.TextChanged += new System.EventHandler(this.txtCodigoProducto_TextChanged);
            // 
            // txtNombreArtículo
            // 
            this.txtNombreArtículo.Location = new System.Drawing.Point(402, 40);
            this.txtNombreArtículo.Name = "txtNombreArtículo";
            this.txtNombreArtículo.Size = new System.Drawing.Size(112, 19);
            this.txtNombreArtículo.TabIndex = 2;
            // 
            // txtDescripcionArtículo
            // 
            this.txtDescripcionArtículo.Location = new System.Drawing.Point(659, 40);
            this.txtDescripcionArtículo.Multiline = true;
            this.txtDescripcionArtículo.Name = "txtDescripcionArtículo";
            this.txtDescripcionArtículo.Size = new System.Drawing.Size(132, 22);
            this.txtDescripcionArtículo.TabIndex = 3;
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
            // picImagenArticulo
            // 
            this.picImagenArticulo.Location = new System.Drawing.Point(14, 112);
            this.picImagenArticulo.Name = "picImagenArticulo";
            this.picImagenArticulo.Size = new System.Drawing.Size(307, 173);
            this.picImagenArticulo.TabIndex = 7;
            this.picImagenArticulo.TabStop = false;
            // 
            // btnCargarImagenArticulo
            // 
            this.btnCargarImagenArticulo.Location = new System.Drawing.Point(71, 32);
            this.btnCargarImagenArticulo.Name = "btnCargarImagenArticulo";
            this.btnCargarImagenArticulo.Size = new System.Drawing.Size(172, 23);
            this.btnCargarImagenArticulo.TabIndex = 8;
            this.btnCargarImagenArticulo.Text = "Seleccionar Imagen";
            this.btnCargarImagenArticulo.UseVisualStyleBackColor = true;
            // 
            // GuardarImagen
            // 
            this.GuardarImagen.Location = new System.Drawing.Point(485, 397);
            this.GuardarImagen.Name = "GuardarImagen";
            this.GuardarImagen.Size = new System.Drawing.Size(84, 23);
            this.GuardarImagen.TabIndex = 3;
            this.GuardarImagen.Text = "Guardar";
            this.GuardarImagen.UseVisualStyleBackColor = true;
            this.GuardarImagen.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // btnCancelarImagenArticulo
            // 
            this.btnCancelarImagenArticulo.Location = new System.Drawing.Point(680, 397);
            this.btnCancelarImagenArticulo.Name = "btnCancelarImagenArticulo";
            this.btnCancelarImagenArticulo.Size = new System.Drawing.Size(84, 23);
            this.btnCancelarImagenArticulo.TabIndex = 4;
            this.btnCancelarImagenArticulo.Text = "Cancelar";
            this.btnCancelarImagenArticulo.UseVisualStyleBackColor = true;
            this.btnCancelarImagenArticulo.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.lblPrecio.Location = new System.Drawing.Point(542, 34);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(103, 13);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "Precio en Pesos:";
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
            this.gbDatosArticulo.Controls.Add(this.txtNombreArtículo);
            this.gbDatosArticulo.Controls.Add(this.txtCodigoProducto);
            this.gbDatosArticulo.Controls.Add(this.txtDescripcionArtículo);
            this.gbDatosArticulo.Controls.Add(this.lblCodigo);
            this.gbDatosArticulo.Controls.Add(this.lblNombre);
            this.gbDatosArticulo.Controls.Add(this.lblDescripcion);
            this.gbDatosArticulo.Location = new System.Drawing.Point(55, 34);
            this.gbDatosArticulo.Name = "gbDatosArticulo";
            this.gbDatosArticulo.Size = new System.Drawing.Size(807, 127);
            this.gbDatosArticulo.TabIndex = 0;
            this.gbDatosArticulo.TabStop = false;
            this.gbDatosArticulo.Text = "Datos Articulo";
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
            this.gbClasificacion.TabIndex = 1;
            this.gbClasificacion.TabStop = false;
            this.gbClasificacion.Text = "Clasificacion Articulo";
            // 
            // gbImagenes
            // 
            this.gbImagenes.Controls.Add(this.btnCargarImagenArticulo);
            this.gbImagenes.Controls.Add(this.picImagenArticulo);
            this.gbImagenes.Controls.Add(this.lblCargarImagen);
            this.gbImagenes.Controls.Add(this.lblImagenCargada);
            this.gbImagenes.Location = new System.Drawing.Point(55, 324);
            this.gbImagenes.Name = "gbImagenes";
            this.gbImagenes.Size = new System.Drawing.Size(335, 314);
            this.gbImagenes.TabIndex = 2;
            this.gbImagenes.TabStop = false;
            this.gbImagenes.Text = "Imagenes del Artículo";
            // 
            // FrmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.gbImagenes);
            this.Controls.Add(this.gbClasificacion);
            this.Controls.Add(this.GuardarImagen);
            this.Controls.Add(this.btnCancelarImagenArticulo);
            this.Controls.Add(this.gbDatosArticulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FrmAltaArticulo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear nuevo artículo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenArticulo)).EndInit();
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
        private System.Windows.Forms.TextBox txtNombreArtículo;
        private System.Windows.Forms.TextBox txtDescripcionArtículo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.PictureBox picImagenArticulo;
        private System.Windows.Forms.Button btnCargarImagenArticulo;
        private System.Windows.Forms.Button GuardarImagen;
        private System.Windows.Forms.Button btnCancelarImagenArticulo;
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