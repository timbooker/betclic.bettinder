using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BetClic.BetTinder.Core.Extensions
{
    public static class StringExtensions
    {
        public static string PascalToSentence(this string pascal)
        {
             return Regex.Replace(pascal, "([A-Z])", " $1", RegexOptions.CultureInvariant).Trim();
        }
    }
}
