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
    public partial class frmLogin : Form
    {
        N_Login LoginNegocio = new N_Login();
        E_Login LoginEntidad = new E_Login();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void CerrarFormulario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void MinimizarFormulario_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {






            
                
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            LoginEntidad.Usuario = txtUsuario.Text;
            LoginEntidad.Clave = txtClave.Text;

            //validar inicio de sesion

            LoginNegocio.validarUsuario(LoginEntidad);
            LoginNegocio.BuscarUsuario(LoginEntidad);

            Console.WriteLine(LoginEntidad.IdDataUsuario);
            if (LoginEntidad.Estado == true)
            {
                this.Hide();
                frmInicio inicio = new frmInicio();
                inicio.Show();

            }
            else
            {
                MessageBox.Show("Datos erroneos por favor vuelve a intentarlo");
                //txtUsuario.Clear();
               // txtClave.Clear();
            }
            



        }
    }
}
