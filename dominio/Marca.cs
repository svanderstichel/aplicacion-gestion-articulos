using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Marca
    {
        public int IdMarca {  get; set; }
        public string Nombre { get; set; }

        // agregue el usuario para que se pueda saber quien cargo el dato
        public string UsuarioCarga { get; }    

    }
}
