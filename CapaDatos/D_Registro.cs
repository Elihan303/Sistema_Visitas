using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    class D_Registro
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        //public void InsertarCliente(E_CLIENTE CLIENTE)
        //{
        //    SqlCommand comando = new SqlCommand("SP_INSERTAR_CLIENTE", conexion);
        //    comando.CommandType = CommandType.StoredProcedure;
        //    conexion.Open();
        //    comando.Parameters.AddWithValue("@NOMBRE", CLIENTE.NombreCliente);
        //    comando.Parameters.AddWithValue("@DIRECCION", CLIENTE.DireccionCliente);
        //    comando.Parameters.AddWithValue("@TELEFONO", CLIENTE.TelefonoCliente);
        //    comando.Parameters.AddWithValue("@EMAIL", CLIENTE.EmailCliente);
        //    comando.ExecuteNonQuery();
        //    conexion.Close();

        //}


    }
}
