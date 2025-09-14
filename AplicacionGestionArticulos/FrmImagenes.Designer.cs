namespace AplicacionGestionArticulos
{
    partial class FrmImagenes
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
            this.gpbDatoArticulo = new System.Windows.Forms.GroupBox();
            this.texCodArtMasImagen = new System.Windows.Forms.TextBox();
            this.lblCodMasImagen = new System.Windows.Forms.Label();
            this.btnCargarMasImagen = new System.Windows.Forms.Button();
            this.btnCancelarMasImagen = new System.Windows.Forms.Button();
            this.gpbCargarMasImagen = new System.Windows.Forms.GroupBox();
            this.picImagenCargarMas = new System.Windows.Forms.PictureBox();
            this.lblVistaImagen = new System.Windows.Forms.Label();
            this.lblCargarUrlMasImagen = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.gpbDatoArticulo.SuspendLayout();
            this.gpbCargarMasImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenCargarMas)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDatoArticulo
            // 
            this.gpbDatoArticulo.Controls.Add(this.texCodArtMasImagen);
            this.gpbDatoArticulo.Controls.Add(this.lblCodMasImagen);
            this.gpbDatoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatoArticulo.Location = new System.Drawing.Point(39, 30);
            this.gpbDatoArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbDatoArticulo.Name = "gpbDatoArticulo";
            this.gpbDatoArticulo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbDatoArticulo.Size = new System.Drawing.Size(859, 66);
            this.gpbDatoArticulo.TabIndex = 0;
            this.gpbDatoArticulo.TabStop = false;
            this.gpbDatoArticulo.Text = "Dato Artìculo";
            // 
            // texCodArtMasImagen
            // 
            this.texCodArtMasImagen.Location = new System.Drawing.Point(408, 23);
            this.texCodArtMasImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.texCodArtMasImagen.Name = "texCodArtMasImagen";
            this.texCodArtMasImagen.Size = new System.Drawing.Size(132, 23);
            this.texCodArtMasImagen.TabIndex = 1;
            // 
            // lblCodMasImagen
            // 
            this.lblCodMasImagen.AutoSize = true;
            this.lblCodMasImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodMasImagen.Location = new System.Drawing.Point(225, 27);
            this.lblCodMasImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodMasImagen.Name = "lblCodMasImagen";
            this.lblCodMasImagen.Size = new System.Drawing.Size(146, 17);
            this.lblCodMasImagen.TabIndex = 0;
            this.lblCodMasImagen.Text = "Còdigo de Artìculo:";
            // 
            // btnCargarMasImagen
            // 
            this.btnCargarMasImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMasImagen.Location = new System.Drawing.Point(555, 494);
            this.btnCargarMasImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarMasImagen.Name = "btnCargarMasImagen";
            this.btnCargarMasImagen.Size = new System.Drawing.Size(123, 46);
            this.btnCargarMasImagen.TabIndex = 2;
            this.btnCargarMasImagen.Text = "Cargar";
            this.btnCargarMasImagen.UseVisualStyleBackColor = true;
            this.btnCargarMasImagen.Click += new System.EventHandler(this.btnCargarMasImagen_Click);
            // 
            // btnCancelarMasImagen
            // 
            this.btnCancelarMasImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarMasImagen.Location = new System.Drawing.Point(773, 494);
            this.btnCancelarMasImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarMasImagen.Name = "btnCancelarMasImagen";
            this.btnCancelarMasImagen.Size = new System.Drawing.Size(124, 46);
            this.btnCancelarMasImagen.TabIndex = 3;
            this.btnCancelarMasImagen.Text = "Cancelar";
            this.btnCancelarMasImagen.UseVisualStyleBackColor = true;
            this.btnCancelarMasImagen.Click += new System.EventHandler(this.btnCancelarMasImagen_Click);
            // 
            // gpbCargarMasImagen
            // 
            this.gpbCargarMasImagen.Controls.Add(this.picImagenCargarMas);
            this.gpbCargarMasImagen.Controls.Add(this.lblVistaImagen);
            this.gpbCargarMasImagen.Controls.Add(this.lblCargarUrlMasImagen);
            this.gpbCargarMasImagen.Controls.Add(this.txtUrl);
            this.gpbCargarMasImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCargarMasImagen.Location = new System.Drawing.Point(39, 103);
            this.gpbCargarMasImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbCargarMasImagen.Name = "gpbCargarMasImagen";
            this.gpbCargarMasImagen.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbCargarMasImagen.Size = new System.Drawing.Size(859, 383);
            this.gpbCargarMasImagen.TabIndex = 1;
            this.gpbCargarMasImagen.TabStop = false;
            this.gpbCargarMasImagen.Text = "Datos Imagen";
            // 
            // picImagenCargarMas
            // 
            this.picImagenCargarMas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picImagenCargarMas.Location = new System.Drawing.Point(516, 79);
            this.picImagenCargarMas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picImagenCargarMas.Name = "picImagenCargarMas";
            this.picImagenCargarMas.Size = new System.Drawing.Size(316, 297);
            this.picImagenCargarMas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagenCargarMas.TabIndex = 8;
            this.picImagenCargarMas.TabStop = false;
            this.picImagenCargarMas.Click += new System.EventHandler(this.picImagenCargarMas_Click);
            // 
            // lblVistaImagen
            // 
            this.lblVistaImagen.AutoSize = true;
            this.lblVistaImagen.Location = new System.Drawing.Point(335, 79);
            this.lblVistaImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVistaImagen.Name = "lblVistaImagen";
            this.lblVistaImagen.Size = new System.Drawing.Size(147, 17);
            this.lblVistaImagen.TabIndex = 5;
            this.lblVistaImagen.Text = "Vista de la Imagen:";
            this.lblVistaImagen.Click += new System.EventHandler(this.lblVistaImagen_Click);
            // 
            // lblCargarUrlMasImagen
            // 
            this.lblCargarUrlMasImagen.AutoSize = true;
            this.lblCargarUrlMasImagen.Location = new System.Drawing.Point(8, 43);
            this.lblCargarUrlMasImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargarUrlMasImagen.Name = "lblCargarUrlMasImagen";
            this.lblCargarUrlMasImagen.Size = new System.Drawing.Size(155, 17);
            this.lblCargarUrlMasImagen.TabIndex = 1;
            this.lblCargarUrlMasImagen.Text = "Cargar URL Imagen:";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(173, 34);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(657, 23);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtUrl.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // FrmImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCancelarMasImagen);
            this.Controls.Add(this.btnCargarMasImagen);
            this.Controls.Add(this.gpbDatoArticulo);
            this.Controls.Add(this.gpbCargarMasImagen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmImagenes";
            this.Text = "Cargar Mas Imagenes";
            this.Load += new System.EventHandler(this.FrmImagenes_Load);
            this.gpbDatoArticulo.ResumeLayout(false);
            this.gpbDatoArticulo.PerformLayout();
            this.gpbCargarMasImagen.ResumeLayout(false);
            this.gpbCargarMasImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenCargarMas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatoArticulo;
        private System.Windows.Forms.TextBox texCodArtMasImagen;
        private System.Windows.Forms.Label lblCodMasImagen;
        private System.Windows.Forms.Button btnCargarMasImagen;
        private System.Windows.Forms.Button btnCancelarMasImagen;
        private System.Windows.Forms.GroupBox gpbCargarMasImagen;
        private System.Windows.Forms.Label lblCargarUrlMasImagen;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblVistaImagen;
        private System.Windows.Forms.PictureBox picImagenCargarMas;
    }
}