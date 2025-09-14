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
            this.gpbDatoArticulo.Location = new System.Drawing.Point(29, 24);
            this.gpbDatoArticulo.Name = "gpbDatoArticulo";
            this.gpbDatoArticulo.Size = new System.Drawing.Size(644, 54);
            this.gpbDatoArticulo.TabIndex = 0;
            this.gpbDatoArticulo.TabStop = false;
            this.gpbDatoArticulo.Text = "Dato Artìculo";
            // 
            // texCodArtMasImagen
            // 
            this.texCodArtMasImagen.Location = new System.Drawing.Point(306, 19);
            this.texCodArtMasImagen.Name = "texCodArtMasImagen";
            this.texCodArtMasImagen.Size = new System.Drawing.Size(100, 20);
            this.texCodArtMasImagen.TabIndex = 1;
            // 
            // lblCodMasImagen
            // 
            this.lblCodMasImagen.AutoSize = true;
            this.lblCodMasImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodMasImagen.Location = new System.Drawing.Point(151, 22);
            this.lblCodMasImagen.Name = "lblCodMasImagen";
            this.lblCodMasImagen.Size = new System.Drawing.Size(149, 13);
            this.lblCodMasImagen.TabIndex = 0;
            this.lblCodMasImagen.Text = "Identificador de Artículo:";
            // 
            // btnCargarMasImagen
            // 
            this.btnCargarMasImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMasImagen.Location = new System.Drawing.Point(416, 401);
            this.btnCargarMasImagen.Name = "btnCargarMasImagen";
            this.btnCargarMasImagen.Size = new System.Drawing.Size(92, 37);
            this.btnCargarMasImagen.TabIndex = 2;
            this.btnCargarMasImagen.Text = "Cargar";
            this.btnCargarMasImagen.UseVisualStyleBackColor = true;
            this.btnCargarMasImagen.Click += new System.EventHandler(this.btnCargarMasImagen_Click);
            // 
            // btnCancelarMasImagen
            // 
            this.btnCancelarMasImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarMasImagen.Location = new System.Drawing.Point(580, 401);
            this.btnCancelarMasImagen.Name = "btnCancelarMasImagen";
            this.btnCancelarMasImagen.Size = new System.Drawing.Size(93, 37);
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
            this.gpbCargarMasImagen.Location = new System.Drawing.Point(29, 84);
            this.gpbCargarMasImagen.Name = "gpbCargarMasImagen";
            this.gpbCargarMasImagen.Size = new System.Drawing.Size(644, 311);
            this.gpbCargarMasImagen.TabIndex = 1;
            this.gpbCargarMasImagen.TabStop = false;
            this.gpbCargarMasImagen.Text = "Datos Imagen";
            // 
            // picImagenCargarMas
            // 
            this.picImagenCargarMas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picImagenCargarMas.Location = new System.Drawing.Point(387, 64);
            this.picImagenCargarMas.Name = "picImagenCargarMas";
            this.picImagenCargarMas.Size = new System.Drawing.Size(237, 241);
            this.picImagenCargarMas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagenCargarMas.TabIndex = 8;
            this.picImagenCargarMas.TabStop = false;
            this.picImagenCargarMas.Click += new System.EventHandler(this.picImagenCargarMas_Click);
            // 
            // lblVistaImagen
            // 
            this.lblVistaImagen.AutoSize = true;
            this.lblVistaImagen.Location = new System.Drawing.Point(251, 64);
            this.lblVistaImagen.Name = "lblVistaImagen";
            this.lblVistaImagen.Size = new System.Drawing.Size(116, 13);
            this.lblVistaImagen.TabIndex = 5;
            this.lblVistaImagen.Text = "Vista de la Imagen:";
            this.lblVistaImagen.Click += new System.EventHandler(this.lblVistaImagen_Click);
            // 
            // lblCargarUrlMasImagen
            // 
            this.lblCargarUrlMasImagen.AutoSize = true;
            this.lblCargarUrlMasImagen.Location = new System.Drawing.Point(6, 35);
            this.lblCargarUrlMasImagen.Name = "lblCargarUrlMasImagen";
            this.lblCargarUrlMasImagen.Size = new System.Drawing.Size(122, 13);
            this.lblCargarUrlMasImagen.TabIndex = 1;
            this.lblCargarUrlMasImagen.Text = "Cargar URL Imagen:";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(130, 28);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(494, 20);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtUrl.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // FrmImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelarMasImagen);
            this.Controls.Add(this.btnCargarMasImagen);
            this.Controls.Add(this.gpbDatoArticulo);
            this.Controls.Add(this.gpbCargarMasImagen);
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