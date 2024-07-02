using Gestion_Creditos_EFuentes.Clases;
using Gestion_Creditos_EFuentes.Formularios.Documentos_Cliente;
using Gestion_Creditos_EFuentes.Formularios.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Creditos_EFuentes.Formularios
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            Formularios.Usuarios.FrmUsuarios usuarios = new Formularios.Usuarios.FrmUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void rOLESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios.FrmEditarElim frmEditarElim = new Usuarios.FrmEditarElim();
            frmEditarElim.MdiParent = this;
            frmEditarElim.Show();
        }

        private void PermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios.FrmActualizarPermisos frmpermisos = new Usuarios.FrmActualizarPermisos();
            frmpermisos.MdiParent = this;
            frmpermisos.Show();
        }

        private void agregarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema.FrmInfoSistema sistema = new Sistema.FrmInfoSistema();
            sistema.MdiParent = this;
            sistema.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios.FrmListarUsers users = new FrmListarUsers();
            users.MdiParent = this; 
            users.Show();   
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Clientes.FrmRegistrarClientes clientes = new Clientes.FrmRegistrarClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clientes.FrmEditarElimClientes frmEdita = new Clientes.FrmEditarElimClientes();
            frmEdita.MdiParent = this;
            frmEdita.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.FrmListarClientes frmListar = new Clientes.FrmListarClientes();
            frmListar.MdiParent = this;
            frmListar.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema.FrmDepartamentos departamentos = new Sistema.FrmDepartamentos();
            departamentos.MdiParent = this;
            departamentos.Show();
        }

        private void municipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema.FrmMunicipio municipio = new Sistema.FrmMunicipio();
            municipio.MdiParent = this;
            municipio.Show();
        }

        private void zonasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sistema.FrmZonas zonas = new Sistema.FrmZonas();
            zonas.MdiParent = this;
            zonas.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roles.FrmRoles roles = new Roles.FrmRoles();
            roles.MdiParent = this;
            roles.Show();
        }

        private void avalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Avales.FrmAvales avales = new Avales.FrmAvales();
            avales.MdiParent = this;
            avales.Show();
        }

        private void editarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Avales.FrmEditElimAvales avales = new Avales.FrmEditElimAvales();
            avales.MdiParent = this;
            avales.Show();
        }

        private void servidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServer servidor = new FrmServer();   
            servidor.MdiParent = this;  
            servidor.Show();       
        }

        private void registrarDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarRequisitos requi = new FrmRegistrarRequisitos();
            requi.MdiParent = this;
            requi.Show();
        }
    }
}
