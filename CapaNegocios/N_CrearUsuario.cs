using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class N_CrearUsuario
    {
        D_CrearUsuario Dato = new D_CrearUsuario();

        public List<E_CrearUsuario> BuscarDatosUsuarioInt(int buscar)
        {
            return Dato.BuscarDatosUsuarioInt(buscar);
        }
    }
}
