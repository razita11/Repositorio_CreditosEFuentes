using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gestion_Creditos_EFuentes.Formularios.Usuarios
{
    public partial class FrmUsuarios : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        Clases.Auth auth = new Clases.Auth();
        
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

            ListarenCmb();
            SetControlsEnabled(false); // Deshabilitar los controles
            BtnNuevo.Enabled = true; // Habilitar el botón Nuevo
            BtnCancelarOp.Enabled = false; // Deshabilitar el botón Cancelar
            BtnRegistrarUser.Enabled = false; // Deshabilitar el botón Registrar
        }

        private void SetControlsEnabled(bool enabled)
        {
            TxtUsuario.Enabled = enabled;
            TxtContraseña.Enabled = enabled;
            TxtNombre.Enabled = enabled;
            TxtCorreo.Enabled = enabled;
            DtpFechaNac.Enabled = enabled;
            CmbGenero.Enabled = enabled;
            CmbRol.Enabled = enabled;
            CmbGuardar.Enabled = enabled;
            CmbActualizar.Enabled = enabled;
            CmbEliminar.Enabled = enabled;
            CmbReimprimir.Enabled = enabled;
            CmbImprimir.Enabled = enabled;
        }

        private void ListarenCmb()
        {
            // Modificar la consulta para obtener tanto el ID como el nombre del rol
            DataTable dt = db.Find("ROLES", "ID, ROL");

            if (dt != null && dt.Rows.Count > 0)
            {
                CmbRol.DataSource = dt;
                CmbRol.DisplayMember = "ROL"; // Mostrar el nombre del rol
                CmbRol.ValueMember = "ID"; // Usar el ID del rol como valor
            }
        }

        private void ClearnForm()
        {
            TxtContraseña.Clear();
            TxtCorreo.Clear();
            TxtNombre.Clear();
            TxtUsuario.Clear();
            CmbGenero.SelectedIndex = -1;
            CmbRol.SelectedIndex = -1;
            CmbGuardar.SelectedIndex = -1;
            CmbActualizar.SelectedIndex = -1;
            CmbEliminar.SelectedIndex = -1;
            CmbReimprimir.SelectedIndex = -1;
            CmbImprimir.SelectedIndex = -1;
            DtpFechaNac.Value = DateTime.Now;
        }

        private void BtnRegistrarUser_Click(object sender, EventArgs e)
        {
            string campos, valores, camposper, valoresper;
            string usuario = TxtUsuario.Text.Trim();
            string contraseña = BCrypt.Net.BCrypt.HashPassword(TxtContraseña.Text);
            string nombre = TxtNombre.Text.Trim();
            string correo = TxtCorreo.Text.Trim();
            string fechanac = DtpFechaNac.Text.Trim();
            string rol = CmbRol.SelectedValue.ToString();
            string genero = CmbGenero.Text.Trim();
            string guardar = CmbGuardar.Text.Trim();
            string actualizar = CmbActualizar.Text.Trim();
            string eliminar = CmbEliminar.Text.Trim();
            string imprimir = CmbActualizar.Text.Trim();
            string reimprimir = CmbReimprimir.Text.Trim();

            campos = "USUARIO,CLAVE,NOMBRE,GENERO,FECHA_N,CORREO,ROL_ID";
            valores = $"'{usuario}','{contraseña}','{nombre}','{genero}','{fechanac}','{correo}','{rol}'";

            camposper = "USUARIO,GUARDAR,ACTUALIZAR,ELIMINAR,IMPRIMIR,REIMPRIMIR";
            valoresper = $"'{usuario}','{guardar}','{actualizar}','{eliminar}','{imprimir}','{reimprimir}'";

            string userlog = auth.ObtenerUsuarioSesion();
            string accion = "Registro de Usuario";
            string tabla = "USUARIOS";
            string detalle = $"El Usuario {userlog}, registró un Nuevo Usuario llamado {usuario}";
            string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
            string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";


            if (db.Save("USUARIOS", campos, valores))
            {
                if(db.Save("PERMISOS",camposper, valoresper))
                {
                    if (db.Save("LOG", camposlog, valoreslog))
                    {
                        h.Success("Usuario Registrado Con Exito!");
                        ClearnForm();
                        TxtUsuario.Focus();
                        SetControlsEnabled(false); // Deshabilitar los controles después del registro
                        BtnRegistrarUser.Enabled = false; // Deshabilitar el botón Registrar
                        BtnCancelarOp.Enabled = false; // Deshabilitar el botón Cancelar
                        BtnNuevo.Enabled = true; // Habilitar el botón Nuevo
                    }
                }
            }
            else
            {
                h.advertencia("Error al Registrar Usuario");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelarOp_Click(object sender, EventArgs e)
        {
            string userlog = auth.ObtenerUsuarioSesion();
            string accion = "Boton Cancelar Operacion";
            string tabla = "USUARIOS";
            string detalle = $"El Usuario {userlog}, Activó el Boton de Cancelar Operacion ";
            string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
            string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";

            string msg = "¿Desea cancelar la operación?";

            if (h.Question(msg) == true)
            {
                if (db.Save("LOG", camposlog, valoreslog))
                {
                    ClearnForm(); // Limpiar los controles
                    SetControlsEnabled(false); // Deshabilitar los controles
                    BtnRegistrarUser.Enabled = false; // Deshabilitar el botón Registrar
                    BtnCancelarOp.Enabled = false; // Deshabilitar el botón Cancelar
                    BtnNuevo.Enabled = true; // Habilitar el botón Nuevo
                }
                
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            string userlog = auth.ObtenerUsuarioSesion();
            string accion = "Boton Nuevo";
            string tabla = "USUARIOS";
            string detalle = $"El Usuario {userlog}, Activó el Boton Nuevo para Registrar un Nuevo Usuario ";
            string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
            string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";

            if (db.Save("LOG", camposlog, valoreslog))
            {
                SetControlsEnabled(true); // Habilitar los controles
                BtnRegistrarUser.Enabled = true; // Habilitar el botón Registrar
                BtnCancelarOp.Enabled = true; // Habilitar el botón Cancelar
                BtnNuevo.Enabled = false; // Deshabilitar el botón Nuevo
            }
        }
    }
}
