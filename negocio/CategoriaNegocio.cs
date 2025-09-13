using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatosCategoria datos = new AccesoDatosCategoria();
            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS ORDER BY Descripcion");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Categoria aux = new Categoria();
                    aux.IdCategoria = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
                return lista;
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
        public void Agregar(Categoria nueva)
        {
            AccesoDatosCategoria datos = new AccesoDatosCategoria();

            try
            {
                datos.setearConsulta("INSERT INTO CATEGORIAS (Descripcion)values(@Nombre)");
                datos.setearParametros("@Nombre", nueva.Nombre);
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

        public void Eliminar(int id)
        {
            AccesoDatosCategoria datos = new AccesoDatosCategoria();
            try
            {
                datos.setearConsulta("Delete FROM Categorias WHERE Id = @Id");
                datos.setearParametros("@Id", id);
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
