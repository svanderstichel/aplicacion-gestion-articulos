using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace negocio
{
    public class AltaArticuloNegocio
    {

        public List<Articulo> alta()
        {
            return new List<Articulo>();

        }
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion )values ('" + nuevo.CodigoArticulo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "')");
                datos.ejercutarLectura();

            }

            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }
        public void modificar(Articulo modificar) { }

    }

}

