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

namespace Gestion_Creditos_EFuentes.Formularios.Usuarios
{
    public partial class FrmActualizarPermisos : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        Clases.Auth auth = new Auth();
        public FrmActualizarPermisos()
        {
            InitializeComponent();
        }

        private void FrmActualizarPermisos_Load(object sender, EventArgs e)
        {
            ListarPermisos();
            TxtUsuario.Enabled = true;
        }

        private void ListarPermisos(string usuario = " ")
        {
            DataTable permisos;
            if (usuario == " ")
            {
                permisos = db.Find("PERMISOS","USUARIO,GUARDAR,ACTUALIZAR,ELIMINAR,IMPRIMIR,REIMPRIMIR");
            }
            else
            {
                string _condicion = $"USUARIO LIKE '%{usuario}%'";
                permisos = db.Find("PERMISOS", "USUARIO,GUARDAR,ACTUALIZAR,ELIMINAR,IMPRIMIR,REIMPRIMIR",_condicion);
            }

            DgvData.Rows.Clear();

            string _usuarios, _guardar, _actualizar, _eliminar, _imprimir, _reimprimir;
            foreach(DataRow permiso in permisos.Rows)
            {
                _usuarios = permiso["USUARIO"].ToString();
                _guardar = permiso["GUARDAR"].ToString();
                _actualizar = permiso["ACTUALIZAR"].ToString();
                _eliminar = permiso["ELIMINAR"].ToString();
                _imprimir = permiso["IMPRIMIR"].ToString();
                _reimprimir = permiso["REIMPRIMIR"].ToString();
                DgvData.Rows.Add(_usuarios, _guardar, _actualizar, _eliminar, _imprimir, _reimprimir);
            }
            permisos.Dispose();
        }

        private void getInfoPermisos(string usuario)
        {
            DataTable Usuario = db.Find("PERMISOS", "*", $"USUARIO='{usuario}'");
            if (Usuario.Rows.Count > 0)
            {
                DataRow info = Usuario.Rows[0];
                TxtUsuario.Text = info["USUARIO"].ToString();
                CmbGuardar.Text = info["GUARDAR"].ToString();
                CmbActualizar.Text = info["ACTUALIZAR"].ToString();
                CmbEliminar.Text = info["ELIMINAR"].ToString();
                CmbImprimir.Text = info["IMPRIMIR"].ToString();
                CmbReimprimir.Text = info["REIMPRIMIR"].ToString();
            }

        }

        private void DgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Rows.Count > 0)
            {
                string _usuarios = DgvData.CurrentRow.Cells[0].Value.ToString();
                getInfoPermisos(_usuarios);
            }
        }

        private void BtnActualizarPermiso_Click(object sender, EventArgs e)
        {
            string usuario = TxtUsuario.Text;
            string guardar = CmbGuardar.Text;
            string actualizarrol = CmbActualizar.Text;
            string eliminar = CmbEliminar.Text;
            string imprimir = CmbImprimir.Text;
            string reimprimir = CmbReimprimir.Text;

            string userlog = auth.ObtenerUsuarioSesion();
            string accion = "Actualizar";
            string tabla = "PERMISOS";
            string detalle = $"El Usuario {userlog}, Activó el Boton Actualizar Permiso para Actualizar los Permisos del Usuario  {usuario}";
            string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
            string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";


            string msg = "¿Desea Actualizar los permisos del Usuario?";

            if (h.Question(msg) == true)
            {
                SetValues();

                string actualizar = $"USUARIO='{usuario}',GUARDAR='{guardar}', ACTUALIZAR='{actualizarrol}',ELIMINAR='{eliminar}',IMPRIMIR='{imprimir}',REIMPRIMIR='{reimprimir}'";
                string condicion = $"USUARIO='{usuario}'";
                if (db.update("PERMISOS", actualizar, condicion) > 0)
                {
                    db.Save("LOG", camposlog, valoreslog);
                    h.Success("Los Datos se actualizaron con Éxito");
                    ListarPermisos();
                }
                else
                {
                    h.advertencia("Formato de fecha incorrecto. Utiliza el formato d/m/a (día/mes/año).");
                }
            }
        }

        private void SetValues()
        {
            
        }
    }
}
