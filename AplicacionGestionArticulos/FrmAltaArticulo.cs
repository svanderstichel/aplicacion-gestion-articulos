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
                articulo.CodigoArticulo = txtCodigoProducto.Text; // saque el casteo a int pues ahora es string en la clase
                articulo.Nombre = txtNombreArtículo.Text;
                articulo.Descripcion = txtDescripcionArtículo.Text;
                articulo.Marca = (Marca)cmbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cmbCategoria.SelectedItem;
                //articulo.Precio= 

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

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            try
            {
                cmbMarca.DataSource = marca.Listar();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            CategoriaNegocio categoria = new CategoriaNegocio();
                try
                {
                    cmbCategoria.DataSource = categoria.Listar();
           


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
        }

        


        

        private void gbClasificacion_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
