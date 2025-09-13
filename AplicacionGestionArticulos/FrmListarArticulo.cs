using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace presentacion
{
    public partial class FrmListarArticulo : Form
    {
        private List<Articulo> listaArticulos;
        private bool cargando;

        public FrmListarArticulo()
        {
            InitializeComponent();
        }

        private void btnAgregarArticuloDesdeLista_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo alta = new FrmAltaArticulo();
            alta.ShowDialog();
        }

        private void cargarDgv()
        {
            cargando = true;
            ListarArticuloNegocio negocio = new ListarArticuloNegocio();
            listaArticulos = negocio.ListarArticulos();
            dgvListadoArticulos.DataSource = listaArticulos;

            CategoriaNegocio categorias = new CategoriaNegocio();
            MarcaNegocio marcas = new MarcaNegocio();

            try
            {
                cmbCategoria.DataSource = categorias.Listar();
                cmbMarca.DataSource = marcas.Listar();
                cmbMarca.SelectedIndex = -1;
                cmbCategoria.SelectedIndex = -1;
                cargando = false;

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        private void FrmListarArticulo_Load(object sender, EventArgs e)
        {
            cargarDgv();
            
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            string filtro = cmbCategoria.Text;
            List<Articulo> listaFiltrada;
            listaFiltrada = listaArticulos.FindAll(articulo => Convert.ToString(articulo.Categoria) == filtro);
            dgvListadoArticulos.DataSource = listaFiltrada;
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            string filtro = cmbMarca.Text;
            List<Articulo> listaFiltrada;
            listaFiltrada = listaArticulos.FindAll(articulo => Convert.ToString(articulo.Marca) == filtro);
            dgvListadoArticulos.DataSource = listaFiltrada;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text;

            if (filtro != "")
            {
                List<Articulo> listaFiltrada;
                listaFiltrada = listaArticulos.FindAll(articulo => Convert.ToString(articulo.Nombre).ToUpper().Contains(filtro.ToUpper()));
                dgvListadoArticulos.DataSource = listaFiltrada;
            }
            else
            {
                dgvListadoArticulos.DataSource = listaArticulos;
            }
        }

        private void lblListadoArticulos_Click(object sender, EventArgs e)
        {

        }

        private void dgvListadoArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void botCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPrincipal volver = new FrmPrincipal();
            volver.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try 
            {
                DialogResult respuesta = MessageBox.Show("Eliminar registro de manera permanente?","Advertencia de eliminado f",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Articulo seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                    ModificarArticuloNegocio articuloNegocio = new ModificarArticuloNegocio();
                    articuloNegocio.Eliminar(seleccionado.IdArticulo);
                    cargarDgv();
                }
            }
            catch(Exception Ex)
            {
                throw Ex;
            }


        }
    }
}
