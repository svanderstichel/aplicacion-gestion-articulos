using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class ListarArticuloNegocio
    {
        public List<Articulo> ListarArticulos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                //conexion.ConnectionString = "server=localhost\\SQLEXPRESS01;database=CATALOGO_P3_DB;integrated security=true"; lo comento pues esta uso yo
                conexion.ConnectionString = "server=localhost\\SQLEXPRESS;database=CATALOGO_P3_DB;integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id, A.Codigo as Codigo, \r\nA.Nombre, \r\nA.Descripcion, \r\nM.Descripcion AS Marca, \r\nC.Descripcion AS Categoria, \r\nA.Precio\r\nFROM ARTICULOS A\r\nLEFT JOIN MARCAS M ON A.IdMarca = M.Id\r\nLEFT JOIN CATEGORIAS C ON A.idCategoria = C.Id;";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = (int)lector["Id"];
                    aux.CodigoArticulo = Convert.ToString(lector["Codigo"]); // lo cambie a string pues asi està en la BD
                    aux.Nombre = Convert.ToString(lector["Nombre"]);
                    aux.Descripcion = Convert.ToString(lector["Descripcion"]);
                    aux.Marca = new Marca();
                    aux.Marca.Nombre = Convert.ToString(lector["Marca"]);
                    aux.Categoria = new Categoria();
                    aux.Categoria.Nombre = Convert.ToString(lector["Categoria"]);
                    if (!(lector["Precio"] is DBNull))
                        aux.Precio = Convert.ToDecimal(lector["Precio"]);

                    listaArticulos.Add(aux);
                }
                return listaArticulos;
            }
            catch(Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conexion.Close();
            }

        }
    }
}
