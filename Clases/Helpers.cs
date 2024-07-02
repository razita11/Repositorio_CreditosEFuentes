using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Creditos_EFuentes.Clases
{
    internal class Helpers
    {
        // Propiedades para los botones de las alertas

        MessageBoxButtons botones;
        MessageBoxIcon icono;

        public void advertencia(string msg_advertencia)
        {
            botones = MessageBoxButtons.OK;
            icono = MessageBoxIcon.Warning;
            MessageBox.Show(msg_advertencia, "Advertencia", botones, icono);
        }

        public void Success(string msg)
        {
            botones = MessageBoxButtons.OK;
            icono = MessageBoxIcon.Information;
            MessageBox.Show(msg, "Exito", botones, icono);

        }

        public bool Question(string msg)
        {
            bool resp = false;
            botones = MessageBoxButtons.YesNo;
            icono = MessageBoxIcon.Question;
            if (MessageBox.Show(msg, "Confirmar", botones, icono) == DialogResult.Yes)
            {
                resp = true;
            }
            return resp;
        }

        public bool OnlyNumbers(KeyPressEventArgs e)
        {
            bool resp = false;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
            {
                resp = true;
            }

            return resp; 
        }

        public bool Money(KeyPressEventArgs e)
        {
            bool resp = false;
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (Char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
            {
                resp = true;
            }
            return resp;
        }

        public string slug(string str)
        {
            string _slug = "";
            _slug = str.Replace(" ", "");
            _slug = _slug.Replace("/", "");
            _slug = _slug.Replace(@"\", "");
            return _slug;
        }

        public string cleanStr(string str)
        {
            string strout = ""; //Cadena de salida

            try
            {
                //Arreglo caracteres prohibidos
                string[] forbiddenchars = { "'", "=", "<", ">", ";", "\\", "?", "¡", "¿", "!", "´" };
                int i, j; //variables para iterar ciclos
                int coinc; //coincidencias

                for (i = 0; i < str.Length; i++)
                {
                    coinc = 0;
                    for (j = 0; j < forbiddenchars.Length; j++)
                    {
                        coinc = str.Substring(i, 1) == forbiddenchars[j] ? coinc + 1 : coinc + 0;
                    }
                    strout = coinc == 0 ? strout + str.Substring(i, 1) : strout;
                }

            }
            catch (Exception error)
            {
                advertencia(error.Message);
            }

            return strout;
        }
    }
}
