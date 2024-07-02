using Gestion_Creditos_EFuentes.Clases;
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

namespace Gestion_Creditos_EFuentes.Formularios.Documentos_Cliente
{
    public partial class FrmRequisitos : Form
    {

        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        Clases.Auth auth = new Clases.Auth();
        private string nombre;
        private string dni;

        public FrmRequisitos(string nombre, string dni)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.dni = dni;
        }

        private void FrmRequisitos_Load(object sender, EventArgs e)
        {
            LblNombre.Text = nombre;
            LblDoci.Text = dni;

            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvData.MultiSelect = false;
            DgvData.SelectionChanged += DgvData_SelectionChanged;

            // Define las columnas del DataGridView
            DgvData.Columns.Clear();

            DataGridViewColumn colCodigo = new DataGridViewTextBoxColumn();
            colCodigo.Name = "CODIGO";
            colCodigo.HeaderText = "Código";
            colCodigo.Width = 80; // Ajusta el ancho según sea necesario
            colCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DgvData.Columns.Add(colCodigo);

            DataGridViewColumn colDocumento = new DataGridViewTextBoxColumn();
            colDocumento.Name = "DOCUMENTO";
            colDocumento.HeaderText = "Documento";
            colDocumento.Width = 255; // Ajusta el ancho según sea necesario
            colDocumento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvData.Columns.Add(colDocumento);

            DataGridViewColumn colOblig = new DataGridViewTextBoxColumn();
            colOblig.Name = "OBLIG";
            colOblig.HeaderText = "Obligatorio";
            colOblig.Width = 90; // Ajusta el ancho según sea necesario
            colOblig.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DgvData.Columns.Add(colOblig);

            DataGridViewColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.Name = "ESTADO";
            colEstado.HeaderText = "Estado";
            colEstado.Width = 80; // Ajusta el ancho según sea necesario
            colEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DgvData.Columns.Add(colEstado);

            // Agrega la columna "Ver"
            DataGridViewButtonColumn verColumn = new DataGridViewButtonColumn();
            verColumn.Name = "Ver";
            verColumn.HeaderText = "Ver";
            verColumn.Text = "Ver";
            verColumn.UseColumnTextForButtonValue = true;
            verColumn.Width = 60; // Ajusta el ancho según sea necesario
            verColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DgvData.Columns.Add(verColumn);

            listarDocs();
        }


        private void listarDocs(string codigo = " ")
        {
            string condicion = "ESTADO = 'A'";
            if (!string.IsNullOrWhiteSpace(codigo))
            {
                condicion += $" AND CODIGO LIKE '%{codigo}%'";
            }

            string campos = "CODIGO,DOCUMENTO,OBLIG,ESTADO";
            DataTable documentos = db.Find("REQUISITOS", campos, condicion);

            DgvData.Rows.Clear();
            foreach (DataRow infodocu in documentos.Rows)
            {
                string _codigo = infodocu["CODIGO"].ToString();
                string _doc = infodocu["DOCUMENTO"].ToString();
                string _oblig = infodocu["OBLIG"].ToString();
                string _estado = infodocu["ESTADO"].ToString();

                // Check if the document is already uploaded for this client
                string condicionDoc = $"CLIENTE_DNI = '{dni}' AND REQ_ID = '{_codigo}'";
                DataTable result = db.Find("REQUISITOS_CLIENTE", "*", condicionDoc);

                int rowIndex = DgvData.Rows.Add(_codigo, _doc, _oblig, _estado);
                if (result.Rows.Count > 0)
                {
                    DgvData.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Green;
                    DgvData.Rows[rowIndex].Cells["Ver"].Tag = result.Rows[0]["PATH"].ToString(); // Store the file path
                }
                else
                {
                    DgvData.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }

        }

        private string GetSavePath(string fileName)
        {
            // Replace with actual logic to determine the save path
            DataTable config = db.Find("CONFIG_APP", "VALOR", "CLAVE = 'SERVER_FILES'");
            string basePath = config.Rows[0]["VALOR"].ToString();
            return Path.Combine(basePath, fileName);
        }



        private void LblDoci_Click(object sender, EventArgs e)
        {

        }

        private void LblNombre_Click(object sender, EventArgs e)
        {

        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            if (DgvData.SelectedRows.Count > 0)
            {
                string reqId = DgvData.SelectedRows[0].Cells["CODIGO"].Value.ToString();

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos PDF, JPG, PNG|*.pdf;*.jpg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileExtension = Path.GetExtension(filePath).ToLower();
                    string originalFileName = Path.GetFileNameWithoutExtension(filePath);
                    string dniPrefix = $"{dni}_";

                    // Generar nuevo nombre de archivo
                    int fileNumber = 1;
                    string newFileName = $"{dniPrefix}_{fileNumber}{fileExtension}";

                    // Buscar un nombre único
                    while (File.Exists(GetSavePath(newFileName)))
                    {
                        fileNumber++;
                        newFileName = $"{dniPrefix}_{fileNumber}{fileExtension}";
                    }

                    // Guardar el archivo con el nuevo nombre
                    string savePath = GetSavePath(newFileName);
                    File.Copy(filePath, savePath, true);

                    if (h.Question("¿Desea guardar este documento?") == true)
                    {
                        // Registrar el documento en la base de datos
                        string userlog = auth.ObtenerUsuarioSesion();
                        string campos = "CLIENTE_DNI, REQ_ID, PATH, USUARIO";
                        string valores = $"'{dni}', '{reqId}', '{savePath}', '{userlog}'";
                        if (db.Save("REQUISITOS_CLIENTE", campos, valores))
                        {
                            h.Success("El documento se ha cargado y registrado con éxito.");
                            listarDocs();
                        }
                        else
                        {
                            h.advertencia("Error al registrar el documento.");
                        }
                    }
                }
            }
            else
            {
                h.advertencia("Seleccione un documento de la lista.");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvData.SelectedRows.Count > 0)
            {
                string reqId = DgvData.SelectedRows[0].Cells["CODIGO"].Value.ToString();
                string filePath = DgvData.SelectedRows[0].Cells["Ver"].Tag?.ToString();

                // Confirmar la eliminación
                if (h.Question("¿Está seguro de que desea eliminar este documento?") == true)
                {
                    // Eliminar el registro de la base de datos
                    if (db.Destroy("REQUISITOS_CLIENTE", $"CLIENTE_DNI = '{dni}' AND REQ_ID = '{reqId}'")>0)
                    {
                        // Eliminar el archivo físicamente
                        if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                        {
                            File.Delete(filePath);
                        }

                        // Actualizar el DataGridView
                        listarDocs();
                        h.Success("El documento ha sido eliminado con éxito.");
                    }
                    else
                    {
                        h.advertencia("Error al eliminar el documento.");
                    }
                }
            }
            else
            {
                h.advertencia("Seleccione un documento de la lista.");
            }
            

        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvData.SelectedRows.Count > 0)
            {
                // Opcional: Puedes hacer algo cuando una fila es seleccionada
                string codigo = DgvData.SelectedRows[0].Cells["CODIGO"].Value.ToString();
                string documento = DgvData.SelectedRows[0].Cells["DOCUMENTO"].Value.ToString();
                // Puedes mostrar esta información en algún lugar si lo necesitas
            }
        }

        private void DgvData_MultiSelectChanged(object sender, EventArgs e)
        {

        }

        private void DgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvData.Columns["Ver"].Index && e.RowIndex >= 0)
            {
                string filePath = DgvData.Rows[e.RowIndex].Cells["Ver"].Tag?.ToString();
                if (!string.IsNullOrEmpty(filePath))
                {
                    System.Diagnostics.Process.Start(filePath);
                }
                else
                {
                    h.advertencia("No hay archivo disponible para ver.");
                }
            }
        }
    }
}
