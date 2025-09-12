using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        //public int CodigoArticulo { get; set; } en la BD està como Varchar. 
        public string CodigoArticulo { get; set; } // Por eso lo agrego como string aqui
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public List<Imagen> ListaImagenes { get; set; }
        public decimal Precio { get; set; }
    }
}
