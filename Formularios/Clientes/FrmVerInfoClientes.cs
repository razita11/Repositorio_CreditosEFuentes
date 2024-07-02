using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Creditos_EFuentes.Formularios.Clientes
{
    public partial class FrmVerInfoClientes : Form
    {

        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        string dni, nombre, direccion, correo, genero, celular, telefono, imagen, fecha, tipo, estado;

        private void BtCancelarOP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FrmVerInfoClientes()
        {
            InitializeComponent();
        }

        private void FrmVerInfoClientes_Load(object sender, EventArgs e)
        {
            DeshabilitarCampos();
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void DeshabilitarCampos()
        {
            TxtDni.Enabled = false;
            TxtNombre.Enabled = false;
            DtpFechaNac.Enabled = false;
            TxtCorreo.Enabled = false;
            TxtDireccion.Enabled = false;
            TxtCelular.Enabled = false;
            TxtTelefono.Enabled = false;
            TxtEstado.Enabled = false;
            CmbTipo.Enabled = false;
            CmbGenero.Enabled = false;
        }

        public void RecibirDatosClienteElim(string dni, string nombre, string fecha, string correo, string direccion, string celular, string telefono, string tipo, string genero,string estado, byte[] foto)
        {
            TxtDni.Text = dni;
            TxtNombre.Text = nombre;
            DtpFechaNac.Text = fecha;
            TxtCorreo.Text = correo;
            TxtDireccion.Text = direccion;
            TxtCelular.Text = celular;
            TxtTelefono.Text = telefono;
            CmbTipo.Text = tipo;
            CmbGenero.Text = genero;
            TxtEstado.Text = estado;


            if (foto != null && foto.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(foto))
                {
                    ImgCli.Image = Image.FromStream(ms);
                }
            }
            else
            {
                ImgCli.Image = null; // O establecer una imagen por defecto
            }

        }

        private void ClearForm()
        {
            TxtDni.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtCorreo.Clear();
            CmbGenero.SelectedIndex = -1;
            TxtCelular.Clear();
            TxtTelefono.Clear();
            TxtEstado.Clear();
            DtpFechaNac.Value = DateTime.Now;
            CmbTipo.SelectedIndex = -1;
            ImgCli.Image = null;
        }


    }
}
