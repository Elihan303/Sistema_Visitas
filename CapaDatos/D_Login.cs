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
    public class D_Login
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
       

        public void ValidarUsuario(E_Login Login) {
            E_CrearUsuario CrearUsuario = new E_CrearUsuario();

            SqlCommand comando = new SqlCommand("SP_VALIDAR_USUARIO", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@USUARIO", Login.Usuario);
            comando.Parameters.AddWithValue("@CLAVE", Login.Clave);
            SqlDataReader dr = comando.ExecuteReader();

            if (dr.Read())
            {
                Login.Estado = true;        
            }
            else
            {
                Login.Estado = false;
            }

            conexion.Close(); 
        }

        public List<E_Login> BuscarUsuario(string contra) {
      
            SqlDataReader LeerFilas;
            SqlCommand comando = new SqlCommand("SP_BUSCAR_USUARIO", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@CLAVE", contra);
            LeerFilas = comando.ExecuteReader();
            List<E_Login> Listar = new List<E_Login>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Login
                {
                    IdDataUsuario = LeerFilas.GetInt32(1)
                });
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

      




    }
}
