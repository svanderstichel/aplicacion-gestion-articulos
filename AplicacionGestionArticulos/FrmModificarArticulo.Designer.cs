namespace AplicacionGestionArticulos
{
    partial class FrmModificarArticulo
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
            this.gbDatosArticulo = new System.Windows.Forms.GroupBox();
            this.txtNombreModificar = new System.Windows.Forms.TextBox();
            this.txtCodigoProductoModificar = new System.Windows.Forms.TextBox();
            this.txtDescripcionModificar = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.gbClasificacion = new System.Windows.Forms.GroupBox();
            this.cmbMarcaModificar = new System.Windows.Forms.ComboBox();
            this.cmbCategoriaModificar = new System.Windows.Forms.ComboBox();
            this.numPrecioModificar = new System.Windows.Forms.NumericUpDown();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.gbImagenes = new System.Windows.Forms.GroupBox();
            this.btnCargarImagenModificar = new System.Windows.Forms.Button();
            this.picImagenModificar = new System.Windows.Forms.PictureBox();
            this.lblCargarImagen = new System.Windows.Forms.Label();
            this.lblImagenCargada = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelarModificar = new System.Windows.Forms.Button();
            this.gbDatosArticulo.SuspendLayout();
            this.gbClasificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioModificar)).BeginInit();
            this.gbImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosArticulo
            // 
            this.gbDatosArticulo.Controls.Add(this.txtNombreModificar);
            this.gbDatosArticulo.Controls.Add(this.txtCodigoProductoModificar);
            this.gbDatosArticulo.Controls.Add(this.txtDescripcionModificar);
            this.gbDatosArticulo.Controls.Add(this.lblCodigo);
            this.gbDatosArticulo.Controls.Add(this.lblNombre);
            this.gbDatosArticulo.Controls.Add(this.lblDescripcion);
            this.gbDatosArticulo.Location = new System.Drawing.Point(1, 12);
            this.gbDatosArticulo.Name = "gbDatosArticulo";
            this.gbDatosArticulo.Size = new System.Drawing.Size(908, 127);
            this.gbDatosArticulo.TabIndex = 20;
            this.gbDatosArticulo.TabStop = false;
            this.gbDatosArticulo.Text = "Datos Articulo:";
            // 
            // txtNombreModificar
            // 
            this.txtNombreModificar.Location = new System.Drawing.Point(452, 40);
            this.txtNombreModificar.Name = "txtNombreModificar";
            this.txtNombreModificar.Size = new System.Drawing.Size(126, 22);
            this.txtNombreModificar.TabIndex = 2;
            // 
            // txtCodigoProductoModificar
            // 
            this.txtCodigoProductoModificar.Location = new System.Drawing.Point(146, 40);
            this.txtCodigoProductoModificar.Name = "txtCodigoProductoModificar";
            this.txtCodigoProductoModificar.Size = new System.Drawing.Size(126, 22);
            this.txtCodigoProductoModificar.TabIndex = 0;
            // 
            // txtDescripcionModificar
            // 
            this.txtDescripcionModificar.Location = new System.Drawing.Point(741, 40);
            this.txtDescripcionModificar.Multiline = true;
            this.txtDescripcionModificar.Name = "txtDescripcionModificar";
            this.txtDescripcionModificar.Size = new System.Drawing.Size(148, 22);
            this.txtDescripcionModificar.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(11, 40);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(117, 16);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo Articulo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(310, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(122, 16);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre Articulo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(638, 43);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(94, 16);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // gbClasificacion
            // 
            this.gbClasificacion.Controls.Add(this.cmbMarcaModificar);
            this.gbClasificacion.Controls.Add(this.cmbCategoriaModificar);
            this.gbClasificacion.Controls.Add(this.numPrecioModificar);
            this.gbClasificacion.Controls.Add(this.lblMarca);
            this.gbClasificacion.Controls.Add(this.lblPrecio);
            this.gbClasificacion.Controls.Add(this.lblCategoria);
            this.gbClasificacion.Location = new System.Drawing.Point(1, 165);
            this.gbClasificacion.Name = "gbClasificacion";
            this.gbClasificacion.Size = new System.Drawing.Size(908, 71);
            this.gbClasificacion.TabIndex = 21;
            this.gbClasificacion.TabStop = false;
            this.gbClasificacion.Text = "Clasificacion Articulo";
            // 
            // cmbMarcaModificar
            // 
            this.cmbMarcaModificar.FormattingEnabled = true;
            this.cmbMarcaModificar.Location = new System.Drawing.Point(81, 31);
            this.cmbMarcaModificar.Name = "cmbMarcaModificar";
            this.cmbMarcaModificar.Size = new System.Drawing.Size(152, 24);
            this.cmbMarcaModificar.TabIndex = 4;
            // 
            // cmbCategoriaModificar
            // 
            this.cmbCategoriaModificar.FormattingEnabled = true;
            this.cmbCategoriaModificar.Location = new System.Drawing.Point(426, 31);
            this.cmbCategoriaModificar.Name = "cmbCategoriaModificar";
            this.cmbCategoriaModificar.Size = new System.Drawing.Size(152, 24);
            this.cmbCategoriaModificar.TabIndex = 5;
            // 
            // numPrecioModificar
            // 
            this.numPrecioModificar.Location = new System.Drawing.Point(739, 31);
            this.numPrecioModificar.Name = "numPrecioModificar";
            this.numPrecioModificar.Size = new System.Drawing.Size(152, 22);
            this.numPrecioModificar.TabIndex = 6;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 31);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(54, 16);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(639, 31);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 16);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(312, 31);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(79, 16);
            this.lblCategoria.TabIndex = 15;
            this.lblCategoria.Text = "Categoria:";
            // 
            // gbImagenes
            // 
            this.gbImagenes.Controls.Add(this.btnCargarImagenModificar);
            this.gbImagenes.Controls.Add(this.picImagenModificar);
            this.gbImagenes.Controls.Add(this.lblCargarImagen);
            this.gbImagenes.Controls.Add(this.lblImagenCargada);
            this.gbImagenes.Location = new System.Drawing.Point(1, 266);
            this.gbImagenes.Name = "gbImagenes";
            this.gbImagenes.Size = new System.Drawing.Size(377, 314);
            this.gbImagenes.TabIndex = 22;
            this.gbImagenes.TabStop = false;
            this.gbImagenes.Text = "Imagenes";
            // 
            // btnCargarImagenModificar
            // 
            this.btnCargarImagenModificar.Location = new System.Drawing.Point(80, 32);
            this.btnCargarImagenModificar.Name = "btnCargarImagenModificar";
            this.btnCargarImagenModificar.Size = new System.Drawing.Size(194, 23);
            this.btnCargarImagenModificar.TabIndex = 8;
            this.btnCargarImagenModificar.Text = "Seleccionar Imagen";
            this.btnCargarImagenModificar.UseVisualStyleBackColor = true;
            // 
            // picImagenModificar
            // 
            this.picImagenModificar.Location = new System.Drawing.Point(16, 112);
            this.picImagenModificar.Name = "picImagenModificar";
            this.picImagenModificar.Size = new System.Drawing.Size(345, 173);
            this.picImagenModificar.TabIndex = 7;
            this.picImagenModificar.TabStop = false;
            // 
            // lblCargarImagen
            // 
            this.lblCargarImagen.AutoSize = true;
            this.lblCargarImagen.Location = new System.Drawing.Point(782, 86);
            this.lblCargarImagen.Name = "lblCargarImagen";
            this.lblCargarImagen.Size = new System.Drawing.Size(0, 16);
            this.lblCargarImagen.TabIndex = 18;
            // 
            // lblImagenCargada
            // 
            this.lblImagenCargada.AutoSize = true;
            this.lblImagenCargada.Location = new System.Drawing.Point(102, 80);
            this.lblImagenCargada.Name = "lblImagenCargada";
            this.lblImagenCargada.Size = new System.Drawing.Size(126, 16);
            this.lblImagenCargada.TabIndex = 17;
            this.lblImagenCargada.Text = "Imagen Cargada:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(506, 352);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 23);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarModificar
            // 
            this.btnCancelarModificar.Location = new System.Drawing.Point(684, 352);
            this.btnCancelarModificar.Name = "btnCancelarModificar";
            this.btnCancelarModificar.Size = new System.Drawing.Size(84, 23);
            this.btnCancelarModificar.TabIndex = 24;
            this.btnCancelarModificar.Text = "Cancelar";
            this.btnCancelarModificar.UseVisualStyleBackColor = true;
            // 
            // FrmModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1251, 731);
            this.Controls.Add(this.btnCancelarModificar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gbImagenes);
            this.Controls.Add(this.gbClasificacion);
            this.Controls.Add(this.gbDatosArticulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FrmModificarArticulo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Articulo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbDatosArticulo.ResumeLayout(false);
            this.gbDatosArticulo.PerformLayout();
            this.gbClasificacion.ResumeLayout(false);
            this.gbClasificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioModificar)).EndInit();
            this.gbImagenes.ResumeLayout(false);
            this.gbImagenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenModificar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosArticulo;
        private System.Windows.Forms.TextBox txtNombreModificar;
        private System.Windows.Forms.TextBox txtCodigoProductoModificar;
        private System.Windows.Forms.TextBox txtDescripcionModificar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox gbClasificacion;
        private System.Windows.Forms.ComboBox cmbMarcaModificar;
        private System.Windows.Forms.ComboBox cmbCategoriaModificar;
        private System.Windows.Forms.NumericUpDown numPrecioModificar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.GroupBox gbImagenes;
        private System.Windows.Forms.Button btnCargarImagenModificar;
        private System.Windows.Forms.PictureBox picImagenModificar;
        private System.Windows.Forms.Label lblCargarImagen;
        private System.Windows.Forms.Label lblImagenCargada;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelarModificar;
    }
}