using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionGestionArticulos;
using dominio;
using negocio;

namespace presentacion
{
    

    public partial class FrmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public FrmAltaArticulo()
        {
            InitializeComponent();
        }
        public FrmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

        }

        private void Guardar_Click(object sender, EventArgs e)

        { 
            
//            Articulo articulo = new Articulo();
            AltaArticuloNegocio alta = new AltaArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.CodigoArticulo = txtCodigoProducto.Text; // saque el casteo a int pues ahora es string en la clase
                articulo.Nombre = txtNombreArtículo.Text;
                articulo.Descripcion = txtDescripcionArtículo.Text;
                articulo.Marca = (Marca)cmbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cmbCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.imagen= texUrlimagen.Text;
                //articulo.ListaImagenes.Add();

                if (articulo.IdArticulo != 0)
                {
                    ModificarArticuloNegocio modificar = new ModificarArticuloNegocio();
                    modificar.Modificar(articulo);
                    MessageBox.Show("Artículo modificado exitosamente!");
                }
                else
                {
                    alta.agregar(articulo);
                    MessageBox.Show("Artículo agregado exitosamente!");
                }

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
            // cierro todos los formularios hijos abiertos
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                form.Close();
            }
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
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                cmbMarca.DataSource = marca.Listar();
                cmbMarca.ValueMember = "IdMarca";
                cmbMarca.DisplayMember = "Nombre";
                cmbCategoria.DataSource = categoria.Listar();
                cmbCategoria.ValueMember = "IdCategoria";
                cmbCategoria.DisplayMember = "Nombre";
                if (articulo != null)
                {
                    txtCodigoProducto.Text = articulo.CodigoArticulo;
                    txtNombreArtículo.Text = articulo.Nombre;
                    txtDescripcionArtículo.Text = articulo.Descripcion;
                    txtPrecio.Text = Convert.ToString(articulo.Precio);
                    cmbMarca.SelectedValue = articulo.Marca.IdMarca;
                    cmbCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        


        

        private void gbClasificacion_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtDescripcionArtículo_TextChanged(object sender, EventArgs e)
        {

        }

        private void numPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void texUrlimagen_Leave(object sender, EventArgs e)
        {
           
            cargarImagen(texUrlimagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                picImagenArticulo.Load(imagen);
            }
            catch (Exception )
            {

                picImagenArticulo.Load ("https://th.bing.com/th/id/OIP.y4-StvPPKc3wQK2ULk-hIQAAAA?w=176&h=180&c=7&r=0&o=5&pid=1.7");
            }
        
        
        
        }

        private void btnCargarMasImagenArticulo_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmImagenes volver = new FrmImagenes();
            volver.ShowDialog();
        }
    }






}
