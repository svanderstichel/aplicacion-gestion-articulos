using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.ComponentModel.Design;



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
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio ) output inserted.Id values ('" + nuevo.CodigoArticulo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "', @IdMarca, @IdCategoria, '" + nuevo.Precio + "')");
                datos.setearParametro("@IdMarca", nuevo.Marca.IdMarca);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.IdCategoria);
                nuevo.IdArticulo=datos.BuscarDato();
                
                
                
            }

            catch (Exception )
            {

                throw ;
             

            }
            finally
            {   
                datos.cerrarConexion();
            }
            
            try
            {   
                datos.setearConsulta("Insert into IMAGENES values ('" + nuevo.IdArticulo + "','" + nuevo.imagen + "')");
                datos.ejecutarAccion();
                

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
    }
}

