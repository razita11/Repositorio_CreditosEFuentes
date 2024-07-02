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

namespace Gestion_Creditos_EFuentes.Formularios.Sistema
{
   
    public partial class FrmZonas : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        public FrmZonas()
        {
            InitializeComponent();
        }

        private void FrmZonas_Load(object sender, EventArgs e)
        {
            ListarenCmbDepto();
            Nuevo();

        }
        private void ListarenCmbDepto()
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

        private void ListarenCmbMuni(int codDepto)
        {
            string condition = $"COD_DEPTO = {codDepto}";
            DataTable dt = db.Find("MUNICIPIOS", "CODIGO, MUNICIPIO", condition);

            if (dt != null && dt.Rows.Count > 0)
            {
                CmbMunicipio.DataSource = dt;
                CmbMunicipio.DisplayMember = "MUNICIPIO";
                CmbMunicipio.ValueMember = "CODIGO";
            }
            else
            {
                CmbMunicipio.DataSource = null;
            }
        }

        private void CmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbDepartamento.SelectedItem != null)
            {
                DataRowView drv = CmbDepartamento.SelectedItem as DataRowView;
                int codDepto = Convert.ToInt32(drv["CODIGO"]);
                ListarenCmbMuni(codDepto);
            }
        }

        private void CmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtZona_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string zona = TxtZona.Text.Trim();
            string departamneto = CmbDepartamento.SelectedValue.ToString();
            string municipio = CmbMunicipio.SelectedValue.ToString();

            string campos = "ZONA,COD_DEPTO,COD_MUNI";
            string valores = $"'{zona}','{departamneto}','{municipio}'";

            if (db.Save("ZONAS", campos, valores))
            {
                h.Success($"la zona {zona} ha sido Registrada con Exito");
                Nuevo();
            }
            else
            {
                h.advertencia("Error al registrar la Zona");
            }
        }

        private void Nuevo()
        {
            BtnNuevo.Enabled = true;
            BtnCancelarOp.Enabled = false;
            BtnRegistrar.Enabled = false;
            ClearnForm();
            TxtZona.Enabled = false;
            CmbDepartamento.Enabled = false;
            CmbMunicipio.Enabled = false;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            BtnCancelarOp.Enabled = true;
            BtnRegistrar.Enabled = true;
            BtnNuevo.Enabled = false;
            TxtZona.Enabled = true;
            CmbDepartamento.Enabled = true;
            CmbMunicipio.Enabled = true;
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
            TxtZona.Clear();
            CmbDepartamento.SelectedIndex = -1;
            CmbMunicipio.SelectedIndex = -1;
        }

        public void RecibirDatosZona(string codigo, string zona, string estado, string departamento,string municipio)
        {
            TxtZona.Enabled = true;
            TxtZona.Text = zona;
            CmbMunicipio.Text = municipio;
            CmbDepartamento.Text = departamento; // Muestra el nombre del departamento
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnReactivar.Enabled = false;
            CmbDepartamento.Enabled = true;
            CmbMunicipio.Enabled = true;
            TxtCodigo.Text = codigo;
        }

        public void RecibirDatosElimZona(string codigo, string zona, string estado, string departamento, string municipio)
        {
            TxtZona.Enabled = true;
            TxtZona.Text = zona;
            CmbMunicipio.Text = municipio;
            CmbDepartamento.Text = departamento; // Muestra el nombre del departamento
            BtnActualizar.Enabled =false;
            BtnEliminar.Enabled = false;
            BtnReactivar.Enabled = true;
            CmbDepartamento.Enabled = false;
            CmbMunicipio.Enabled = false;
            TxtCodigo.Text = codigo;
            TxtCodigo.Enabled = false;
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            Formularios.Sistema.FrmBuscarZona buscar = new FrmBuscarZona();
            this.AddOwnedForm(buscar);
            ClearnForm();
            buscar.Show();
        }

        private void BtnverElim_Click(object sender, EventArgs e)
        {
            Formularios.Sistema.FrmVerZonElim buscar = new FrmVerZonElim();
            this.AddOwnedForm(buscar);
            ClearnForm();
            buscar.Show();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string codigo = TxtCodigo.Text.Trim();
            string zona = TxtZona.Text.Trim();
            string departamento = CmbDepartamento.SelectedValue.ToString();
            string municipio = CmbMunicipio.SelectedValue.ToString();

            string actualizar = $"ZONA='{zona}', COD_DEPTO='{departamento}', COD_MUNI='{municipio}'";
            string condicion = $"CODIGO='{codigo}'";

            if (db.UpdateInner("ZONAS", actualizar, condicion) > 0)
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
            string msg = "¿Desea marcar esta Zona como Inactivo?";

            if (h.Question(msg) == true)
            {
                string codigo = TxtCodigo.Text.Trim();
                string actualizar = $"ESTADO='I'";
                string condicion = $"CODIGO='{codigo}'";

                if (db.update("ZONAS", actualizar, condicion) > 0)
                {
                    h.Success("La Zona se ha marcado como Inactivo con Éxito");
                    ClearnForm();
                }
                else
                {
                    h.advertencia("Error al actualizar el estado de la Zona.");
                }
            }
        }

        private void BtnReactivar_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea marcar esta Zona como Activo?";

            if (h.Question(msg) == true)
            {
                string codigo = TxtCodigo.Text.Trim();
                string actualizar = $"ESTADO='A'";
                string condicion = $"CODIGO='{codigo}'";

                if (db.update("ZONAS", actualizar, condicion) > 0)
                {
                    h.Success("La Zona se ha marcado como Activo con Éxito");
                    ClearnForm();
                }
                else
                {
                    h.advertencia("Error al actualizar el estado de la Zona.");
                }
            }

        }
    }
}
