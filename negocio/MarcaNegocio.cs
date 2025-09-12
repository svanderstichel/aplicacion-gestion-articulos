using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatosMarca datos = new AccesoDatosMarca();
            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS ORDER BY Descripcion");
                datos.ejecutarLectura();

                while (datos.Lector.Read()) {
 
                    Marca aux = new Marca();
                    aux.IdMarca = (int)datos.Lector["Id"];
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
        public void Agregar(Marca nueva)
        {
            AccesoDatosMarca datos = new AccesoDatosMarca();

            try
            {
                datos.setearConsulta("INSERT INTO MARCAS (Descripcion)values(@Nombre)");
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
            try
            {
                AccesoDatosMarca datos = new AccesoDatosMarca();
                datos.setearConsulta("delete from MARCAS WHERE Id = @Id");
                datos.setearParametros("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
        }
    
    }
}
