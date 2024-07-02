using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Gestion_Creditos_EFuentes.Formularios
{
    public partial class FrmServer : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();

        string server_files, back_files;
        public FrmServer()
        {
            InitializeComponent();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            validar();
            if (validar() == 0)
            {
                server_files = FormatearRuta(server_files);
                back_files = FormatearRuta(back_files);

                string actualizar = $"VALOR='{server_files}'";
                db.update("CONFIG_APP", actualizar, "CLAVE = 'SERVER_FILES'");
                string campo = $"VALOR='{back_files}'";
                db.update("CONFIG_APP", campo, "CLAVE = 'BACKUPS'");

                h.Success("La configuracion se guardo con Exito");
                this.Close();
            }




        }

        private string FormatearRuta(string ruta)
        {
            string path = " ";
            int lenght = ruta.Length;
            string last_char= ruta.Substring(lenght-1,1); 

            if (last_char == @"\")
            {

                path = ruta;
            }
            else
            {
                path = ruta + @"\";
            }

            return path;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            PathDialog.ShowDialog();
            TxtPathRuta.Text = PathDialog.SelectedPath.ToString();
        }

        private int validar()
        {
            int errors = 0;
            server_files = TxtPathRuta.Text.Trim();
            back_files = TxtPathBackups.Text.Trim();

            string Path_Server_Files = server_files;
            string backups = back_files;
            if (!Directory.Exists(Path_Server_Files))
            {
                h.advertencia("La Ruta que ingresó no pudo ser comprobada !");
                errors++;
                TxtPathRuta.Focus();
                return errors;
            }

            if (!Directory.Exists(backups))
            {
                h.advertencia("La Ruta que ingresó no pudo ser comprobada !");
                errors++;
                TxtPathBackups.Focus();
                return errors;
            }
            return errors;
        }
    }
}
