using Gestion_Creditos_EFuentes.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Creditos_EFuentes.Formularios.Roles
{
    public partial class FrmRoles : Form
    {
        private int idRol= 1;
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        Clases.Auth auth = new Clases.Auth();   
        public FrmRoles()
        {
            InitializeComponent();
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            Nuevo();
            string lastRolesId = db.GetLastRolId();

            if (!string.IsNullOrEmpty(lastRolesId))
            {
                // Convertir el último ID de muestra a entero y agregar 1 para el próximo ID
                idRol = int.Parse(lastRolesId) + 1;
            }

            // Mostrar el próximo ID de muestra en el campo TxtMuestra
            TxtId.Text = idRol.ToString();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            string userlog = auth.ObtenerUsuarioSesion();
            string accion = "Boton Nuevo";
            string tabla = "ROLES";
            string detalle = $"El Usuario {userlog}, Activó el Boton Nuevo para Registrar un Nuevo Rol ";
            string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
            string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";

            if (db.Save("LOG", camposlog, valoreslog))
            {
                BtnCancelarOp.Enabled = true;
                BtnRegistrar.Enabled = true;
                BtnNuevo.Enabled = false;
                TxtRol.Enabled = true;
                BtnActualizar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnReactivar.Enabled = false;

            }
               
        }
        private void Nuevo()
        {
            BtnNuevo.Enabled = true;
            BtnCancelarOp.Enabled = false;
            BtnRegistrar.Enabled = false;
            TxtRol.Clear();
            TxtRol.Enabled = false;
            TxtId.Enabled = false;
        }
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string rol = TxtRol.Text.Trim();
            string id = TxtId.Text.Trim();

            string campos = "ID,ROL";
            string valores = $"'{id}','{rol}'";

            string userlog = auth.ObtenerUsuarioSesion();
            string accion = "Registro de Usuario";
            string tabla = "USUARIOS";
            string detalle = $"El Usuario {userlog}, registró un Nuevo Rol Llamado {rol}";
            string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
            string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";


            if (db.Save("ROLES", campos, valores))
            {
                if (db.Save("LOG", camposlog, valoreslog))
                {
                    h.Success($"el rol '{rol}' Se registró con Exito");
                    Nuevo();
                    string lastRolesId = db.GetLastRolId();

                    if (!string.IsNullOrEmpty(lastRolesId))
                    {
                        // Convertir el último ID de muestra a entero y agregar 1 para el próximo ID
                        idRol = int.Parse(lastRolesId) + 1;
                    }

                    // Mostrar el próximo ID de muestra en el campo TxtMuestra
                    TxtId.Text = idRol.ToString();

                }
                    
            }
            else
            {
                h.advertencia("Error al registrar el rol");
            }
        }
        public void RecibirDatosRol(string id, string rol, string estado)
        {
            TxtRol.Enabled = true;
            TxtRol.Text = rol;
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnReactivar.Enabled = false;
            TxtId.Text = id;
            TxtId.Enabled = false;
        }

        public void RecibirDatosRolElim(string id, string rol, string estado)
        {
            TxtRol.Enabled = false;
            TxtRol.Text = rol;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnReactivar.Enabled = true;
            TxtId.Text = id;
            TxtId.Enabled= false;
        }
        
        private void ClearnForm()
        {
            TxtId.Clear();
            TxtRol.Clear();
        }

        private void BtnCancelarOp_Click(object sender, EventArgs e)
        {

        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            Formularios.Roles.FrmBuscarRol buscar = new FrmBuscarRol();
            this.AddOwnedForm(buscar);
            ClearnForm();
            buscar.Show();
        }

        private void BtnverElim_Click(object sender, EventArgs e)
        {

            Formularios.Roles.FrmVerRolElim buscar = new FrmVerRolElim();
            this.AddOwnedForm(buscar);
            ClearnForm();
            buscar.Show();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

            string msg = "¿Desea Actualizar este Rol?";

            if (h.Question(msg) == true)
            {
                string codigo = TxtId.Text.Trim();
                string departamento = TxtRol.Text.Trim();
                string actualizar = $"ROL='{departamento}'";
                string condicion = $"ID='{codigo}'";


                string rol = TxtRol.Text.Trim();
                string userlog = auth.ObtenerUsuarioSesion();
                string accion = "Actualizar";
                string tabla = "ROLES";
                string detalle = $"El Usuario {userlog}, Activó el Boton Actualizar para Actualizar los datos del Rol {rol} ";
                string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
                string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";


                if (db.update("ROLES", actualizar, condicion) > 0)
                {
                    db.Save("LOG", camposlog, valoreslog);
                    h.Success("Los Datos Se actualizaron con Exito");
                    TxtRol.Clear();
                    TxtId.Clear();
                }
                else
                {
                    h.advertencia("Error al Actualizar El Rol");
                }
                BtnReactivar.Enabled = true;

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea marcar este Rol como Inactivo?";


            if (h.Question(msg) == true)
            {
                string codigo = TxtId.Text.Trim();
                string actualizar = $"ESTADO='S'";
                string condicion = $"ID='{codigo}'";

                string rol = TxtRol.Text.Trim();
                string userlog = auth.ObtenerUsuarioSesion();
                string accion = "Eliminar";
                string tabla = "ROLES";
                string detalle = $"El Usuario {userlog}, Activó el Boton Eliminar para Actualizar los datos del Rol {rol} a estado Inactivo";
                string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
                string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";

                if (db.update("ROLES", actualizar, condicion) > 0)
                {
                    db.Save("LOG", camposlog, valoreslog);

                    h.Success("El Rol se ha marcado como Activo con Éxito");
                    ClearnForm();
                }
                else
                {
                    h.advertencia("Error al actualizar el estado del Departamento.");
                }
            }
        }

        private void BtnReactivar_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea marcar este Rol como Activo?";

            string rol = TxtRol.Text.Trim();
            string userlog = auth.ObtenerUsuarioSesion();
            string accion = "Reactivar";
            string tabla = "ROLES";
            string detalle = $"El Usuario {userlog}, Activó el Boton Reactivar para Actualizar los datos del Rol {rol} a estado Activo";
            string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
            string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";

            if (h.Question(msg) == true)
            {
                string codigo = TxtId.Text.Trim();
                string actualizar = $"ESTADO='A'";
                string condicion = $"ID='{codigo}'";

                if (db.update("ROLES", actualizar, condicion) > 0)
                {
                    db.Save("LOG", camposlog, valoreslog);
                    h.Success("El Rol se ha marcado como Activo con Éxito");
                    ClearnForm();
                }
                else
                {
                    h.advertencia("Error al actualizar el estado del Departamento.");
                }
            }
        }
    }
}
