using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Core
{
    public static class Extensions
    {
        public static string DollarToLira(this double _variable)
        {
            var variable = (_variable * 13.70).ToString();
            return variable;
        }

        public static string GetEnumDisplayName(this Enum _variable)
        {
            var variable = _variable.GetType().GetMember(_variable.ToString()).First().GetCustomAttributes<DisplayAttribute>().First().Name;
            return variable;
        }
    }
}
