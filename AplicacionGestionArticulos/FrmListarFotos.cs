using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionGestionArticulos
{
    public partial class FrmListarFotos : Form
    {
        private Articulo articulo;
        public FrmListarFotos(Articulo articulo)
        {
            InitializeComponent();
            lblArticulo.Text = articulo.Nombre;
            this.articulo = articulo;
        }

        private void FrmListarFotos_Load(object sender, EventArgs e)
        {   
            ListarArticuloNegocio negocio = new ListarArticuloNegocio();
            List<Imagen> listaFotos = negocio.ListarFotos(articulo);
            dgvFotos.DataSource = listaFotos;
            dgvFotos.Columns["IdImagen"].Visible = false;
            dgvFotos.Columns["IdArticulo"].Visible = false;


            if (dgvFotos.Rows.Count > 0)
            {
                dgvFotos.ClearSelection();                     
                dgvFotos.Rows[0].Selected = true;              
                dgvFotos.CurrentCell = dgvFotos.Rows[0].Cells[1]; 
            }

            cargarImagen();
        }

        private void cargarImagen()
        {
            try
            {
                Imagen imagen = (Imagen)dgvFotos.CurrentRow.DataBoundItem;
                pcbFotosArticulos.Load(imagen.Url);
            }
            catch(Exception Ex)
            {
                pcbFotosArticulos.Load("https://th.bing.com/th/id/OIP.y4-StvPPKc3wQK2ULk-hIQAAAA?w=176&h=180&c=7&r=0&o=5&pid=1.7");
            }
        }

        private void dgvFotos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarImagen();
        }
    }
}
