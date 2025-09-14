using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class FrmMarcas : Form
    {
        private List<Marca> listaMarcas;
        public FrmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            //me traigo los datos desde la db
            listaMarcas = negocio.Listar();
            //los guardo en el data grid
            dgvMarcas.DataSource = listaMarcas;
            dgvMarcas.Columns["IdMarca"].Visible =false;
        }


        private void BotonAceptarCargaMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                marca.Nombre = txtCargarNombreMarca.Text;

                negocio.Agregar(marca);
                cargar();
                MessageBox.Show("Agregado existosamente!");
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

          
        }

        private void BotonLimpiarDatosCargaMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro que queres eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.IdMarca);
                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BotonCancelarCargaMarca_Click(object sender, EventArgs e)
        {
            // cierro todos los formularios hijos abiertos
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                form.Close();
            }
        }

        private void txtCargarNombreMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
