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
        private string connectionString = "server=localhost\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";

        public List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();
            SqlConnection conexion =new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            { 
                conexion.ConnectionString = connectionString;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Descripcion FROM Marcas ORDER BY Descripcion";
                comando.Connection = conexion;

                //open connection
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) {
                    //creo una marca por cada fila
                    Marca aux = new Marca();
                    aux.IdMarca = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Descripcion"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public void Agregar(string nombre)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                //conexion, tipo de comando, consulta
                conexion.ConnectionString = connectionString;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO MARCAS (Descripcion) VALUES ";

            }
            catch (Exception)
            {

                throw;
            }

        }
    
    }
}
