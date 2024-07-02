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
    public partial class FrmVerEliminados : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        Clases.Auth auth = new Clases.Auth();

        string usuario, nombre, contraseña, correo, fechanac, rol;

        private void BtnActualizarUser_Click(object sender, EventArgs e)
        {
            
            string msg = "¿Desea marcar este usuario como Activo?";

            if (h.Question(msg) == true)
            {
                string usuario = TxtUsuario.Text.Trim();
                string actualizar = $"ESTADO='ACTIVO'";
                string condicion = $"USUARIO='{usuario}'";

                string userlog = auth.ObtenerUsuarioSesion();
                string accion = "Actualizar";
                string tabla = "USUARIOS";
                string detalle = $"El Usuario {userlog}, Activó el Boton Actualizar para Actualizar los datos del Usuario  {usuario}  a estado Activo";
                string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
                string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";

                if (db.update("USUARIOS", actualizar, condicion) > 0)
                {

                    db.Save("LOG",camposlog,valoreslog);
                    h.Success("El Usuario se ha marcado como Activado con Éxito");
                    ClearForm();
                    ListarUsuarios();
                }
                else
                {
                    h.advertencia("Error al actualizar el estado del usuario.");
                }
            }
        }

        private void DgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Rows.Count > 0)
            {
                string _usuarios = DgvData.CurrentRow.Cells[0].Value.ToString();
                getInfoUsuarios(_usuarios);
            }
        }

        public FrmVerEliminados()
        {
            InitializeComponent();
        }

        private void FrmVerEliminados_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
            ListarenCmb();
        }

        private void SetValues()
        {
            usuario = TxtUsuario.Text;
            nombre = TxtNombre.Text;
            //contraseña = TxtContraseña.Text;
            correo = TxtCorreo.Text;
            fechanac = DtpFechaNac.Text;
            rol = CmbRol.SelectedValue.ToString(); // Obtener el ID del rol seleccionado
        }

        private void ListarUsuarios(string usuario = " ")
        {
            DataTable usuarios;
            string condicion = "u.ESTADO = 'INACTIVO'";

            if (usuario != " ")
            {
                condicion += $" AND u.USUARIO LIKE '%{usuario}%'";
            }

            usuarios = db.Find("USUARIOS u JOIN ROLES r ON u.ROL_ID = r.ID", "u.USUARIO, u.CLAVE, u.NOMBRE, u.GENERO, u.FECHA_N, u.CORREO, r.ROL, u.ESTADO, u.REGISTRO", condicion);

            DgvData.Rows.Clear();

            string _usuarios, _nombre, _clave, _fechanac, _correo, _rol, _estado, _genero, _registro;
            foreach (DataRow Usuario in usuarios.Rows)
            {
                _usuarios = Usuario["USUARIO"].ToString();
                _clave = Usuario["CLAVE"].ToString();
                _nombre = Usuario["NOMBRE"].ToString();
                _genero = Usuario["GENERO"].ToString();
                _fechanac = Usuario["FECHA_N"].ToString();
                _correo = Usuario["CORREO"].ToString();
                _rol = Usuario["ROL"].ToString();
                _estado = Usuario["ESTADO"].ToString();
                _registro = Usuario["REGISTRO"].ToString();
                DgvData.Rows.Add(_usuarios, _nombre, _rol, _registro);
            }

            usuarios.Dispose();
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

        private void getInfoUsuarios(string usuario)
        {
            

            DataTable Usuario = db.Find("USUARIOS", "*", $"USUARIO='{usuario}'");
            if (Usuario.Rows.Count > 0)
            {
                DataRow info = Usuario.Rows[0];
                TxtEstado.Text = info["ESTADO"].ToString();
                TxtUsuario.Text = info["USUARIO"].ToString();
                TxtNombre.Text = info["NOMBRE"].ToString();
                //TxtContraseña.Text = info["CLAVE"].ToString();
                TxtCorreo.Text = info["CORREO"].ToString();
                DtpFechaNac.Text = info["FECHA_N"].ToString();
                CmbRol.SelectedValue = info["ROL_ID"]; // Seleccionar el rol basado en el rol_id
            }
            
        }

        private void ClearForm()
        {
            TxtUsuario.Clear();
            TxtNombre.Clear();
            //TxtContraseña.Clear();
            TxtCorreo.Clear();
        }



    }
}
