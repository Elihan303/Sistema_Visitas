using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CapaEntidad;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class frmRegistro : Form
    {
        E_Registro RegistroEntidad = new E_Registro();
        N_Registro RegistroNegocio = new N_Registro();
        

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void CerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio inicio = new frmInicio();
            inicio.Show();
        }

        private void MinimizarFormulario_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                txtFoto.Text = openFileDialog1.FileName;
                CuadroImag.Image = Image.FromFile(openFileDialog1.FileName);
               
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            CuadroImag.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            Console.WriteLine(ms.GetBuffer());
            /* byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }
            Console.WriteLine(file.ToString());*/

            RegistroEntidad.Nombre = txtNombre.Text;
            RegistroEntidad.Apellido = txtApellido.Text;
            RegistroEntidad.Correo = txtCorreo.Text;
            RegistroEntidad.Carrera = txtCarrera.Text;
            RegistroEntidad.Edificio = Convert.ToInt32(comboBoxEdificio.Text);
            RegistroEntidad.AulaIr = comboBoxAula2.Text;
            // RegistroEntidad.HoraEntrada=
            // RegistroEntidad.HoraSalida=
            RegistroEntidad.MotivoVisita = txtMotivoVisita.Text;
            RegistroEntidad.Foto = ms.GetBuffer();

          
            
          


        }
    }
}
