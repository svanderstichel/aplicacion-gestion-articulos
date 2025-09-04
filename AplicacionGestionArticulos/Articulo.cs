using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionGestionArticulos
{
    internal class Articulo
    {
        public int CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public Image Imagen { get; set; }
        public decimal Precio { get; set; }
    }
}
