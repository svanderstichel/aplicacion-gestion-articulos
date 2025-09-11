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
            MarcaNegocio negocio = new MarcaNegocio();
            //me traigo los datos desde la db
            listaMarcas = negocio.Listar();

            //los guardo en el data grid
            dgvMarcas.DataSource = listaMarcas;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void CargaIdMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonCargaMarca_Click(object sender, EventArgs e)
        {
            string nombre = txtCargarNombreMarca.Text;

          
        }
    }
}
