using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_16.Extensions
{
    internal static class DateTimeExtensions
    {
        public static String ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now - thisObj;

            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1") + "hours";
            }

            return duration.TotalDays.ToString("F1") + "days";
        }
    }
}
