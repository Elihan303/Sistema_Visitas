using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Registro
    {
        private string _Nombre;
        private string _Apellido;
        private string _Correo;
        private string _Carrera;
        private int _Edificio;
        private string _AulaIr;
        private DateTime _HoraEntrada;
        private DateTime _HoraSalida;
        private string _MotivoVisita;
        private byte[] _Foto;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Carrera { get => _Carrera; set => _Carrera = value; }
        public int Edificio { get => _Edificio; set => _Edificio = value; }
        public string AulaIr { get => _AulaIr; set => _AulaIr = value; }
        public DateTime HoraEntrada { get => _HoraEntrada; set => _HoraEntrada = value; }
        public DateTime HoraSalida { get => _HoraSalida; set => _HoraSalida = value; }
        public string MotivoVisita { get => _MotivoVisita; set => _MotivoVisita = value; }
        public byte[] Foto { get => _Foto; set => _Foto = value; }
    }
}
