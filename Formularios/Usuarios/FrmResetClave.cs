using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Gestion_Creditos_EFuentes.Formularios.Usuarios
{
    public partial class FrmResetClave : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        public FrmResetClave()
        {
            InitializeComponent();
        }

        private void FrmResetClave_Load(object sender, EventArgs e)
        {

        }

        private void BtnResetearClave_Click(object sender, EventArgs e)
        {
            string codigo = TxtCodigo.Text.Trim();
            string newClave = TxtNewClave.Text.Trim();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newClave);

            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(newClave))
            {
                h.advertencia("Por favor, completa todos los campos.");
                return;
            }

            // Verificar el código de verificación y su validez
            DataTable dt = db.Find("USUARIOS", "*", $"CODIGO_VERIFICACION = '{codigo}' AND DATEDIFF(minute, CREACION_CODIGO, GETDATE()) <= 30");

            if (dt.Rows.Count > 0)
            {
                // Código válido, actualizar la contraseña
                string correo = dt.Rows[0]["CORREO"].ToString();
                string data = $"CLAVE = '{hashedPassword}', CODIGO_VERIFICACION = NULL, CREACION_CODIGO = NULL";
                string condition = $"CORREO = '{correo}'";

                if (db.update("USUARIOS", data, condition) > 0)
                {
                    h.Success("Contraseña restablecida con éxito.");
                    this.Close();
                }
                else
                {
                    h.advertencia("Error al actualizar la contraseña.");
                }
            }
            else
            {
                h.advertencia("Código de verificación inválido o expirado.");
            }
        }
    }
}
