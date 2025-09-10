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

namespace presentacion
{
    

    public partial class FrmAltaArticulo : Form
    { 
        public FrmAltaArticulo()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)

        { 
            
            Articulo articulo = new Articulo();
            AltaArticuloNegocio alta = new AltaArticuloNegocio();

            try
            {
                articulo.CodigoArticulo = int.Parse(txtCodigoProducto.Text);
                articulo.Nombre = txtNombreArtículo.Text;
                articulo.Descripcion = txtDescripcionArtículo.Text;

                alta.agregar(articulo);
                MessageBox.Show("Artículo agregado exitosamente!");
                Close();
                FrmPrincipal volver = new FrmPrincipal();
                volver.ShowDialog();

            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.ToString());
            }
            
        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPrincipal volver = new FrmPrincipal  ();
            volver.ShowDialog();
        }
    }
}
