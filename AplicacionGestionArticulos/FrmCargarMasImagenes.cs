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

namespace AplicacionGestionArticulos
{
    public partial class FrmCargarMasImagenes : Form
    {
        public FrmCargarMasImagenes()
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
    }
}
