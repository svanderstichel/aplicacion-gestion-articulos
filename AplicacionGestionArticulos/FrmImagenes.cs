using negocio;
using presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace AplicacionGestionArticulos
{
    public partial class FrmImagenes : Form
    {
        public FrmImagenes()
        {
            InitializeComponent();
        }

        private void lblVistaImagen_Click(object sender, EventArgs e)
        {

        }

        private void picImagenCargarMas_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarMasImagen_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPrincipal volver = new FrmPrincipal();
            volver.ShowDialog();
        }

        private void btnCargarMasImagen_Click(object sender, EventArgs e)
        {
            try
            {
                Imagen nueva = new Imagen();
                ImagenNegocio negocio = new ImagenNegocio();

                nueva.IdArticulo = int.Parse(texCodArtMasImagen.Text);
                nueva.Url = texCodArtMasImagen.Text;

                negocio.Agregar(nueva);

                MessageBox.Show("Imagen cargada exitosamente.");
                txtUrl.Clear();
                picImagenCargarMas.Image = null;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmImagenes_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrl.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                picImagenCargarMas.Load(imagen);
            }
            catch (Exception ex)
            {
                //picImagenCargarMas.Load();
            }
        }
    }
}
