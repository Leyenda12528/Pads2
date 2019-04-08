using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoads2.Base
{
    class Help1
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
    }
}
