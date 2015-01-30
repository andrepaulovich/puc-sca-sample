using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Compartilhado
{
    public static class StringExtensions
    {

        #region Regex Fields

        private const string CpfMask = @"000\.000\.000\-00";
        private const string CnpjMask = @"00\.000\.000\/0000\-00";
        private static readonly Regex EmailExpression = new Regex(@"^([0-9a-zA-Z]+[-._+&])*[0-9a-zA-Z]+@([-0-9a-zA-Z]+[.])+[a-zA-Z]{2,6}$", RegexOptions.Singleline | RegexOptions.Compiled);
        private static readonly Regex UrlExpression = new Regex(@"^(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?", RegexOptions.Singleline | RegexOptions.Compiled);

        #endregion

        #region Methods

        /// <summary>
        /// Formata uma string. Equivalente ao método String.Format()
        /// </summary>
        /// <param name="target">string a formatar</param>
        /// <param name="args">Argumentos para substituir na string.</param>
        /// <returns>String formatada.</returns>
        public static string FormatWith(this string target, params object[] args)
        {
            return String.Format(target, args);
        }

        public static bool IsEmail(this string target)
        {
            return !string.IsNullOrEmpty(target) && EmailExpression.IsMatch(target);
        }

        public static bool IsValidUrl(this string target)
        {
            return !string.IsNullOrEmpty(target) && UrlExpression.IsMatch(target);
        }

        public static string ToSlug(this string name)
        {

            byte[] b = Encoding.GetEncoding(1251).GetBytes(name); // 8 bit characters
            string t = Encoding.ASCII.GetString(b); // 7 bit characters

            return t.Trim().Replace(" ", "-").ToLower();

        }

        public static string ToSearchString(this string name)
        {

            return ToSlug(name).Replace('-', ' ');

        }

        public static string ToCnpjFormat(this string target, params object[] args)
        {
            return Convert.ToUInt64(target).ToString(CnpjMask);
        }

        public static string ToCpfFormat(this string target, params object[] args)
        {
            return Convert.ToUInt64(target).ToString(CpfMask);
        }

        public static string RemoveNonDigits(this string input)
        {
            return Regex.Replace(input, @"\D", "");
        }

        public static string CropText(this string input, int maxChars)
        {
            return input.Length > maxChars ? input.Substring(0, maxChars) : input;
        }

        public static string RemoveHtmlTags(this string htmlString)
        {

            // Regex to find all the html tags
            const string pattern = @"<(.|\n)*?>";

            // Return the string without html tags
            return Regex.Replace(htmlString, pattern, string.Empty);

        }

        #endregion

    }
}
