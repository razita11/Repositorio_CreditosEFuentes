using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Creditos_EFuentes.Formularios.Clientes
{
    public partial class FrmEditarElimClientes : Form
    {

        Clases.DB db = new Clases.DB ();
        Clases.Helpers h = new Clases.Helpers ();
        Clases.Auth auth = new Clases.Auth();
        string dni, nombre, direccion, correo, genero, celular, telefono, foto, fecha, tipo;

        private void BtnEliminarUser_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea marcar este cliente como Inactivo?";

            if (h.Question(msg) == true)
            {
                string dni = TxtDni.Text.Trim();
                string actualizar = $"ESTADO='INACTIVO'";
                string condicion = $"DNI='{dni}'";

                string nombre = TxtNombre.Text.Trim();
                string userlog = auth.ObtenerUsuarioSesion();
                string accion = "Eliminar";
                string tabla = "CLIENTES";
                string detalle = $"El Usuario {userlog}, Activó el Boton Eliminar para Actualizar los datos del Cliente {nombre} a estado Inactivo";
                string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
                string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";


                if (db.update("CLIENTES", actualizar, condicion) > 0)
                {
                    db.Save("LOG", camposlog, valoreslog);
                    h.Success("El Cliente se ha marcado como INACTIVO con Éxito");
                    ClearForm();
                    DeshabilitarCampos();
                    DeshabilitarBotones();
                }
                else
                {
                    h.advertencia("Error al actualizar el estado del usuario.");
                }
            }
        }

        private void FrmEditarElimClientes_Load(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            DeshabilitarBotones();
        }

        private void DeshabilitarBotones()
        {
            BtnEliminarUser.Enabled = false;
            BtnLogo.Enabled = false;
            BtnReacitvar.Enabled = false;
            BtnActualizarUser.Enabled = false;
        }

        private void BtnVerElim_Click(object sender, EventArgs e)
        {
            Formularios.Clientes.FrmVerClienteEliminado eliminados = new FrmVerClienteEliminado();
            this.AddOwnedForm(eliminados);
            eliminados.Show();

        }

        private void BtnReacitvar_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea marcar este cliente como Activo?";

            if (h.Question(msg) == true)
            {
                string dni = TxtDni.Text.Trim();
                string actualizar = $"ESTADO='ACTIVO'";
                string condicion = $"DNI='{dni}'";

                string nombre = TxtNombre.Text.Trim();
                string userlog = auth.ObtenerUsuarioSesion();
                string accion = "Reactivar";
                string tabla = "CLIENTES";
                string detalle = $"El Usuario {userlog}, Activó el Boton Reactivar para Actualizar los datos del Cliente {nombre} a estado Activo";
                string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
                string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";

                if (db.update("CLIENTES", actualizar, condicion) > 0)
                {
                    db.Save("LOG", camposlog, valoreslog);
                    h.Success("El Cliente se ha marcado como Activo con Éxito");
                    ClearForm();
                    DeshabilitarCampos();
                    BtnActualizarUser.Enabled = true;
                    BtnEliminarUser.Enabled = true;
                }
                else
                {
                    h.advertencia("Error al actualizar el estado del usuario.");
                }
            }
            DeshabilitarBotones();
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

        private void BtCancelarOP_Click(object sender, EventArgs e)
        {
            if (h.Question("¿Está seguro de que desea cancelar la operación?"))
            {
                ClearForm();
                DeshabilitarCampos();
                DeshabilitarBotones();
            }
        }

        public FrmEditarElimClientes()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Formularios.Clientes.FrmBuscarCliente buscar = new FrmBuscarCliente();
            this.AddOwnedForm(buscar);
            ClearForm();
            buscar.Show();
        }

        private void ImgCli_Click(object sender, EventArgs e)
        {

        }

        public void RecibirDatosClienteElim(string dni, string nombre, string fecha, string correo, string direccion, string celular, string telefono, string tipo, string genero, string fotoPath)
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

            if (!string.IsNullOrEmpty(fotoPath) && File.Exists(fotoPath))
            {
                ImgCli.Image = Image.FromFile(fotoPath);
            }
            else
            {
                ImgCli.Image = null; // O establecer una imagen por defecto
            }

            DeshabilitarCampos();
            BtnActualizarUser.Enabled = false;
            BtnEliminarUser.Enabled = false;
            BtnReacitvar.Enabled = true;

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
            CmbTipo.Enabled = false;
            CmbGenero.Enabled = false;
        }

        private void BtnRequisitos_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text.Trim();
            string dni = TxtDni.Text.Trim();

            Formularios.Documentos_Cliente.FrmRequisitos requisitos = new Formularios.Documentos_Cliente.FrmRequisitos(nombre, dni);
            this.AddOwnedForm(requisitos);
            ClearForm();
            requisitos.Show();
        }

        private void HabilitarCampos()
        {
            TxtDni.Enabled = true;
            TxtNombre.Enabled = true;
            DtpFechaNac.Enabled = true;
            TxtCorreo.Enabled = true;
            TxtDireccion.Enabled = true;
            TxtCelular.Enabled = true;
            TxtTelefono.Enabled = true;
            CmbTipo.Enabled = true;
            CmbGenero.Enabled = true;
        }

        public void RecibirDatosCliente(string dni, string nombre, string fecha, string correo, string direccion, string celular, string telefono, string tipo, string genero, string fotoPath)
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

            if (!string.IsNullOrEmpty(fotoPath) && File.Exists(fotoPath))
            {
                ImgCli.Image = Image.FromFile(fotoPath);
            }
            else
            {
                ImgCli.Image = null; // O establecer una imagen por defecto
            }

            BtnEliminarUser.Enabled = true;
            BtnActualizarUser.Enabled = true;
            BtnLogo.Enabled = true;
            BtnReacitvar.Enabled = false;
            HabilitarCampos();
            TxtDni.Enabled = false;
        }


        private Image ConvertByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void SetValues()
        {
            dni = TxtDni.Text.Trim();
            nombre = TxtNombre.Text.Trim();
            direccion = TxtDireccion.Text.Trim();
            correo = TxtCorreo.Text.Trim();
            genero = CmbGenero.Text.Trim();
            celular = TxtCelular.Text.Trim();
            telefono = TxtTelefono.Text.Trim();
            fecha = DtpFechaNac.Text.Trim();
            tipo = CmbTipo.Text.Trim();
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

        private string GetImageSavePath()
        {
            DataTable result = db.Find("CONFIG_APP", "VALOR", "CLAVE = 'SERVER_FILES'");
            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["VALOR"].ToString();
            }

            throw new Exception("No se encontró la clave 'SERVER_FILES' en la configuración de la aplicación.");
        }


        private string SaveImageAndGetUrl(Image image, string dni)
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

        private void BtnActualizarUser_Click(object sender, EventArgs e)
        {
            SetValues();

            string actualizar = $"DNI='{dni}',TIPO='{tipo}',NOMBRE_RAZON='{nombre}',DIRECCION='{direccion}',TELEFONO='{telefono}',CELULAR='{celular}',GENERO='{genero}',FECHA_N='{fecha}',CORREO='{correo}'";
            string condicion = $"DNI='{dni}'";

            // Solo actualiza la imagen si una nueva imagen ha sido seleccionada
            if (ImgCli.Image != null)
            {
                string nuevaRutaImagen = SaveImageAndGetUrl(ImgCli.Image, dni);
                if (nuevaRutaImagen == null)
                {
                    h.advertencia("Error al guardar la imagen del cliente.");
                    return;
                }
                actualizar += $",FOTO='{nuevaRutaImagen}'";
            }

            string userlog = auth.ObtenerUsuarioSesion();
            string accion = "Actualizar";
            string tabla = "CLIENTES";
            string detalle = $"El Usuario {userlog}, activó el botón Actualizar para actualizar los datos del cliente {nombre}";
            string camposlog = "USUARIO,ACCION,TABLA,DETALLE";
            string valoreslog = $"'{userlog}','{accion}','{tabla}','{detalle}'";

            if (db.update("CLIENTES", actualizar, condicion) > 0)
            {
                db.Save("LOG", camposlog, valoreslog);
                h.Success("Los datos se actualizaron con éxito");
                ClearForm();
                DeshabilitarBotones();
                DeshabilitarCampos();
            }
            else
            {
                h.advertencia("Error al actualizar al cliente");
            }
            BtnReacitvar.Enabled = true;

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
    }
}
