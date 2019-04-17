using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoads2.Base
{
    public class Help1
    {
        private String valor = "'%;(-)º<>¿?*//\\ª!·$&=^¨¡`+´ç";
        private bool var = false;
        public Help1() { }

        internal bool valorRestringuido(char keyChar)
        {
            for (int i = 0; i < valor.Length; i++)
            {
                if (keyChar == valor[i] || keyChar == '"')
                {                    
                    var = true;
                    break;
                }
                else var = false;
            }
            return var;            
        }

        public bool validarCorreo(String text)
        {
            String correo = "^[_a-zA-Z0-9-]+(\\.[_a-zA-Z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,4})$";
             return text != null && Regex.IsMatch(text, correo);
            //if (Pattern.compile(correo).matcher(text).matches()) return true;
            //else return false;
        }        

        public bool exitsFecha(String fechaProd)
        {
            DateTime DateValue;
            Boolean dd = DateTime.TryParseExact(fechaProd, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateValue);
            return dd;
        }

        public bool dateMaxNow(String fechaProd)
        {
            DateTime fechaF = Convert.ToDateTime(fechaProd).Date;
            DateTime FechAc = DateTime.Now.Date;
            if (fechaF <= FechAc) // Si la fecha indicada es menor o igual a la fecha actual
                return false;            
            else
                return true;
            
        }

    }
}
