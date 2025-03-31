using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFCValidator
{

    /// <summary>
    /// Clase para la validación y normalización de RFCs (Registro Federal de Contribuyentes) en México.
    /// </summary>
    public class RFC
    {
        /// <summary>
        /// Expresión regular para validar un RFC.
        /// </summary>
        private static readonly Regex rfcPattern = new Regex(@"^[A-Z&Ñ]{3,4}\d{6}[A-Z0-9]{2,3}$", RegexOptions.Compiled);

        /// <summary>
        /// Verifica si un RFC proporcionado es válido.
        /// </summary>
        /// <param name="rfc">El RFC a validar.</param>
        /// <returns>True si el RFC es válido, de lo contrario, False.</returns>
        public static bool EsRFCValido(string rfc)
        {
            if (string.IsNullOrWhiteSpace(rfc))
                return false;

            rfc = NormalizarRFC(rfc);
            return rfcPattern.IsMatch(rfc);
        }

        /// <summary>
        /// Normaliza un RFC eliminando espacios en blanco y convirtiéndolo a mayúsculas.
        /// </summary>
        /// <param name="rfc">El RFC a normalizar.</param>
        /// <returns>El RFC normalizado en mayúsculas sin espacios en blanco adicionales.</returns>
        public static string NormalizarRFC(string rfc)
        {
            if (string.IsNullOrWhiteSpace(rfc))
                return string.Empty;

            return rfc.Trim().ToUpper();
        }

    }
}