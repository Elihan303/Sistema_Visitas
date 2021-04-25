using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CapaDatos
{
     public class D_CrearUsuario
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        
        public List<E_CrearUsuario> BuscarDatosUsuarioInt(int buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand comando = new SqlCommand("SP_BUSCAR_DATO_USUARIO_INT", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@BUSCAR", buscar);
            LeerFilas = comando.ExecuteReader();
            List<E_CrearUsuario> Listar = new List<E_CrearUsuario>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_CrearUsuario
                {
                    IdDataUsuario = LeerFilas.GetInt32(0),
                    Nombre= LeerFilas.GetString(1),
                    Apellido= LeerFilas.GetString(2),
                    FechaNacimiento = LeerFilas.GetDateTime(3),
                    TipoUsuario = LeerFilas.GetString(4)

                });
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;

        }
    }
}
