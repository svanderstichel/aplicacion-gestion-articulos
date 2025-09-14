using dominio;
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
        public void Modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idmarca, IdCategoria = @idcategoria, Precio = @precio WHERE Id = @id");
                datos.setearParametro("@codigo",articulo.CodigoArticulo);
                datos.setearParametro("@nombre",articulo.Nombre);
                datos.setearParametro("@descripcion",articulo.Descripcion);
                datos.setearParametro("@idmarca",articulo.Marca.IdMarca);
                datos.setearParametro("@idcategoria",articulo.Categoria.IdCategoria);
                datos.setearParametro("@precio",articulo.Precio);
                datos.setearParametro("@id",articulo.IdArticulo);
                datos.ejecutarAccion();

            } 
            catch(Exception Ex)
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
