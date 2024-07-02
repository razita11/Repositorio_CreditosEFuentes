using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Creditos_EFuentes.Formularios.Sistema
{
    public partial class FrmMunicipio : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        public FrmMunicipio()
        {
            InitializeComponent();
        }

        private void FrmMunicipio_Load(object sender, EventArgs e)
        {
            ListarenCmb();
            Nuevo();
        }

        private void ListarenCmb()
        {
            // Modificar la consulta para obtener tanto el ID como el nombre del rol
            DataTable dt = db.Find("DEPARTAMENTOS", "CODIGO, DEPARTAMENTO");

            if (dt != null && dt.Rows.Count > 0)
            {
                CmbDepartamento.DataSource = dt;
                CmbDepartamento.DisplayMember = "DEPARTAMENTO"; // Mostrar el nombre del rol
                CmbDepartamento.ValueMember = "CODIGO"; // Usar el ID del rol como valor
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string municipio = TxtMunicipio.Text.Trim();
            string departamento = CmbDepartamento.SelectedValue.ToString();

            string campos = "MUNICIPIO,COD_DEPTO";
            string valores = $"'{municipio}','{departamento}'";

            if (db.Save("MUNICIPIOS", campos, valores))
            {
                h.Success($"El Municipio '{municipio}' ha sido Registrado Con Exito");
                Nuevo();
            }
            else
            {
                h.advertencia("Error Al registrar el Municipio");
            }
        }

        private void Nuevo()
        {
            BtnNuevo.Enabled = true;
            BtnCancelarOp.Enabled = false;
            BtnRegistrar.Enabled = false;
            ClearnForm();
            TxtMunicipio.Enabled = false;
            CmbDepartamento.Enabled = false;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            BtnCancelarOp.Enabled = true;
            BtnRegistrar.Enabled = true;
            BtnNuevo.Enabled = false;
            TxtMunicipio.Enabled = true;
            CmbDepartamento.Enabled = true;
        }

        private void BtnCancelarOp_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea cancelar la operación?";

            if (h.Question(msg) == true)
            {
                ClearnForm(); // Limpiar los controles
                Nuevo();
            }
        }

        private void ClearnForm()
        {
            TxtMunicipio.Clear();
            CmbDepartamento.SelectedIndex = -1;
        }

        public void RecibirDatosMuni(string codigo, string municipio, string estado, string departamento)
        {
            TxtMunicipio.Enabled = true;
            TxtMunicipio.Text = municipio;
            CmbDepartamento.Text = departamento; // Muestra el nombre del departamento
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnReactivar.Enabled = false;
            CmbDepartamento.Enabled = true;
            TxtCodigo.Text = codigo;
        }

        public void RecibirDatosElimMuni(string codigo, string municipio, string estado, string departamento)
        {
            TxtMunicipio.Enabled = false;
            TxtMunicipio.Text = municipio;
            CmbDepartamento.Text = departamento; // Muestra el nombre del departamento
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnReactivar.Enabled = true;
            CmbDepartamento.Enabled = false;
            TxtCodigo.Text = codigo;
        }



        private void BtBuscar_Click(object sender, EventArgs e)
        {
            Formularios.Sistema.FrmBuscarMuni buscar = new FrmBuscarMuni();
            this.AddOwnedForm(buscar);
            ClearnForm();
            buscar.Show();
        }

        private void BtnverElim_Click(object sender, EventArgs e)
        {
            Formularios.Sistema.FrmVerMunEli buscar = new FrmVerMunEli();
            this.AddOwnedForm(buscar);
            ClearnForm();
            buscar.Show();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string codigo = TxtCodigo.Text.Trim();
            string municipio = TxtMunicipio.Text.Trim();
            string departamento = CmbDepartamento.SelectedValue.ToString();

            string actualizar = $"MUNICIPIO='{municipio}', COD_DEPTO='{departamento}'";
            string condicion = $"CODIGO='{codigo}'";

            if (db.UpdateInner("MUNICIPIOS", actualizar, condicion) > 0)
            {
                h.Success("Los Datos Se actualizaron con Exito");
                Nuevo();
            }
            else
            {
                h.advertencia("Error al Actualizar el Municipio");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea marcar este Municipio como Inactivo?";

            if (h.Question(msg) == true)
            {
                string codigo = TxtCodigo.Text.Trim();
                string actualizar = $"ESTADO='I'";
                string condicion = $"CODIGO='{codigo}'";

                if (db.update("MUNICIPIOS", actualizar, condicion) > 0)
                {
                    h.Success("El Municipio se ha marcado como Inactivo con Éxito");
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
            string msg = "¿Desea marcar este Municipio como Activo?";

            if (h.Question(msg) == true)
            {
                string codigo = TxtCodigo.Text.Trim();
                string actualizar = $"ESTADO='A'";
                string condicion = $"CODIGO='{codigo}'";

                if (db.update("MUNICIPIOS", actualizar, condicion) > 0)
                {
                    h.Success("El Municipio se ha marcado como Activo con Éxito");
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
