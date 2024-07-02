using Gestion_Creditos_EFuentes.Formularios.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Creditos_EFuentes.Formularios.Avales
{
    public partial class FrmEditElimAvales : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        Clases.Auth auth = new Clases.Auth();
        string dni, nombre, apellidos, direccion, correo, genero, telefono, fecha;

        private void BtnActualizarUser_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea Actualizar los datos de Este Usuario?";
            if (h.Question(msg) == true)
            {
                SetValues();
                string actualizar = $"DNI='{dni}',NOMBRE='{nombre}',APELLIDOS='{apellidos}',DIRECCION='{direccion}',TELEFONO='{telefono}',GENERO = '{genero}',FECHA_N='{fecha}',CORREO='{correo}'";
                string condicion = $"DNI='{dni}'";

                string nombrelog = TxtNombre.Text.Trim();
                string userlog = auth.ObtenerUsuarioSesion();
                string accion = "Actualizar";
                string tabla = "AVALES";
                string detalle = $"El Usuario {userlog}, Activó el Boton Actualizar para Actualizar los datos del Aval {nombrelog}";
                string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
                string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";



                if (db.update("AVALES", actualizar, condicion) > 0)
                {
                    db.Save("LOG", camposlog, valoreslog);
                    h.Success($"Los datos del Aval '{nombre}' se han actualizado con Exito");
                    ClearForm();
                    DeshabilitarBotones();
                    DeshabilitarCampos();

                }
                else 
                {
                    h.advertencia("ERROR AL ACTUALIZAR LOS DATOS");
                    BtnReacitvar.Enabled = true;
                }

            }
               

        }

        private void DeshabilitarBotones()
        {
            BtnEliminarUser.Enabled = false;
            BtnReacitvar.Enabled = false;
            BtnActualizarUser.Enabled = false;
        }

        private void DeshabilitarCampos()
        {
            TxtDni.Enabled = false;
            TxtNombre.Enabled = false;
            DtpFechaNac.Enabled = false;
            TxtCorreo.Enabled = false;
            TxtDireccion.Enabled = false;
            TxtTelefono.Enabled = false;
            CmbGenero.Enabled = false;
            TxtApellidos.Enabled = false;
        }

        private void BtnEliminarUser_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea marcar este Aval como Inactivo?";

            if (h.Question(msg) == true)
            {
                string dni = TxtDni.Text.Trim();
                string actualizar = $"ESTADO='I'";
                string condicion = $"DNI='{dni}'";

                string nombre = TxtNombre.Text.Trim();
                string userlog = auth.ObtenerUsuarioSesion();
                string accion = "Eliminar";
                string tabla = "AVALES";
                string detalle = $"El Usuario {userlog}, Activó el Boton Eliminar para Actualizar los datos del Aval {nombre} a estado Inactivo";
                string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
                string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";


                if (db.update("AVALES", actualizar, condicion) > 0)
                {
                    db.Save("LOG", camposlog, valoreslog);
                    h.Success("El Aval se ha marcado como INACTIVO con Éxito");
                    ClearForm();
                    DeshabilitarCampos();
                    DeshabilitarBotones();
                }
                else
                {
                    h.advertencia("Error al actualizar el estado del usuario.");
                }
            }
        }

        private void BtnVerElim_Click(object sender, EventArgs e)
        {
            FrmVerElim buscar = new FrmVerElim();
            this.AddOwnedForm(buscar);
            ClearForm();
            buscar.Show();
        }

        private void HabilitarCampos()
        {
            TxtDni.Enabled = true;
            TxtNombre.Enabled = true;
            DtpFechaNac.Enabled = true;
            TxtCorreo.Enabled = true;
            TxtDireccion.Enabled = true;
            TxtTelefono.Enabled = true;
            CmbGenero.Enabled = true;
            TxtApellidos.Enabled = true;
        }

        private void BtnReacitvar_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea marcar este Aval como Activo?";

            if (h.Question(msg) == true)
            {
                string dni = TxtDni.Text.Trim();
                string actualizar = $"ESTADO='A'";
                string condicion = $"DNI='{dni}'";

                string nombre = TxtNombre.Text.Trim();
                string userlog = auth.ObtenerUsuarioSesion();
                string accion = "ReActivar";
                string tabla = "AVALES";
                string detalle = $"El Usuario {userlog}, Activó el Boton Eliminar para Actualizar los datos del Aval {nombre} a estado Activo";
                string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
                string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";


                if (db.update("AVALES", actualizar, condicion) > 0)
                {
                    db.Save("LOG", camposlog, valoreslog);
                    h.Success("El Aval se ha marcado como Activo con Éxito");
                    ClearForm();
                    DeshabilitarCampos();
                }
                else
                {
                    h.advertencia("Error al actualizar el estado del Aval.");
                }
            }
        }

        public FrmEditElimAvales()
        {
            InitializeComponent();
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarAval buscar = new FrmBuscarAval();
            this.AddOwnedForm(buscar);
            ClearForm();
            buscar.Show();
        }

        private void FrmEditElimAvales_Load(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            DeshabilitarBotones();
        }

        private void SetValues()
        {
            dni = TxtDni.Text.Trim();
            nombre = TxtNombre.Text.Trim();
            apellidos = TxtApellidos.Text.Trim();
            direccion = TxtDireccion.Text.Trim();
            correo = TxtCorreo.Text.Trim();
            genero = CmbGenero.Text.Trim();
            telefono = TxtTelefono.Text.Trim();
            fecha = DtpFechaNac.Text.Trim();
        }

        public void RecibirDatosAvales(string dni, string nombre, string apellidos, string direccion, string telefono, string genero, string fecha_n, string correo)
        {
            TxtDni.Text = dni;
            TxtNombre.Text = nombre;
            TxtApellidos.Text = apellidos;
            DtpFechaNac.Text = fecha_n;
            TxtCorreo.Text = correo;
            TxtDireccion.Text = direccion;
            TxtTelefono.Text = telefono;
            CmbGenero.Text = genero;
            BtnEliminarUser.Enabled = true;
            BtnActualizarUser.Enabled = true;
            BtnReacitvar.Enabled = false;
            HabilitarCampos();

        }

        public void RecibirDatosElimAvales(string dni, string nombre, string apellidos, string direccion, string telefono, string genero, string fecha_n, string correo)
        {
            TxtDni.Text = dni;
            TxtNombre.Text = nombre;
            TxtApellidos.Text = apellidos;
            DtpFechaNac.Text = fecha_n;
            TxtCorreo.Text = correo;
            TxtDireccion.Text = direccion;
            TxtTelefono.Text = telefono;
            CmbGenero.Text = genero;
            DeshabilitarCampos();
            BtnActualizarUser.Enabled = false;
            BtnEliminarUser.Enabled = false;
            BtnReacitvar.Enabled = true;
        }


    }
}
