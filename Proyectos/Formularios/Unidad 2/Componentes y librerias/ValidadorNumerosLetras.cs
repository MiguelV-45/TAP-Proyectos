using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InputValidator
{

    /// <summary>
    /// Clase para la validación de cadenas que contienen solo números o solo letras.
    /// </summary>
    public class ValidadorNumerosLetras
    {
        /// <summary>
        /// Verifica si una cadena contiene solo números.
        /// </summary>
        /// <param name="texto">La cadena a validar.</param>
        /// <returns>True si la cadena contiene solo números, de lo contrario, False.</returns>
        public static bool EsSoloNumeros(string texto)
        {
            return Regex.IsMatch(texto, @"^\d+$");
        }

        /// <summary>
        /// Verifica si una cadena contiene solo letras.
        /// </summary>
        /// <param name="texto">La cadena a validar.</param>
        /// <returns>True si la cadena contiene solo letras, de lo contrario, False.</returns>
        public static bool EsSoloLetras(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ]+$");
        }
    }
}
