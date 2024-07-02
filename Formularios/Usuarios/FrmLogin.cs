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
    public partial class FrmLogin : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Helpers helpers = new Clases.Helpers();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();
        Clases.Configuracion c = new Clases.Configuracion();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            {
                if (bs.revisarArchivosConfig() == true)
                {
                    if (bs.revisarInfoArchivoConfiguracion() == true)
                    {
                        auth.RegisterUserSuperAdmin();
                        c.checkInfoConfiguracion();
                    }
                }
                else
                {
                    MessageBox.Show("ERROR AL CARGAR EL ARCHIVO DE CONFIGURACION");
                    Application.Exit();
                }
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUsuario.Text.Trim();
            string clave = TxtClave.Text.Trim();
            string user = TxtUsuario.Text.Trim();


            string accion = "Inicio de Sesion";
            string tabla = "USUARIOS";
            string detalle = $"Inicio de Sesion al Sistema del Usuario {user} ";
            string campos = "USUARIO,ACCION,TABLA,DETALLE";
            string valores = $"'{username}','{accion}','{tabla}','{detalle}'";

            if (auth.makeLogin(username, clave) == true)
            {
                Formularios.FrmMenu menu = new Formularios.FrmMenu();
                db.Save("LOG", campos, valores);
                    menu.Show();
                    this.Hide();
            }
        }

        private void BtnRecuperar_Click(object sender, EventArgs e)
        {
            Formularios.Usuarios.FrmRecuperarClave recuperarClave = new FrmRecuperarClave();
            recuperarClave.Show();
        }
    }
}
