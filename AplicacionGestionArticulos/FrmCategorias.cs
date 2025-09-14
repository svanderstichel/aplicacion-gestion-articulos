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
    public partial class FrmCategorias : Form
    {
        List<Categoria> listaCategoria;
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void botCancelar_Click(object sender, EventArgs e)
        {
            // cierro todos los formularios hijos abiertos
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                form.Close();
            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCategoria = negocio.Listar();
            dgvCategorias.DataSource = listaCategoria;
            dgvCategorias.Columns["IdCategoria"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                categoria.Nombre = txtNuevaCategoria.Text;
                negocio.Agregar(categoria);
                cargar();
                MessageBox.Show("Categoria agregada exitosamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro que queres eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.IdCategoria);
                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
