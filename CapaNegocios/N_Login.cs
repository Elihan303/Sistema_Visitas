using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class N_Login
    {
        D_Login Dato = new D_Login();

        public void validarUsuario(E_Login Login)
        {
            Dato.ValidarUsuario(Login);
        }

        public void BuscarUsuario(E_Login Login) 
        {
            Dato.BuscarUsuario(Login.Clave);
        }

    }
}
