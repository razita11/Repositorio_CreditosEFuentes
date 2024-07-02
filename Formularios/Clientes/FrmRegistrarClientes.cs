using Gestion_Creditos_EFuentes.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gestion_Creditos_EFuentes.Formularios.Clientes
{
    public partial class FrmRegistrarClientes : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        Clases.Auth auth = new Clases.Auth();



        private bool isLoading = false;
        private string lastDni = "";
        private string ImagePath;
        private void CheckClientExists()
        {
            string dni = TxtDni.Text; // Asume que tienes un campo de texto para el DNI.
            string nombre = GetClientNameByDni(dni);

            if (!string.IsNullOrEmpty(nombre))
            {
                h.advertencia($"EL CLIENTE YA EXISTE: {nombre}");
                BtnRegistrarCliente.Enabled = false;
            }
            else
            {
                BtnRegistrarCliente.Enabled = true;
            }
        }

        private string GetClientNameByDni(string dni)
        {
            string query = $"SELECT NOMBRE_RAZON FROM CLIENTES WHERE DNI = '{dni}' AND ESTADO = 'ACTIVO'";

            DataTable result = db.Find("CLIENTES", "NOMBRE_RAZON", $"DNI = '{dni}' AND ESTADO = 'ACTIVO'");

            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["NOMBRE_RAZON"].ToString();
            }

            return null;
        }


        private string SaveImageAndGetUrl(Image image)
        {
            if (image == null)
                return null;

            string basePath = GetImageSavePath(); // Obtener la ruta base desde la base de datos
            string fileName = $"{Guid.NewGuid()}.jpg";
            string fullPath = Path.Combine(basePath, fileName);

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                File.WriteAllBytes(fullPath, ms.ToArray());
            }

            return fullPath;
        }

        private string GetImageSavePath()
        {
            DataTable result = db.Find("CONFIG_APP", "VALOR", "CLAVE = 'SERVER_FILES'");
            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["VALOR"].ToString();
            }

            throw new Exception("No se encontró la clave 'SERVER_FILES' en la configuración de la aplicación.");
        }

        public FrmRegistrarClientes()
        {
            InitializeComponent();
        }

        private void FrmRegistrarClientes_Load(object sender, EventArgs e)
        {
            TxtDni.TextChanged += new EventHandler(TxtDni_TextChanged);

            DeshabilitarBotones();
            DeshabilitarCampos();
            BtnSalir.Enabled = true;
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

        private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            string campos;
            string valores;

            string dni, nombre, direccion, correo, genero, celular, telefono, fecha, tipo, imagenUrl;

            dni = TxtDni.Text.Trim();
            nombre = TxtNombre.Text.Trim();
            direccion = TxtDireccion.Text.Trim();
            correo = TxtCorreo.Text.Trim();
            genero = CmbGenero.Text.Trim();
            celular = TxtCelular.Text.Trim();
            telefono = TxtTelefono.Text.Trim();
            fecha = DtpFechaNac.Text.Trim();
            tipo = CmbTipo.Text.Trim();
            imagenUrl = SaveImageAndGetUrl(ImgCli.Image); // Guardar imagen y obtener la URL

            campos = "DNI,TIPO,NOMBRE_RAZON,DIRECCION,TELEFONO,CELULAR,GENERO,FECHA_N,CORREO,FOTO";
            valores = $"'{dni}','{tipo}','{nombre}','{direccion}','{telefono}','{celular}','{genero}','{fecha}','{correo}','{imagenUrl}'";

            string userlog = auth.ObtenerUsuarioSesion();
            string accion = "Registro de Cliente";
            string tabla = "CLIENTES";
            string detalle = $"El Usuario {userlog}, registró un Nuevo Cliente llamado {nombre}, con Identidad {dni}";
            string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
            string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";

            if (db.Save("CLIENTES", campos, valores))
            {
                db.Save("LOG", camposlog, valoreslog);
                h.Success("Registro de Datos Exitoso");
                ClearForm();
                DeshabilitarBotones();
                DeshabilitarCampos();
            }
            else
            {
                h.advertencia("Error al Registrar Los datos");
            }
        }

       
        private void BtnLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult resultado = foto.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ImgCli.Image = Image.FromFile(foto.FileName);
                ImagePath = foto.FileName; // Guardar la ruta de la imagen seleccionada
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
            DtpFechaNac.Value = DateTime.Now;
            CmbTipo.SelectedIndex = -1;
            ImgCli.Image = null;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            string userlog = auth.ObtenerUsuarioSesion();
            string accion = "Boton Nuevo";
            string tabla = "CLIENTES";
            string detalle = $"El Usuario {userlog}, Activó el Boton Nuevo para Registrar un Cliente ";
            string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
            string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";
            if (db.Save("LOG", camposlog, valoreslog))
            {
                HabilitarBotones();
                ClearForm();
                HabilitarCampos();
            }

        }

        private void BtnCancelarOp_Click(object sender, EventArgs e)
        {
            if (h.Question("¿Está seguro de que desea cancelar la operación?"))
            {
                ClearForm();
                DeshabilitarBotones();
                DeshabilitarCampos();
                BtnSalir.Enabled = true; // El botón salir debe estar habilitado.
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeshabilitarBotones()
        {
            BtnRegistrarCliente.Enabled = false;
            BtnLogo.Enabled = false;
            BtnCancelarOp.Enabled = false;
            BtnNuevo.Enabled = true;
            BtnSalir.Enabled = true;
        }

        private void HabilitarBotones()
        {
            BtnRegistrarCliente.Enabled = true;
            BtnLogo.Enabled = true;
            BtnCancelarOp.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnSalir.Enabled = true;
        }

        private void DeshabilitarCampos()
        {
            TxtDni.Enabled = false;
            TxtNombre.Enabled = false;
            TxtDireccion.Enabled = false;
            TxtCorreo.Enabled = false;
            CmbGenero.Enabled = false;
            TxtCelular.Enabled = false;
            TxtTelefono.Enabled = false;
            DtpFechaNac.Enabled = false;
            CmbTipo.Enabled = false;
            ImgCli.Enabled = false;
        }

        private void HabilitarCampos()
        {
            TxtDni.Enabled = true;
            TxtNombre.Enabled = true;
            TxtDireccion.Enabled = true;
            TxtCorreo.Enabled = true;
            CmbGenero.Enabled = true;
            TxtCelular.Enabled = true;
            TxtTelefono.Enabled = true;
            DtpFechaNac.Enabled = true;
            CmbTipo.Enabled = true;
            ImgCli.Enabled = true;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TxtDni_TextChanged(object sender, EventArgs e)
        {
            if (!isLoading && TxtDni.Text != lastDni)
            {
                lastDni = TxtDni.Text;
                CheckClientExists();
            }
        }
    }
}
