using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
     public class E_CrearUsuario
    {
        private int _IdDataUsuario;
        private string _Nombre;
        private string _Apellido;
        private DateTime _FechaNacimiento;
        private string _TipoUsuario;

        public int IdDataUsuario { get => _IdDataUsuario; set => _IdDataUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public DateTime FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string TipoUsuario { get => _TipoUsuario; set => _TipoUsuario = value; }
    }
}
