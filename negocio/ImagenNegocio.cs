using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using negocio;


namespace negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> ListarImagen(int idArticulo)
        {
            List <Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Id, IdArticulo, UrlImagen FROM Imagenes WHERE IdArticulo = @IdArticulo");
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.ejercutarLectura();

                while (datos.lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.IdImagen = (int)datos.lector["Id"];
                    aux.IdArticulo = (int)datos.lector["IdArticulo"];
                    aux.Url = (string)datos.lector["UrlImagen"];
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
        public void Agregar(Imagen nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO Imagenes (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @UrlImagen)");
                datos.setearParametro("@IdArticulo", nueva.IdArticulo);
                datos.setearParametro("@UrlImagen", nueva.Url);
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
