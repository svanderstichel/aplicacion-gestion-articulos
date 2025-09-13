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
        private bool cargando = true;
        public FrmListarArticulo()
        {
            InitializeComponent();
        }

        private void btnAgregarArticuloDesdeLista_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo alta = new FrmAltaArticulo();
            alta.ShowDialog();
        }

        private void FrmListarArticulo_Load(object sender, EventArgs e)
        {
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

            } catch (Exception Ex)
            {
                throw Ex;
            }
            
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
                listaFiltrada = listaArticulos.FindAll(articulo => Convert.ToString(articulo.Nombre) == filtro);
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
    }
}
