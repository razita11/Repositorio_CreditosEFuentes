using Gestion_Creditos_EFuentes.Clases;
using Gestion_Creditos_EFuentes.Formularios.Sistema;
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

namespace Gestion_Creditos_EFuentes.Formularios.Documentos_Cliente
{
    public partial class FrmRegistrarRequisitos : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        Clases.Auth auth = new Clases.Auth();
        public FrmRegistrarRequisitos()
        {
            InitializeComponent();
        }

        private void Nuevo()
        {
            BtnNuevo.Enabled = true;
            BtnCancelarOp.Enabled = false;
            BtnRegistrar.Enabled = false;
            TxtDoc.Clear();
            TxtDoc.Enabled = false;
            CmbOblig.SelectedIndex=-1; 
            CmbOblig.Enabled = false;
        }


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            BtnCancelarOp.Enabled = true;
            BtnRegistrar.Enabled = true;
            BtnNuevo.Enabled = false;
            TxtDoc.Enabled = true;
            CmbOblig.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnReactivar.Enabled = false;
        }

        private void logRegister()
        {
            string doc = TxtDoc.Text.Trim();
            string userlog = auth.ObtenerUsuarioSesion();
            string accion = "Registro de Documento";
            string tabla = "REQUISITOS";
            string detalle = $"El Usuario {userlog}, registró un Nuevo Documento Llamado {doc}";
            string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
            string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";
            db.Save("LOG", camposlog, valoreslog);
        }

        private void logupdate()
        {
            string doc = TxtDoc.Text.Trim();
            string userlog = auth.ObtenerUsuarioSesion();
            string accion = "Actualizacion de Documentos";
            string tabla = "REQUISITOS";
            string detalle = $"El Usuario {userlog}, Actualizó el Documento Llamado {doc}";
            string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
            string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";
            db.Save("LOG", camposlog, valoreslog);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string doc;
            string oblig;

            doc = TxtDoc.Text.Trim();
            oblig = CmbOblig.Text.Trim();
            string campos = "DOCUMENTO,OBLIG";
            string valores = $"'{doc}','{oblig}'";

            if (db.Save("REQUISITOS",campos,valores))
            {
           
                h.Success($"El Documento{doc}, se Registró con Exito");
                logRegister();
                Nuevo();
            }
            else
            {
                h.advertencia("Error al Registrar el Documento");
            }


        }

        private void BtnCancelarOp_Click(object sender, EventArgs e)
        {
            string text = "Desea Cancelar La Operacion En Proceso?";
            if (h.Question(text) == true)
            {
                ClearnForm();
            }
        }

        private void ClearnForm()
        {
            TxtDoc.Clear();
            TxtCodigo.Clear();
            Nuevo();
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            Formularios.Documentos_Cliente.FrmBuscarRequisito buscar = new FrmBuscarRequisito();
            this.AddOwnedForm(buscar);
            ClearnForm();
            buscar.Show();
        }

        private void BtnverElim_Click(object sender, EventArgs e)
        {
            Formularios.Documentos_Cliente.FrmBuscarElimRequi buscar = new FrmBuscarElimRequi();
            this.AddOwnedForm(buscar);
            ClearnForm();
            buscar.Show();
        }

        private void FrmRegistrarRequisitos_Load(object sender, EventArgs e)
        {
            Nuevo();
            TxtCodigo.Enabled = true;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string doc;
            string oblig;
            doc = TxtDoc.Text.Trim();
            oblig = CmbOblig.Text.Trim();
            string codigo = TxtCodigo.Text.Trim();
            string condicion = $"CODIGO='{codigo}'";
            string actualizar = $"DOCUMENTO='{doc}',OBLIG='{oblig}'";

            string code = "¿Desea Actualizar Los Datos?";
            if (h.Question(code) == true){

                if (db.update("REQUISITOS", actualizar, condicion) > 0)
                {
                    h.Success("Los Datos Se Actualizaron con Exito");
                    logupdate();
                    Nuevo();
                }
                else
                {
                    h.advertencia("Erorr al Actualizar el Documento");
                }

            }     
        }

        public void RecibirDatosDoc(string codigo, string documento, string oblig, string estado)
        {
            TxtDoc.Enabled = true;
            TxtDoc.Text = documento;
            CmbOblig.Enabled = true;
            CmbOblig.Text = oblig;
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnReactivar.Enabled = false;
            TxtCodigo.Text = codigo;
            BtnCancelarOp.Enabled = true;
        }

        public void RecibirDatosElimDoc(string codigo, string documento, string oblig, string estado)
        {
            TxtDoc.Enabled = false;
            TxtDoc.Text = documento;
            CmbOblig.Enabled = false;
            CmbOblig.Text = oblig;
            BtnActualizar.Enabled = false ;
            BtnEliminar.Enabled = false;
            BtnReactivar.Enabled = true;
            TxtCodigo.Text = codigo;
            BtnCancelarOp.Enabled = true;
        }

        private void BtnReactivar_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea marcar este Documento como Activo?";

            if (h.Question(msg) == true)
            {
                string codigo = TxtCodigo.Text.Trim();
                string actualizar = $"ESTADO='A'";
                string condicion = $"CODIGO='{codigo}'";

                if (db.update("REQUISITOS", actualizar, condicion) > 0)
                {
                    h.Success("El Documento se ha marcado como Activo con Éxito");
                    ClearnForm();
                }
                else
                {
                    h.advertencia("Error al actualizar el estado del Documento.");
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea marcar este Documento como Inactivo?";

            if (h.Question(msg) == true)
            {
                string codigo = TxtCodigo.Text.Trim();
                string actualizar = $"ESTADO='I'";
                string condicion = $"CODIGO='{codigo}'";

                if (db.update("REQUISITOS", actualizar, condicion) > 0)
                {
                    h.Success("El Documento se ha marcado como INACTIVO con Éxito");
                    ClearnForm();
                }
                else
                {
                    h.advertencia("Error al actualizar el estado del Documento.");
                }
            }
        }
    }
}
