using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_16.Extensions
{
    internal static class StringExtensions
    {
        public static string Cut(this string thisObj, int n)
        {
            if (thisObj.Length <= n)
            {
                return thisObj;
            }

            return thisObj.Substring(0, n) + "...";
        }
    }
}
