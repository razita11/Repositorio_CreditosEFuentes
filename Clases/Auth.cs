using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using BCrypt.Net;

namespace Gestion_Creditos_EFuentes.Clases
{
    internal class Auth
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();

        public static string USERNAME;
        public static string ROL;
        public static string NOMBRE;
        public static string GUARDAR;
        public static string ACTUALIZAR;
        public static string ELIMINAR;
        public static string IMPRIMIR;
        public static string REIMPRIMIR;

        public bool RegisterUserSuperAdmin()
        {
            bool resp = false;

            if (db.Exists("USUARIOS", "USUARIO", $"'EFuentes'") == false)
            {
                string username, clave, nombre, genero, fechanac, correo,rol_id;
                username = "EFuentes";
                clave = BCrypt.Net.BCrypt.HashPassword("12345678");
                nombre = "Nazareth Enmanuel Fuentes Bautista";
                genero = "Hombre";
                fechanac = "05/10/2001";
                correo = "enmanuelfuentes794@gmail.com";
                rol_id = "SADMN";
                string campos = "USUARIO, CLAVE, NOMBRE, GENERO, FECHA_N, CORREO, ROL_ID";
                string valores = $"'{username}','{clave}','{nombre}','{genero}','{fechanac}','{correo}','{rol_id}'";
                db.Save("USUARIOS", campos, valores);
            }

            return resp;
        }


        public bool makeLogin(string username, string clave)
        {
            bool resp = false;
            DataTable data = db.Find("USUARIOS", "*", $"USUARIO='{username}'");

            if (data.Rows.Count > 0)
            {
                DataRow infouser = data.Rows[0];
                string usuario = infouser["USUARIO"].ToString();
                string clave_db = infouser["CLAVE"].ToString();
                string estado = infouser["ESTADO"].ToString();
                USERNAME = usuario;
                ROL = infouser["ROL_ID"].ToString();
                NOMBRE = infouser["NOMBRE"].ToString();
                if (username == usuario && BCrypt.Net.BCrypt.Verify(clave, clave_db) && estado == "ACTIVO")
                {
                    CargarPermisos(usuario);
                    h.Success($"Bienvenido'{usuario}'");
                    resp = true;

                }
                else
                {
                    h.advertencia("Las credenciales parecen no ser Correctas");
                }

            }
            else
            {
                h.advertencia("Usuario No Existe!");
            }
            return resp;
        }

        public string ObtenerUsuarioSesion()
        {
            return Auth.USERNAME;
        }

        private void CargarPermisos(string username)
        {
            DataTable data = db.Find("PERMISOS", "*", $"USUARIO='{username}'");
            if (data.Rows.Count > 0)
            {
                DataRow permisos = data.Rows[0];
                GUARDAR = permisos["GUARDAR"].ToString();
                ACTUALIZAR = permisos["ACTUALIZAR"].ToString();
                ELIMINAR = permisos["ELIMINAR"].ToString();
                IMPRIMIR = permisos["IMPRIMIR"].ToString();
                REIMPRIMIR = permisos["REIMPRIMIR"].ToString();
            }
            else
            {
                h.advertencia($"Error al cargar los Permisos del USUARIO!! {username}");
                Application.Exit();
            }
            data.Dispose();
        }

        // Recuperacion de Claves 


        public bool EnviarCodeVerificacion(string userEmail)
        {
            try
            {
                // Generar un código de verificación
                string codigoVerificacion = GenerarCodigoVerificacion();

                // Guardar el código de verificación y la fecha en la base de datos
                string data = $"CODIGO_VERIFICACION = '{codigoVerificacion}', CREACION_CODIGO = '{DateTime.Now}'";
                string condition = $"CORREO = '{userEmail}'";

                if (db.update("USUARIOS", data, condition) > 0)
                {
                    // Configurar el correo electrónico
                    MailMessage mail = new MailMessage("oiplepaera@gmail.com", userEmail);
                    mail.Subject = "Código de verificación";
                    mail.Body = $"Tu código de verificación es: {codigoVerificacion}\nUtiliza este código para restablecer tu contraseña.";

                    // Configurar el cliente SMTP
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587; // Puerto SMTP para TLS
                    client.Credentials = new System.Net.NetworkCredential("oiplepaera@gmail.com", "Pjjr znju zqhe zdka");
                    client.EnableSsl = true;

                    // Enviar el correo electrónico
                    client.Send(mail);

                    return true;
                }
                else
                {
                    h.advertencia("Error al actualizar el código de verificación en la base de datos.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                h.advertencia($"Error al enviar el correo de verificación: {ex.Message}");
                return false;
            }
        }

        private string GenerarCodigoVerificacion()
        {
            const string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(validChars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private string GenerateRandomPassword()
        {
            // Puedes personalizar este método para generar una contraseña más segura
            const string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(validChars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


    }
}
