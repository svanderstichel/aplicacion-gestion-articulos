using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {

        [ DisplayName("Id Artìculo")]
        public int IdArticulo { get; set; }
        //public int CodigoArticulo { get; set; } en la BD està como Varchar. 
        [DisplayName("Còdigo Artìculo")]
        public string CodigoArticulo { get; set; } // Por eso lo agrego como string aqui
        public string Nombre { get; set; }
        [DisplayName("Descripciòn")]
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        [DisplayName("Categorìa")]
        public Categoria Categoria { get; set; }
        public List<Imagen> ListaImagenes { get; set; }
        public string imagen { get; set; }
        public decimal Precio { get; set; }
    }
}
