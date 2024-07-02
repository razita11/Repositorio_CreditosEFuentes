using Gestion_Creditos_EFuentes.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Creditos_EFuentes.Formularios.Avales
{
    public partial class FrmAvales : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        Clases.Auth auth = new Clases.Auth();
        public FrmAvales()
        {
            InitializeComponent();
        }

        private void FrmAvales_Load(object sender, EventArgs e)
        {
            DeshabilitarBotones();
            DeshabilitarCampos();
            BtnSalir.Enabled = true;
        }

        private void DeshabilitarBotones()
        {
            BtnRegistrarCliente.Enabled = false;
            BtnCancelarOp.Enabled = false;
            BtnNuevo.Enabled = true;
            BtnSalir.Enabled = true;
        }

        private void HabilitarBotones()
        {
            BtnRegistrarCliente.Enabled = true;
            BtnCancelarOp.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnSalir.Enabled = true;
        }

        private void DeshabilitarCampos()
        {
            TxtDni.Enabled = false;
            TxtNombre.Enabled = false;
            TxtApellidos.Enabled = false;
            TxtDireccion.Enabled = false;
            TxtCorreo.Enabled = false;
            CmbGenero.Enabled = false;
            TxtTelefono.Enabled = false;
            DtpFechaNac.Enabled = false;
        }

        private void HabilitarCampos()
        {
            TxtDni.Enabled = true;
            TxtNombre.Enabled = true;
            TxtApellidos.Enabled = true;
            TxtDireccion.Enabled = true;
            TxtCorreo.Enabled = true;
            CmbGenero.Enabled = true;
            TxtTelefono.Enabled = true;
            DtpFechaNac.Enabled = true;
        }
        private void ClearForm()
        {
            TxtDni.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtCorreo.Clear();
            CmbGenero.SelectedIndex = -1;
            TxtTelefono.Clear();
            TxtApellidos.Clear();
            DtpFechaNac.Value = DateTime.Now;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            string userlog = auth.ObtenerUsuarioSesion();
            string accion = "Boton Nuevo";
            string tabla = "AVALES";
            string detalle = $"El Usuario {userlog}, Activó el Boton Nuevo para Registrar un Aval ";
            string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
            string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";
            if (db.Save("LOG", camposlog, valoreslog))
            {
                HabilitarBotones();
                ClearForm();
                HabilitarCampos();
            }
        }

        private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            string dni = TxtDni.Text.Trim();
            string nombre = TxtNombre.Text.Trim();
            string apellido = TxtApellidos.Text.Trim();
            string genero = CmbGenero.Text.Trim();
            string correo = TxtCorreo.Text.Trim();
            string direccion = TxtDireccion.Text.Trim();
            string fechanac = DtpFechaNac.Text.Trim();
            string telefono = TxtTelefono.Text.Trim();

            string campos = "DNI,NOMBRE,APELLIDOS,DIRECCION,TELEFONO,GENERO,FECHA_N,CORREO";
            string valores = $"'{dni}','{nombre}','{apellido}','{direccion}','{telefono}','{genero}','{fechanac}','{correo}'";


            string userlog = auth.ObtenerUsuarioSesion();
            string accion = "Registro de Aval";
            string tabla = "AVALES";
            string detalle = $"El Usuario {userlog}, registró un Nuevo Aval llamado {nombre}, con Identidad {dni}";
            string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
            string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";


            if (db.Save("AVALES", campos, valores))
            {
                db.Save("LOG", camposlog, valoreslog);
                h.Success($"El Aval '{nombre}' ha Sido Registrado con Exito ");
                ClearForm();
                DeshabilitarBotones();
                DeshabilitarCampos();

            }
            else
            {
                h.advertencia("Error al Registrar al Aval");
            }


        }

        private void BtnCancelarOp_Click(object sender, EventArgs e)
        {
            if (h.Question("¿Está seguro de que desea cancelar la operación?"))
            {
                ClearForm();
                DeshabilitarBotones();
                DeshabilitarCampos();
                BtnSalir.Enabled = true; // El botón salir debe estar habilitado.
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
