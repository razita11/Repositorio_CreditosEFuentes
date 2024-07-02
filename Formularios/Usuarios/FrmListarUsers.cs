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
    public partial class FrmListarUsers : Form
    {
        Clases.DB db = new Clases.DB();
        Clases. Helpers h = new Clases.Helpers();
        public FrmListarUsers()
        {
            InitializeComponent();
        }

        private void FrmListarUsers_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void ListarUsuarios(string usuario = " ")
        {
            DataTable usuarios;

            if (usuario == " ")
            {
                usuarios = db.Find("USUARIOS u JOIN ROLES r ON u.ROL_ID = r.ID", "u.USUARIO, u.CLAVE, u.NOMBRE, u.GENERO, u.FECHA_N, u.CORREO, r.ROL, u.ESTADO, u.REGISTRO");
            }
            else
            {
                string _condicion = $"u.USUARIO LIKE '%{usuario}%'";
                usuarios = db.Find("USUARIOS u JOIN ROLES r ON u.ROL_ID = r.ID", "u.USUARIO, u.CLAVE, u.NOMBRE, u.GENERO, u.FECHA_N, u.CORREO, r.ROL, u.ESTADO, u.REGISTRO", _condicion);
            }

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
                DgvData.Rows.Add(_usuarios, _nombre, _rol, _registro,_estado,_correo);
            }

            usuarios.Dispose();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string usuario = TxtBuscar.Text.Trim();
            ListarUsuarios(usuario);
        }
    }
}
