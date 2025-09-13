using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ModificarArticuloNegocio
    {
        public void Eliminar(int id)
        {
                AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id =  @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
