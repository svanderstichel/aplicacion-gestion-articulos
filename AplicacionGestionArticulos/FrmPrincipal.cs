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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //genera ventana bienvenida al iniciar el programa
            FrmBienvenida frmBienvenida = new FrmBienvenida();
            frmBienvenida.MdiParent = this;
            frmBienvenida.Show();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        //verifica que la tabla no exista antes de instanciarla
        foreach (var item in Application.OpenForms)
        {
                if (item.GetType() == typeof(FrmAltaArticulo))
                {
                    MessageBox.Show ("Ya existe una ventaba abierta, complete los campos");
                 return;
                }
               
        }
        // Cierro todos las ventanas abiertas
        foreach (Form form in this.MdiChildren)
        {
            form.Close();
        }
            //instancia ventana de alta articulo
            FrmAltaArticulo frmAltaArticulo = new FrmAltaArticulo();
        frmAltaArticulo.MdiParent = this;
        frmAltaArticulo.Show();
        }

        private void bienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verifica que la tabla no exista antes de instanciarla
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmBienvenida))
                {
                    MessageBox.Show("Ya existe una ventaba abierta, complete los campos");
                    return;
                }
            }
            // Cierro todos las ventanas abiertas
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            //instancia ventana de bienvenida
            FrmBienvenida frmBienvenida = new FrmBienvenida();
            frmBienvenida.MdiParent = this;
            frmBienvenida.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        { 
                //verifica que la tabla no exista antes de instanciarla
                foreach (var item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(FrmModificarArticulo))
                {
                    MessageBox.Show("Ya existe una ventaba abierta, complete los campos");
                    return;
                }
            }
                // Cierro todos las ventanas abiertas
                foreach (Form form in this.MdiChildren)
                {
                    form.Close();
                }
                //instancia ventana de modificar articulo
                FrmModificarArticulo frmModificarArticulo = new FrmModificarArticulo();
                frmModificarArticulo.MdiParent = this;
                frmModificarArticulo.Show();
            }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verifica que la tabla no exista antes de instanciarla
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmListarArticulo))
                {
                    MessageBox.Show("Ya existe una ventaba abierta, complete los campos");
                    return;
                }
            }
            // Cierro todos las ventanas abiertas
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            //instancia ventana de modificar articulo
            FrmListarArticulo frmListarArticulo = new FrmListarArticulo();
            frmListarArticulo.MdiParent = this;
            frmListarArticulo.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verifica que la tabla no exista antes de instanciarla
            //foreach (var item in Application.OpenForms)
            // {
            // if (item.GetType() == typeof(frmMarcas)) 
            // {
            //MessageBox.Show("Ya existe una ventaba abierta, complete los campos");
            //return;
        //}
        //  }
        // Cierro todos las ventanas abiertas
        //foreach (Form form in this.MdiChildren)
        // {
        // form.Close();
        //}
        //instancia ventana de modificar articulo
        //frmMarcas marca = new frmMarcas();
        //marca.MdiParent = this;
        // marca.Show ();



    }
    }
    }

