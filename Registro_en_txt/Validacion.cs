using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Registro_en_txt
{
    public class Validacion
    {
        public static bool TelefonoValido(string valor)
        {
            return valor.All(char.IsDigit) && valor.Length == 10;
        }

        public static bool TextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }

        public static bool EstaturaValido(string valor)
        {
            if (double.TryParse(valor, out double estatura))
            {
                return estatura >= 0.5 && estatura <= 2.5;
            }
            return false;
        }

        public static bool EdadValido(string valor)
        {
            if (int.TryParse(valor, out int edad))
            {
                return edad >= 1 && edad <= 120;
            }
            return false;
        }
    }
}
