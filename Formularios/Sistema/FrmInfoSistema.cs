using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO; // Necesario para MemoryStream
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gestion_Creditos_EFuentes.Formularios.Sistema
{
    public partial class FrmInfoSistema : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        public FrmInfoSistema()
        {
            InitializeComponent();
        }

        private void FrmInfoSistema_Load(object sender, EventArgs e)
        {
            VerificarDatos();
            GetInfoFinanciera();
        }

        private void SetTextBoxesEnabled(bool enabled)
        {
            TxtRtn.Enabled = enabled;
            TxtNombre.Enabled = enabled;
            TxtDireccion.Enabled = enabled;
            TxtTelefono.Enabled = enabled;
            TxtCorreo.Enabled = enabled;
            TxtWeb.Enabled = enabled;
            // Si tienes más TextBox, agrégalos aquí
        }

        private void VerificarDatos()
        {
            DataTable dt = db.Find("FINANCIERA", "*");

            if (dt != null && dt.Rows.Count > 0)
            {
                // Si hay datos, deshabilitar todos los botones menos el de eliminar
                BtnNuevo.Enabled = false;
                BtnRegistrar.Enabled = false;
                BtnCancelarOp.Enabled = false;
                BtnEliminar.Enabled = true;
                SetTextBoxesEnabled(false); // Deshabilitar TextBox
            }
            else
            {
                // Si no hay datos, habilitar solo el botón de nuevo
                BtnNuevo.Enabled = true;
                BtnRegistrar.Enabled = false;
                BtnCancelarOp.Enabled = false;
                BtnEliminar.Enabled = false;
            }
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            // Habilitar todos los botones menos el de eliminar
            BtnRegistrar.Enabled = true;
            BtnCancelarOp.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnEliminar.Enabled = false;
            SetTextBoxesEnabled(true); // Habilitar TextBox
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

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string valores, campos;
            string rtn = TxtRtn.Text.Trim();
            string nombre = TxtNombre.Text.Trim();
            string direccion = TxtDireccion.Text.Trim();
            string telefono = TxtTelefono.Text.Trim();
            string correo = TxtCorreo.Text.Trim();
            string web = TxtWeb.Text.Trim();
            byte[] logo1 = ConvertImageToByteArray(ImgCli.Image);

            campos = "RTN,NOMBRE_RAZON,DIRECCION,TELEFONOS,CORREO,WEBSITE,LOGO1";
            valores = $"'{rtn}','{nombre}','{direccion}','{telefono}','{correo}','{web}',@logo1";

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@logo1", logo1);

            if (db.Saveimage("FINANCIERA", campos, valores, parametros))
            {
                h.Success("Registro de Datos Exitoso");
            }
            else
            {
                h.advertencia("Error al Registrar Los datos");
            }


        }

        bool targer = false;
        private void GetInfoFinanciera()
        {
            DataTable usuarios = db.Find("FINANCIERA", "*");
            if (usuarios.Rows.Count > 0)
            {
                DataRow info = usuarios.Rows[0];

                TxtRtn.Text = info["RTN"].ToString();
                TxtNombre.Text = info["NOMBRE_RAZON"].ToString();
                TxtDireccion.Text = info["DIRECCION"].ToString();
                TxtTelefono.Text = info["TELEFONOS"].ToString();
                TxtCorreo.Text = info["CORREO"].ToString();
                TxtWeb.Text = info["WEBSITE"].ToString();

                if (info["LOGO1"] != DBNull.Value)
                {
                    byte[] logoBytes = (byte[])info["LOGO1"];
                    using (MemoryStream ms = new MemoryStream(logoBytes))
                    {
                        ImgCli.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        private void BtnCancelarOp_Click(object sender, EventArgs e)
        {
            VerificarDatos();
            SetTextBoxesEnabled(false);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea Eliminar los datos de la empresa?";

            if (h.Question(msg) == true)
            {
                if (db.Destroy("FINANCIERA", "1=1") > 0)
                {
                    h.Success("Los datos de la empresa se eliminaron con éxito");
                    VerificarDatos();
                }
            }
        }

        private void TxtRtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult resultado = foto.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ImgCli.Image = Image.FromFile(foto.FileName);
            }
        }

        private void ImgCli_Click(object sender, EventArgs e)
        {

        }

        private void FrmInfoSistema_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = h.OnlyNumbers(e) ? false : true;
        }
    }
}
