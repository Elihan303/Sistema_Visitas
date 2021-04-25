using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocios;


namespace CapaPresentacion
{
    public partial class frmInicio : Form
    {   E_CrearUsuario CrearUsuarioEntidad = new E_CrearUsuario();
        N_CrearUsuario CrearUsuarioNegocios = new N_CrearUsuario();
        E_Login LoginEntidad = new E_Login();
        
        public frmInicio()
        {
            InitializeComponent();
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            Console.WriteLine(LoginEntidad.IdDataUsuario);
            CrearUsuarioNegocios.BuscarDatosUsuarioInt(LoginEntidad.IdDataUsuario);
            lblNombre.Text = CrearUsuarioEntidad.Nombre;
            lblEstatus.Text = CrearUsuarioEntidad.TipoUsuario;
        }


        private void CerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin Login = new frmLogin();
            Login.Show();
        }

    

        private void MinimizarFormulario_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistro registro = new frmRegistro();
            registro.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultar consultar = new frmConsultar();
            consultar.Show();
        }

        private void btnEditarRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditarRegistro editar = new frmEditarRegistro();
            editar.Show();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCrearUsuario crearusuario = new frmCrearUsuario();
            crearusuario.Show();
            
        }

       
    }
}
