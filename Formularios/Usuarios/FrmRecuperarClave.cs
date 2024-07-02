using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Creditos_EFuentes.Formularios.Usuarios
{
    public partial class FrmRecuperarClave : Form
    {
        Clases.Auth auth = new Clases.Auth();
        Clases.Helpers h = new Clases.Helpers();
        public FrmRecuperarClave()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            string email = TxtCorreo.Text.Trim();

            if (auth.EnviarCodeVerificacion(email))
            {
                h.Success("Código de verificación enviado. Verifica tu correo electrónico.");

                Formularios.Usuarios.FrmResetClave frmReset = new FrmResetClave();
                frmReset.Show();
                this.Close();
            }
            else
            {
                h.advertencia("Error al enviar el código de verificación. Asegúrate de que el correo esté registrado.");
            }
        }

        private void FrmRecuperarClave_Load(object sender, EventArgs e)
        {

        }
    }
}
