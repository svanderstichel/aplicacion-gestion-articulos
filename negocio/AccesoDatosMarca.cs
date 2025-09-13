﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace negocio
{
    public class AccesoDatosMarca
    {
        private SqlConnection conexion; 
        private SqlCommand comando; 
        private SqlDataReader lector; 

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatosMarca()
        {
            //conexion = new SqlConnection("server=localhost\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            conexion = new SqlConnection("server=localhost\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=true"); // lo dejo comentado pues es el que yo uso
            comando = new SqlCommand();
        }
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void setearParametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void cerrarConexion()
        {
            if(lector != null)
            {
                lector.Close();
                conexion.Close();
            }
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
    }
}
