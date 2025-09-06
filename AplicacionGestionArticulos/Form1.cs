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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show ("Organizá, encontrá y compartí tus artículos fácilmente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estás a un paso de sumar un nuevo artículo.");
            FrmAltaArticulo ventana = new FrmAltaArticulo();
            ventana.ShowDialog();
        }
    }
}
