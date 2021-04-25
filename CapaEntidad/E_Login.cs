using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Login
    {
        private int _IdDataUsuario;
        private string _Usuario;
        private string _Clave;
        private bool _Estado;
        private string _TipoUsuario;


        public int IdDataUsuario { get => _IdDataUsuario; set => _IdDataUsuario = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
        public string TipoUsuario { get => _TipoUsuario; set => _TipoUsuario = value; }
        
    }
}
